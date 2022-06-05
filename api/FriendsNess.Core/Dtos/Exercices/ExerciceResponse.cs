using FriendsNess.Core.Domain.Exercices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Dtos.Exercices;

public class ExerciceResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public ExerciceCategory Category { get; set; }
    public BodyPart BodyPart { get; set; }
}
