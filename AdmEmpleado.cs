using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Modelo;

namespace Controlador
{
    public class AdmEmpleado
    {
        static List<Empleado> lista = new List<Empleado>();
        Empleado empleado = null;
        DatosEmpleado datosEmp = null;
        Conexion Cn = null;
        string[] cargos = { "Gerente", "Recepcionista", "Limpieza", "Seguridad", "Chef", "Mesero", "Mantenimiento" };
        public void CargarEmpleados()
        {
            ConsultarEmpleadosBDD();
        }
        private void ConsultarEmpleadosBDD()
        {
            Cn = new Conexion();
            datosEmp = new DatosEmpleado();
            List<Empleado> tmp = null;
            string msj = Cn.Conectar();
            if (msj[0] == '1')
            {
                tmp = datosEmp.ConsultarEmpleados(Cn.Cn);
                lista.Clear();
                if (tmp != null && tmp.Count > 0)
                {
                    lista.AddRange(tmp);
                }
                else
                {
                    MessageBox.Show("No se encontraron empleados en la base de datos.");
                }
                Cn.Cerrar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj);
            }
        }

        public int GetCantidadLista()
        {
            return lista.Count;
        }
        public void LlenarComboCargo(ComboBox cmbCargo)
        {
            foreach (string cargo in cargos)
            {
                cmbCargo.Items.Add(cargo);
            }
        }
        public void LlenarTabla(DataGridView dgvEmpleados)
        {
            int indice = 0;
            dgvEmpleados.Rows.Clear();
            if (lista.Count > 0)
            {
                foreach (Empleado e in lista)
                {
                    indice = dgvEmpleados.Rows.Add();
                    dgvEmpleados.Rows[indice].Cells["colNro"].Value = indice + 1;
                    dgvEmpleados.Rows[indice].Cells["colCedula"].Value = e.cedula;
                    dgvEmpleados.Rows[indice].Cells["colNombres"].Value = e.nombres;
                    dgvEmpleados.Rows[indice].Cells["colCorreo"].Value = e.correo;
                    dgvEmpleados.Rows[indice].Cells["colCargo"].Value = e.cargo;
                    dgvEmpleados.Rows[indice].Cells["colFecha"].Value = e.fecha_Ingreso.ToShortDateString();
                    dgvEmpleados.Rows[indice].Cells["colSueldo"].Value = e.sueldo.ToString("F2");
                    dgvEmpleados.Rows[indice].Cells["colAntiguedad"].Value = e.CalcularAntiguedad() + " años";
                }
            }
        }
        public bool EsVacio(string cedula, string nombres,
            string correo, string cargo, string sueldoText)
        {
            if (string.IsNullOrEmpty(cedula) ||
                string.IsNullOrEmpty(nombres) || string.IsNullOrEmpty(correo) ||
                string.IsNullOrEmpty(cargo) || string.IsNullOrEmpty(sueldoText))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return true;
            }
            return false;
        }

        public bool EsCorreoValido(string correo)
        {
            if (!correo.Contains("@") || !correo.Contains("."))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
                return false;
            }
            return true;
        }

        public string Registrar(string cedula, string nombres,
            string correo, string cargo, DateTime fecha, double sueldo)
        {
            empleado = new Empleado(cedula, nombres, correo, cargo, fecha, sueldo);
            lista.Add(empleado);
            RegistrarEmpleadoBDD(empleado);
            return empleado.ToString();
        }

        public void RegistrarEmpleadoBDD(Empleado empleado)
        {
            Cn = new Conexion();
            datosEmp = new DatosEmpleado();
            string msj = Cn.Conectar();
            string resp = "";
            if (msj[0] == '1')
            {
                resp = datosEmp.RegistrarEmpleado(empleado, Cn.Cn);
                if(resp[0] == '1')
                {
                    MessageBox.Show("Empleado registrado en la base de datos.");
                }
                else if(resp[0] == '0')
                {
                    MessageBox.Show(resp);
                }
                Cn.Cerrar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj);
            }
        }
        public void EliminarEmpleado(string cedulaB)
        {
            int posicionEmp = lista.FindIndex(x => x.cedula == cedulaB);
            long idEmp = lista[posicionEmp].idEmp;
            lista.RemoveAll(e => e.cedula == cedulaB);
            EliminarEmpleadoBDD(idEmp, cedulaB);
        }
        private void EliminarEmpleadoBDD(long idEmp, string cedulaB)
        {
            Cn = new Conexion();
            datosEmp = new DatosEmpleado();
            string msj = Cn.Conectar();
            string resp = "";
            if (msj[0] == '1')
            {
                resp = datosEmp.EliminarEmpleado((int)idEmp, Cn.Cn);
                if(resp[0] == '1')
                {
                    MessageBox.Show("Empleado con cedula " + cedulaB+ "eliminado de la base de datos.");
                }
                else if(resp[0] == '0')
                {
                    MessageBox.Show(resp);
                }
                Cn.Cerrar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj);
            }
        
        }

        public void FiltrarXCargo(string cargoF, DataGridView dgvEmpleados)
        {
            int indice = 0;
            dgvEmpleados.Rows.Clear();
            if (lista.Count > 0)
            {
                foreach (Empleado e in lista)
                {
                    if(e.cargo == cargoF)
                    {
                        indice = dgvEmpleados.Rows.Add();
                        dgvEmpleados.Rows[indice].Cells["colNro"].Value = indice + 1;
                        dgvEmpleados.Rows[indice].Cells["colCedula"].Value = e.cedula;
                        dgvEmpleados.Rows[indice].Cells["colNombres"].Value = e.nombres;
                        dgvEmpleados.Rows[indice].Cells["colCorreo"].Value = e.correo;
                        dgvEmpleados.Rows[indice].Cells["colCargo"].Value = e.cargo;
                        dgvEmpleados.Rows[indice].Cells["colFecha"].Value = e.fecha_Ingreso.ToShortDateString();
                        dgvEmpleados.Rows[indice].Cells["colSueldo"].Value = e.sueldo.ToString("F2");
                        dgvEmpleados.Rows[indice].Cells["colAntiguedad"].Value = e.CalcularAntiguedad() + " años";
                    }
                }
            }
        }

        public void FiltrarXAntiguedad(int antD, int antH, DataGridView dgvEmpleados)
        {
            int indice = 0;
            dgvEmpleados.Rows.Clear();
            if (lista.Count > 0)
            {
                foreach (Empleado e in lista)
                {
                    if(e.CalcularAntiguedad() >= antD && e.CalcularAntiguedad() <= antH)
                    {
                        indice = dgvEmpleados.Rows.Add();
                        dgvEmpleados.Rows[indice].Cells["colNro"].Value = indice + 1;
                        dgvEmpleados.Rows[indice].Cells["colCedula"].Value = e.cedula;
                        dgvEmpleados.Rows[indice].Cells["colNombres"].Value = e.nombres;
                        dgvEmpleados.Rows[indice].Cells["colCorreo"].Value = e.correo;
                        dgvEmpleados.Rows[indice].Cells["colCargo"].Value = e.cargo;
                        dgvEmpleados.Rows[indice].Cells["colFecha"].Value = e.fecha_Ingreso.ToShortDateString();
                        dgvEmpleados.Rows[indice].Cells["colSueldo"].Value = e.sueldo.ToString("F2");
                        dgvEmpleados.Rows[indice].Cells["colAntiguedad"].Value = e.CalcularAntiguedad() + " años";
                    }
                }
            }
        }
        public void BuscarEmpleadoXCedula(string cedula, DataGridView dgvEmpleados)
        {
            Empleado e = lista.Find(x => x.cedula == cedula);
            int i = 0;
            if(e != null)
            {
                i = lista.IndexOf(e);
                dgvEmpleados.Rows.Clear();
                int indice = dgvEmpleados.Rows.Add();
                dgvEmpleados.Rows[indice].Cells["colNro"].Value = indice+1;
                dgvEmpleados.Rows[indice].Cells["colCedula"].Value = e.cedula;
                dgvEmpleados.Rows[indice].Cells["colNombres"].Value = e.nombres;
                dgvEmpleados.Rows[indice].Cells["colCorreo"].Value = e.correo;
                dgvEmpleados.Rows[indice].Cells["colCargo"].Value = e.cargo;
                dgvEmpleados.Rows[indice].Cells["colFecha"].Value = e.fecha_Ingreso.ToShortDateString();
                dgvEmpleados.Rows[indice].Cells["colSueldo"].Value = e.sueldo.ToString("F2");
                dgvEmpleados.Rows[indice].Cells["colAntiguedad"].Value = e.CalcularAntiguedad() + " años";
            }
            else
            {
                MessageBox.Show("Empleado con cédula " + cedula + " no encontrado.");
            }
        }


        public void Conectar()
        {
            Cn = new Conexion();
            string res = Cn.Conectar();
            if (res[0] == '1')
            {
                MessageBox.Show("Conexión exitosa a la base de datos.");
                Cn.Cerrar();
            }
            else if(res[0] == '0')
            {
                MessageBox.Show(res);
            }
        }
    }
}
