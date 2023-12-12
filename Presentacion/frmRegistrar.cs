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
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
            msRegistrar.ForeColor = Color.White;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.msRegistrar.BackColor = Color.FromArgb(0, 123, 95);
            this.ActiveControl = label2;
        }

        private void msRegistrarInicio_Click(object sender, EventArgs e)
        {
            frmInicio inicioFrm = new frmInicio();
            this.Close();
            inicioFrm.Show();
        }

        private void msRegistrarRegistrar_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void msRegistrarModificarEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar eliminarFrm = new frmEliminar();
            this.Close();
            eliminarFrm.Show();
        }

        private void msRegistrarModificarActualizar_Click(object sender, EventArgs e)
        {
            frmActualizar actualizarFrm = new frmActualizar();
            this.Close();
            actualizarFrm.Show();
        }

        private void msRegistrarCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin loginFrm = new FrmLogin();
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Está seguro que desea salir?", "Centro de información", botones, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                loginFrm.ShowDialog();

            }
            if (dr == DialogResult.No)
            {

            }
        }

        private void txtMatricula_Click(object sender, EventArgs e)
        {
            txtMatricula.Text = string.Empty;
            txtMatricula.ForeColor = Color.Black;
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtNombre.ForeColor = Color.Black;
        }

        private void txtApP_Click(object sender, EventArgs e)
        {
            txtApP.Text = string.Empty;
            txtApP.ForeColor = Color.Black;
        }

        private void txtApM_Click(object sender, EventArgs e)
        {
            txtApM.Text = string.Empty;
            txtApM.ForeColor = Color.Black;
        }

        private void txtGrupo_Click(object sender, EventArgs e)
        {
            txtGrupo.Text = string.Empty;
            txtGrupo.ForeColor = Color.Black;
        }

        private void txtMatricula_Leave(object sender, EventArgs e)
        {
            if (txtMatricula.Text == string.Empty)
            {
                txtMatricula.Text = "Matricula";
                txtMatricula.ForeColor = Color.Gray;
            }
            
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty)
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Gray;
            }
           
        }

        private void txtApP_Leave(object sender, EventArgs e)
        {
            if (txtApP.Text == string.Empty)
            {
                txtApP.Text = "Apellido Paterno";
                txtApP.ForeColor = Color.Gray;
            }
            
        }

        private void txtApM_Leave(object sender, EventArgs e)
        {
            if (txtApM.Text == string.Empty)
            {
                txtApM.Text = "Apellido Materno";
                txtApM.ForeColor = Color.Gray;
            }
            
        }

        private void txtGrupo_Leave(object sender, EventArgs e)
        {
            if (txtGrupo.Text == string.Empty)
            {
                txtGrupo.Text = "Grupo";
                txtGrupo.ForeColor = Color.Gray;
            }
            
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 127||e.KeyChar==45||e.KeyChar==08||e.KeyChar==13)
            {

                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Caracter no valido", "Centro de informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)|| e.KeyChar == 32||e.KeyChar==08||e.KeyChar==127||e.KeyChar==13)
            {

                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se permiten letras", "Centro de informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtApP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)||e.KeyChar == 32||e.KeyChar==08||e.KeyChar==127||e.KeyChar==13)
            {

                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se permiten letras", "Centro de informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtApM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)|| e.KeyChar == 32||e.KeyChar==08||e.KeyChar==128||e.KeyChar==13)
            {

                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se permiten letras", "Centro de informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)||e.KeyChar==127||e.KeyChar==08||e.KeyChar==13)
            {
                e.Handled = false;
                if (e.KeyChar == (Char)(Keys.Enter))
                {
                    e.Handled = true;
                    btnRegistrar_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Solo se permiten números", "Centro de informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatricula.Text != "Matricula" && txtNombre.Text != "Nombre" && txtApP.Text != "Apellido Paterno" && txtApM.Text != "Apellido Materno" && txtGrupo.Text != "Grupo")
                {
                    GeneralModelo insertarAlumno = new GeneralModelo();
                    insertarAlumno.InsertarAlumnos(txtMatricula.Text, txtNombre.Text, txtApP.Text, txtApM.Text, txtGrupo.Text);
                    MessageBox.Show("Se insertó correctamente el registro");
                }
                else
                {
                    MessageBox.Show("Ningún campo debe estar vacío", "Centro de informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("No fue posible insertar los datos debido a: " + ex);

                txtNombre.Text = string.Empty;
                txtMatricula.Text = string.Empty;
                txtApM.Text = string.Empty;
                txtApP.Text = string.Empty;
                txtGrupo.Text = string.Empty;

            }
        }

        private void btnRegistrar_MouseHover(object sender, EventArgs e)
        {
            this.btnRegistrar.BackColor = Color.FromArgb(173, 209, 171);
        }

        private void btnRegistrar_MouseLeave(object sender, EventArgs e)
        {
            this.btnRegistrar.BackColor = Color.White;
        }

        private void msRegistrarVerHistorial_Click(object sender, EventArgs e)
        {
            frmVerHistorial verHistorialFrm = new frmVerHistorial();
            this.Close();
            verHistorialFrm.Show();
        }

        private void msRegistrarVerHistorial_Click_1(object sender, EventArgs e)
        {
            frmVerHistorial verHistorial = new frmVerHistorial();
            this.Close();
            verHistorial.Show();  
        }
    }

       
    }
