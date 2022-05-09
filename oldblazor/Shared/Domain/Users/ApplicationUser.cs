using FriendsNess.Shared.Domain.Exercices;
using Microsoft.AspNetCore.Identity;

namespace FriendsNess.Shared.Domain.Users;

public class ApplicationUser : IdentityUser<int>
{
    public ICollection<UserExercice> UserExercices { get; set; }
}