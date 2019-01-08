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
using Prueba2.Vista;

namespace Prueba2.Vista
{
    public partial class frmBuscarFactura : Form
    {
        ControllerTramite objController = new ControllerTramite();
        public frmBuscarFactura()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboParametro.Text == "Identificacion propietario")
            {
                txtIdentificacion.Text = "";
                dateInicio.Visible = false;
                dateFin.Visible = false;
                lblParametro.Visible=true;
                txtIdentificacion.Visible = true;
                btnBuscar.Visible = true;
                lblParametro.Text = "Ingrese una identificacion:";

            } else if (comboParametro.Text == "Placa vehiculo")
            {
                txtIdentificacion.Text = "";
                dateInicio.Visible = false;
                dateFin.Visible = false;
                lblParametro.Visible = true;
                txtIdentificacion.Visible = true;
                btnBuscar.Visible = true;
                lblParametro.Text = "Ingrese la placa del vehiculo:";
            }else if (comboParametro.Text == "Intervalo de fechas")
            {
                lblParametro.Visible = true;
                dateInicio.Visible = true;
                dateFin.Visible = true;
                btnBuscar.Visible = true;
                txtIdentificacion.Visible = false;
                lblParametro.Text = "Seleccione las fechas a buscar Inicial/Final:";

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if (comboParametro.Text == "Placa vehiculo" && txtIdentificacion.Text != "")
            {
               
                gridFacturas.DataSource = "";
                gridFacturas.DataSource = objController.FacturaByPlaca(txtIdentificacion.Text);
                btnDetalle.Visible = true;
                if (gridFacturas.RowCount == 1)
                {
                    dateInicio.Visible = false;
                    dateFin.Visible = false;
                    gridFacturas.DataSource = "";
                    txtIdentificacion.Text = "";
                    MessageBox.Show("El sistema no encuentra facturas que se ajusten a los criterios debúsqueda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                  
                  
                    
                }
            }else if(comboParametro.Text == "Identificacion propietario" && txtIdentificacion.Text != "")
            {
               
                gridFacturas.DataSource = "";
                gridFacturas.DataSource = objController.FacturaByIdentificacion(txtIdentificacion.Text);
                if (gridFacturas.RowCount == 1)
                {
                    dateInicio.Visible = false;
                    dateFin.Visible = false;
                    gridFacturas.DataSource = "";
                    txtIdentificacion.Text = "";
                    MessageBox.Show("El sistema no encuentra facturas que se ajusten a los criterios debúsqueda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               

                }

            }else if (comboParametro.Text == "Intervalo de fechas" && dateInicio.Value != null && dateFin.Value!=null)
            {
             
                gridFacturas.DataSource = "";
                DateTime fechaInicio = dateInicio.Value;
                DateTime fechaFin = dateFin.Value;
                gridFacturas.DataSource = objController.FacturaByRangoFechas(fechaInicio.ToString("MM/dd/yyyy"), fechaFin.ToString("MM/dd/yyyy"));
                if (gridFacturas.RowCount == 1)
                {
                    txtIdentificacion.Visible = false;
                    dateInicio.Visible = true;
                    dateFin.Visible = true;
                    gridFacturas.DataSource = "";
                  
                    MessageBox.Show("El sistema no encuentra facturas que se ajusten a los criterios debúsqueda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               

                }

            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
           int numeroFactura=Convert.ToInt32( gridFacturas.Rows[gridFacturas.CurrentRow.Index].Cells[0].Value.ToString());
            string placa =gridFacturas.Rows[gridFacturas.CurrentRow.Index].Cells[2].Value.ToString();

            detalleFactura frm = new detalleFactura(numeroFactura,placa);
            frm.ShowDialog();
        }
    }
}
