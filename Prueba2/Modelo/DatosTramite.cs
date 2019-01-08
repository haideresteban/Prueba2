using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Prueba2.Modelo;
using Prueba2.Vista;


namespace Prueba2.Modelo
{
    public class DatosTramite
    {
        public SqlConnection conexion;
        public SqlTransaction transaccion;
        private string error;


        public string Error
        {
            get { return error; }
            set { error = value; }
        }
        public DatosTramite()
        {
            this.conexion = Conexion.getConexion();
        }

        public List<Tramite> numeroFactura()
        {
            List<Tramite> listaTramite = new List<Tramite>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            comando.CommandText = "select* from TRAMITE ";

            try
            {
                //error
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    Tramite tramite = new Tramite();
                    tramite.id = registro.GetDecimal(0);
                    tramite.descripcion = registro.GetString(1);
                   // tramite.valor =Convert.ToDecimal( registro.GetInt32(2));
                    listaTramite.Add(tramite);

                }
                registro.Close();

            }
            catch (SqlException ex)
            {
                this.error = ex.Message;

            }
            return listaTramite;

        }
        public Tramite buscarTramite(decimal id)
        {
            Tramite tramite = new Tramite();

            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            comando.CommandText = "  select* from TRAMITE where ID="+id;

            try
            {
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    //Tramite tramite = new Tramite();
                    tramite.id = registro.GetDecimal(0);
                    tramite.descripcion = registro.GetString(1);
                   tramite.valor =registro.GetDecimal(2);
                }
                registro.Close();

            }
            catch (SqlException ex)
            {
                this.error = ex.Message;

            }
            return tramite;

        }

        public bool agregarTramite(Tramite tramite, Factura factura)
        {
            this.error = "";
            bool agregado = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            try
            {
                comando.Transaction = this.conexion.BeginTransaction();
                //INSERTAR FACTURA
                comando.CommandText = "insert into FACTURA VALUES(@numero,@fecha,@idVehiculo,@observaciones)";
                comando.Parameters.AddWithValue("@numero",factura.numero);
                comando.Parameters.AddWithValue("@fecha", factura.fecha);
                comando.Parameters.AddWithValue("@idVehiculo", factura.idVehiculo);
               comando.Parameters.AddWithValue("@observaciones", tramite.descripcion);
                comando.ExecuteNonQuery();
                //OBTENGO IDFACTURA
                comando.CommandText = "select max(ID) from FACTURA";
                decimal idFactura = Convert.ToDecimal(comando.ExecuteScalar());
                //INSERTO FACTURA TRAMITE 
                comando.CommandText="insert into FACTURA_TRAMITE VALUES(@idFactura,@idTramite)";
                comando.Parameters.AddWithValue("@idFactura",idFactura);
                comando.Parameters.AddWithValue("@idTramite", tramite.id);
                comando.ExecuteNonQuery();
                comando.Transaction.Commit();
                agregado = true;
            }
            catch (SqlException ex)
            {
                comando.Transaction.Rollback();
                this.error = ex.Message;
            }
           
            return agregado;

              }
       
    }
}


