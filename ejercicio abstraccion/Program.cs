using System;

namespace Empresa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancias con datos precargados
            Gerente gerente = new Gerente()
            {
                ID = 1,
                Nombre = "María López",
                SalarioBase = 5000,
                BonoAnual = 12000
            };

            Desarrollador desarrollador = new Desarrollador()
            {
                ID = 2,
                Nombre = "Carlos García",
                SalarioBase = 4000,
                LenguajePrincipal = "C#"
            };

            Contador contador = new Contador()
            {
                ID = 3,
                Nombre = "Ana Torres",
                SalarioBase = 3500,
                HorasExtras = 50,
                PagoPorHoraExtra = 25
            };

            // Mostrar información
            gerente.MostrarInformacion();
            desarrollador.MostrarInformacion();
            contador.MostrarInformacion();

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}