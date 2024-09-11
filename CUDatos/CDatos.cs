using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace CUDatos
{
    public class CDatos
    {
        public static double ConversorDeHertz(double Hertz, int opcion) //De otra hertz a hertz
        {
            if (opcion == 1)
                return Hertz;
            else if (opcion == 2)
                return Hertz * (Math.Pow(10, 3));
            else if (opcion == 3)
                return Hertz * (Math.Pow(10, 6));
            else if (opcion == 4)
                return Hertz * (Math.Pow(10, 9));
            else if (opcion == 5)
                return Hertz * (Math.Pow(10, 12));
            else return 0;
        }

        public static double ConversorDeFrecuencia(double hertz, int opcion) //Hertz
        {
            double segundosI = 1 / hertz;
            double milisegundos = segundosI * (Math.Pow(10, 3));    // 1 segundo = 1000 milisegundos
            double microsegundos = segundosI * (Math.Pow(10, 6));    // 1 segundo = 1,000,000 microsegundos
            double nanosegundos = segundosI * (Math.Pow(10, 9));     // 1 segundo = 1,000,000,000 nanosegundos
            double picosegundos = segundosI * (Math.Pow(10, 12));    // 1 segundo = 1,000,000,000,000 picosegundos

            if (opcion == 1)
                return segundosI;
            else if (opcion == 2)
                return milisegundos;
            else if (opcion == 3)
                return microsegundos;
            else if (opcion == 4)
                return nanosegundos;
            else if (opcion == 5)
                return picosegundos;
            else return 0;

        }


        public static double ConversorDeSegundos(double segundos, int opcion)
        {

            double Herzios = 1/segundos;    // 1 Herzio = 1 segundos
            double KiloHerzio = 1/(segundos * 1000);    // 1 KiloHerzio = 0.001 segundos
            double MegaHerzio = 1 / (segundos * Math.Pow(10, 6));    // 1 Megaherzio = 0.000001 segundos
            double GigaHerzio = 1 / (segundos * Math.Pow(10, 9));   // 1 Gigaherzio = 1.0E-9 segundos
            double TeraHerzio = 1 / (segundos * Math.Pow(10, 12));  // 1 Teraherzio = 1.0E-12 segundos

            if (opcion == 1)
                return Herzios;
            else if (opcion == 2)
                return KiloHerzio;
            else if (opcion == 3)
                return MegaHerzio;
            else if (opcion == 4)
                return GigaHerzio;
            else if (opcion == 5)
                return TeraHerzio;
            else return 0;
        }

        public static double ConversorDeMilisegundos(double milisegundos, int opcion)
        {
            // Convertir milisegundos a segundos
            double segundos = milisegundos / 1000.0;

            // Calcular las frecuencias en diferentes unidades
            double Herzios = 1 / segundos;  // 1 Hertzio = 1 segundo
            double KiloHerzio = 1 / (segundos * 1000);  // 1 KiloHerzio = 0.001 segundos
            double MegaHerzio = 1 / (segundos * Math.Pow(10, 6));  // 1 Megaherzio = 0.000001 segundos
            double GigaHerzio = 1 / (segundos * Math.Pow(10, 9));  // 1 Gigaherzio = 1.0E-9 segundos
            double TeraHerzio = 1 / (segundos * Math.Pow(10, 12));  // 1 Teraherzio = 1.0E-12 segundos

            // Devolver la frecuencia en la unidad solicitada
            if (opcion == 1)
                return Herzios;
            else if (opcion == 2)
                return KiloHerzio;
            else if (opcion == 3)
                return MegaHerzio;
            else if (opcion == 4)
                return GigaHerzio;
            else if (opcion == 5)
                return TeraHerzio;
            else
                return 0;
        }
        public static double ConversorDeMicrosegundos(double microsegundos, int opcion)
        {
            // Convertir microsegundos a segundos
            double segundos = microsegundos / 1000000.0;

            // Calcular las frecuencias en diferentes unidades
            double Herzios = 1 / segundos;  // 1 Hertzio = 1 segundo
            double KiloHerzio = 1 / (segundos * 1000);  // 1 KiloHerzio = 0.001 segundos
            double MegaHerzio = 1 / (segundos * Math.Pow(10, 6));  // 1 Megaherzio = 0.000001 segundos
            double GigaHerzio = 1 / (segundos * Math.Pow(10, 9));  // 1 Gigaherzio = 1.0E-9 segundos
            double TeraHerzio = 1 / (segundos * Math.Pow(10, 12));  // 1 Teraherzio = 1.0E-12 segundos

            // Devolver la frecuencia en la unidad solicitada
            if (opcion == 1)
                return Herzios;
            else if (opcion == 2)
                return KiloHerzio;
            else if (opcion == 3)
                return MegaHerzio;
            else if (opcion == 4)
                return GigaHerzio;
            else if (opcion == 5)
                return TeraHerzio;
            else
                return 0;
        }
        public static double ConversorDeNanosegundos(double nanosegundos, int opcion)
        {
            // Convertir nanosegundos a segundos
            double segundos = nanosegundos / 1000000000.0;

            // Calcular las frecuencias en diferentes unidades
            double Herzios = 1 / segundos;  // 1 Hertzio = 1 segundo
            double KiloHerzio = 1 / (segundos * 1000);  // 1 KiloHerzio = 0.001 segundos
            double MegaHerzio = 1 / (segundos * Math.Pow(10, 6));  // 1 Megaherzio = 0.000001 segundos
            double GigaHerzio = 1 / (segundos * Math.Pow(10, 9));  // 1 Gigaherzio = 1.0E-9 segundos
            double TeraHerzio = 1 / (segundos * Math.Pow(10, 12));  // 1 Teraherzio = 1.0E-12 segundos

            // Devolver la frecuencia en la unidad solicitada
            if (opcion == 1)
                return Herzios;
            else if (opcion == 2)
                return KiloHerzio;
            else if (opcion == 3)
                return MegaHerzio;
            else if (opcion == 4)
                return GigaHerzio;
            else if (opcion == 5)
                return TeraHerzio;
            else
                return 0;
        }
        public static double ConversorDePicosegundos(double picosegundos, int opcion)
        {
            // Convertir picosegundos a segundos
            double segundos = picosegundos / 1000000000000.0;

            // Calcular las frecuencias en diferentes unidades
            double Herzios = 1 / segundos;  // 1 Hertzio = 1 segundo
            double KiloHerzio = 1 / (segundos * 1000);  // 1 KiloHerzio = 0.001 segundos
            double MegaHerzio = 1 / (segundos * Math.Pow(10, 6));  // 1 Megaherzio = 0.000001 segundos
            double GigaHerzio = 1 / (segundos * Math.Pow(10, 9));  // 1 Gigaherzio = 1.0E-9 segundos
            double TeraHerzio = 1 / (segundos * Math.Pow(10, 12));  // 1 Teraherzio = 1.0E-12 segundos

            // Devolver la frecuencia en la unidad solicitada
            if (opcion == 1)
                return Herzios;
            else if (opcion == 2)
                return KiloHerzio;
            else if (opcion == 3)
                return MegaHerzio;
            else if (opcion == 4)
                return GigaHerzio;
            else if (opcion == 5)
                return TeraHerzio;
            else
                return 0;
        }

    }
}
