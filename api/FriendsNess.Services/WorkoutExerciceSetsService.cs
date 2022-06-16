﻿using AutoMapper;
using FriendsNess.Core.Repositories;
using FriendsNess.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Services;

public class WorkoutExerciceSetsService : BaseService, IWorkoutExerciceSetsService
{
    public WorkoutExerciceSetsService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
    {
    }
}
