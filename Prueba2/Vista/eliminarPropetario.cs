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
    public partial class eliminarPropetario : Form
    {
        ControllerPropietario controlllerPropietario = new ControllerPropietario();
        public eliminarPropetario()
        {
            InitializeComponent();
        }

        private void eliminarPropetario_Load(object sender, EventArgs e)
        {
            dgvEliminar.DataSource = controlllerPropietario.listaPropietarios().ToList();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
