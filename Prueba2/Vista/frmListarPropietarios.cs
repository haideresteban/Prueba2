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
    public partial class frmListarPropietarios : Form
    {
        ControllerPropietario controlllerPropietario = new ControllerPropietario();

        public frmListarPropietarios()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmListarPropietarios_Load(object sender, EventArgs e)
        {
            dgvListaPropietarios.DataSource = controlllerPropietario.listaPropietarios().ToList();
            dgvListaPropietarios.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvListaPropietarios.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = getId();
            if (id != null)
            {
                frmEditarPropietario frmEditar = new frmEditarPropietario(id);
                this.Close();
                frmEditar.ShowDialog();

            }
            else
            {
                lblSeleccione.Text= "SELECIONE UN PROPIETARIO";
            }


        }

        private  int? getId()
        {
            try
            {
                return int.Parse(dgvListaPropietarios.Rows[dgvListaPropietarios.CurrentRow.Index].Cells[1].Value.ToString());
                //return int.Parse(dgvListaPropietarios.Rows[dgvListaPropietarios.ColumnCount].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                return null;

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            frmAgregar frm = new frmAgregar();
            this.Close();
            frm.Show();
        }

        private void dgvListaPropietarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
