using BarterAppSolution.Core.Entity;
using BarterAppSolution.Core.Repository;
using BarterAppSolution.Core.Service;
using BarterAppSolution.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarterAppSolution.Service.Service
{
    public class UserService : Service<User>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public User GetByActivationLink(string activationLink)
        {
            return _unitOfWork.userRepository.GetByFilter(a => a.ActivationLink.Trim().ToLower() == activationLink.Trim().ToLower());
        }

        public User GetByUserNameAndPassword(string username, string password)
        {
            return _unitOfWork.userRepository.GetByUserNameAndPassword(username, password);
        }

        public User GetUserByIdWithRoles(int id)
        {
            return _unitOfWork.userRepository.GetUserByIdWithRoles(id);
        }

        public IEnumerable<User> GetUsersWithRoles()
        {
            return _unitOfWork.userRepository.GetUsersWithRoles();
        }
    }
}
