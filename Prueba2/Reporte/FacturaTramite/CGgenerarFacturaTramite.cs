using Prueba2.Reporte.Facturacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba2.Modelo;
using CrystalDecisions.Shared;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Prueba2.Reporte.FacturaTramite
{
    public class CGgenerarFacturaTramite
    {
        public SqlConnection conexion;
        public SqlTransaction transaccion;
        public void generar(bool generarEnPDF)
        {
            this.conexion = Conexion.getConexion();
            DsFacturaTramite ds = new DsFacturaTramite();
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            comando.CommandText = "SELECT * FROM PROPIETARIO";
            try
            {
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    DataRow fila1 = ds.PROPIETARIO.NewRow();
                    fila1["P_NUMEROIDENTIFICACION"] =  Convert.ToInt32(registro.GetString(1));
                    fila1["P_NOMBRES"] = registro.GetString(2);
                    fila1["P_APELLIDOS"] = registro.GetString(3);
                    fila1["P_DIRECCION"] = registro.GetString(4);
                    fila1["P_TELEFONO"] = registro.GetString(5);
                    fila1["P_CORREOELECTRONICO"] = registro.GetString(6);
                    ds.PROPIETARIO.Rows.Add(fila1);
                }
                registro.Close();
                if (generarEnPDF)
                {
                    string adicion = DateTime.Now.ToShortDateString().Replace("/", "-") + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute;

                    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string rutaArchivo = path + "\\" + adicion + "_" + "factura.pdf";
                    CrFacturaTramite cr = new CrFacturaTramite();
                    cr.SetDataSource(ds);
                    cr.ExportToDisk(ExportFormatType.PortableDocFormat, rutaArchivo);
                    Process.Start(rutaArchivo);
                }
                else
                {
                    frmFacturaTramite frm = new frmFacturaTramite(ds);
                    frm.ShowDialog();
                    ds.PROPIETARIO.Dispose();
                    ds = null;
                }




            }
            catch (Exception ex)
            {

            }
        }
    }
}
