using System;

namespace Empresa
{
    public class Contador : Empleado
    {
        // Propiedades adicionales
        public int HorasExtras { get; set; }
        public double PagoPorHoraExtra { get; set; }

        // Implementación del método abstracto
        public override double CalcularSalarioAnual()
        {
            double pagoHorasExtras = HorasExtras * PagoPorHoraExtra;
            return (SalarioBase * 12) + pagoHorasExtras;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("=== Contador ===");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Salario Base: {SalarioBase:C}");
            Console.WriteLine($"Horas Extras: {HorasExtras}");
            Console.WriteLine($"Pago por Hora Extra: {PagoPorHoraExtra:C}");
            Console.WriteLine($"Salario Anual: {CalcularSalarioAnual():C}");
            Console.WriteLine();
        }
    }
}
