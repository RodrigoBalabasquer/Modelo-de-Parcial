using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Libreria;
using System.Threading;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public TiendaElectronica tienda;
        public TiendaElectronica otratienda;
        public string dirreccion;
        public Form1()
        {
            InitializeComponent();
            tienda = new TiendaElectronica();
            otratienda = new TiendaElectronica();
            dirreccion = "archivo.xml";
            tienda.Direccion = dirreccion;
            otratienda.Direccion = dirreccion;
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtAncho.Text) > 0 && (int.Parse(txtAncho.Text)%2) == 0)
                {
                    //this.tienda.Ancho = int.Parse(txtAncho.Text);
                    this.tienda.SetAnchoDeFrente(int.Parse(txtAncho.Text));
                    this.tienda.SerializaLegajo = int.Parse(txtLegajo.Text);
                    Thread Hilo = new Thread(this.tienda.Guardar);
                    Hilo.Start();
                }
                else
                {
                    throw new Exception("Ancho invalido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            Thread Hilo = new Thread(this.otratienda.Leer);
            Hilo.Start();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.otratienda.ExponerDatos());
        }

        

    }
}
