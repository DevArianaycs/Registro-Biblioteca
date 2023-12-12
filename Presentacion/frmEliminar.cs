using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
            msEliminar.ForeColor = Color.White;
        }

        private void FrmActualizar_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.msEliminar.BackColor = Color.FromArgb(0, 123, 95);
            this.ActiveControl = label2;
        }

        private void msEliminarInicio_Click(object sender, EventArgs e)
        {
            frmInicio inicioFrm = new frmInicio();
            this.Close();
            inicioFrm.Show();
        }


        private void msEliminarRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrar registrarFrm = new frmRegistrar();
            this.Close();
            registrarFrm.Show();

        }

        private void msEliminarModificarEliminar_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void msEliminarModificarActualizar_Click(object sender, EventArgs e)
        {
            frmActualizar actualizarFrm = new frmActualizar();
            this.Close();
            actualizarFrm.Show();
        }

        private void msEliminarCerrarSesion_Click(object sender, EventArgs e)
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

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                textBox1.Text = "Matricula";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 127 || e.KeyChar == 45||e.KeyChar==08||e.KeyChar==13)
            {

                e.Handled = false;
                if (e.KeyChar == (Char)(Keys.Enter))
                {
                    e.Handled = true;
                    btnEliminarAlumno_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Caracter no valido", "Centro de informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="Matricula")
            {

                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar registro?", "Centro de información", botones, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    GeneralModelo eliminarAlumno = new GeneralModelo();
                    eliminarAlumno.EliminarAlumnoRegistro(textBox1.Text);
                    eliminarAlumno.EliminarAlumno(textBox1.Text);
                }
                if (dr == DialogResult.No)
                {
                }
            }
            else
            {
                MessageBox.Show("Ingresa la matricula del alumno a eliminar");
            }
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarAlumno_MouseHover(object sender, EventArgs e)
        {
            this.btnEliminarAlumno.BackColor = Color.FromArgb(173, 209, 171);
        }

        private void btnEliminarAlumno_MouseLeave(object sender, EventArgs e)
        {
            this.btnEliminarAlumno.BackColor = Color.White;
        }

        private void msEliminarVerHistorial_Click(object sender, EventArgs e)
        {
            frmVerHistorial verHistorialFrm = new frmVerHistorial();
            this.Close();
            verHistorialFrm.Show();
        }
    }
}
