using FriendsNess.Core.Domain.Exercices;
using Microsoft.AspNetCore.Identity;

namespace FriendsNess.Core.Domain.Users;

public class ApplicationUser : IdentityUser<int>
{
    public ICollection<UserExercice> UsersExercices { get; set; }
}