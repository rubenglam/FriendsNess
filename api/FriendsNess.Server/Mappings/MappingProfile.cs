using AutoMapper;
using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Domain.Users;
using FriendsNess.Core.Dtos.Authentication;
using FriendsNess.Core.Dtos.Exercices;
using FriendsNess.Core.Dtos.ExerciceSet;
using FriendsNess.Core.Dtos.UserExercices;
using FriendsNess.Core.Dtos.Users;

namespace FriendsNess.Server.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<RegisterRequest, ApplicationUser>()
            .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.Email));

        CreateMap<ApplicationUser, UserResponse>();

        CreateMap<Exercice, ExerciceResponse>();

        CreateMap<ExerciceSet, ExerciceSetResponse>();

        CreateMap<UserExercice, UserExerciceResponse>();
    }
}
