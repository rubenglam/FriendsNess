using AutoMapper;
using FriendsNess.Core.Domain.Users;
using FriendsNess.Core.Dtos.Authentication;
using FriendsNess.Core.Exceptions;
using FriendsNess.Core.Models;
using FriendsNess.Core.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Services;

public class AuthenticationService : BaseService, IAuthenticationService
{
    private readonly JwtSettings _jwtSettings;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<ApplicationRole> _roleManager;

    public AuthenticationService(JwtSettings jwtSettings, IMapper mapper, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
    {
        _jwtSettings = jwtSettings;
        _mapper = mapper;
        _roleManager = roleManager;
        _userManager = userManager;
    }

    public async Task<AuthenticationResponse> Login(LoginRequest loginRequest)
    {
        var user = _userManager.Users.SingleOrDefault(u => u.UserName == loginRequest.Email);
        if (user is null)
        {
            throw new ApiException("User not found");
        }
        var result = await _userManager.CheckPasswordAsync(user, loginRequest.Password);

        if (result)
        {
            var roles = await _userManager.GetRolesAsync(user);
            return new AuthenticationResponse()
            {
                Token = GenerateJwt(user, roles),
                Email = user.Email,
                UserId = user.Id,
                UserName = user.UserName
            };
        }
        throw new ApiException("Email or password incorrect");
    }

    public async Task<AuthenticationResponse> RefreshToken()
    {
        throw new NotImplementedException();
    }

    public async Task<AuthenticationResponse> Register(RegisterRequest registerRequest)
    {
        var user = _mapper.Map<RegisterRequest, ApplicationUser>(registerRequest);
        var result = await _userManager.CreateAsync(user, registerRequest.Password);
        if (result.Succeeded)
        {
            var roles = await _userManager.GetRolesAsync(user);
            return new AuthenticationResponse()
            {
                Token = GenerateJwt(user, roles),
                Email = user.Email,
                UserId = user.Id,
                UserName = user.UserName
            };
        }
        throw new ApiException(result.Errors.Select(x => x.Description));
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
