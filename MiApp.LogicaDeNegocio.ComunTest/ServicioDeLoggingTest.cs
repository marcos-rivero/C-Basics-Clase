using MiApp.LogicaDeNegocio.Comun;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MiApp.LogicaDeNegocio.ComunTest
{
    [TestClass]
    public class ServicioDeLoggingTest
    {
        [TestMethod]
        public void EscribirEnArchivo_Objetos_EscribirEnConsola()
        {
            var listadoDeObjetos = new List<Object>();
            //var listadoDeObjetos = new List<ILoggable>();

            var cliente = new Cliente(1)
            {
                Nombre = "Fabian",
                DireccionDeMail = "Fabian@unsta.edu.ar"
            };

            listadoDeObjetos.Add(cliente);

            var direccion = new Direccion(1)
            {
                Calle1 = "Av. Peron 2400",
                CodigoPostal = "4000"
            };

            listadoDeObjetos.Add(direccion);

            ServicioDeLogging.EscribirEnUnArchivo(listadoDeObjetos);
        }
    }
}
