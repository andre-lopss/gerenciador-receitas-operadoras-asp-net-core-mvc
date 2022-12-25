using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciadorDeOperadorasMVC.Models;
using GerenciadorDeOperadorasMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeOperadorasMVC.Controllers
{
    public class BeneficiariosController : Controller
    {
        private readonly BeneficiarioService _beneficiarioService;
        private readonly OperadoraService _operadoraService;

        public BeneficiariosController(BeneficiarioService beneficiarioService, OperadoraService operadoraService)
        {
            _beneficiarioService = beneficiarioService;
            _operadoraService = operadoraService;
        }

        //public async Task<IActionResult> Index()
        //{
        //    var list = await _beneficiarioService.FindAllAsync();
        //    return View(list);
        //}

        //public async Task<IActionResult> Create()
        //{
        //    var operadoras = await _operadoraService.FindAllAsync();
        //    var viewModel = new BeneficiarioFormularioViewModel { Operadoras = operadoras };
        //    return View(viewModel);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(Beneficiario beneficiario)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var operadoras = await _operadoraService.FindAllAsync();
        //        var viewModel = new BeneficiarioFormularioViewModel { Beneficiario = beneficiario, Operadora = operadoras };
        //        return View(viewModel);
        //    }
        //    await _beneficiarioService.InsertAsync(beneficiario);
        //    return RedirectToAction(nameof(Index));
        //}

        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return RedirectToAction(nameof(Error), new { message = "Id not provided" });
        //    }

        //    var obj = await _beneficiarioService.FindByIdAsync(id.Value);
        //    if (obj == null)
        //    {
        //        return RedirectToAction(nameof(Error), new { message = "Id not found" });
        //    }

        //    return View(obj);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    try
        //    {
        //        await _beneficiarioService.RemoveAsync(id);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch (IntegrityException e)
        //    {
        //        return RedirectToAction(nameof(Error), new { message = e.Message });
        //    }

        //}

        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return RedirectToAction(nameof(Error), new { message = "Id not found" });
        //    }

        //    var obj = await _beneficiarioService.FindByIdAsync(id.Value);
        //    if (obj == null)
        //    {
        //        return RedirectToAction(nameof(Error), new { message = "Id not found" });
        //    }

        //    return View(obj);
        //}

        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return RedirectToAction(nameof(Error), new { message = "Id not provided" });
        //    }

        //    var obj = await _beneficiarioService.FindByIdAsync(id.Value);
        //    if (obj == null)
        //    {
        //        return RedirectToAction(nameof(Error), new { message = "Id not found" });
        //    }

        //    List<Operadora> operadoras = await _operadoraService.FindAllAsync();
        //    BeneficiarioFormularioViewModel viewModel = new BeneficiarioFormularioViewModel { Beneficiario = obj, Operadora = operadoras };
        //    return View(viewModel);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, Beneficiario beneficiario)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var operadoras = await _operadoraService.FindAllAsync();
        //        var viewModel = new BeneficiarioFormularioViewModel { Beneficiario = beneficiario, Operadora = operadoras };
        //        return View(viewModel);
        //    }
        //    if (id != beneficiario.Id)
        //    {
        //        return RedirectToAction(nameof(Error), new { message = "Id mismatch" });
        //    }
        //    try
        //    {
        //        await _beneficiarioService.UpdateAsync(beneficiario);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch (ApplicationException e)
        //    {
        //        return RedirectToAction(nameof(Error), new { message = e.Message });
        //    }
        //}

        //public IActionResult Error(string message)
        //{
        //    var viewModel = new ErrorViewModel
        //    {
        //        Message = message,
        //        RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        //    };
        //    return View(viewModel);
        //}
    }
}