using Microsoft.VisualStudio.TestTools.UnitTesting;
using ActividadTDDApp;

namespace TestActividadTDDApp
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        public void CalcularFactorial_NumeroNegativo_DevuelveMenosUno()
        {
            int n = -5;
            long resultado = Funciones.CalcularFactorial(n);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Cero_DevuelveUno()
        {
            int n = 0;
            long resultado = Funciones.CalcularFactorial(n);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_NumeroPositivo_DevuelveCalculoCorrecto()
        {
            int n = 5;
            long resultado = Funciones.CalcularFactorial(n);
            Assert.AreEqual(120, resultado);
        }

        // Separación Testng

        [TestMethod]
        public void EsContrasenyaValida_Nula_DevuelveFalse()
        {
            string contrasenya = null;
            bool resultado = Funciones.EsContrasenyaValida(contrasenya);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_Vacia_DevuelveFalse()
        {
            string contrasenya = "";
            bool resultado = Funciones.EsContrasenyaValida(contrasenya);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_LongitudMenorDeOcho_DevuelveFalse()
        {
            string contrasenya = "Ab1#xyz";
            bool resultado = Funciones.EsContrasenyaValida(contrasenya);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_SinCaracterAlmohadilla_DevuelveFalse()
        {
            string contrasenya = "Password123";
            bool resultado = Funciones.EsContrasenyaValida(contrasenya);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_CumpleRequisitos_DevuelveTrue()
        {
            string contrasenya = "Password#2024";
            bool resultado = Funciones.EsContrasenyaValida(contrasenya);
            Assert.IsTrue(resultado);
        }
    }
}