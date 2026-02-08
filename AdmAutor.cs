using Datos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class AdmAutor
    {
        Conexion conexion = new Conexion();
        DatosAutor datosAutor = new DatosAutor();
        public List<Autor> ObtenerDatosAutor()
        {
            List<Autor> lista = new List<Autor>();
            string msj = conexion.Conectar();

            if (msj[0] == '1')
            {
                lista = datosAutor.ConsultarAutor(conexion.Cn);
                conexion.Cerrar();
            }
            return lista;
        }
    }
}
