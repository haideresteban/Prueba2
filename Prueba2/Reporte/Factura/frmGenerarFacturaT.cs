using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba2.Reporte.Factura
{
    public partial class frmGenerarFacturaT : Form
    {
        public frmGenerarFacturaT(DataSet ds)
        {
            InitializeComponent();
            CrFactura cr = new CrFactura();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource=cr;
        }

    }
}
