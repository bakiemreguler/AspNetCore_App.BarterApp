using BarterAppSolution.Core.Entity;
using BarterAppSolution.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarterAppSolution.Core.Service
{
    public interface IUserReviewService : IService<UserReview>
    {
        IEnumerable<UserReview> GetUserReviewsWithUser(int userId);
    }
}
