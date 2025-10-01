using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Realizar un programa de computadora que haga el cálculo del área y perímetro de un rectangulo

            // Variables
            double altura, ancho, area, perimetro;

            // Pedimos la altura
            Console.Write("Ingrese la altura: ");
            altura = double.Parse(Console.ReadLine());

            // Pedimos el ancho 
            Console.Write("Ingrese el ancho: ");
            ancho = Convert.ToDouble(Console.ReadLine());

            // Calcular el área
            area = altura * ancho;

            // Calculamos el perimetro
            perimetro = 2*(ancho + altura);

            // Salida a consola
            Console.WriteLine("El área del recatangulo es: {0}", area); 
            Console.WriteLine("El perimetro del recatangulo es: {0}", perimetro); 
        }
    }
}
