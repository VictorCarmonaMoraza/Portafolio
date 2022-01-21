using Portafolio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portafolio.Servicios
{
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
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
    }
}
