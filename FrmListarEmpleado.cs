using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Modelo;

namespace Visual
{
    public partial class FrmListarEmpleado : Form
    {
        AdmEmpleado admEmp = new AdmEmpleado();
        public FrmListarEmpleado()
        {
            InitializeComponent();
            admEmp.LlenarTabla(dgvEmpleados);
            admEmp.LlenarComboCargo(cmbCargo);
        }
        private void btnFiltrarClick(object sender, EventArgs e)
        {
            if (rbCargo.Checked)
            {
                string cargo= (string)cmbCargo.SelectedItem;
                admEmp.FiltrarXCargo(cargo, dgvEmpleados);
            }
            else if (rbAntiguedad.Checked)
            {
                int antD = (int)nudAntDesde.Value;
                int antH = (int)nudAntHasta.Value;
                admEmp.FiltrarXAntiguedad(antD, antH, dgvEmpleados);
            }
            else
            {
                MessageBox.Show("Seleccione un criterio de filtrado");
            }
        }
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            admEmp.LlenarTabla(dgvEmpleados);
            cmbCargo.SelectedIndex = -1;
            nudAntDesde.Value = 0;
            nudAntHasta.Value = 0;
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {

        List<Empleado> listaParaImprimir = admEmp.ObtenerListaEmpleados();

        AdmPDF admPdf = new AdmPDF();
        admPdf.CrearReporte(listaParaImprimir);
        }

        private void rbCargo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCargo.Checked)
            {
                cmbCargo.Visible = true;
                nudAntDesde.Visible = false;
                nudAntHasta.Visible = false;
                lblDesde.Visible = false;
                lblHasta.Visible = false;
            }
        }
        private void rbAntiguedad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAntiguedad.Checked)
            {
                cmbCargo.Visible = false;
                nudAntDesde.Visible = true;
                nudAntHasta.Visible = true;
                lblDesde.Visible = true;
                lblHasta.Visible = true;
            }
        }

    }
}
