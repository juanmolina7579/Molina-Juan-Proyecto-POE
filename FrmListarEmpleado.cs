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

namespace Visual
{
    public partial class FrmListarEmpleado : Form
    {
        AdmEmpleado admEmp = new AdmEmpleado();
        public FrmListarEmpleado()
        {
            InitializeComponent();
            admEmp.CargarEmpleados();
            admEmp.LlenarTabla(dgvEmpleados);
            admEmp.LlenarComboCargo(cmbCargo);
        }

        private void btnFiltrarAnt_Click(object sender, EventArgs e)
        {
            int antD = (int)nudAntDesde.Value;
            int antH = (int)nudAntHasta.Value;
            admEmp.FiltrarXAntiguedad(antD, antH, dgvEmpleados);
        }

        private void btnFiltrarCargo_Click(object sender, EventArgs e)
        {
            string cargo = (string)cmbCargo.SelectedItem;
            admEmp.FiltrarXCargo(cargo, dgvEmpleados);
        }
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            admEmp.LlenarTabla(dgvEmpleados);
            cmbCargo.SelectedIndex = -1;
            nudAntDesde.Value = 0;
            nudAntHasta.Value = 0;
        }
    }
}
