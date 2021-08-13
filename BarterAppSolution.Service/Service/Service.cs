using BarterAppSolution.Core.Entity;
using BarterAppSolution.Core.Repository;
using BarterAppSolution.Core.Service;
using BarterAppSolution.Core.UnitOfWork;
using BarterAppSolution.Service.Helpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BarterAppSolution.Service.Service
{
    public class Service<T> : IService<T> where T : AuditableEntity
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<T> _repository;
        public Service(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<T>();
        }

        public T Add(T entity, HttpRequest Request = null)
        {
            int userId = Utils.GetUserIdFromToken(Request);

            entity.CreatedBy = userId;
            entity.UpdatedBy = userId;
            entity.CreatedDate = DateTime.Now;
            entity.UpdatedDate = DateTime.Now;
            entity.IsActive = true;
            entity.IsDeleted = false;

            _repository.Add(entity);
            _unitOfWork.CommitChanges();

            return entity;
        }

        public List<T> AddRange(List<T> entity)
        {
            _repository.AddRange(entity);
            _unitOfWork.CommitChanges();

            return entity;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
            _unitOfWork.CommitChanges();
        }

        public IQueryable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public IQueryable<T> GetAllWithFilter(Expression<Func<T, bool>> predicate)
        {
            return _repository.GetAllWithFilter(predicate);
        }

        public T GetByFilter(Expression<Func<T, bool>> predicate)
        {
            return _repository.GetByFilter(predicate);
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
            _unitOfWork.CommitChanges();
        }
    }
}
