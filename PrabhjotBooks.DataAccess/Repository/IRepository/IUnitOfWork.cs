﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PrabhjotBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }
    }
}