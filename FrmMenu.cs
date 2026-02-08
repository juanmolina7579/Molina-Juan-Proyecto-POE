using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Visual
{
    public partial class FrmMenu : Form
    {
        AdmEmpleado admEmp = new AdmEmpleado();
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroEmpleado frmRegEmp = new FrmRegistroEmpleado();
            frmRegEmp.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcercaDe = new FrmAcercaDe();
            frmAcercaDe.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admEmp.CargarEmpleados();
            if (admEmp.GetCantidadLista() > 0)
            {
                FrmListarEmpleado frmLisEmp = new FrmListarEmpleado();
                frmLisEmp.ShowDialog();
            }
            else
            {
                MessageBox.Show("No existen empleados registrados");
            }
        }

        private void conexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admEmp.Conectar();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(admEmp.GetCantidadLista() > 0)
            {
                FrmEliminarEmpleado frmEliEmp = new FrmEliminarEmpleado();
                frmEliEmp.ShowDialog();
            }
            else
            {
                MessageBox.Show("No existen empleados registrados");
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admEmp.CargarEmpleados();
            if(admEmp.GetCantidadLista() > 0)
            {
                FrmEditarEmpleado frmEditEmp = new FrmEditarEmpleado();
                frmEditEmp.ShowDialog();
            }
            else
            {
                MessageBox.Show("No existen empleados registrados");
            }
        }
    }
}
