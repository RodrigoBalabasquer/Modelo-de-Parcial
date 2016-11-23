using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Libreria;
using Excepciones;

namespace Unitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void ValidarExcepcion()
        {
            TiendaElectronica tienda = new TiendaElectronica("direccion", 10, 14);
            try
            {
                tienda.Guardar();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(NoGuardarException));
            }
        }
        [TestMethod]
        public void ValidarGuardado()
        {
            TiendaElectronica tienda = new TiendaElectronica("direccion", 10,1);
            try
            {
                tienda.Guardar();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(NoGuardarException));
            }
            TiendaElectronica otratienda = new TiendaElectronica();
            otratienda.Direccion = tienda.Direccion;
            try
            {
                otratienda.Leer();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(NoLeerException));
            }
            Assert.AreEqual(tienda.Ancho, otratienda.Ancho);
            Assert.AreEqual(tienda.Direccion, otratienda.Direccion);
            Assert.AreEqual(tienda.SerializaLegajo, otratienda.SerializaLegajo);
        }
    }
}
