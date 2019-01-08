using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba2.Reporte.FacturaTramite
{
    public partial class frmFacturaTramite : Form
    {
        public frmFacturaTramite(DataSet ds)
        {
            InitializeComponent();
            CrFacturaTramite cr = new CrFacturaTramite();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }


         }
}
