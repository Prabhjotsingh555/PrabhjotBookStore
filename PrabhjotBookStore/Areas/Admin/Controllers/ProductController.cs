using Microsoft.AspNetCore.Mvc;
using PrabhjotBooks.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrabhjotBookStore.Areas.Admin.Controllers
{
    [Area ("Admin")]
    public class ProductController: Controller
    {
        private readonly IUnitOfWork _unitOfWork;
    }
}
