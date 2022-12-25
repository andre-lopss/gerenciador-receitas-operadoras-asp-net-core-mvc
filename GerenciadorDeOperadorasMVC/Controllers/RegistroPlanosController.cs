//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using GerenciadorDeOperadorasMVC.Services;
//using Microsoft.AspNetCore.Mvc;

//namespace GerenciadorDeOperadorasMVC.Controllers
//{
//    public class RegistroPlanosController : Controller
//    {
//        private readonly RegistroPlanosService _registroPlanosService;

//        public RegistroPlanosController(RegistroPlanosService registroPlanosService)
//        {
//            _registroPlanosService = registroPlanosService;
//        }

//        public IActionResult Index()
//        {
//            return View();
//        }

//        public async Task<IActionResult> BuscaSimples(DateTime? dataMinima, DateTime? dataMaxima)
//        {
//            if (!dataMinima.HasValue)
//            {
//                dataMinima = new DateTime(DateTime.Now.Year, 1, 1);
//            }
//            if (!dataMaxima.HasValue)
//            {
//                dataMaxima = DateTime.Now;
//            }
//            ViewData["minDate"] = dataMinima.Value.ToString("yyyy-MM-dd");
//            ViewData["maxDate"] = dataMaxima.Value.ToString("yyyy-MM-dd");
//            var result = await _registroPlanosService.FindByDateAsync(dataMinima, dataMaxima);
//            return View(result);
//        }
//        public async Task<IActionResult> BuscaAgrupada(DateTime? dataMinima, DateTime? dataMaxima)
//        {
//            if (!dataMinima.HasValue)
//            {
//                dataMinima = new DateTime(DateTime.Now.Year, 1, 1);
//            }
//            if (!dataMaxima.HasValue)
//            {
//                dataMaxima = DateTime.Now;
//            }
//            ViewData["minDate"] = dataMinima.Value.ToString("yyyy-MM-dd");
//            ViewData["maxDate"] = dataMaxima.Value.ToString("yyyy-MM-dd");
//            var result = await _registroPlanosService.FindByDateGroupingAsync(dataMinima, dataMaxima);
//            return View(result);
//        }
//    }
//}
//}