using PrabhjotBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PrabhjotBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
        Product GetFirstOrDefault(Expression<Func<Product, bool>> filter = null, string includeProperties = null);
    }
}
