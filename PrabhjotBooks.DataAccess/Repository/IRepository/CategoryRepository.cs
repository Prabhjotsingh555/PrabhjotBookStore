using PrabhjotBooks.DataAccess.Repository.IRepository;
using PrabhjotBooks.Models;
using PrabhjotBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrabhjotBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(Category category)
        {
            // use .NET LINQ to retrieve the first or default category object,
            // then pass the id as a generic entity  which matches the Category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null) // save  changes if not null
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
    }
}