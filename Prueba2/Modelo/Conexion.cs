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
    public class Conexion
    {
        private static SqlConnection objConexion;
        private static string error;


        public static SqlConnection getConexion()
        {
            if (objConexion != null)
                return objConexion;
            objConexion = new SqlConnection();
            objConexion.ConnectionString = @"Data Source=HAIDER\SQLEXPRESS; Initial Catalog=PRUEBA1;Integrated Security=true";
            try
            {
                objConexion.Open();
                return objConexion;
            }
            catch (Exception e)
            {
                error = e.Message;
                return null;
            }
        }
        public static void cerrarConexion()
        {
            if (objConexion != null)
            {
                if (objConexion != null)
                {
                    objConexion.Close();
                }
            }

        }


    }
}