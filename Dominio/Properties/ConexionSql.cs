using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public abstract class ConexionSql
    {
        private readonly string cadenaConexion;

        public ConexionSql()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        }

        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }


    }
}
