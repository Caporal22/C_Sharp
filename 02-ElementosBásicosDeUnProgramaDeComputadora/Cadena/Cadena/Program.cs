using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int num1=5, num2, resultado;

            // Preguntamos al usuario el número
            Console.Write("Dame un número para sumarlo: ");
            entrada = Console.ReadLine();

            // Convertimos la cadena a un tipo int
            //num2 = Convert.ToInt32(entrada);
            num2 = Int32.Parse(entrada);

            resultado = num1 + num2;

            // Mostramos el resultado
            Console.WriteLine("El resultado de la suma es: {0}", resultado);


            Convert.ToSingle(entrada);
            Single.Parse(entrada);

            // Convertir cadena sin usar variables de tipo string
            num2 = Convert.ToInt32(Console.ReadLine());


            

        }
    }
}
