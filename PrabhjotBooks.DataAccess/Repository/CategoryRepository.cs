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

        /*public void Update(Category category)
        {
            var objfromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objfromDb ! = null)
            {
                objfromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }*/
        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
