using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Números primos entre 1 y 100 ===\n");

            for (int numero = 2; numero <= 100; numero++)
            {
                bool esPrimo = true;

                for (int divisor = 2; divisor <= Math.Sqrt(numero); divisor++)
                {
                    if (numero % divisor == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    Console.Write($"{numero} ");
                }
            }

            Console.WriteLine("\n\nProceso terminado.");
        }
    }
}