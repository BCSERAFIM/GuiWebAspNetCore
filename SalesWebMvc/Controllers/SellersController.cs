using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using SalesWebMvc.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }

        // o construtor vem com o metodo Get padrão não sendo necessario incluir
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }


        public IActionResult Create()
        {
            // buscar do banco de dados todos os departamentos
            var departments = _departmentService.FindaAll();
            // instanciar objeto do view model
            var viewModel = new SellerFormViewMode { Departments = departments };
            return View(viewModel);
        }

        // Annotation of POST 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            // POST action
            _sellerService.Insert(seller);
            // retornar para View
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _sellerService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _sellerService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _sellerService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }




    }
}
