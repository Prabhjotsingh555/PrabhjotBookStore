﻿using PrabhjotBooks.Models;
using PrabhjotBookStore.DataAccess.Data;
using PrabhjotBooks.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrabhjotBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public CategoryRepository Category { get; private set; }
        public SP_Call SP_Call { get; private set; }

        ICategoryRepository IUnitOfWork.Category => throw new NotImplementedException();

        ISP_Call IUnitOfWork.SP_Call => throw new NotImplementedException();

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
