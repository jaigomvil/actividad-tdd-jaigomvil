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
    }
}