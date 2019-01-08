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

namespace Prueba2
{
    public partial class frmAgregar : Form
    {
        ControllerPropietario controlllerPropietario = new ControllerPropietario();


        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                if (vaidarGuardar())
                {

                    Propietario unPropietario = new Propietario();
                    unPropietario.numeroIdentificacion = Convert.ToInt32(txtIdentificacion.Text);
                    unPropietario.nombres = txtNombres.Text;
                    unPropietario.apellidos = txtApellidos.Text;
                    unPropietario.direccion = txtDireccion.Text;
                    unPropietario.telefono = txtTelefono.Text;
                    unPropietario.correoElectronico = txtCorreo.Text;

                    bool agregado = controlllerPropietario.agregarPropietario(unPropietario);

                    if (agregado)
                    {
                        lblMensaje.Text = "Propietario agregada correctamente ";
                        this.Close();
                        frmListarPropietarios frmLista = new frmListarPropietarios();
                        frmLista.Show();

                    }
                    else
                    {
                        lblMensaje.Text = "Propietario no  agregada ";

                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error, datos de errror:" + ex.Message);
            }

        }

        private bool vaidarGuardar()
        {
            try
            {
                int numero;
                bool EsEntero = Int32.TryParse(txtIdentificacion.Text, out numero);
                if(!EsEntero)
                {
                    MessageBox.Show("Ingrese un valor entero","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    txtIdentificacion.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtNombres.Text))
                {

                    MessageBox.Show("Ingrese el nombre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtNombres.Focus();
                    return false;
                }

                return true;

            }
            catch (Exception ex)
            {

                throw;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void vtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
