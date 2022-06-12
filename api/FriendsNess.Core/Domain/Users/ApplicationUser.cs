using FriendsNess.Core.Domain.Exercices;
using Microsoft.AspNetCore.Identity;
using FriendsNess.Core.Domain.Workouts;

namespace FriendsNess.Core.Domain.Users;

public class ApplicationUser : IdentityUser<int>
{
    public ApplicationUser()
    {
        UserExercices = new List<UserExercice>();
        Workouts = new List<Workout>();
    }

    public ICollection<UserExercice> UserExercices { get; set; }
    public ICollection<Workout> Workouts { get; set; }
}