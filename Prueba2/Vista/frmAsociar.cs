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
    public partial class frmAsociar : Form
    {
        ControllerVehiculo controllerVehiculo = new ControllerVehiculo();

        ControllerPropietario objControllerPropietario = new ControllerPropietario();
        ControllerAsociarPropietario objControllerAsociar = new ControllerAsociarPropietario();
        public int? id;
        public frmAsociar(int? id)
        {
            this.id = id;
            InitializeComponent();
            if (id != null)
            {
                lblIdentificacion.Text = Convert.ToString( id);
            }
        }

        private void btnAsociar_Click(object sender, EventArgs e)
        {
            //gridPropietarioPorPlaca.DataSource = controllerVehiculo.propietarioByPLaca(lbl);

            Propietario propietario = objControllerPropietario.buscarPropietario(txtIedentificacion.Text);
            if (propietario != null)
            {
                bool agregado = objControllerAsociar.propietariagregarPropietarioVehiculo(propietario.id, Convert.ToDecimal(id));
                if (agregado)
                {
                    MessageBox.Show("Propietario Agregado exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            
        }

        private void btnBuscarVehiculo_Click(object sender, EventArgs e)
        {
          
            Propietario propietario = objControllerPropietario.buscarPropietario(txtIedentificacion.Text);

            if (propietario != null)
            {
                decimal id = Convert.ToDecimal(lblIdentificacion.Text);
                Propietario obj2Propietario = new Propietario();
                obj2Propietario = objControllerAsociar.yaEsPropietario(id, propietario.id);

                if (obj2Propietario ==null)
                {
                    lblConfirmar.Text = "Desea asociar a " + propietario.nombres + " " + propietario.apellidos + " como propietario de este vehiculo";
                    btnAsociar.Enabled = true;
                }
                else
                {
                    lblConfirmar.Text = "El sñr(a) " + propietario.nombres + " " + propietario.apellidos + " ya es propietario de este vehiculo";
                    btnAsociar.Enabled = false;
                }

            }
            else
            {
               lblConfirmar.Text = "No hay registro";
            }


        }

        private void frmAsociar_Load(object sender, EventArgs e)
        {

        }
    }
}
