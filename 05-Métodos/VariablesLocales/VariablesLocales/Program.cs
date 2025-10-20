using System;

namespace VariablesLocalesYReferencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ======================================
            // SECCIÓN 1: VARIABLES LOCALES EN C#
            // ======================================

            Console.WriteLine("=== VARIABLES LOCALES EN C# ===\n");

            // Variable local declarada con tipo explícito
            string nombre = "Daniel";

            // Variable local declarada con tipo implícito (var)
            var edad = 25;

            // Constante local
            const double PI = 3.1416;

            // Variable local dentro de un bloque
            {
                var mensaje = "Hola desde dentro del bloque.";
                Console.WriteLine(mensaje);
            }

            // Variable estática local (disponible desde C# 8.0 en adelante)
            // Conserva su valor entre llamadas al método
            ContadorDeLlamadas();
            ContadorDeLlamadas();
            ContadorDeLlamadas();

            Console.WriteLine("\nPresiona una tecla para continuar a la siguiente sección...");
            Console.ReadKey();
            Console.Clear();

            // ==========================================
            // SECCIÓN 2: PASO POR VALOR Y REFERENCIA
            // ==========================================

            Console.WriteLine("=== PASO POR VALOR Y POR REFERENCIA ===\n");

            int numero = 10;

            Console.WriteLine($"Valor inicial: {numero}");

            // Paso por valor: el método recibe una copia del valor
            CambiarValor(numero);
            Console.WriteLine($"Después de pasar por valor: {numero}");

            // Paso por referencia: el método recibe una referencia al valor original
            CambiarPorReferencia(ref numero);
            Console.WriteLine($"Después de pasar por referencia: {numero}");

            // Uso del parámetro out: el método asigna un nuevo valor
            int resultado;
            AsignarValor(out resultado);
            Console.WriteLine($"Valor asignado con out: {resultado}");

            // Paso por referencia con lectura (in)
            MostrarValor(in numero);

            Console.WriteLine("\nEjecución finalizada. Presione cualquier tecla para salir.");
            Console.ReadKey();
        }

        // Método que demuestra variable estática local
        static void ContadorDeLlamadas()
        {
            // La variable estática conserva su valor entre llamadas al método
            int contador = 0;
            contador++;
            Console.WriteLine($"El método ContadorDeLlamadas ha sido llamado {contador} veces.");
        }

        // Paso por valor: el parámetro recibe una copia del valor original
        static void CambiarValor(int n)
        {
            n = 50;
            Console.WriteLine($"Dentro de CambiarValor(): n = {n}");
        }

        // Paso por referencia: el parámetro apunta a la variable original
        static void CambiarPorReferencia(ref int n)
        {
            n = 100;
            Console.WriteLine($"Dentro de CambiarPorReferencia(): n = {n}");
        }

        // Uso de 'out': el método debe asignar un valor antes de salir
        static void AsignarValor(out int n)
        {
            n = 200;
            Console.WriteLine("Dentro de AsignarValor(): se asignó un nuevo valor.");
        }

        // Uso de 'in': el método recibe una referencia de solo lectura
        static void MostrarValor(in int n)
        {
            Console.WriteLine($"Dentro de MostrarValor(): n = {n}");
        }
    }
}
