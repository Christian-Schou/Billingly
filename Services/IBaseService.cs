using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq.Expressions;
using Billingly.Entities;

namespace Billingly.Services
{
    public interface IBaseService<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

