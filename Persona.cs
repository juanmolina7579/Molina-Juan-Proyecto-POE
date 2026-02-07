using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Persona
    {
        public string nombres { get; set; }
        public string cedula { get; set; }
        public string correo { get; set; }
        protected Persona(string nombres, string cedula, string correo)
        {
            this.nombres = nombres;
            this.cedula = cedula;
            this.correo = correo;
        }

        public virtual string ObtenerNombreCompleto()
        {
            return nombres?.Trim();
        }
        public override string ToString()
        {
            return Environment.NewLine + "Nombres: " + nombres + Environment.NewLine
                + "Cédula: " + cedula + Environment.NewLine
                + "Correo: " + correo;
        }
    }
}
