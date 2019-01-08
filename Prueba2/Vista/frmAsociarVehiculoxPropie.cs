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
    public partial class frmAsociarVehiculoxPropie : Form
    {
        ControllerAsociarPropietario controllerVehiculo = new ControllerAsociarPropietario();
        ControllerVehiculo controllerv = new ControllerVehiculo();
        public frmAsociarVehiculoxPropie()
        {
            InitializeComponent();
        }

        private void btnBUscarVehiculo_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            if (txtPlaca.Text != "")
            {
                gridPropietarioPorPlaca.DataSource = controllerVehiculo.propietarioByPLaca(placa);
                gridPropietarioPorPlaca.RowsDefaultCellStyle.BackColor = Color.LightGray;
                gridPropietarioPorPlaca.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

                gridVehiculo.DataSource = controllerv.buscarVehiculobyPlaca(placa);
                gridVehiculo.RowsDefaultCellStyle.BackColor = Color.LightGray;
                gridVehiculo.AlternatingRowsDefaultCellStyle.BackColor = Color.White;



                if  (gridVehiculo.RowCount == 2 && gridPropietarioPorPlaca.RowCount==1)
                {
                    MessageBox.Show("No hay ningun propietario de este vehiculo en el sistema", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnAgregar.Enabled = true;
                }else if (gridVehiculo.RowCount == 1 && gridPropietarioPorPlaca.RowCount == 1)
                {
                    MessageBox.Show("No se ha encontrado un vehiculo con esta placa, ingrese la placa nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }else if (gridPropietarioPorPlaca.RowCount >= 2)
                {
                    btnAgregar.Enabled = true;
                }

                else { 
               
                    if (gridVehiculo.CurrentRow == null)
                    {
                        //lblprueba.Text = gridPropietarioPorPlaca.Rows[gridPropietarioPorPlaca.CurrentRow.Index].Cells[1].Value.ToString();

                        MessageBox.Show("Seleccione el registro a editar");
                        btnAgregar.Enabled = false;
                    }
                    
                }
            }
            else
            {
                gridPropietarioPorPlaca.DataSource = "";
                gridVehiculo.DataSource = "";
                MessageBox.Show("Ingrese un valor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int? id = getId();

            if (id != null)
            {
                frmAsociar frm = new frmAsociar(id);
                this.Close();
                frm.ShowDialog();
    
            }
            else
            {
                MessageBox.Show("debe seleccionar un valor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private int? getId()
        {
            try
            {
                return int.Parse(gridVehiculo.Rows[gridVehiculo.CurrentRow.Index].Cells[0].Value.ToString());
                //return int.Parse(dgvListaPropietarios.Rows[dgvListaPropietarios.ColumnCount].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                return null;

            }
        }

        private void frmAsociarVehiculoxPropie_Load(object sender, EventArgs e)
        {

        }

        private void gridVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridPropietarioPorPlaca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
