using PrabhjotBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrabhjotBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
        Category GetType(int v);
        void Add(Category category);
        void Remove(IEnumerable<Category> objFromDb);
        object GetAll(int id);
        void Remove(object objFromDb);
    }
}
