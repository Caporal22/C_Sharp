using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalificacionPrepa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            float calPrepa, calExamen;

            Console.Write("¿Con qué promedio concluiste tus estudios de preparatoria? : ");
            calPrepa = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingresa la calificación que obtuviste en tu examen de primer ingreso: ");
            calExamen = Convert.ToSingle(Console.ReadLine());

            // Condición
            if((calPrepa >= 9) || calExamen >=9.5)
            {
                Console.WriteLine("Felicidades, tienes la beca");
            } else
            {
                Console.WriteLine("Lástima, no eres acreador de la beca");
            }
        }
    }
}
