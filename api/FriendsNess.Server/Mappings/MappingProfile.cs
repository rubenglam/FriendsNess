using AutoMapper;
using FriendsNess.Core.Domain.Users;
using FriendsNess.Core.Dtos.Authentication;

namespace FriendsNess.Server.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<RegisterRequest, ApplicationUser>()
            .ForMember(u => u.UserName, opt => opt.MapFrom(ur => ur.Email));
    }
}
