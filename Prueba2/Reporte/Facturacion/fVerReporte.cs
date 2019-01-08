using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba2.Reporte.Facturacion
{
    public partial class fVerReporte : Form
    {
        public fVerReporte(DataSet ds)
        {
            InitializeComponent();
            CrFcaturacion cr = new CrFcaturacion();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void fVerReporte_Load(object sender, EventArgs e)
        {

        }
    }
}
