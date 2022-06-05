using AutoMapper;
using FriendsNess.Core.Domain.Users;
using FriendsNess.Core.Dtos;
using FriendsNess.Core.Dtos.Authentication;
using FriendsNess.Core.Exceptions;
using FriendsNess.Core.Models;
using FriendsNess.Core.Repositories;
using FriendsNess.Core.Services;
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
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService, ILogger<AuthenticationController> logger) : base(logger)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<AuthenticationResponse>> Register(RegisterRequest registerRequest)
        {
            try
            {
                return Success(await _authenticationService.Register(registerRequest));
            }
            catch (ApiException apiException)
            {
                return Error(apiException);
            }
            catch (Exception exception)
            {
                return Error(exception);
            }
        }

        [HttpPost("login")]
        public async Task<ActionResult<AuthenticationResponse>> Login(LoginRequest loginRequest)
        {
            try
            {
                return Success(await _authenticationService.Login(loginRequest));
            }
            catch (ApiException apiException)
            {
                return Error(apiException);
            }
            catch (Exception exception)
            {
                return Error(exception);
            }
        }

        [HttpPost("refreshtoken")]
        public async Task<ActionResult> RefreshToken()
        {
            try
            {
                await _authenticationService.RefreshToken();
                return Success();
            }
            catch (ApiException apiException)
            {
                return Error(apiException);
            }
            catch (Exception exception)
            {
                return Error(exception);
            }
        }
    }
}