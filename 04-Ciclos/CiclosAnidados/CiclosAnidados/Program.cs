using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiclosAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            string[] horas = { "8:00", "10:00", "12:00", "14:00", "16:00" };

            Console.WriteLine("=== Generador de Horario Semanal ===\n");

            for (int i = 0; i < dias.Length; i++)
            {
                Console.WriteLine($"--- {dias[i]} ---");

                for (int j = 0; j < horas.Length; j++)
                {
                    Console.WriteLine($"Clase programada a las {horas[j]}");
                }

                Console.WriteLine();
            }
        }
    }
}