using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portafolio.Interfaces
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
}
