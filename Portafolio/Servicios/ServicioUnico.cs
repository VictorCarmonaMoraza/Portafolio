using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portafolio.Servicios
{
    public class ServicioUnico
    {
        public Guid ObtenerGuid { get; private set; }

        public ServicioUnico()
        {
            ObtenerGuid = Guid.NewGuid();
        }
    }

    public class ServicioDelimitado
    {
        public Guid ObtenerGuid { get; private set; }

        public ServicioDelimitado()
        {
            ObtenerGuid = Guid.NewGuid();
        }
    }

    public class ServicioTransitorio
    {
        public Guid ObtenerGuid { get; private set; }

        public ServicioTransitorio()
        {
            ObtenerGuid = Guid.NewGuid();
        }
    }
}
