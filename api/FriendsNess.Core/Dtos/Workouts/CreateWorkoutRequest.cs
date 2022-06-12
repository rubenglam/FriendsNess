using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Dtos.Workouts;

public class CreateWorkoutRequest
{
    public string Name { get; set; }
    public DateTimeOffset Date { get; set; }
}
