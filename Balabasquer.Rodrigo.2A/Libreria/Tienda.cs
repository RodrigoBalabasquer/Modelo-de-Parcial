using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excepciones;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Libreria
{   
    [XmlInclude(typeof(TiendaElectronica))]
    public abstract class Tienda:Local,IArchivos<Tienda>
    {
        protected string _direccion;
        protected int _anchoDeFrente;
        public Tienda() 
        {

        }
        public Tienda(int legajo):base(legajo)
        {

        }
        public Tienda(string direccion, int anchoDeFrente,int legajo):this(legajo)
        {
            this._anchoDeFrente = anchoDeFrente;
            this._direccion = direccion;
        }
        public int Ancho 
        {
            get 
            {
                return this._anchoDeFrente;
            }
            set 
            {
                this._anchoDeFrente = value;
            }
        }
        public string Direccion
        {
            get
            {
                return this._direccion;
            }
            set
            {
                this._direccion = value;
            }
        }
        protected override int Legajo
        {
            get
            {
                return this._legajo;
            }
            set
            {
                this._legajo = value;
            }
        }
        public string ExponerDatos() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Direccion de la tienda " + this._direccion);
            sb.AppendLine("Ancho de Frente " + this._anchoDeFrente);
            sb.AppendLine("Legajo de la tienda " + base.ToString());
            return sb.ToString();
        }

        public void Guardar()
        {
            try
            {
                Tienda.GuardarTienda(this);
            }
            catch (Exception)
            {

                throw new NoGuardarException("No se pudo guardar");
            }
        }

        public void Leer()
        {
            try
            {
                Tienda tienda = Tienda.LeerTienda(this.Direccion);
                this.Ancho = tienda._anchoDeFrente;
                this.Direccion = tienda._direccion;
                this.Legajo = tienda.Legajo;
            }
            catch (Exception)
            {
                throw new NoLeerException("No se pudo leer");
            }
        }
        public static void GuardarTienda(Tienda tienda) 
        {
            using (XmlTextWriter escritor = new XmlTextWriter(tienda._direccion, Encoding.UTF8))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Tienda));
                serializador.Serialize(escritor, tienda);
            }
        }
        public static Tienda LeerTienda(string direccion) 
        {
            Tienda tienda = null;
            using (XmlTextReader lector = new XmlTextReader(direccion))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Tienda));
                tienda = (Tienda)serializador.Deserialize(lector);
            }
            return tienda;
        }
    }
}
