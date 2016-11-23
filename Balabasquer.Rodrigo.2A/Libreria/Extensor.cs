using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{
    public static class Extensor
    {
        public static void SetAnchoDeFrente(this TiendaElectronica dato,int ancho)
        {
            dato.Ancho = ancho;
        }
    }
}
