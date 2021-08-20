using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioFull.Models;

namespace DesafioFull.Controllers
{
    public class TitulosController : Controller
    {
        public IActionResult Index()
        { 
            List<Titulos> list = new List<Titulos>();
            list.Add(new Titulos { Id = 1, Nome = "João" });
            list.Add(new Titulos { Id = 2, Nome = "Pedro" });



            return View(list);
        }
    }
}
