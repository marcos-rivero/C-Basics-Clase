using MiApp.LogicaDeNegocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MiApp.LogicaDeNegocioTest
{
    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        public void NombreCompleto_NombreYApellido_RetornarNombreCompleto()
        {
            //Arrange
            Cliente cliente = new Cliente();
            cliente.Apellido = "Perez";
            cliente.Nombre = "Juan";
            string esperado = "Perez, Juan";
            //Act
            string resultado = cliente.NombreCompleto;

            //Assert
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void NombreCompleto_Apellido_RetornarNombreCompleto()
        {
            //Arrange
            Cliente cliente = new Cliente();
            cliente.Apellido = "Perez";
            string esperado = "Perez";
            //Act
            string resultado = cliente.NombreCompleto;

            //Assert
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void NombreCompleto_Nombre_RetornarNombreCompleto()
        {
            //Arrange
            Cliente cliente = new Cliente();
            cliente.Nombre = "Juan";
            string esperado = "Juan";
            //Act
            string resultado = cliente.NombreCompleto;

            //Assert
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void ContadorDeInstancias_Instancias_RetornarCantidadDeInstancias()
        {
            //Arrange
            Cliente cliente1 = new Cliente();
            Cliente.ContadorDeInstancias++;
            int esperado = 1;
            //Act


            //Assert
            Assert.AreEqual(esperado, Cliente.ContadorDeInstancias);
        }
        [TestMethod]
        public void Validar_NombreYDireccionDeEmail_RetornarVerdadero()
        {
            //Arrange
            Cliente cliente1 = new Cliente()
            {
                Nombre = "Marcia",
                DireccionDeMail = "marcias@unsta.edu.ar"
            };
            bool esperado = true;
            //cliente1.Nombre = "Marcia";
            
            //Act
            bool actual = cliente1.Validar();

            //Assert
            Assert.AreEqual(esperado, actual);
        }
        [TestMethod]
        public void Validar_NombreYDireccionDeEmail_RetornarFalso()
        {
            Cliente cliente1 = new Cliente()
            {
                Nombre = "Marcia"
            };
            bool esperado = false;
            //cliente1.Nombre = "Marcia";

            //Act
            bool actual = cliente1.Validar();
            bool nulo;
            
            //Assert
            Assert.AreEqual(esperado, actual);
        }
        [TestMethod]
        public void Constructor_NombreYDireccionDeEmail_MuestraEnConsola()
        {
            //Arrange
            Cliente cliente1 = new Cliente("marcia")
            {             
                DireccionDeMail = "marcias@unsta.edu.ar"
            };
            bool esperado = true;
            //cliente1.Nombre = "Marcia";

            //Act
            bool actual = cliente1.Validar();

            //Assert
            Console.WriteLine(cliente1.ClienteID);
        }
        [TestMethod]
        public void ToString_NombreYApellido_RetornaNombreCompleto()
        {
            // Arrange
            Cliente cliente1 = new Cliente();
            cliente1.Nombre = "Juan";
            cliente1.Apellido = "Perez";
            string esperado = "Juan Perez";

            Direccion direccion = new Direccion(1)
            {
                Calle1 = "Av. Mate de Luna 2300",
                CodigoPostal = "4000"
            };

            Console.WriteLine(direccion.ToString());

            // Act
            string valorActual = cliente1.ToString();
            cliente1.

            Console.WriteLine(cliente1.ToString());


            // Assert
            Assert.AreEqual(esperado, valorActual);
        }
    }

}
