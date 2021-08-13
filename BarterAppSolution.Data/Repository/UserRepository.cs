using BarterAppSolution.Core.Entity;
using BarterAppSolution.Core.Repository;
using BarterAppSolution.Data.Context;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Linq;

namespace BarterAppSolution.Data.Repository
{
    class UserRepository : Repository<User>, IUserRepository
    {
        private DatabaseContext _context { get => _dbContext as DatabaseContext; }
        public UserRepository(DatabaseContext context) : base(context) { }

        public User GetByUserNameAndPassword(string username, string password)
        {
            return _context.Users.SingleOrDefault(a => a.LoginName == username && a.LoginPass == password && a.IsActive && !a.IsDeleted);
        }

        public IEnumerable<User> GetUsersWithRoles()
        {
            return _context.Users.Include(a => a.UserRole);
        }

        public User GetUserByIdWithRoles(int id)
        {
            return _context.Users.Where(a=>a.Id == id).Include(a => a.UserRole).SingleOrDefault();
        }
    }
}
