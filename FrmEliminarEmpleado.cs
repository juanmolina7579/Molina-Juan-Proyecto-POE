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
    public partial class FrmEliminarEmpleado : Form
    {
        AdmEmpleado admEmp = new AdmEmpleado();
        public FrmEliminarEmpleado()
        {
            InitializeComponent();
            admEmp.LlenarTabla(dgvEmpleados);
        }

        public void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = 0;
            string cedulaB = "";
            if (dgvEmpleados.SelectedRows.Count == 1)
            {
                indice = dgvEmpleados.SelectedRows[0].Index;
                cedulaB = dgvEmpleados.SelectedRows[0].Cells["colCedula"].Value?.ToString();
                DialogResult result = MessageBox.Show("Desea eliminar al empleado " + cedulaB + "?", 
                    "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    admEmp.EliminarEmpleado(cedulaB);
                    dgvEmpleados.Rows.RemoveAt(indice);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }
    }
}
