using AutoMapper;
using FriendsNess.Core.Domain.Users;
using FriendsNess.Core.Dtos.Authentication;
using FriendsNess.Core.Models;
using FriendsNess.Core.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FriendsNess.Server.Controllers
{
    public class AuthenticationController : RootController
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IMapper _mapper;
        private readonly JwtSettings _jwtSettings;

        public AuthenticationController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, IMapper mapper,
            ILogger<AuthenticationController> logger, IOptionsSnapshot<JwtSettings> jwtSettings) : base(logger)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
            _jwtSettings = jwtSettings.Value;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            var user = _mapper.Map<RegisterDto, ApplicationUser>(registerDto);
            var result = await _userManager.CreateAsync(user, registerDto.Password);
            if (result.Succeeded)
            {
                var roles = await _userManager.GetRolesAsync(user);
                return Created(string.Empty, new AuthenticationDto()
                {
                    Success = true,
                    Token = GenerateJwt(user, roles),
                    Email = user.Email,
                    Message = "User created",
                    UserId = user.Id,
                    UserName = user.UserName
                });
            }
            return Problem(result.Errors.First().Description, null, 500);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDto signInDto)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.UserName == signInDto.Email);
            if (user is null)
            {
                return NotFound("User not found");
            }
            var result = await _userManager.CheckPasswordAsync(user, signInDto.Password);

            if (result)
            {
                var roles = await _userManager.GetRolesAsync(user);
                return Ok(new AuthenticationDto()
                {
                    Success = true,
                    Token = GenerateJwt(user, roles),
                    Email = user.Email,
                    Message = "Loging success",
                    UserId = user.Id,
                    UserName = user.UserName
                });
            }

            return BadRequest("Email or password incorrect.");
        }

        [HttpPost("Roles")]
        public async Task<IActionResult> CreateRole(string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
            {
                return BadRequest("Role name should be provided.");
            }

            var newRole = new ApplicationRole
            {
                Name = roleName
            };

            var roleResult = await _roleManager.CreateAsync(newRole);

            if (roleResult.Succeeded)
            {
                return Ok();
            }

            return Problem(roleResult.Errors.First().Description, null, 500);
        }

        [HttpPost("User/{userEmail}/Role")]
        public async Task<IActionResult> AddUserToRole(string userEmail, [FromBody] string roleName)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.UserName == userEmail);

            var result = await _userManager.AddToRoleAsync(user, roleName);

            if (result.Succeeded)
            {
                return Ok();
            }

            return Problem(result.Errors.First().Description, null, 500);
        }

        private string GenerateJwt(ApplicationUser user, IList<string> roles)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            var roleClaims = roles.Select(r => new Claim(ClaimTypes.Role, r));
            claims.AddRange(roleClaims);

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(Convert.ToDouble(_jwtSettings.ExpirationInDays));

            var token = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Issuer,
                claims,
                expires: expires,
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
