using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq.Expressions;
using Billingly.Entities;

namespace Billingly.Services
{
    public interface IBaseService<T> where T : BaseEntity
    {
        Task<IQueryable<T>> GetAllAsync();

        Task<IQueryable<T>> All(params Expression<Func<T, Object>>[] includeProperties);

        Task<T> FindAsync(long id);

        Task<T> FindAsync(Int64 id, params Expression<Func<T, object>>[] includeProperties);

        void InsertAsync(T entity);

        void UpdateAsync(T entity, int id);

        void DeleteAsync(T entity);
    }
}

