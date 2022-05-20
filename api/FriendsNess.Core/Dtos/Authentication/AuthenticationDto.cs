using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Dtos.Authentication;

public class AuthenticationDto
{
    public bool Success { get; set; }
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Token { get; set; }
    public string Message { get; set; }
}
