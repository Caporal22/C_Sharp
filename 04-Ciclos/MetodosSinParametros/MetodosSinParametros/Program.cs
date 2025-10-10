using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosSinParametros
{
    namespace MetodosSinParametros
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                MostrarBienvenida();
                MostrarFechaActual();
                MostrarMenu();
                MostrarSeparador();
                ProcesarOpcion();
            }

            static void MostrarBienvenida()
            {
                Console.WriteLine("=== Bienvenido al sistema de demostración ===");
            }

            static void MostrarFechaActual()
            {
                Console.WriteLine($"Fecha actual: {DateTime.Now:dddd, dd MMMM yyyy HH:mm:ss}");
            }

            static void MostrarMenu()
            {
                Console.WriteLine("Opciones disponibles:");
                Console.WriteLine("1. Ver información");
                Console.WriteLine("2. Salir");
            }

            static void MostrarSeparador()
            {
                Console.WriteLine(new string('-', 40));
            }

            static void ProcesarOpcion()
            {
                Console.Write("Seleccione una opción (1-2): ");
                string entrada = Console.ReadLine();

                switch (entrada)
                {
                    case "1":
                        MostrarInformacion();
                        break;
                    case "2":
                        Console.WriteLine("Saliendo del sistema... ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                Console.ReadKey(); // Mantiene la consola abierta
            }

            static void MostrarInformacion()
            {
                Console.WriteLine("Este sistema demuestra el uso de métodos sin parámetros en C#.");
                Console.WriteLine("Cada método realiza una tarea específica sin requerir argumentos.");
            }
        }


    }
}
