using iTextSharp.text;
using iTextSharp.text.pdf;
using Modelo;
using System;
using System.Collections.Generic;
using System.IO;

namespace Datos
{
    public class DatosPDF
    {
        public void GenerarReporteEmpleados(List<Empleado> listaEmpleados, string rutaDestino)
        {
            Document doc = new Document(PageSize.A4);
            try
            {
                PdfWriter.GetInstance(doc, new FileStream(rutaDestino, FileMode.Create));
                doc.Open();
                Font fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);
                Paragraph titulo = new Paragraph("Reporte de Empleados", fuenteTitulo);
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);
                doc.Add(new Paragraph(" "));
                PdfPTable tabla = new PdfPTable(5);
                tabla.WidthPercentage = 100;
                tabla.AddCell(new PdfPCell(new Phrase("Cédula", FontFactory.GetFont(FontFactory.HELVETICA_BOLD))));
                tabla.AddCell(new PdfPCell(new Phrase("Nombres", FontFactory.GetFont(FontFactory.HELVETICA_BOLD))));
                tabla.AddCell(new PdfPCell(new Phrase("Cargo", FontFactory.GetFont(FontFactory.HELVETICA_BOLD))));
                tabla.AddCell(new PdfPCell(new Phrase("Sueldo", FontFactory.GetFont(FontFactory.HELVETICA_BOLD))));
                tabla.AddCell(new PdfPCell(new Phrase("Fecha Ingreso", FontFactory.GetFont(FontFactory.HELVETICA_BOLD))));
                foreach (Empleado emp in listaEmpleados)
                {
                    tabla.AddCell(emp.cedula);
                    tabla.AddCell(emp.nombres);
                    tabla.AddCell(emp.cargo);
                    tabla.AddCell(emp.sueldo.ToString("C"));
                    tabla.AddCell(emp.fecha_Ingreso.ToShortDateString());
                }

                doc.Add(tabla);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (doc.IsOpen())
                {
                    doc.Close();
                }
            }
        }
    }
}