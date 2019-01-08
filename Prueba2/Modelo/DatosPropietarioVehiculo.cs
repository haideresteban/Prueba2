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


    public class DatosPropietarioVehiculo
    {
        public SqlConnection conexion;
        public SqlTransaction transaccion;
        private string error;

        public string Error
        {
            get { return error; }
            set { error = value; }
        }
        public DatosPropietarioVehiculo()
        {
            this.conexion = Conexion.getConexion();
        }

        public DataTable propietariosByPlaca(string placa)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            String SQL =
                "select PROPIETARIO.ID, PROPIETARIO.NUMEROIDENTIFICACION, PROPIETARIO.NOMBRES, PROPIETARIO.APELLIDOS, PROPIETARIO.DIRECCION, PROPIETARIO.TELEFONO  "+
                "FROM PROPIETARIO_VEHICULO"+
                " INNER JOIN PROPIETARIO ON(PROPIETARIO_VEHICULO.ID_PROPIETARIO= PROPIETARIO.ID) " +
                "INNER JOIN VEHICULO ON(PROPIETARIO_VEHICULO.ID_VEHICULO= VEHICULO.ID) " +
                " WHERE VEHICULO.PLACA='"+@placa+"'";
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


        public bool agregarpPropietarioVehiculo(decimal idPropietario, decimal idVehiculo)
        {
            this.error = "";
            bool agregado = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;

            try
            {
                comando.Transaction = this.conexion.BeginTransaction();
                comando.CommandText = "insert into PROPIETARIO_VEHICULO VALUES(@ID_PROPIETARIO, @ID_VEHICULO)";
                comando.Parameters.AddWithValue("@ID_PROPIETARIO", idPropietario);
                comando.Parameters.AddWithValue("@ID_VEHICULO", idVehiculo);
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

        public Propietario yaEsPropietario(decimal id, decimal idpropie)
        {
            this.error = "";
            Propietario unPropietario = null;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            comando.CommandText = "select PROPIETARIO.ID, PROPIETARIO.NUMEROIDENTIFICACION, PROPIETARIO.NOMBRES, PROPIETARIO.APELLIDOS, PROPIETARIO.DIRECCION, PROPIETARIO.TELEFONO "+
                                   "FROM PROPIETARIO_VEHICULO "+
                                   " INNER JOIN PROPIETARIO ON(PROPIETARIO_VEHICULO.ID_PROPIETARIO= PROPIETARIO.ID)"+
                                   " INNER JOIN VEHICULO ON(PROPIETARIO_VEHICULO.ID_VEHICULO= VEHICULO.ID) WHERE PROPIETARIO.ID="+idpropie+" AND VEHICULO.ID="+id;
            try
            {
                unPropietario = null;
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    unPropietario = new Propietario();
                    unPropietario.id = Convert.ToInt32(registro.GetDecimal(0));
                    unPropietario.numeroIdentificacion = Convert.ToInt32(registro.GetString(1));
                    unPropietario.nombres = registro.GetString(2);
                    unPropietario.apellidos = registro.GetString(3);
                    unPropietario.direccion = registro.GetString(4);
                    unPropietario.telefono = registro.GetString(5);
               //     unPropietario.correoElectronico = registro.GetString(6);
                }
                registro.Close();
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
            }
            return unPropietario;
        }

      public Propietario propietarioByVehiculoIdentificacion(string placa, string identificacion)
        {
            this.error = "";
            Propietario unPropietario = null;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            comando.CommandText = "select PROPIETARIO.ID, PROPIETARIO.NUMEROIDENTIFICACION, PROPIETARIO.NOMBRES, PROPIETARIO.APELLIDOS, PROPIETARIO.DIRECCION, PROPIETARIO.TELEFONO " +
                                   "FROM PROPIETARIO_VEHICULO " +
                                   " INNER JOIN PROPIETARIO ON(PROPIETARIO_VEHICULO.ID_PROPIETARIO= PROPIETARIO.ID)" +
                                   " INNER JOIN VEHICULO ON(PROPIETARIO_VEHICULO.ID_VEHICULO= VEHICULO.ID) WHERE  PROPIETARIO.NUMEROIDENTIFICACION='" + identificacion + "' AND VEHICULO.PLACA='" + placa+"'";
            try
            {
                unPropietario = null;
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    unPropietario = new Propietario();
                    unPropietario.id = Convert.ToInt32(registro.GetDecimal(0));
                    unPropietario.numeroIdentificacion = Convert.ToInt32(registro.GetString(1));
                    unPropietario.nombres = registro.GetString(2);
                    unPropietario.apellidos = registro.GetString(3);
                    unPropietario.direccion = registro.GetString(4);
                    unPropietario.telefono = registro.GetString(5);
                    //     unPropietario.correoElectronico = registro.GetString(6);
                }
                registro.Close();
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
            }
            return unPropietario;
        }


    }
}
