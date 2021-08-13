using BarterAppSolution.Core.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BarterAppSolution.Core.Service
{
    public interface IService<T> where T : AuditableEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAllWithFilter(Expression<Func<T, bool>> predicate);
        T GetById(int id);
        T GetByFilter(Expression<Func<T, bool>> predicate);

        T Add(T entity, HttpRequest Request = null);
        List<T> AddRange(List<T> entity);

        void Update(T entity);

        void Delete(int id);
    }
}
