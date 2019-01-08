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
    public partial class frmEditarPropietario : Form
    {
        ControllerPropietario controllerPropietario = new ControllerPropietario();
        public int? id;

        public frmEditarPropietario(int? id)
        {
            this.id = id;
            
            InitializeComponent();

            if (id != null)
            {
                txtBuscar.Text = id.ToString();
                Propietario propietario = new Propietario();
                propietario = controllerPropietario.buscarPropietario(Convert.ToString(id));
                lblID.Text = propietario.id.ToString();
                txtIdentificacion.Text = propietario.numeroIdentificacion.ToString();
                txtNombres.Text = propietario.nombres.ToString();
                txtApellidos.Text = propietario.apellidos.ToString();
                txtDireccion.Text = propietario.direccion.ToString();
                txtTelefono.Text = propietario.telefono.ToString();
                txtCorreo.Text = propietario.correoElectronico.ToString();
                txtIdentificacion.Enabled = true;
                txtNombres.Enabled = true;
                txtApellidos.Enabled = true;
                txtDireccion.Enabled = true;
                txtTelefono.Enabled = true;
                txtCorreo.Enabled = true;
                lblNoEncontrado.Text = " ";

                btnGuardar.Enabled = true;

            }

        }

        private void frmEditarPropietario_Load(object sender, EventArgs e)
        {

        }

        private void vtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtBuscar.Text!="")
            {
                string identificacion = txtBuscar.Text;
                Propietario unPropietario = new Propietario();
                unPropietario = controllerPropietario.buscarPropietario(identificacion);
  
                if (unPropietario != null)
                {
                    lblID.Text = unPropietario.id.ToString();
                    txtIdentificacion.Text = unPropietario.numeroIdentificacion.ToString();
                    txtNombres.Text = unPropietario.nombres.ToString();
                    txtApellidos.Text = unPropietario.apellidos.ToString();
                    txtDireccion.Text = unPropietario.direccion.ToString();
                    txtTelefono.Text = unPropietario.telefono.ToString();
                    txtCorreo.Text = unPropietario.correoElectronico.ToString();
                    txtIdentificacion.Enabled = true;
                    txtNombres.Enabled = true;
                    txtApellidos.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtCorreo.Enabled = true;
                    lblNoEncontrado.Text = " ";

                    btnGuardar.Enabled = true;
                }
                else
                {

                    txtIdentificacion.Text = "";
                    txtNombres.Text = "";
                    txtApellidos.Text = "";
                    txtDireccion.Text = "";
                    txtTelefono.Text = "";
                    txtCorreo.Text = "";
                    txtIdentificacion.Enabled = false;
                    txtNombres.Enabled = false;
                    txtApellidos.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtCorreo.Enabled = false;
                    btnGuardar.Enabled = false;



                    lblNoEncontrado.Text = "PROPIETARIO NO ENCONTRADA";
                }

            }
            else
            {
                lblNoEncontrado.Text = "Ingrese una identificacion";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            bool validar = validarGuardar();
            
            if(validar)
            {
                Propietario propietario = new Propietario();
                propietario.id =Convert.ToDecimal(lblID.Text);
                propietario.numeroIdentificacion = Convert.ToInt32(txtIdentificacion.Text);
                propietario.nombres = txtNombres.Text;
                propietario.apellidos = txtApellidos.Text;
                propietario.direccion = txtDireccion.Text;
                propietario.telefono = txtTelefono.Text;
                propietario.correoElectronico = txtCorreo.Text;

                bool actualizar = controllerPropietario.actualizarPropietario(propietario);
                if (actualizar == true)
                {


                    txtIdentificacion.Text = "";
                    txtNombres.Text = "";
                    txtApellidos.Text = "";
                    txtDireccion.Text = "";
                    txtTelefono.Text = "";
                    txtCorreo.Text = "";
                    txtIdentificacion.Enabled = false;
                    txtNombres.Enabled = false;
                    txtApellidos.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtCorreo.Enabled = false;
                    btnGuardar.Enabled = false;
                    lblNoEncontrado.Text = "ACTUALIZACION EXITOSA";
                }
                else
                {
                    lblNoEncontrado.Text = controllerPropietario.Error;
                   // lblNoEncontrado.Text = "Hubo un error, actualizado el usuario";
                }


            }
            else{
                lblNoEncontrado.Text = "TODOS LOS CAMPOS SON REQUERIDOS";

            }
        }

        private bool validarGuardar()
        {
            try
            {
                int numero;
                bool EsEntero = Int32.TryParse(txtIdentificacion.Text, out numero);
                if (!EsEntero)
                {
                    MessageBox.Show("Ingrese un valor entero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

    }
}
