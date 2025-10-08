using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Cálculo de Potencia ===");

            // Entrada base
            Console.Write("Ingresa la base: ");
            double baseNum = Convert.ToDouble(Console.ReadLine());

            // Entrada exponente
            Console.Write("Ingresa el exponente (puede ser negativo): ");
            int exponente = Convert.ToInt32(Console.ReadLine());

            // Cálculo
            double resultado = Math.Pow(baseNum, exponente);

            // Salida
            Console.WriteLine($"\nResultado: {baseNum}^{exponente} = {resultado}");
        }
    }
}