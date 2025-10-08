using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Contraseña definida por el sistema
            string claveCorrecta = "Daniel2025";
            string intento;
            int intentosRestantes = 3;

            Console.WriteLine("=== Sistema de Autenticación ===");

            // Ciclo de validación
            while (intentosRestantes > 0)
            {
                Console.Write("Ingresa tu contraseña: ");
                intento = Console.ReadLine();

                if (intento == claveCorrecta)
                {
                    Console.WriteLine("Acceso concedido. Bienvenido al sistema.");
                    break;
                }
                else
                {
                    intentosRestantes--;
                    Console.WriteLine($"Contraseña incorrecta. Intentos restantes: {intentosRestantes}");
                }
            }

            // Si se agotan los intentos
            if (intentosRestantes == 0)
            {
                Console.WriteLine("Acceso denegado. Has excedido el número de intentos.");
            }
        }
    }
}