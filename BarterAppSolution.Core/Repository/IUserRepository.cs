using BarterAppSolution.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarterAppSolution.Core.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByUserNameAndPassword(string username, string password);
        User GetUserByIdWithRoles(int id);
        IEnumerable<User> GetUsersWithRoles();
    }
}
