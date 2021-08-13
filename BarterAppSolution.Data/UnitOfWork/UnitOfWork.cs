using BarterAppSolution.Core.Entity;
using BarterAppSolution.Core.Repository;
using BarterAppSolution.Core.UnitOfWork;
using BarterAppSolution.Data.Context;
using BarterAppSolution.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarterAppSolution.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private UserRepository _userRepository;
        private UserReviewRepository _userReviewRepository;
        private ILocationDataRepository _locationDataRepository;
        public IUserRepository userRepository => _userRepository = _userRepository ?? new UserRepository(_context);
        public IUserReviewRepository userReviewRepository => _userReviewRepository = _userReviewRepository ?? new UserReviewRepository(_context);
        public ILocationDataRepository locationDataRepository => _locationDataRepository = _locationDataRepository ?? new LocationDataRepository(_context);

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public void CommitChanges()
        {
            _context.SaveChanges();
        }

        public IRepository<T> GetRepository<T>() where T : AuditableEntity
        {
            return new Repository<T>(_context);
        }
    }
}
