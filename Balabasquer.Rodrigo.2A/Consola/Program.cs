using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;
using Excepciones;

namespace Consola
{
    class Program
    {
        static void Main()
        {
            TiendaElectronica tienda = new TiendaElectronica("Archivo.xml", 40, 1);
            try
            {
                tienda.Guardar();
            }
            catch (Exception EX)
            {
                Console.Write(EX.Message);
            }
            Console.ReadKey();
            TiendaElectronica otraTienda = new TiendaElectronica();
            otraTienda.Direccion = tienda.Direccion;
            otraTienda.Leer();
            Console.WriteLine("Direccion: "+otraTienda.Direccion);
            Console.WriteLine("Legajo: " + otraTienda.SerializaLegajo);
            Console.WriteLine("Ancho: " + otraTienda.Ancho);
            Console.ReadKey();
        }
    }
}
