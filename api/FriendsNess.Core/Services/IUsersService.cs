using FriendsNess.Core.Domain.Users;
using FriendsNess.Core.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Services;

public interface IUsersService
{
    Task<IEnumerable<UserResponse>> GetAllUsers();
    Task<UserResponse> GetUserById(int userId);
}
