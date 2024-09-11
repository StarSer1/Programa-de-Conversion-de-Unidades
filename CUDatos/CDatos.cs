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
        public static double ConversorDeFrecuencia(double segundos, int opcion)
        {

            double milisegundos = segundos * (Math.Pow(10,3));    // 1 segundo = 1000 milisegundos
            double microsegundos = segundos * (Math.Pow(10,6));    // 1 segundo = 1,000,000 microsegundos
            double nanosegundos = segundos * (Math.Pow(10, 9));     // 1 segundo = 1,000,000,000 nanosegundos
            double picosegundos = segundos * (Math.Pow(10, 12));    // 1 segundo = 1,000,000,000,000 picosegundos

            if (opcion == 1)
                return segundos;
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
        
        
    }
}
