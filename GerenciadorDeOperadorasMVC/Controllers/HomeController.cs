using System.Diagnostics;
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
            ViewData["Mensagem"] = "APLICAÇÃO PARA GERENCIAMENTO DE RECEITAS DE OPERADORAS DE SAÚDE EM C#(CSHARP)";
            ViewData["Desenvolvedor"] = "André Lopes";
            return View();
        }

        public IActionResult Contato()
        {
            ViewData["Mensegem"] = "ENTRE EM CONTATO COM A TECHNO HEALTH";

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
