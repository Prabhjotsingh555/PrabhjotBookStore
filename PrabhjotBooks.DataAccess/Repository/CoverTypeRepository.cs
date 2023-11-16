using PrabhjotBooks.DataAccess.Repository.IRepository;
using PrabhjotBooks.Models;
using PrabhjotBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrabhjotBooks.DataAccess.Repository
{
    class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(CoverType coverType)
        {
            // use .NET LINQ to retrieve the first or default category object,
            // then pass the id as a generic entity  which matches the Category ID
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null) // save  changes if not null
            {
                objFromDb.Name = coverType.Name;
                _db.SaveChanges();
            }
        }
    }
}