using BarterAppSolution.Core.Entity;
using BarterAppSolution.Core.Repository;
using BarterAppSolution.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarterAppSolution.Data.Repository
{
    class UserReviewRepository : Repository<UserReview>, IUserReviewRepository
    {
        private DatabaseContext _context { get => _dbContext as DatabaseContext; }
        public UserReviewRepository(DatabaseContext context) : base(context) { }

        public IEnumerable<UserReview> GetUserReviewsWithUser(int userId)
        {
            return _context.UserReviews.Where(a=>a.UserId == userId).Include(a => a.User);
        }
    }
}
