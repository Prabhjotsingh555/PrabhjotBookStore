using Microsoft.AspNetCore.Mvc;
using PrabhjotBooks.DataAccess.Repository;
using PrabhjotBooks.DataAccess.Repository.IRepository;
using PrabhjotBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrabhjotBookStore.Areas.Admin.Controllers
{
        [Area("Admin")]
        public class CategoryController : Controller
        {
            private readonly UnitOfWork _unitOfWork;

            public CategoryController(UnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public IActionResult Index()
            {
                return View();
            }
            public IActionResult upsert(int? id) 
            {
                Category category = new Category(); 
                if (id == null)
                {
                    // this is for create 
                    return View(category);
                }

                category = _unitOfWork.Category.Get(id.GetValueOrDefault());
                if (category == null)
                {
                    return NotFound();
                }

                return View(category);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]



            public IActionResult Upsert(Category category)
            {
                if (ModelState.IsValid)
                {
                    if (category.Id == 0)
                    {
                        _unitOfWork.Category.Add(category);
                    }
                    else
                    {
                        _unitOfWork.Category.Update(category);
                    }
                    _unitOfWork.Save();
                    return RedirectToAction(nameof(Index));
                }
                return View(category);
            }
            // API calls here



        }
    }