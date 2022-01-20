using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portafolio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
            new Proyecto {
                Titulo ="Amazon",
                Descripcion = "E-Commerce realizado en ASP.NET Core",
                Link = "https://amazon.com",
                ImagenURL = "/imagenes/amazon.png"
            },
            new Proyecto
            {
                Titulo = "Randstad",
                Descripcion = "Nu neghocio",
                Link = "https://amazon.com",
                ImagenURL = "/imagenes/randstad.png"
            },
            new Proyecto
            {
                Titulo = "New York Time",
                Descripcion = "Pagina de noticias en React",
                Link = "https://amazon.com",
                ImagenURL = "/imagenes/newyorkTime.png"
            }
            };
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
