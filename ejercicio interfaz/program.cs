using System;
using Dispositivos;

namespace ProyectoDispositivos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear y precargar datos
            Telefono telefono = new Telefono()
            {
                Marca = "Samsung",
                Modelo = "Galaxy S23",
                EstaEncendido = false
            };

            Laptop laptop = new Laptop()
            {
                Marca = "Dell",
                Modelo = "XPS 15",
                EstaEncendido = false,
                NivelBateria = 85
            };

            // Estado inicial
            Console.WriteLine("=== ESTADO INICIAL ===");
            telefono.MostrarEstado();
            laptop.MostrarEstado();

            // Encender dispositivos
            Console.WriteLine("\n=== ENCENDIENDO DISPOSITIVOS ===");
            telefono.Encender();
            laptop.Encender();

            // Mostrar nuevo estado
            Console.WriteLine("\n=== ESTADO DESPUÉS DE ENCENDER ===");
            telefono.MostrarEstado();
            laptop.MostrarEstado();

            // Apagar dispositivos
            Console.WriteLine("\n=== APAGANDO DISPOSITIVOS ===");
            telefono.Apagar();
            laptop.Apagar();

            // Estado final
            Console.WriteLine("\n=== ESTADO FINAL ===");
            telefono.MostrarEstado();
            laptop.MostrarEstado();

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
