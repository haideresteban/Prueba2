using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;



namespace Prueba2.Modelo
{
    public class DatosPropietario
    {
        public SqlConnection conexion;
        public SqlTransaction transaccion;
        private string error;

        public string Error
        {
            get { return error; }
            set { error = value; }
        }



        public DatosPropietario()
        {
            this.conexion = Conexion.getConexion();
        }
        public List<Propietario> listarPropietarios()
        {
            List<Propietario> listaPropietarios = new List<Propietario>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            comando.CommandText = "SELECT * FROM PROPIETARIO";

            try
            {
               
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    
                    Propietario propi = new Propietario();
                    propi.id = Convert.ToInt32(registro.GetDecimal(0));
                    propi.numeroIdentificacion =Convert.ToInt32(registro.GetString(1)) ;
                    propi.nombres = registro.GetString(2);
                    propi.apellidos = registro.GetString(3);
                    propi.direccion = registro.GetString(4);
                    propi.telefono = registro.GetString(5);
                    propi.correoElectronico = registro.GetString(6);
                    listaPropietarios.Add(propi);
                }
                registro.Close();
            }
            catch(SqlException ex)
            {
                this.error = ex.Message;
            }

            return listaPropietarios;
        }


        public bool agregarPropietario(Propietario propietario)
        {
            this.error = "";
            bool agregado = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;

            try
            {
                comando.Transaction = this.conexion.BeginTransaction();
                comando.CommandText = "insert into PROPIETARIO values(@NUMEROIDENTIFICACION, @NOMBRES, @APELLIDOS, @DIRECCION, @TELEFONO, @CORREOELECTRONICO)";
                comando.Parameters.AddWithValue("@NUMEROIDENTIFICACION", propietario.numeroIdentificacion);
                comando.Parameters.AddWithValue("@NOMBRES", propietario.nombres);
                comando.Parameters.AddWithValue("@APELLIDOS", propietario.apellidos);
                comando.Parameters.AddWithValue("@DIRECCION", propietario.direccion);
                comando.Parameters.AddWithValue("@TELEFONO", propietario.telefono);
                comando.Parameters.AddWithValue("@CORREOELECTRONICO", propietario.correoElectronico);
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

      /*  public bool eliminar(int id)
        {
            this.error = "";
            bool agregado = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            try
            {
                comando.Transaction = this.conexion.BeginTransaction();
                comando.CommandText = "DELETE FROM PROPIETARIO WHERE NUMEROIDENTIFICACION=( @NUMEROIDENTIFICACION)";
                comando.Parameters.AddWithValue("@NUMEROIDENTIFICACION", id);



            }
            catch (Exception ex)
            {
                comando.Transaction.Rollback();
                this.error = ex.Message;
            }



        }*/

            public bool actualizarPropietario(Propietario unPropietario)
        {

             this.error = "";
            bool actualizado = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
          //  Propietario propietario = new Propietario();
           

            try
            {
                comando.Transaction = this.conexion.BeginTransaction();
               comando.CommandText = "UPDATE PROPIETARIO SET NUMEROIDENTIFICACION =@identificacion,NOMBRES =@nombres,APELLIDOS =@apellidos" +
               ",DIRECCION =@direccion,TELEFONO =@telefono,CORREOELECTRONICO =@correo WHERE ID=@id";
                comando.Parameters.AddWithValue("@identificacion", unPropietario.numeroIdentificacion);
                comando.Parameters.AddWithValue("@nombres", unPropietario.nombres);
                comando.Parameters.AddWithValue("@apellidos", unPropietario.apellidos);
                comando.Parameters.AddWithValue("@direccion", unPropietario.direccion);
                comando.Parameters.AddWithValue("@telefono", unPropietario.telefono);
                comando.Parameters.AddWithValue("@CORREO", unPropietario.correoElectronico);

                comando.Parameters.AddWithValue("@id", unPropietario.id);
               comando.ExecuteNonQuery();
                comando.Transaction.Commit();
                actualizado = true;
            }

            catch (SqlException ex)
            {
                this.error = ex.Message;
            }
            return actualizado;
        }

        public Propietario buscarPropietario(string identificacion)
        {
            this.error = "";
            Propietario unPropietario = null;
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexion;
            //comando.CommandText = "SELECT * FROM PROPIETARIO WHERE NUMEROIDENTIFICACION=@identificacion";
            comando.CommandText = "SELECT * FROM PROPIETARIO WHERE NUMEROIDENTIFICACION=" + identificacion;
           // comando.Parameters.AddWithValue("@identificacion", identificacion);
            try
            {
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    unPropietario = new Propietario();
                    unPropietario.id = Convert.ToInt32( registro.GetDecimal(0));
                    unPropietario.numeroIdentificacion =Convert.ToInt32( registro.GetString(1));
                    unPropietario.nombres = registro.GetString(2);
                    unPropietario.apellidos = registro.GetString(3);
                    unPropietario.direccion = registro.GetString(4);
                    unPropietario.telefono = registro.GetString(5);
                    unPropietario.correoElectronico = registro.GetString(6);
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
