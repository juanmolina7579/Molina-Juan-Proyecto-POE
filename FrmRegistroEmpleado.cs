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
using Modelo;

namespace Visual
{
    public partial class FrmRegistroEmpleado : Form
    {
        AdmEmpleado admEmp = new AdmEmpleado();
        public FrmRegistroEmpleado()
        {
            InitializeComponent();
            admEmp.LlenarComboCargo(cmbCargo);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim(), nombres = txtNombres.Text.Trim(),
                correo = txtCorreo.Text.Trim(), cargo =(string)cmbCargo.SelectedItem,
            sueldoText = txtSueldo.Text.Trim();
            DateTime fecha = dtpFechaIngreso.Value;
            string contenido = "";
            if (!admEmp.EsVacio(cedula, nombres, correo, cargo, txtSueldo.Text))
            {
                if(!admEmp.EsCorreoValido(correo))
                {
                    return;
                }
                double sueldo = double.Parse(sueldoText);
                contenido = admEmp.Registrar(cedula, nombres, correo, cargo, fecha, sueldo);
                txtContenido.Text = contenido;
                MessageBox.Show("Datos registrados correctamente");
                LimpiarCampos();
            }
        }
        private void LimpiarCampos()
        {
            txtCedula.Clear();
            txtNombres.Clear();
            txtCorreo.Clear();
            cmbCargo.SelectedIndex = -1;
            dtpFechaIngreso.Value = DateTime.Now;
            txtSueldo.Clear();
        }
        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
