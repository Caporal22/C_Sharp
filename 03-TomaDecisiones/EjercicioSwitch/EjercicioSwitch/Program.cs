using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string color;

            Console.Write("Ingresa el color RGB para dar su código: ");
            color = Console.ReadLine();

            switch (color)
            {
                case "Red":
                    Console.WriteLine("El código RGB para {0} es: 255, 0, 0", color);
                    break;

                case "Green":
                    Console.WriteLine("El código RGB para {0} es: 0, 255, 0", color);
                    break;

                case "Blue":
                    Console.WriteLine("El código RGB para {0} es: 0, 0, 255", color);
                    break;

                default:
                    Console.WriteLine("Ingresa un color válido: {0}", color);
                    break;
            }
        }
    }
}
