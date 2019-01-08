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

        public DataTable FacturaByPlaca(string placa)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            String SQL =
                "select f.NUMERO AS FACTURA, f.FECHA, v.PLACA "+
               "from FACTURA f INNER JOIN VEHICULO v ON (f.ID_VEHICULO = v.ID) "+
               "WHERE v.PLACA = '" + @placa + "'";
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
        public DataTable FacturaByIdentificacion(string identificacion)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            String SQL =
               "select f.NUMERO AS FACTURA, f.FECHA, v.PLACA, PROPIETARIO.NUMEROIDENTIFICACION AS IDENTIFICACION "+
                "from FACTURA f "+
                "INNER JOIN VEHICULO v ON(f.ID_VEHICULO = v.ID) "+
                "INNER JOIN PROPIETARIO_VEHICULO pv ON(v.ID = pv.ID_VEHICULO) "+
                "inner JOIN PROPIETARIO on (pv.ID_PROPIETARIO = PROPIETARIO.ID) "+
                "WHERE PROPIETARIO.NUMEROIDENTIFICACION = '"+ identificacion+"'";
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
        public DataTable facturaByRangoFechas(string fechaIni, string FechaFin)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            String SQL =
               "select f.NUMERO AS FACTURA, f.FECHA, v.PLACA " +
                "from FACTURA f " +
                "INNER JOIN VEHICULO v ON(f.ID_VEHICULO = v.ID) " +
                "WHERE f.FECHA >= '"+fechaIni+"' AND f.FECHA <= '"+FechaFin+"'";
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
        public Factura facturaByNumeroF(string numeroFactura)
        {

            this.error = "";
            Factura unaFactura = null;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            comando.CommandText = "select * from FACTURA WHERE FACTURA.NUMERO=" + numeroFactura;
            try
            {
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    unaFactura = new Factura();
                    unaFactura.id = Convert.ToInt32(registro.GetDecimal(0));
                    unaFactura.numero = registro.GetString(1);
                    unaFactura.fecha = Convert.ToDateTime( registro.GetDateTime(2));
                    unaFactura.idVehiculo = Convert.ToDecimal(registro.GetDecimal(3));
                    unaFactura.observaciones = unaFactura.numero = registro.GetString(4);
                }
                registro.Close();
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
            }
            return unaFactura;

        }


    }
  
    
}


