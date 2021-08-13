using BarterAppSolution.Core.Entity;
using BarterAppSolution.Core.Service;
using BarterAppSolution.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarterAppSolution.Service.Service
{
    public class UserReviewService : Service<UserReview>, IUserReviewService
    {
        public UserReviewService(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public IEnumerable<UserReview> GetUserReviewsWithUser(int userId)
        {
            return _unitOfWork.userReviewRepository.GetUserReviewsWithUser(userId);
        }
    }
}
