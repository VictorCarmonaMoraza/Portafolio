using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portafolio.Models
{
    public class HomeIndexViewModel
    {
        //Aqui cargaremos la lista de proyectos
        public IEnumerable<Proyecto> Proyectos { get; set; }
    }
}
