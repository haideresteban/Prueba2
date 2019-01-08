using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba2.Vista;
using Prueba2.Reporte.Facturacion;
using Prueba2.Reporte.FacturaTramite;

namespace Prueba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gestiónDePropietariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarPropietarios frmLista = new frmListarPropietarios();
            frmLista.Show();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregar frmAgregar = new frmAgregar();
            //frmAgregar.MdiParent = this;
            frmAgregar.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            eliminarPropetario frmEliminarPro = new eliminarPropetario();
            frmEliminarPro.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarPropietario frmEditar = new frmEditarPropietario(null);
                        frmEditar.ShowDialog();

        }

        private void gestionDeVhiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarVehiculos frm =new frmListarVehiculos();
            frm.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarVehiculo frmAgregar = new frmAgregarVehiculo(null);
            frmAgregar.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarPropietarios frm = new frmListarPropietarios();
            frm.Show();
        }

        private void asociarVehiculosYPropietariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsociarVehiculoxPropie frm = new frmAsociarVehiculoxPropie();
            frm.ShowDialog();
        }

        private void fcaturacionDeTramitesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmFacturacion frm = new frmFacturacion();
            //frmAgregar.MdiParent = this;
            frm.ShowDialog();
        }

        private void pruebaReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CGenerarReporteFacturacion a = new CGenerarReporteFacturacion();
                a.generar(false);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CGgenerarFacturaTramite a = new CGgenerarFacturaTramite();
                a.generar(false);
            }
            catch (Exception)
            {
                 throw;
            }

        }

        private void buscarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buscarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmBuscarFactura frm = new frmBuscarFactura();
            frm.ShowDialog();
        }
    }
}
