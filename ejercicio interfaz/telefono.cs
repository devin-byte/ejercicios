using System;

namespace Dispositivos
{
    public class Telefono : IDispositivoElectronico
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool EstaEncendido { get; set; }

        public void Encender()
        {
            EstaEncendido = true;
            Console.WriteLine($"{Marca} {Modelo} está ahora encendido.");
        }

        public void Apagar()
        {
            EstaEncendido = false;
            Console.WriteLine($"{Marca} {Modelo} se ha apagado.");
        }

        public void MostrarEstado()
        {
            string estado = EstaEncendido ? "Encendido" : "Apagado";
            Console.WriteLine($"Teléfono: {Marca} {Modelo} - Estado: {estado}");
        }
    }
}
