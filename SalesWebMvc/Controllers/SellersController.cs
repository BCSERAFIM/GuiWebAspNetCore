using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using SalesWebMvc.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Services.Exceptions;
using System.Diagnostics;
using System.Threading.Tasks;

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
        public async Task< IActionResult> Index()
        {
            var list = await _sellerService.FindAllAsync();
            return View(list);
        }


        public async Task< IActionResult>  Create()
        {
            // buscar do banco de dados todos os departamentos
            var departments = await _departmentService.FindaAllAsync();
            // instanciar objeto do view model
            var viewModel = new SellerFormViewMode { Departments = departments };
            return View(viewModel);
        }

        // Annotation of POST 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Seller seller)
        {
            // verificação de preenchimento correto dos campos, mesmo com JS desabilitado
            if (!ModelState.IsValid)
            {
                var departments = await _departmentService.FindaAllAsync();
                var viewModel = new SellerFormViewMode { Seller = seller, Departments = departments };
                return View(viewModel);
            }
            // POST action
            await _sellerService.InsertAsync(seller);
            // retornar para View
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = await _sellerService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not Found" });
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task< IActionResult> Delete(int id)
        {
            await _sellerService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = await _sellerService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not Found" });
            }

            return View(obj);
        }

        public async Task< IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }
            var obj = await _sellerService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not Found" });
            }

            List<Department> departments = await _departmentService.FindaAllAsync();
            SellerFormViewMode viewModel = new SellerFormViewMode { Seller = obj, Departments = departments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Seller seller)
        {

            if (!ModelState.IsValid)
            {
                var departments = await _departmentService.FindaAllAsync();
                var viewModel = new SellerFormViewMode { Seller = seller, Departments = departments };
                return View(viewModel);
            }

            if (id != seller.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id mismatch" });
            }

            try
            {
                await _sellerService.UpdateAsync(seller);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                // Pegar o Id interno da requisição
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }


    }
}
