using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresBooleanos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            float energia;
            bool propulsorIzquierdo, propulsorDerecho;

            Console.Write("Ingrese el nivel de energía: ");
            energia = Convert.ToSingle(Console.ReadLine());

            Console.Write("El propulsor derecho esta en buen estado? (true/false): ");
            propulsorDerecho = Convert.ToBoolean(Console.ReadLine());

            Console.Write("El propulsor izquierdo esta en buen estado? (true/false): ");
            propulsorIzquierdo = Convert.ToBoolean(Console.ReadLine());

            if (((propulsorIzquierdo && propulsorDerecho) == true) && (energia >= 75) || ((propulsorDerecho || propulsorIzquierdo) == true) && (energia == 100))
            {
                Console.WriteLine("Puedes despegar...");
            } else
            {
                Console.WriteLine("No es seguro despegar...");
            }
                
        }
    }
}
