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
            double kiloHertz = CDatos.ConversorDeHertz(12, 2);
            double resultado2 = 8.3333333333333E-5;
            double resultadoGenereal;
            resultadoGenereal = CDatos.ConversorDeFrecuencia(kiloHertz, 1);
            Assert.Equal(resultado2, resultadoGenereal);
        }
        [Fact]
        public void megaHertz()
        {
            double megaHertz = CDatos.ConversorDeHertz(44, 3);
            double resultado3 = 1000000;
            double resultadoGenereal;
            resultadoGenereal = CDatos.ConversorDeFrecuencia(megaHertz, 3);
            Assert.Equal(resultado3, resultadoGenereal);
        }
        [Fact]
        public void gigaHertz()
        {
            double gigaHertz = CDatos.ConversorDeHertz(5, 4);
            double resultado4 = 2.0E-7;
            double resultadoGenereal;
            resultadoGenereal = CDatos.ConversorDeFrecuencia(gigaHertz, 2);
            Assert.Equal(resultado4, resultadoGenereal);
        }
        [Fact]
        public void teraHertz()
        {
            double teraHertz = CDatos.ConversorDeHertz(44, 5);
            double resultado5 = 0.022727272727273;
            double resultadoGenereal;
            resultadoGenereal = CDatos.ConversorDeFrecuencia(teraHertz, 2);
            Assert.Equal(resultado5, resultadoGenereal);
        }

        //Segundos
        [Fact]
        public void Herzio()
        {
            double Segundos = 1;
            double resultado5 = 1;
            double resultadoGenereal;
            resultadoGenereal = CDatos.ConversorDeSegundos(Segundos, 1);
            Assert.Equal(resultado5, resultadoGenereal);
        }
        [Fact]
        public void KiloHerzio()
        {
            double Segundos = 10;
            double resultado5 = 0.0001;
            double resultadoGenereal;
            resultadoGenereal = CDatos.ConversorDeSegundos(Segundos, 2);
            Assert.Equal(resultado5, resultadoGenereal);
        }
        [Fact]
        public void MegaHerzio()
        {
            double Segundos = 10;
            double resultado5 = 1.0E-7;
            double resultadoGenereal;
            resultadoGenereal = CDatos.ConversorDeSegundos(Segundos, 3);
            Assert.Equal(resultado5, resultadoGenereal);
        }
        [Fact]
        public void GigaHerzio()
        {
            double GigaHerzio = 10;
            double resultado5 = 1.0E-10;
            double resultadoGenereal;
            resultadoGenereal = CDatos.ConversorDeSegundos(GigaHerzio, 4);
            Assert.Equal(resultado5, resultadoGenereal);
        }
        [Fact]
        public void TeraHerzio()
        {
            double TeraHerzio = 1;
            double resultado5 = 1.0E-12;
            double resultadoGenereal;
            resultadoGenereal = CDatos.ConversorDeSegundos(TeraHerzio, 5);
            Assert.Equal(resultado5, resultadoGenereal);
        }
        //Milisegundos
        [Fact]
        public void Herzios()
        {
            double Milisegundos = 3;
            double resultado5 = 333.33333333333;
            double resultadoGenereal;
            resultadoGenereal = CDatos.ConversorDeMilisegundos(Milisegundos, 1);
            Assert.Equal(resultado5, resultadoGenereal);
        }
        [Fact]
        public void KiloHerzios()
        {
            double Milisegundos = 1;
            double resultado5 = 1;
            double resultadoGenereal;
            resultadoGenereal = CDatos.ConversorDeMilisegundos(Milisegundos, 2);
            Assert.Equal(resultado5, resultadoGenereal);
        }
        [Fact]
        public void MegaHerzios()
        {
            double Milisegundos = 1;
            double resultado5 = 0.001;
            double resultadoGenereal;
            resultadoGenereal = CDatos.ConversorDeMilisegundos(Milisegundos, 3);
            Assert.Equal(resultado5, resultadoGenereal);
        }
        [Fact]
        public void GigaHerzios()
        {
            double Milisegundos = 0.1;
            double resultado5 = 1.0E-5;
            double resultadoGenereal;
            resultadoGenereal = CDatos.ConversorDeMilisegundos(Milisegundos, 4);
            Assert.Equal(resultado5, resultadoGenereal);
        }
        [Fact]
        public void TeraHerzios()
        {
            double Milisegundos = 0.1;
            double resultado5 = 1.0E-8;
            double resultadoGenereal;
            resultadoGenereal = CDatos.ConversorDeMilisegundos(Milisegundos, 5);
            Assert.Equal(resultado5, resultadoGenereal);
        }
        // Microsegundos
        [Fact]
        public void HerziosDeMicrosegundos()
        {
            double microsegundos = 1;
            double resultado5 = 1000000;
            double resultadoGenereal = CDatos.ConversorDeMicrosegundos(microsegundos, 1);
            Assert.Equal(resultado5, resultadoGenereal);
        }

        [Fact]
        public void KiloHerziosDeMicrosegundos()
        {
            double microsegundos = 1;
            double resultado5 = 1000;
            double resultadoGenereal = CDatos.ConversorDeMicrosegundos(microsegundos, 2);
            Assert.Equal(resultado5, resultadoGenereal);
        }

        [Fact]
        public void MegaHerziosDeMicrosegundos()
        {
            double microsegundos = 1;
            double resultado5 = 1;
            double resultadoGenereal = CDatos.ConversorDeMicrosegundos(microsegundos, 3);
            Assert.Equal(resultado5, resultadoGenereal);
        }

        [Fact]
        public void GigaHerziosDeMicrosegundos()
        {
            double microsegundos = 1;
            double resultado5 = 1.0E-3;
            double resultadoGenereal = CDatos.ConversorDeMicrosegundos(microsegundos, 4);
            Assert.Equal(resultado5, resultadoGenereal);
        }

        [Fact]
        public void TeraHerziosDeMicrosegundos()
        {
            double microsegundos = 1;
            double resultado5 = 1.0E-6;
            double resultadoGenereal = CDatos.ConversorDeMicrosegundos(microsegundos, 5);
            Assert.Equal(resultado5, resultadoGenereal);
        }

        // Nanosegundos
        [Fact]
        public void HerziosDeNanosegundos()
        {
            double nanosegundos = 1;
            double resultado5 = 1000000000;
            double resultadoGenereal = CDatos.ConversorDeNanosegundos(nanosegundos, 1);
            Assert.Equal(resultado5, resultadoGenereal);
        }

        [Fact]
        public void KiloHerziosDeNanosegundos()
        {
            double nanosegundos = 1;
            double resultado5 = 1000000;
            double resultadoGenereal = CDatos.ConversorDeNanosegundos(nanosegundos, 2);
            Assert.Equal(resultado5, resultadoGenereal);
        }

        [Fact]
        public void MegaHerziosDeNanosegundos()
        {
            double nanosegundos = 1;
            double resultado5 = 1000;
            double resultadoGenereal = CDatos.ConversorDeNanosegundos(nanosegundos, 3);
            Assert.Equal(resultado5, resultadoGenereal);
        }

        [Fact]
        public void GigaHerziosDeNanosegundos()
        {
            double nanosegundos = 1;
            double resultado5 = 1;
            double resultadoGenereal = CDatos.ConversorDeNanosegundos(nanosegundos, 4);
            Assert.Equal(resultado5, resultadoGenereal);
        }

        [Fact]
        public void TeraHerziosDeNanosegundos()
        {
            double nanosegundos = 1;
            double resultado5 = 1.0E-3;
            double resultadoGenereal = CDatos.ConversorDeNanosegundos(nanosegundos, 5);
            Assert.Equal(resultado5, resultadoGenereal);
        }

        // Picosegundos
        [Fact]
        public void HerziosDePicosegundos()
        {
            double picosegundos = 1;
            double resultado5 = 1000000000000;
            double resultadoGenereal = CDatos.ConversorDePicosegundos(picosegundos, 1);
            Assert.Equal(resultado5, resultadoGenereal);
        }

        [Fact]
        public void KiloHerziosDePicosegundos()
        {
            double picosegundos = 1;
            double resultado5 = 1000000000;
            double resultadoGenereal = CDatos.ConversorDePicosegundos(picosegundos, 2);
            Assert.Equal(resultado5, resultadoGenereal);
        }

        [Fact]
        public void MegaHerziosDePicosegundos()
        {
            double picosegundos = 1;
            double resultado5 = 1000000;
            double resultadoGenereal = CDatos.ConversorDePicosegundos(picosegundos, 3);
            Assert.Equal(resultado5, resultadoGenereal);
        }

        [Fact]
        public void GigaHerziosDePicosegundos()
        {
            double picosegundos = 1;
            double resultado5 = 1000;
            double resultadoGenereal = CDatos.ConversorDePicosegundos(picosegundos, 4);
            Assert.Equal(resultado5, resultadoGenereal);
        }

        [Fact]
        public void TeraHerziosDePicosegundos()
        {
            double picosegundos = 1;
            double resultado5 = 1;
            double resultadoGenereal = CDatos.ConversorDePicosegundos(picosegundos, 5);
            Assert.Equal(resultado5, resultadoGenereal);
        }
    }
}
