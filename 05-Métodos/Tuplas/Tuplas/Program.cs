using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuplas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // SECCIÓN 1: VARIABLES BÁSICAS
            // ==========================================

            string nombre = "Daniel";
            byte edad = 50;
            long numero = 5533004466;
            int dirPostal = 001122;

            // (tipo) Identificador = (valor)
            var persona1 = (nombre: "Juanito", edad: 50, telefono: 5533004466L, codigoPostal: 001122);

            Console.WriteLine("=== INFORMACIÓN DE LA TUPLA ===");
            Console.WriteLine($"Nombre: {persona1.nombre}");
            Console.WriteLine($"Edad: {persona1.edad}");
            Console.WriteLine($"Teléfono: {persona1.telefono}");
            Console.WriteLine($"Código Postal: {persona1.codigoPostal}");

            Console.WriteLine("\nPresiona una tecla para continuar con más ejemplos...");
            Console.ReadKey();
            Console.Clear();

            // ==========================================
            // SECCIÓN 2: OTRAS FORMAS DE USAR TUPLAS
            // ==========================================

            Console.WriteLine("=== OTRAS FORMAS DE CREAR Y USAR TUPLAS ===\n");

            // Tupla sin nombres, accediendo por posición
            var producto = ("Laptop", 12000.99, true);
            Console.WriteLine($"Producto: {producto.Item1}");
            Console.WriteLine($"Precio: {producto.Item2}");
            Console.WriteLine($"Disponible: {producto.Item3}");

            // Tupla con nombres personalizados
            var alumno = (nombre: "Ana", calificacion: 9.5, grupo: "3A");
            Console.WriteLine($"\nAlumno: {alumno.nombre} | Calificación: {alumno.calificacion} | Grupo: {alumno.grupo}");

            // Desempaquetar (deconstruir) tupla en variables
            var empleado = (nombre: "María", puesto: "Desarrolladora", salario: 18500.75);
            (string nom, string cargo, double sueldo) = empleado;
            Console.WriteLine($"\nEmpleado: {nom} - {cargo} - ${sueldo}");

            // Desempaquetar ignorando algunos valores
            var direccion = ("Av. Siempre Viva", 742, "Springfield");
            (string calle, _, string ciudad) = direccion;
            Console.WriteLine($"\nDirección simplificada: {calle}, {ciudad}");

            Console.WriteLine("\nPresiona una tecla para continuar a la siguiente sección...");
            Console.ReadKey();
            Console.Clear();

            // ==========================================
            // SECCIÓN 3: TUPLAS COMO RETORNO DE MÉTODOS
            // ==========================================

            Console.WriteLine("=== TUPLAS COMO VALOR DE RETORNO ===\n");

            var resultado = CalcularTotales(120.50, 0.16);
            Console.WriteLine($"Subtotal: {resultado.subtotal}");
            Console.WriteLine($"IVA: {resultado.iva}");
            Console.WriteLine($"Total: {resultado.total}");

            Console.WriteLine("\nPresiona una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // ==========================================
            // SECCIÓN 4: TUPLAS EN PARÁMETROS DE MÉTODOS
            // ==========================================

            Console.WriteLine("=== PASAR TUPLAS COMO PARÁMETROS ===\n");

            var cliente = (nombre: "Luis", correo: "luis@gmail.com", pais: "México");
            MostrarCliente(cliente);

            Console.WriteLine("\nEjecución finalizada. Presione cualquier tecla para salir.");
            Console.ReadKey();
        }

        // Método que retorna una tupla
        static (double subtotal, double iva, double total) CalcularTotales(double precio, double tasaIVA)
        {
            double iva = precio * tasaIVA;
            double total = precio + iva;
            return (precio, iva, total);
        }

        // Método que recibe una tupla como parámetro
        static void MostrarCliente((string nombre, string correo, string pais) cliente)
        {
            Console.WriteLine($"Cliente: {cliente.nombre}");
            Console.WriteLine($"Correo: {cliente.correo}");
            Console.WriteLine($"País: {cliente.pais}");
        }
    }
}
