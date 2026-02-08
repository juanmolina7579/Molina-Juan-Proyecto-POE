using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual
{
    public partial class FrmEditarEmpleado : Form
    {
        AdmEmpleado admEmp = new AdmEmpleado();
        public FrmEditarEmpleado()
        {
            InitializeComponent();
            admEmp.LlenarComboCargo(cmbCargo);
        }
        public void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim();
            admEmp.BuscarEmpleadoXCedula(cedula, dgvEmpleados);
            if (dgvEmpleados.Rows.Count > 0)
            {
                txtCedula.Enabled = false;
            }
        }


        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCedula.Text = dgvEmpleados.Rows[e.RowIndex].Cells["colCedula"].Value.ToString();
                txtNombre.Text = dgvEmpleados.Rows[e.RowIndex].Cells["colNombres"].Value.ToString();
                txtCorreo.Text = dgvEmpleados.Rows[e.RowIndex].Cells["colCorreo"].Value.ToString();
                cmbCargo.Text = dgvEmpleados.Rows[e.RowIndex].Cells["colCargo"].Value.ToString();
                txtSueldo.Text = dgvEmpleados.Rows[e.RowIndex].Cells["colSueldo"].Value.ToString();
                dtpFechaIngreso.Value = Convert.ToDateTime(dgvEmpleados.Rows[e.RowIndex].Cells["colFecha"].Value);
                txtCedula.Enabled = false;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim(), nombres = txtNombre.Text.Trim(),
                correo = txtCorreo.Text.Trim(), cargo = cmbCargo.Text,
            sueldoText = txtSueldo.Text.Trim();
            DateTime fecha = dtpFechaIngreso.Value;
            if (!admEmp.EsVacio(cedula, nombres, correo, cargo, txtSueldo.Text))
            {
                if (!admEmp.EsCorreoValido(correo))
                {
                    return;
                }
                double sueldo = double.Parse(sueldoText);
                admEmp.EditarEmpleado(cedula, nombres, correo, cargo, fecha, sueldo);
                MessageBox.Show("Datos actualizados correctamente");
                Limpiar();
            }
        }   

        private void Limpiar()
        {
            txtCedula.Text = "";
            txtCedula.ReadOnly=false;
            txtCedula.Enabled = true;
            txtNombre.Clear();
            txtCorreo.Clear();
            cmbCargo.SelectedIndex = -1;
            txtSueldo.Clear();
            dgvEmpleados.Rows.Clear();
            dtpFechaIngreso.Value = DateTime.Now;
        }
    
    }
}