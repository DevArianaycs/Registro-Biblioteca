using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Windows.Forms;

namespace Dominio
{
    public class GeneralModelo
    {

        GeneralDao generalDao = new GeneralDao();
        Usuarios usuarioDao = new Usuarios();

        public bool LoginUser(string usuario, string contrasena)
        {
            return usuarioDao.Login(usuario, contrasena);
        }
        public bool ProbarConexion()
        {
            return generalDao.ProbarConexion();
        }
        public DataTable HistorialAlumnos()
        {
            return generalDao.Data();
        }
        public DataTable HistorialInvitados()
        {
            return generalDao.DataInvitado();
        }
        public void InsertarAlumnos (string matricula, string nombreAlumno, string apPAlumno, string apMAlumno, string grupo)
        {
            usuarioDao.InsertarRegistroAlumno(matricula, nombreAlumno, apPAlumno, apMAlumno, grupo);
        }
        public void EliminarAlumno (string matricula)
        {

            if (usuarioDao.EliminarAlumno(matricula))
            {
                
                MessageBox.Show("Se ha realizado el proceso correctamente");
            }
            else
            {
                MessageBox.Show("Matricula no existente");
            }
           
        }
        public void EliminarAlumnoRegistro(string matricula)
        {

            usuarioDao.EliminarAlumnoRegistro(matricula);
            

        }
        public void EditarAlumnoPorGrupo (string matricula, string grupo)
        {
            if (usuarioDao.ActualizarGrupoAlumno(matricula, grupo))
            {
                MessageBox.Show("Se ha realizado el proceso");
            }
            else
            {
                MessageBox.Show("matricula no existente");
            }
        }
        public void EditarGrupoCompleto(string grupo, string nuevoGrupo)
        {
            usuarioDao.ActualizarGrupoGrupo(grupo, nuevoGrupo);
        }
        public void InsertarMatricula (string matricula)
        {
            if (usuarioDao.ValidarMatricula(matricula))
            {
                MessageBox.Show("Gracias por visitarnos");  
            }
            else
            {
                MessageBox.Show("Matricula no existente");
            }
        }
        public void InsertarRegistroAlumno(string matricula)
        {
            usuarioDao.InsertarRegistroAlumno(matricula);
        }
       public void InsertarDatosTablaInvitado (string nombreInvitado, string ocupacion)
        {
            usuarioDao.InsertarDatosdeInvitado(nombreInvitado, ocupacion);
        }
        public DataTable Buscar (string search)
        {
            DataTable td = new DataTable();
            td = generalDao.Buscar(search);
            return td;
        }
        
    }
}
