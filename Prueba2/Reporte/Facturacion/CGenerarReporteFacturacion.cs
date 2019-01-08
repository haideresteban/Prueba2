using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2.Reporte.Facturacion
{
    public class CGenerarReporteFacturacion
    {
        public void generar(bool generarEnPDF)
        {
            try
            {
                //1. instanciar ds

                DsFcaturacionxsd ds = new DsFcaturacionxsd();

                //DataRow fila1 = ds.DATOS.NewRow();
                //fila1["D_NOMBRES"] = "Pepito";
                //fila1["D_APELLIDOS"] = "Perez";
                //fila1["D_DIRECCION"] = "Calle falsa 123";
                //fila1["D_IDENTIFICACION"] = "123112313";
                //fila1["D_EDAD"] = 22;
                //ds.DATOS.Rows.Add(fila1);


                for (int i = 0; i < 10; i++)
                {
                    DataRow fila1 = ds.DATOS.NewRow();
                    fila1["D_NOMBRES"] = "Pepito_"+i+1;
                    fila1["D_APELLIDOS"] = "Perez";
                    fila1["D_DIRECCION"] = "Calle falsa 123";
                    fila1["D_IDENTIFICACION"] = (123+i);
                    fila1["D_EDAD"] = 22+i;
                    ds.DATOS.Rows.Add(fila1);
                }

                if (generarEnPDF)
                {
                    string adicion = DateTime.Now.ToShortDateString().Replace("/", "-") + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute;               
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string rutaArchivo = path+"\\" + adicion + "_"+"factura.pdf";
                    CrFcaturacion cr = new CrFcaturacion();
                    cr.SetDataSource(ds);
                    cr.ExportToDisk(ExportFormatType.PortableDocFormat, rutaArchivo);
                    Process.Start(rutaArchivo);
                }
                else
                {

                    fVerReporte frm = new fVerReporte(ds);
                    frm.ShowDialog();
                    ds.DATOS.Dispose();
                    ds = null;
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
