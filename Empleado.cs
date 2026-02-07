using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Empleado : Persona
    {
        public long idEmp { get; set; }
        public string cargo { get; set; }
        public DateTime fecha_Ingreso { get; set; }
        public double sueldo { get; set; } = 0;

        public Empleado(string cedula, string nombres, string correo,
            string cargo, DateTime fecha, double sueldo) : base(nombres, cedula, correo)
        {
            this.cargo = cargo;
            this.fecha_Ingreso = fecha;
            this.sueldo = sueldo;
        }
        public int CalcularAntiguedad()
        {
            return DateTime.Today.Year - fecha_Ingreso.Year;
        }
        public override string ToString()
        {
            return base.ToString()+ Environment.NewLine +
           "Cargo: " + cargo + Environment.NewLine +
           "Fecha Ingreso: " + fecha_Ingreso.ToShortDateString() + Environment.NewLine +
           "Sueldo: $" + sueldo.ToString("0.00") + Environment.NewLine +
           "Antigüedad (años): " + CalcularAntiguedad();
        }
    }
}
