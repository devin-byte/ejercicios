using System;

namespace Dispositivos
{
    public class Laptop : IDispositivoElectronico
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool EstaEncendido { get; set; }
        public int NivelBateria { get; set; }

        public void Encender()
        {
            EstaEncendido = true;
            Console.WriteLine($"{Marca} {Modelo} está ahora encendida.");
        }

        public void Apagar()
        {
            EstaEncendido = false;
            Console.WriteLine($"{Marca} {Modelo} se ha apagado.");
        }

        public void MostrarEstado()
        {
            string estado = EstaEncendido ? "Encendida" : "Apagada";
            Console.WriteLine($"Laptop: {Marca} {Modelo} - Estado: {estado} - Batería: {NivelBateria}%");
        }
    }
}
