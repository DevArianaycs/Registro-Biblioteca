using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class Usuarios: ConexionSql
    {
        public bool Login (string usuario, string contrasena)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "SELECT * FROM Administrador WHERE usuarioAdmin=@usuario AND contraseñaAdmin=@contrasena";
                    comando.Parameters.AddWithValue("usuario", usuario);
                    comando.Parameters.AddWithValue("contrasena", contrasena);
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

        }
        public void InsertarRegistroAlumno(string matricula, string nombreAlumno, string apPAlumno, string apMAlumno, string grupo)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "sp_RegistrarAlumno";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@matricula",matricula);
                    comando.Parameters.AddWithValue("@nombreAlumno", nombreAlumno);
                    comando.Parameters.AddWithValue("@apPAlumno", apPAlumno);
                    comando.Parameters.AddWithValue("@apMAlumno", apMAlumno);
                    comando.Parameters.AddWithValue("@grupo", grupo);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }
            }
        }
        public bool EliminarAlumno(string matricula)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "sp_EliminarAlumno2";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@matricula", matricula);
                    int count = (int)comando.ExecuteScalar();
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                    return count > 0;
                }
            }
        }
        public bool EliminarAlumnoRegistro(string matricula)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "sp_EliminarRegistroDeAlumnoEliminado";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@matricula", matricula);
                    int count = (int)comando.ExecuteScalar();
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                    return count > 0;
                }
            }
        }

        public bool ActualizarGrupoAlumno(string matricula, string grupo)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "sp_ActualizarPorAlumno2";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@matricula", matricula);
                    comando.Parameters.AddWithValue("@grupo", grupo);
                    int count = (int)comando.ExecuteScalar();
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                    return count > 0;
                }
            }
        }
        public void ActualizarGrupoGrupo(string grupo, string nuevoGrupo)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "sp_ActualizarGrupoCompleto";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@grupo", grupo);
                    comando.Parameters.AddWithValue("@nuevoGrupo", nuevoGrupo);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }
            }
        }
        public bool ValidarMatricula(string matricula)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "SELECT COUNT(*) FROM Alumno WHERE matricula = @matricula";
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@matricula", matricula);
                    int count = (int)comando.ExecuteScalar();
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                    return count > 0;
                }
            }
        }
        public void InsertarRegistro(string matricula, string nombreAlumno, string apPAlumno, string apMAlumno, string grupo)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "sp_RegistrarAlumno";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@matricula", matricula);
                    comando.Parameters.AddWithValue("@nombreAlumno", nombreAlumno);
                    comando.Parameters.AddWithValue("@apPAlumno", apPAlumno);
                    comando.Parameters.AddWithValue("@apMAlumno", apMAlumno);
                    comando.Parameters.AddWithValue("@grupo", grupo);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }
            }
        }
        public void InsertarDatosdeInvitado(string nombreInvitado, string ocupacion)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "sp_InsertarInvitado";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@nombreInvitado", nombreInvitado);
                    comando.Parameters.AddWithValue("@ocupacion", ocupacion);

                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }
            }
        }
        public void InsertarRegistroAlumno(string matricula)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "sp_ValidarInsertarAlumno";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@matricula", matricula);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }
            }
        }
        

    }
}
