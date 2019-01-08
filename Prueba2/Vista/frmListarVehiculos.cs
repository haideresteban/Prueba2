using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba2.Vista
{
    public partial class frmListarVehiculos : Form
    {
        ControllerVehiculo controllerVehiculo = new ControllerVehiculo();

        public frmListarVehiculos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarVehiculo frm = new frmAgregarVehiculo(null);
            this.Close();
            frm.ShowDialog();
        }

        private void frmListarVehiculos_Load(object sender, EventArgs e)
        {
            dgvListaVehiculos.DataSource = controllerVehiculo.listaVehiculos();
            dgvListaVehiculos.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvListaVehiculos.AlternatingRowsDefaultCellStyle.BackColor = Color.White;



        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (dgvListaVehiculos.CurrentRow != null && dgvListaVehiculos.CurrentRow.Selected == true)
            //    {
         

            //        DataGridViewSelectedRowCollection filasselec = dgvListaVehiculos.SelectedRows;
            //        int id = int.Parse(filasselec[0].Cells["ID"].Value.ToString());

            //        frmAgregarVehiculo frm = new frmAgregarVehiculo(id);
            //        frm.ShowDialog();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Seleccione el registro a editar");
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            int? id = getId();
            if (id != null)
            {
                frmAgregarVehiculo frmEditar = new frmAgregarVehiculo(id);
                this.Close();
                frmEditar.ShowDialog();

            }
            else
            {
                       MessageBox.Show("Seleccione el registro a editar");

            }
        }

        private int? getId()
        {
            try
            {
                return int.Parse(dgvListaVehiculos.Rows[dgvListaVehiculos.CurrentRow.Index].Cells[0].Value.ToString());
                //return int.Parse(dgvListaPropietarios.Rows[dgvListaPropietarios.ColumnCount].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                return null;

            }
        }

        private void dgvListaVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
