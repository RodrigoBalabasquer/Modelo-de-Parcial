using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{
    public class TiendaElectronica:Tienda
    {
        public TiendaElectronica() 
        {

        }
        public TiendaElectronica(string direccion, int anchoDeFrente, int legajo)
            : base(direccion, anchoDeFrente,legajo) 
        {

        }
        public int SerializaLegajo
        {
            get
            {
                return this.Legajo;
            }
            set
            {
                this.Legajo = value;
            }
        }
     }
}
