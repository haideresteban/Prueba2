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
    public partial class frmAgregarVehiculo : Form
    {
        ControllerVehiculo controllerVehiculo = new ControllerVehiculo();
        public int? id;

        public frmAgregarVehiculo(int? id)
        {
            this.id = id;
            
            InitializeComponent();
            if (id != null)
            {
                lblIdActualizar.Text = id.ToString();
                Vehiculo vehiculo = new Vehiculo();
                vehiculo = controllerVehiculo.buscarVehiculo(id);

                txtPlaca.Text = vehiculo.placa;
                txtModelo.Text = vehiculo.modelo;
                txtColor.Text = vehiculo.color;
                txtNumeroMotor.Text = vehiculo.numeroMotor;

                txtPlaca.Enabled = false;
                txtModelo.Enabled = false;
                txtColor.Enabled = false;
                txtNumeroMotor.Enabled = false;

            }
        }

        private void frmAgregarVehiculo_Load(object sender, EventArgs e)
        {
            List<ClaseVehiculo> listaClaseVehiculo = new List<ClaseVehiculo>();
            listaClaseVehiculo = controllerVehiculo.listaClaseVEhiculos();
            List<TipoServicio> listaTipoSer = new List<TipoServicio>();
            listaTipoSer = controllerVehiculo.listaTipoServicios();
            List<Marca> listaMarcas = new List<Marca>();

            //pppp
            Vehiculo vehiculo = new Vehiculo();
            lblTitulo.Text = "AGREGAR VEHICULO";

            if (id != null)
            {
                lblTitulo.Text = "EDITAR VEHICULO";
                vehiculo = controllerVehiculo.buscarVehiculo(id);
                cbMarca.SelectedValue = Convert.ToString(vehiculo.idLinea.idMarca);

            }


            //SuggestAppend= PARA BUSCAR POR LETRA 
            //cbMarca.ValueMember = "Id";
            //cbMarca.DisplayMember = "descripcion";
            listaMarcas = controllerVehiculo.listaMarcas();
            cbMarca.DataSource = listaMarcas;
            cbTipoSer.DataSource = listaTipoSer;
            cbClaseVehiculo.DataSource = listaClaseVehiculo;

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal id;

            if (cbMarca.SelectedValue != null)
            {
                id = Convert.ToDecimal(cbMarca.SelectedValue);
                List<Linea> lineaByMarca = controllerVehiculo.lineaByMarca(id);
                cbLinea.DataSource = lineaByMarca;
            }


        }

        private void cbLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            txtPlaca.MaxLength = 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehiculo objVehiculo = new Vehiculo();
            objVehiculo.placa= txtPlaca.Text;


            Prueba2.Modelo.Linea objLinea = new Prueba2.Modelo.Linea();
            objLinea.id= long.Parse(cbLinea.SelectedValue.ToString());
            objVehiculo.idLinea=objLinea;

            objVehiculo.modelo = txtModelo.Text;
            objVehiculo.numeroMotor = txtNumeroMotor.Text;
            objVehiculo.color = txtColor.Text;

            ClaseVehiculo objClaseVeh = new ClaseVehiculo();
            objClaseVeh.id= long.Parse(cbClaseVehiculo.SelectedValue.ToString()); ;
            objVehiculo.idClaseVehiculo = objClaseVeh;


            TipoServicio objTipoSer = new TipoServicio();
            objTipoSer.id= long.Parse(cbTipoSer.SelectedValue.ToString()); ;
            objVehiculo.idTipoServicio = objTipoSer;

            bool agregado = controllerVehiculo.agregarVehiculo(objVehiculo);

            if (agregado)
            {
                MessageBox.Show("SE HA REALIZADO CON EXITO EL VEHICULO", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
    }
}
