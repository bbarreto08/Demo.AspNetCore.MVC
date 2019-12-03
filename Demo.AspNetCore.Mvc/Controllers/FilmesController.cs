using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demo.AspNetCore.Mvc.Controllers
{
    public class FilmesController : Controller
    {

        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Adicionar(Filmes filmes)
        //{
        //    return View();
        //}
    }
}