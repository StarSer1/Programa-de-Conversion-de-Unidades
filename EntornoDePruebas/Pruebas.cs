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
        public void PruebaHertz()
        {
            double hertz = 50;
            double resultado1 = 50000000000000;           
            double resultadoGenereal;
            resultadoGenereal = CDatos.ConversorDeFrecuencia(hertz, 5);
            Assert.Equal(resultado1, resultadoGenereal);
        }
        [Fact]
        public void kiloHertz()
        {
            double kiloHertz = 44;
            double resultado2 = 44000;
            double resultadoGenereal;
            resultadoGenereal = CDatos.ConversorDeFrecuencia(kiloHertz, 2);
            Assert.Equal(resultado2, resultadoGenereal);
        }
        [Fact]
        public void megaHertz()
        {
            double megaHertz = 1 * (Math.Pow(10, 6)); ;
            double resultado3 = 1000000;
            double resultadoGenereal;
            resultadoGenereal = CDatos.ConversorDeFrecuencia(megaHertz, 3);
            Assert.Equal(resultado3, resultadoGenereal);
        }
        [Fact]
        public void gigaHertz()
        {
            double gigaHertz = 1 * (Math.Pow(10, 9));
            double resultado4 = 1000000000;
            double resultadoGenereal;
            resultadoGenereal = CDatos.ConversorDeFrecuencia(gigaHertz, 4);
            Assert.Equal(resultado4, resultadoGenereal);
        }
        [Fact]
        public void teraHertz()
        {
            double teraHertz = 44 * (Math.Pow(10, 12));
            double resultado5 = 4.4E+25; 
            double resultadoGenereal;
            resultadoGenereal = CDatos.ConversorDeFrecuencia(teraHertz, 5);
            Assert.Equal(resultado5, resultadoGenereal);
        }
    }
}
