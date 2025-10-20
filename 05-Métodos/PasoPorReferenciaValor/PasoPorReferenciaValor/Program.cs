using System;

namespace PasoPorReferenciaValor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Ejemplo: Paso por Valor vs Paso por Referencia ===\n");

            int valor = 10;
            Console.WriteLine($"[Antes del método] Valor: {valor}");

            // Llamada por valor (copia)
            IncrementarPorValor(valor);
            Console.WriteLine($"[Después de IncrementarPorValor] Valor: {valor}\n");

            // Llamada por referencia (modifica el original)
            IncrementarPorReferencia(ref valor);
            Console.WriteLine($"[Después de IncrementarPorReferencia] Valor: {valor}\n");

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        /// <summary>
        /// Recibe un número por valor (se pasa una copia).
        /// </summary>
        /// <param name="numero">Número original (por valor).</param>
        static void IncrementarPorValor(int numero)
        {
            numero += 5;
            Console.WriteLine($"[Dentro de IncrementarPorValor] Número: {numero}");
        }

        /// <summary>
        /// Recibe un número por referencia (se pasa el original).
        /// </summary>
        /// <param name="numero">Número original (por referencia).</param>
        static void IncrementarPorReferencia(ref int numero)
        {
            numero += 5;
            Console.WriteLine($"[Dentro de IncrementarPorReferencia] Número: {numero}");
        }
    }
}
