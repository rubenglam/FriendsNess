using AutoMapper;
using FriendsNess.Core.Domain.Users;
using FriendsNess.Core.Dtos.Users;
using FriendsNess.Core.Exceptions;
using FriendsNess.Core.Repositories;
using FriendsNess.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Services;

public class UsersService : BaseService, IUsersService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UsersService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
    {
    }

    public async Task<IEnumerable<UserResponse>> GetAllUsers()
    {
        var users = await _unitOfWork.Users.GetAllAsync();
        var response = _mapper.Map<List<UserResponse>>(users);
        return response;
    }

    public async Task<UserResponse> GetUserById(int userId)
    {
        var user = await _unitOfWork.Users.GetByIdAsync(userId);
        if (user == null)
        {
            throw new ApiException("No user found");
        }
        var response = _mapper.Map<UserResponse>(user);
        return response;
    }
}
