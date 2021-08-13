using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BarterAppSolution.Core.Repository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAllWithFilter(Expression<Func<T, bool>> predicate);
        T GetById(int id);
        T GetByFilter(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void AddRange(List<T> entity);

        void Update(T entity);

        void Delete(int id);
    }
}
