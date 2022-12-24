using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GerenciadorDeOperadorasMVC.Models.ViewModels;

namespace GerenciadorDeOperadorasMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            ViewData["Mensagem"] = "Gerenciador de receitas de Operadoras de saúde em C#";
            ViewData["Desenvolvedor"] = "André Lopes";
            return View();
        }

        public IActionResult Contato()
        {
            ViewData["Mensegem"] = "Entre em contato com a Techno Health";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
