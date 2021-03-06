using FriendsNess.Core.Domain.Routines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Repositories;

public interface IRoutinesRepository
{
    Task<IList<Routine>> GetAll();
    Task<Routine> Get(int id);
}
