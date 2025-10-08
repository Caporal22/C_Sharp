using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar número de alumnos
            Console.Write("¿Cuántos alumnos deseas registrar? : ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            // Variables para estadísticas
            float suma = 0;
            float mayor = float.MinValue;
            float menor = float.MaxValue;
            int aprobados = 0;

            // Ciclo para capturar calificaciones
            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Ingresa la calificación del alumno #{i}: ");
                float calificacion = Convert.ToSingle(Console.ReadLine());

                suma += calificacion;

                if (calificacion > mayor)
                    mayor = calificacion;

                if (calificacion < menor)
                    menor = calificacion;

                if (calificacion >= 6)
                    aprobados++;
            }

            // Resultados
            float promedio = suma / cantidad;

            Console.WriteLine("\n--- Estadísticas ---");
            Console.WriteLine($"Promedio general: {promedio:F2}");
            Console.WriteLine($"Calificación más alta: {mayor}");
            Console.WriteLine($"Calificación más baja: {menor}");
            Console.WriteLine($"Alumnos aprobados: {aprobados} de {cantidad}");
        }
    }
}