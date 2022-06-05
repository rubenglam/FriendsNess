﻿using FriendsNess.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Domain.Exercices;

public class UserExercice
{
    public int UserId { get; set; }
    public ApplicationUser User { get; set; }

    public int ExerciceId { get; set; }
    public Exercice Exercice { get; set; }

    public ICollection<ExerciceSet> ExercicesSets { get; set; }
}
