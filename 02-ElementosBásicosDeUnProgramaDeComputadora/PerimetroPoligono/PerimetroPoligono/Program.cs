using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetroPoligono
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ** Hacer un programa que calcule el perímetro de cualquier polígono regular
            // Declaración de variables
            int lados;
            double perimetro, longitud;

            // Pedir el número de lados
            Console.Write("Ingrese el número de lados: ");
            lados = Convert.ToInt32(Console.ReadLine());

            // Pedir la longitud
            Console.Write("Ingrese la longitud de los lados: ");
            longitud = Convert.ToDouble(Console.ReadLine());

            // Calcular el perimetro
            perimetro = lados * longitud;

            // Escribir en consola el perimetro
            Console.WriteLine("El perimetro del poligono es: {0}", perimetro);

            Console.WriteLine("  *****  ");
            Console.WriteLine("  *****  ");
            Console.WriteLine("  *****  ");


            // ** Hacer un programa que transforme de grados C a grados F

            // Variables
            double gradosCelsius, gradosFahrenheit;

            Console.Write("Ingrese los grados Celsius: ");
            gradosCelsius = Convert.ToDouble(Console.ReadLine());

            // Fórmula de conversión 
            gradosFahrenheit = (gradosCelsius * 1.8) + 32;


            // Escribir en consola la conversión
            Console.WriteLine("La conversión a Fahrenheit es: {0}", gradosFahrenheit);




        }
    }
}
