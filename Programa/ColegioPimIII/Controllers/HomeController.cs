using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ColegioPimIII.Model;
using ColegioPimIII.Models;
using Microsoft.AspNetCore.Mvc;

namespace ColegioPimIII.Controllers
{
    public class HomeController : Controller
    {
        //https://localhost:44319/Home/NovaTarefa?nomeTarefa=fulano&dataPostagem=22/12/1983&dataEntrega=22/12/1984

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NovaTarefa()

        {
            return View();
        }
        
        public IActionResult ListaTarefas()
        {
            return View();
        }

        public IActionResult EditaLista()
        {
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
