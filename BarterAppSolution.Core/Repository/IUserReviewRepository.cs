using BarterAppSolution.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarterAppSolution.Core.Repository
{
    public interface IUserReviewRepository : IRepository<UserReview>
    {
        IEnumerable<UserReview> GetUserReviewsWithUser(int userId);
    }
}
