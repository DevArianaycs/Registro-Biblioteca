using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class frmVerHistorial : Form
    {
        
        public frmVerHistorial()
        {
            InitializeComponent();
            msVerHistorial.ForeColor = Color.White;
        }

        private void btnRevisarConexion_Click(object sender, EventArgs e)
        {
            GeneralModelo generalModelo = new GeneralModelo();
            if (generalModelo.ProbarConexion())
            {
                MessageBox.Show("EXITO!");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
        
        private void visualizarBtn_Click(object sender, EventArgs e)
        {

                GeneralModelo generalModelo = new GeneralModelo();
                dataGridView1.DataSource = generalModelo.HistorialAlumnos();
            
            
        }

        private void frmVerHistorial_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.msVerHistorial.BackColor = Color.FromArgb(0, 123, 95);
        }

        private void msVerHistorialInicio_Click(object sender, EventArgs e)
        {
            frmInicio inicioFrm = new frmInicio();
            this.Close(); 
            inicioFrm.Show();
        }

        private void msVerHistorialRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrar registrarfrm = new frmRegistrar();
            this.Close();
            registrarfrm.Show();
        }

        private void msVerHistorialModificarEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar eliminarFrm = new frmEliminar();
            this.Close();
            eliminarFrm.Show();
        }

        private void msVerHistorialModificarActualizar_Click(object sender, EventArgs e)
        {
            frmActualizar actualizarFrm = new frmActualizar();
            this.Close();
            actualizarFrm.Show();
        }

        private void msVerHistorialCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin loginFrm = new FrmLogin();
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Centro de información", botones, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                loginFrm.ShowDialog();

            }
            if (dr == DialogResult.No)
            {

            }
        }

        private void btnVisualizarInvitados_Click(object sender, EventArgs e)
        {

            GeneralModelo generalModelo = new GeneralModelo();
            dataGridView1.DataSource = generalModelo.HistorialInvitados();
        }

        private void msVerHistorialVerHistorial_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
