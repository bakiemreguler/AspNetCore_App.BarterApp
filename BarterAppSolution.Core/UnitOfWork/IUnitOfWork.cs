using BarterAppSolution.Core.Entity;
using BarterAppSolution.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarterAppSolution.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        IUserRepository userRepository { get; }
        IUserReviewRepository userReviewRepository { get; }
        ILocationDataRepository locationDataRepository { get; }
        IRepository<T> GetRepository<T>() where T : AuditableEntity;
        void CommitChanges();
    }
}
