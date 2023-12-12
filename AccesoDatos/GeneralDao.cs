using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class GeneralDao : ConexionSql
    {
        private SqlDataReader LeerFilas;
        public bool ProbarConexion()
        {

            SqlConnection conexion = ObtenerConexion();
            try
            {
                conexion.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conexion.Close();
            }
            

        }
        public DataTable Data()
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    DataTable table = new DataTable();
                    comando.CommandText = "sp_MostrarRegistros";
                    comando.CommandType = CommandType.StoredProcedure;
                    LeerFilas = comando.ExecuteReader();
                    table.Load(LeerFilas);
                    LeerFilas.Close();
                    return table;
                }
            }
        }
        public DataTable DataInvitado()
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    DataTable table = new DataTable();
                    comando.CommandText = "sp_MostrarRegistrosInvitados2";
                    comando.CommandType = CommandType.StoredProcedure;
                    LeerFilas = comando.ExecuteReader();
                    table.Load(LeerFilas);
                    LeerFilas.Close();
                    return table;
                }
            }
        }
        public DataTable Buscar(string search)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    SqlDataReader rd;
                    comando.Connection = conexion;
                    DataTable table = new DataTable();
                    comando.CommandText = "sp_Buscar";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("search",search);
                    rd = comando.ExecuteReader();
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    table.Load(rd);
                    return table;
                }
            }
        }

    }


}
