﻿using FriendsNess.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Repositories;

public interface IUsersRepository : IRepository<ApplicationUser>
{
}