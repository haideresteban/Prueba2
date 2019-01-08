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
using Prueba2.Reporte.FacturaTramite;
using Prueba2.Reporte.Factura;

namespace Prueba2.Vista
{

    public partial class frmFacturacion : Form
    {
        List<Tramite> listaTramites = new List<Tramite>();
       // listaTramites = controllerVehiculo.listaTipoServicios();
        ControllerAsociarPropietario objControllerAsociar = new ControllerAsociarPropietario();
        ControllerVehiculo objControllerVehiculo = new ControllerVehiculo();
        ControllerTramite objControllerTramite = new ControllerTramite();

        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            listaTramites = objControllerTramite.listaTramites();
            cbTramite.DataSource = listaTramites;


        }

        private void btnBuscarVehiculo_Click(object sender, EventArgs e)
        {
            Propietario propietario = objControllerAsociar.propietarioByVehiculoIdentificacion(txtPlaca.Text, txtIdentifiacion.Text);
            string numeroFactura = objControllerVehiculo.numeroFactura();
            if (propietario != null)
            {
                if (numeroFactura == "")
                {
                    txtNumeroFactura.Text = Convert.ToString(1001);
                }else
                {
                    int facturaNumero = Convert.ToInt32(numeroFactura);
                    txtNumeroFactura.Text = Convert.ToString(facturaNumero+1);
                }
               // gridTramites.DataSource = objControllerVehiculo.tramite();
                contaioner.Panel2.Enabled = true;


            }
            else
            {
                MessageBox.Show("Ingrese nuevamente los datos");
                contaioner.Panel2.Enabled = false;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            decimal idAuto = objControllerVehiculo.idVehiculoByPlaca(txtPlaca.Text);
            decimal idTramite= Convert.ToDecimal(gridTramites.Rows[gridTramites.CurrentRow.Index].Cells[0].Value.ToString());
            string descripcion= gridTramites.Rows[gridTramites.CurrentRow.Index].Cells[1].Value.ToString();
            decimal valor =Convert.ToDecimal( gridTramites.Rows[gridTramites.CurrentRow.Index].Cells[2].Value.ToString());


            Factura unaFactura = new Factura();
            Tramite tramite = new Tramite();

            unaFactura.numero = txtNumeroFactura.Text;
            unaFactura.fecha = Convert.ToDateTime(dtFecha.Value);
            unaFactura.idVehiculo = idAuto;
            tramite.id = idTramite;
            tramite.descripcion = descripcion;
            tramite.valor = valor;

            bool agregado = objControllerTramite.agregarFactura(tramite,unaFactura);
            if (agregado)
            {
               // MessageBox.Show("Se ha registrado la factura, desea imprimir su factura","Registro exitoso",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                contaioner.Panel2.Enabled = false;             
               var result= MessageBox.Show("Se ha registrado la factura, desea descargar su factura", "Registro exitoso",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                     {
                       
                        CgGenerarFacturaT a = new CgGenerarFacturaT();
                        a.generar(unaFactura,tramite,txtPlaca.Text,txtIdentifiacion.Text);
                        txtPlaca.Text = "";
                        txtIdentifiacion.Text = "";

                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }

            }
            else
            {
                MessageBox.Show("Error");

            }


        }

        private void cbTramite_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal id;
            List<Tramite> listaFactura = new List<Tramite>();
            Tramite tramite = new Tramite();
            if (cbTramite.SelectedValue != null)
            {
                id =Convert.ToDecimal( cbTramite.SelectedValue);
                tramite=objControllerTramite.buscarTramite(id);
                if (tramite != null)
                {
                    listaFactura.Add(tramite);
                }

            }
            //DISEÑO DE LA GRIDVIEW
            gridTramites.RowsDefaultCellStyle.BackColor = Color.LightGray;
            gridTramites.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            gridTramites.DataSource = listaFactura;
          lblTotal.Text=  gridTramites.Rows[gridTramites.CurrentRow.Index].Cells[2].Value.ToString();
        
       



        }

        private void gridTramites_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void contaioner_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
