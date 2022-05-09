using FriendsNess.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Domain.Exercices;

public class Exercice : BaseEntity
{
    public string Name { get; set; }
    public string Image { get; set; }
    public ExerciceCategory Category { get; set; }
    public BodyPart BodyPart { get; set; }

    public ICollection<UserExercice> ExerciceUsers { get; set; }
}
