using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelo;

namespace Datos
{
    public class DatosEmpleado
    {
        SqlCommand cmd = null;
        public List<Empleado> ConsultarEmpleados(SqlConnection cn)
        {
            List<Empleado> lista = new List<Empleado>();
            Empleado empleado = null;
            string comando = "SELECT * FROM empleado WHERE estado='A'";
            cmd = new SqlCommand();
            SqlDataReader tablaVirtual = null;
            try
            {
                cmd.Connection = cn;
                cmd.CommandText = comando;
                tablaVirtual = cmd.ExecuteReader();
                while (tablaVirtual.Read())
                {
                    empleado = new Empleado("", "", "", "", DateTime.Now, 0);
                    empleado.idEmp = Convert.ToInt64(tablaVirtual["idEmp"]);
                    empleado.cedula = tablaVirtual["cedula"].ToString();
                    empleado.nombres = tablaVirtual["nombres"].ToString();
                    empleado.correo = tablaVirtual["correo"].ToString();
                    empleado.cargo = tablaVirtual["cargo"].ToString();
                    empleado.fecha_Ingreso = DateTime.Parse(tablaVirtual["fecha_Ingreso"].ToString());
                    empleado.sueldo = Convert.ToDouble(tablaVirtual["sueldo"]);
                    lista.Add(empleado);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }
        public string EliminarEmpleado(int idEmp, SqlConnection cn)
        {
            string msj = "";
            string comando = "UPDATE Empleado SET estado=@Estado WHERE idEmp=@IdEmp";
            cmd = new SqlCommand(comando, cn);
            cmd.Parameters.AddWithValue("@IdEmp", idEmp);
            cmd.Parameters.AddWithValue("@Estado", 'I');
            try
            {
                cmd.ExecuteNonQuery();
                msj = "1";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                msj = "0" + ex.Message;
            }
            return msj;
        }

        public string RegistrarEmpleado(Empleado empleado, SqlConnection cn)
        {
            string msj = "";
            string comando = "INSERT INTO Empleado (cedula, nombres, correo, cargo, fecha_Ingreso, sueldo, estado) " +
                             "VALUES (@Cedula, @Nombres, @Correo, @Cargo, @Fecha_Ingreso, @Sueldo, @Estado)";

            cmd = new SqlCommand(comando, cn);
            cmd.Parameters.AddWithValue("@Cedula", empleado.cedula);
            cmd.Parameters.AddWithValue("@Nombres", empleado.nombres);
            cmd.Parameters.AddWithValue("@Correo", empleado.correo);
            cmd.Parameters.AddWithValue("@Cargo", empleado.cargo);
            cmd.Parameters.AddWithValue("@Fecha_Ingreso", empleado.fecha_Ingreso.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Sueldo", empleado.sueldo);
            cmd.Parameters.AddWithValue("@Estado", 'A');

            try
            {
                cmd.ExecuteNonQuery();
                msj = "1";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                msj = "0" + ex.Message;
            }
            return msj;
        }
    }
}
