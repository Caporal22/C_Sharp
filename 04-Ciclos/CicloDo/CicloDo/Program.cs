using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreProducto;
            float precio;
            string continuar;

            Console.WriteLine("=== Registro de productos ===");

            do
            {
                // Captura del nombre
                Console.Write("Nombre del producto: ");
                nombreProducto = Console.ReadLine();

                // Captura del precio con validación
                do
                {
                    Console.Write("Precio del producto: ");
                    bool valido = float.TryParse(Console.ReadLine(), out precio);

                    if (!valido || precio < 0)
                    {
                        Console.WriteLine("Precio inválido. Intenta nuevamente.");
                    }

                } while (precio < 0);

                // Mostrar resumen
                Console.WriteLine($"\nProducto registrado: {nombreProducto} - ${precio:F2}");

                // Preguntar si desea continuar
                Console.Write("\n¿Deseas registrar otro producto? (s/n): ");
                continuar = Console.ReadLine().ToLower();

                Console.WriteLine();

            } while (continuar == "s");
        }
    }
}