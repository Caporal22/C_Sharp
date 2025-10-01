using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double precioCamisa = 399;
            //string colorCamisa = "Amarillo";

            //Console.WriteLine("El precio de la camisa es: {0} y su color es: {1}", precioCamisa, colorCamisa);
            //Console.WriteLine(precioCamisa);

            string nombre;
            Console.Write("Cómo te llamas: ");
            nombre = Console.ReadLine();

            // Saludamos al usuario
            Console.WriteLine("Hola {0}, un placer", nombre);
        }
    }
}
