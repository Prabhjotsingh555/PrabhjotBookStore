using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrabhjotBooks.DataAccess.Repository.IRepository;
using PrabhjotBooks.Models;
using PrabhjotBookStore.Models.ViewModels;
using System.Collections.Generic;
using System.Diagnostics;

namespace PrabhjotBookStore.Area.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unifOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unifOfWork)
        {
            _logger = logger;
            _unifOfWork = unifOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> productList = _unifOfWork.Product.GetAll(includeProperties: "Category,CoverType");
            return View(productList);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Detail(int? id)
        {
        if (id == null)
        {
            return NotFound();
        }

        var product = _unifOfWork.Product.GetFirstOrDefault(p => p.Id == id, includeProperties: "Category,CoverType");

        if (product == null)
        {
            return NotFound();
        }

    return View(product);
}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

