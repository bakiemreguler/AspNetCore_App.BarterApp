using BarterAppSolution.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarterAppSolution.Core.Service
{
    public interface IUserService : IService<User>
    {
        User GetByUserNameAndPassword(string username, string password);
        User GetByActivationLink(string activationLink);
        IEnumerable<User> GetUsersWithRoles();
        User GetUserByIdWithRoles(int id);
    }
}
