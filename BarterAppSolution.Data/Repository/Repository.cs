using BarterAppSolution.Core.Entity;
using BarterAppSolution.Core.Repository;
using BarterAppSolution.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BarterAppSolution.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : AuditableEntity
    {
        protected readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public Repository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }
        public void AddRange(List<T> entity)
        {
            _dbSet.AddRange(entity);
        }
        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity == null) return;
            else
            {
                if (entity.GetType().GetProperty("IsDeleted") != null)
                {
                    T _entity = entity;
                    _entity.GetType().GetProperty("IsDeleted").SetValue(_entity, true);
                    this.Update(_entity);
                }
            }
        }
        public T GetById(int id)
        {
            return _dbSet.SingleOrDefault(a=>a.Id == id && !a.IsDeleted);
        }
        public T GetByFilter(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(a => !a.IsDeleted).Where(predicate).SingleOrDefault();
        }
        public IQueryable<T> GetAll()
        {
            return _dbSet.Where(a => !a.IsDeleted);
        }
        public IQueryable<T> GetAllWithFilter(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(a => !a.IsDeleted).Where(predicate);
        }
        
        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
