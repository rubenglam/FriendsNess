using AutoMapper;
using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Domain.Users;
using FriendsNess.Core.Domain.Workouts;
using FriendsNess.Core.Dtos.Authentication;
using FriendsNess.Core.Dtos.Exercices;
using FriendsNess.Core.Dtos.Users;
using FriendsNess.Core.Dtos.Workouts;

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
        CreateMap<CreateExerciceSetRequest, ExerciceSet>();
        CreateMap<EditExerciceSetRequest, ExerciceSet>();
        CreateMap<UserExercice, UserExerciceResponse>();

        CreateMap<Workout, WorkoutResponse>();
        CreateMap<WorkoutExercice, WorkoutExerciceResponse>();
        CreateMap<WorkoutExerciceSet, WorkoutExerciceSetResponse>();
    }
}
