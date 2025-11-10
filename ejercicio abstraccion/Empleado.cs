using System;

namespace Empresa
{
    public abstract class Empleado
    {
        // Propiedades comunes
        public string Nombre { get; set; }
        public int ID { get; set; }
        public double SalarioBase { get; set; }

        // Métodos abstractos: cada clase hija los debe implementar
        public abstract double CalcularSalarioAnual();
        public abstract void MostrarInformacion();
    }
}