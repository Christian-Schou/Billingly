using System;
using Billingly.Services;
using Billingly.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Billingly.Data.Repositories.Base
{
    public abstract class BaseRepository<T> : IBaseService<T> where T : class
    {
        private readonly ApplicationDbContext _appDbContext;

        public BaseRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Create(T entity)
        {
            _appDbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _appDbContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll()
        {
            return _appDbContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _appDbContext.Set<T>()
                .Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            _appDbContext.Set<T>().Update(entity);
        }
    }
}

