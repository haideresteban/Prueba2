using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Prueba2.Modelo;
using Prueba2.Vista;


namespace Prueba2.Modelo
{
   public class DatosVehiculo
    {
        public SqlConnection conexion;
        public SqlTransaction transaccion;
        private string error;


        public string Error
        {
            get { return error; }
            set { error = value; }
        }
        public DatosVehiculo()
        {
            this.conexion = Conexion.getConexion();
        }
        public bool agregarVehiculo(Vehiculo vehiculo)
        {
            this.error = "";
            bool agregado = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            try
            {
                comando.Transaction = this.conexion.BeginTransaction();
                comando.CommandText = "INSERT INTO VEHICULO values(@placa,@idlinea,@modelo,@numeromotor,@color,@idclase, @idtiposervicio)";
                comando.Parameters.AddWithValue("@placa", vehiculo.placa);
                comando.Parameters.AddWithValue("@idlinea", vehiculo.idLinea.id);
                comando.Parameters.AddWithValue("@modelo", vehiculo.modelo);
                comando.Parameters.AddWithValue("@numeroMotor", vehiculo.numeroMotor);
                comando.Parameters.AddWithValue("@color", vehiculo.color);
                comando.Parameters.AddWithValue("@idclase", vehiculo.idClaseVehiculo.id);
                comando.Parameters.AddWithValue("@idtiposervicio", vehiculo.idTipoServicio.id);
                comando.ExecuteNonQuery();
                comando.Transaction.Commit();
                agregado = true;
            }
            catch(SqlException ex)
            {
                comando.Transaction.Rollback();
                this.error = ex.Message;

            }
            return agregado;
        }
        public List<ClaseVehiculo> listaClaseVehiculos()
        {
            List<ClaseVehiculo> listaClase = new List<ClaseVehiculo>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            comando.CommandText = "Select * from CLASEVEHICULO";
            try
            {
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    ClaseVehiculo CV = new ClaseVehiculo();
                    CV.id = registro.GetDecimal(0);
                    CV.descripcion = registro.GetString(1);
                    listaClase.Add(CV);

                }
                registro.Close();

            }
            catch (Exception ex)
            {
                this.error = ex.Message;

            }
            return listaClase;
        }
        public List<Marca> listaMarcas()
        {
            List<Marca> listaMarcas = new List<Marca>();
            SqlCommand comando = new SqlCommand();
            comando.Connection=this.conexion;
            comando.CommandText = "Select * from MARCA";
            try
            {
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    Marca marca = new Marca();
                    marca.Id = registro.GetDecimal(0);
                    marca.descripcion = registro.GetString(1);
                    listaMarcas.Add(marca);

                }
                registro.Close();

            }catch(Exception ex)
            {
                this.error = ex.Message;

            }
            return listaMarcas;
        }

        public List<Linea> listaLineas(decimal idMarca)
        {
            List<Linea> listaLineas = new List<Linea>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            comando.CommandText = "SELECT * from LINEA WHERE ID=@idmarca";
             comando.Parameters.AddWithValue("@idmarca", idMarca);

            try
            {
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    Linea linea = new Linea();
                    linea.id = registro.GetDecimal(0);
                    linea.descripcion = registro.GetString(1);
                   // linea.idMarca.Id=registro.GetDecimal(2)
                    listaLineas.Add(linea);

                }
                registro.Close();

            }
            catch (SqlException ex)
            {
                this.error = ex.Message;

            }
            return listaLineas;

        }
        public List<TipoServicio> listarTipodeServicios()
        {
            List<TipoServicio> listaServicios = new List<TipoServicio>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            comando.CommandText = "SELECT * from TIPOSERVICIO";
            try
            {
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    TipoServicio tipoServicio = new TipoServicio();
                    tipoServicio.id = registro.GetDecimal(0);
                    tipoServicio.descripcion = registro.GetString(1);
                    listaServicios.Add(tipoServicio);

                }
                registro.Close();


            }catch(Exception ex)
            {
                this.error = ex.Message;
            }
            return listaServicios;


        }


        
        public DataTable listarVehiculos2()
        {
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;

            String SQL =
               "select VEHICULO.ID,VEHICULO.PLACA, LINEA.DESCRIPCION AS LINEA, VEHICULO.MODELO,VEHICULO.COLOR , CLASEVEHICULO.DESCRIPCION AS CLASE, TIPOSERVICIO.DESCRIPCION AS TIPO FROM VEHICULO INNER JOIN LINEA ON(LINEA.ID = VEHICULO.ID_LINEA) " +
               "INNER JOIN CLASEVEHICULO ON(VEHICULO.ID_CLASE= CLASEVEHICULO.ID) " +
              " INNER JOIN TIPOSERVICIO ON(VEHICULO.ID_TIPOSERVICIO= TIPOSERVICIO.ID)";
            
            comando.CommandText = SQL;
            try
            {

                SqlDataReader registro = comando.ExecuteReader();

                DataTable DT = new DataTable();
                DT.Load(registro);
                
                registro.Close();

                return DT;
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
            }

            return new DataTable();
        }


        public bool actualizarVehiculo(Vehiculo vehiculo) {

            bool actualiza= false;

            return actualiza;
        }


        public Vehiculo BuscarVehiculo(int? id)
        {
            this.error = "";
            Vehiculo unVehiculo = null;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            comando.CommandText= "SELECT * FROM VEHICULO WHERE ID=" + id;
            try
            {
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    unVehiculo = new Vehiculo();
                    unVehiculo.id = Convert.ToInt32(registro.GetDecimal(0));
                    unVehiculo.placa = registro.GetString(1);

                    Linea linea = new Linea();
                    linea.id = registro.GetDecimal(2);
                    unVehiculo.idLinea = linea;

                    unVehiculo.modelo = registro.GetString(3);
                    unVehiculo.numeroMotor = registro.GetString(4);
                    unVehiculo.color = registro.GetString(5);

                    ClaseVehiculo clase = new ClaseVehiculo();
                    clase.id = registro.GetDecimal(6);
                    unVehiculo.idClaseVehiculo = clase;
                    TipoServicio tipo = new TipoServicio();
                    tipo.id = registro.GetDecimal(7);

                }
                registro.Close();

            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                                                         }
            return unVehiculo;

            }

        public DataTable BuscarVehiculoByPlaca(string placa )
        {
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            String SQL =
               "select VEHICULO.ID,VEHICULO.PLACA, LINEA.DESCRIPCION AS LINEA, VEHICULO.MODELO,VEHICULO.COLOR , CLASEVEHICULO.DESCRIPCION AS CLASE, TIPOSERVICIO.DESCRIPCION AS TIPO FROM VEHICULO INNER JOIN LINEA ON(LINEA.ID = VEHICULO.ID_LINEA) " +
               " INNER JOIN CLASEVEHICULO ON(VEHICULO.ID_CLASE= CLASEVEHICULO.ID) " +
              " INNER JOIN TIPOSERVICIO ON(VEHICULO.ID_TIPOSERVICIO= TIPOSERVICIO.ID)"+
              " WHERE VEHICULO.PLACA='"+placa+"'";

            comando.CommandText = SQL;
            try
            {
                SqlDataReader registro = comando.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Load(registro);
                registro.Close();
                return DT;
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
            }

            return new DataTable();

        }

        public DataTable tramites()
        {
           
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            String SQL =
               "select* from TRAMITE ";

            comando.CommandText = SQL;
            try
            {
                SqlDataReader registro = comando.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Load(registro);
                registro.Close();
                return DT;
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
            }

            return new DataTable();

        }

        public string numeroFactura()
        {
            string numeroFactura = "";
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            String SQL =
                " SELECT FACTURA.NUMERO FROM FACTURA WHERE FACTURA.ID=(SELECT max (ID) FROM FACTURA)";
            comando.CommandText = SQL;
            try
            {
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    numeroFactura = registro.GetString(0);
                }
                               registro.Close();
                return numeroFactura;
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
            }
            return numeroFactura;
        }
        public decimal idAutoByPlaca(string placa)
        {
            decimal idAuto = 0;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            comando.CommandText = "SELECT ID FROM VEHICULO where PLACA='" + placa+"'";
            try
            {
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    idAuto = registro.GetDecimal(0);

                }
                registro.Close();

            }
            catch (SqlException ex)
            {
                this.error = ex.Message;

            }
            return idAuto; ;

        }
    }

    }

