using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PrabhjotBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T GetT(int id);

        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedEnumerable<T>> orderBy = null,
            string includeProperties = null
            );

        T GetFirstOrderDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        void Addd(T entity);
        void Remove(int id);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
