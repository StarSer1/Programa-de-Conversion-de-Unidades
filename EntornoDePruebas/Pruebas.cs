using CUDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntornoDePruebas
{
    public class Pruebas
    {
        [Fact]
        public void Prueba1()
        {
            int n = 1;
            int n2 = 1;
            bool resultado;
            resultado = CDatos.numeroxd(n, n2);
            Assert.True(resultado);
        }
    }
}
