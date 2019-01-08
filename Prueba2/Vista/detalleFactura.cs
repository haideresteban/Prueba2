using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba2.Modelo;

namespace Prueba2.Vista
{
    public partial class detalleFactura : Form
    {
        ControllerTramite objController = new ControllerTramite();
        public int? id;
        public detalleFactura(int? id,string placa)
        {
            this.id = id;
            InitializeComponent();
            if (id != null)
            {
                Factura unaFactura = new Factura();
                unaFactura = objController.FacturaByNumeroF(Convert.ToString( id));
                txtTramite.Text= unaFactura.observaciones;
                txtFecha.Text = unaFactura.fecha.ToShortDateString();
                lblnumeroFactura.Text = Convert.ToString(id);
                txtPlaca.Text = placa;

            }

        }

        private void detalleFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
