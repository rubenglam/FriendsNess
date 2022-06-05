using FriendsNess.Core.Dtos.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Services;

public interface IAuthenticationService
{
    Task<AuthenticationResponse> Register(RegisterRequest registerRequest);
    Task<AuthenticationResponse> Login(LoginRequest loginRequest);
    Task<AuthenticationResponse> RefreshToken();
}
