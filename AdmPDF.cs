using Datos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Controlador
{
    public class AdmPDF
    {
        DatosPDF datosPdf = new DatosPDF();
        public void CrearReporte(List<Empleado> lista)
        {
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir.");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "ReporteEmpleados.pdf";
            sfd.Filter = "PDF Files|*.pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    datosPdf.GenerarReporteEmpleados(lista, sfd.FileName);
                    MessageBox.Show("Reporte generado exitosamente.");

                    // Abrir el PDF automáticamente
                    System.Diagnostics.Process.Start(sfd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar PDF: " + ex.Message);
                }
            }
        }
    }
}