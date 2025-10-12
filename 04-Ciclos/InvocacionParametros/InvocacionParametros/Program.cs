using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvocacionParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Invocación de Parámetros en C#";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== Invocación de Parámetros en C# ===\n");
            Console.ResetColor();

            // Parámetro por valor
            int numero = 10;
            Console.WriteLine($"[Valor] Antes: {numero}");
            PorValor(numero);
            Console.WriteLine($"[Valor] Después: {numero}\n");

            // Parámetro por referencia
            int referencia = 10;
            Console.WriteLine($"[Ref] Antes: {referencia}");
            PorReferencia(ref referencia);
            Console.WriteLine($"[Ref] Después: {referencia}\n");

            // Parámetro de salida
            int resultado;
            PorSalida(out resultado);
            Console.WriteLine($"[Out] Resultado: {resultado}\n");

            // Parámetro opcional
            Console.WriteLine("[Opcional] Invocación sin segundo parámetro:");
            Opcional("Daniel");
            Console.WriteLine("[Opcional] Invocación con segundo parámetro:");
            Opcional("Daniel", "¡Bienvenido al sistema!");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Parámetro por valor
        static void PorValor(int x)
        {
            x += 5;
            Console.WriteLine($"[PorValor] Internamente modificado a: {x}");
        }

        // Parámetro por referencia
        static void PorReferencia(ref int x)
        {
            x += 5;
            Console.WriteLine($"[PorReferencia] Internamente modificado a: {x}");
        }

        // Parámetro de salida
        static void PorSalida(out int x)
        {
            x = 100;
            Console.WriteLine($"[PorSalida] Asignado internamente a: {x}");
        }

        // Parámetro opcional
        static void Opcional(string nombre, string mensaje = "Hola desde C#!")
        {
            Console.WriteLine($"[Opcional] {nombre}, {mensaje}");
        }
    }
}
