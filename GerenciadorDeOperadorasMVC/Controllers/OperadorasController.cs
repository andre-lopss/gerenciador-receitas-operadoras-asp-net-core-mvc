using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciadorDeOperadorasMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeOperadorasMVC.Controllers
{
    public class OperadorasController : Controller
    {
        public IActionResult Index()
        {
            List<Operadora> list = new List<Operadora>();
            list.Add(new Operadora(1, "Bradesco Saúde"));
            list.Add(new Operadora(2, "NotreDame Intermédica"));
            list.Add(new Operadora(3, "Hapvida Assistência Médica"));
            list.Add(new Operadora(4, "Amil Assistência Médica"));
            return View(list);
        }
    }
}