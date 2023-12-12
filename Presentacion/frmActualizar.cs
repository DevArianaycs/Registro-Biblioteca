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
    public partial class frmActualizar : Form
    {
        public frmActualizar()
        {
            InitializeComponent();
            msActualizarInicio.ForeColor = Color.White;
            msActualizarVerHistorial.ForeColor = Color.White;
            msActualizarRegistrar.ForeColor = Color.White;
            msActualizarModificar.ForeColor = Color.White;
            msActualizarCerrarSesión.ForeColor = Color.White;
        }

        private void frmActualizar_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            this.msActualizar.BackColor = Color.FromArgb(0, 123, 95);
            this.msActualizarInicio.BackColor = Color.FromArgb(0,123,95);
            this.ActiveControl = label2;
        }

        private void msActualizarInicio_Click(object sender, EventArgs e)
        {
            frmInicio inicioFrm = new frmInicio();
            this.Close();
            inicioFrm.Show();
        }

        private void msActualizarRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrar registrarFrm = new frmRegistrar();
            this.Close();
            registrarFrm.Show();
        }

        private void msActualizarModificarEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar eliminarFrm = new frmEliminar();
            this.Close();
            eliminarFrm.Show();
        }

        private void msActualizarModificarActualizar_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void msActualizarCerrarSesión_Click(object sender, EventArgs e)
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

        private void txtMatriculaActualizar_Click(object sender, EventArgs e)
        {
            txtMatriculaActualizar.Text = string.Empty;
            txtMatriculaActualizar.ForeColor = Color.Black;
        }

        private void txtMatriculaActualizar_Leave(object sender, EventArgs e)
        {
            if (txtMatriculaActualizar.Text == string.Empty)
            {
                txtMatriculaActualizar.Text = "Matricula";
                txtMatriculaActualizar.ForeColor = Color.Gray;
            }
        }

        private void txtGrupoActualizar_Click(object sender, EventArgs e)
        {
            txtGrupoActualizar.Text = string.Empty;
            txtGrupoActualizar.ForeColor = Color.Black;
        }

        private void txtGrupoActualCompleto_Click(object sender, EventArgs e)
        {
            txtGrupoActualCompleto.Text = string.Empty;
            txtGrupoActualCompleto.ForeColor = Color.Black;
        }

        private void txtNuevoGrupoCompleto_Click(object sender, EventArgs e)
        {
            txtNuevoGrupoCompleto.Text = string.Empty;
            txtNuevoGrupoCompleto.ForeColor = Color.Black;
        }

        private void txtGrupoActualizar_Leave(object sender, EventArgs e)
        {
            if (txtGrupoActualizar.Text == string.Empty)
            {
                txtGrupoActualizar.Text = "Nuevo grupo";
                txtGrupoActualizar.ForeColor = Color.Gray;
            }
        }

        private void txtGrupoActualCompleto_Leave(object sender, EventArgs e)
        {
            if (txtGrupoActualCompleto.Text == string.Empty)
            {
                txtGrupoActualCompleto.Text = "Grupo";
                txtGrupoActualCompleto.ForeColor = Color.Gray;
            }
        }

        private void txtNuevoGrupoCompleto_Leave(object sender, EventArgs e)
        {
            if (txtNuevoGrupoCompleto.Text == string.Empty)
            {
                txtNuevoGrupoCompleto.Text = "Nuevo grupo";
                txtNuevoGrupoCompleto.ForeColor = Color.Gray;
            }
        }

        private void txtMatriculaActualizar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 08 || e.KeyChar == 45 || e.KeyChar == 127||e.KeyChar==13)
            {

                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Caracter no valido", "Centro de informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtGrupoActualizar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 08 || e.KeyChar == 127||e.KeyChar==13)
            {

                e.Handled = false;
                if (e.KeyChar == (Char)(Keys.Enter))
                {
                    e.Handled = true;
                    btnActualizarPorAlumno_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Solo se permiten números", "Centro de informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtGrupoActualCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 08 || e.KeyChar == 127||e.KeyChar==13)
            {

                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se permiten números", "Centro de informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtNuevoGrupoCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 08 || e.KeyChar == 127||e.KeyChar==13)
            {

                e.Handled = false;
                if (e.KeyChar == (Char)(Keys.Enter))
                {
                    e.Handled = true;
                    btnActualizarGrupoCompleto_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Solo se permiten números", "Centro de informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void btnActualizarPorAlumno_Click(object sender, EventArgs e)
        {
            if (txtMatriculaActualizar.Text != "Matricula" && txtGrupoActualizar.Text != "Nuevo grupo")
            {
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult dr = MessageBox.Show("¿Está seguro que desea actualizar el grupo?", "Centro de información", botones, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    GeneralModelo ActualizarGrupo1 = new GeneralModelo();
                    ActualizarGrupo1.EditarAlumnoPorGrupo(txtMatriculaActualizar.Text, txtGrupoActualizar.Text);

                }
                if (dr == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Ningún campo debe estar vacío");
            }
        }

        private void btnActualizarGrupoCompleto_Click(object sender, EventArgs e)
        {
            if (txtGrupoActualCompleto.Text != "Grupo" && txtNuevoGrupoCompleto.Text != "Nuevo grupo")
            {
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult dr = MessageBox.Show("¿Está seguro que desea actualizar el grupo?", "Centro de información", botones, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    GeneralModelo ActualizarGrupo2 = new GeneralModelo();
                    ActualizarGrupo2.EditarGrupoCompleto(txtGrupoActualCompleto.Text, txtNuevoGrupoCompleto.Text);
                    MessageBox.Show("Grupo Actualizado");  
                }
                if (dr == DialogResult.No)
                {
                }
            }
            else
            {
                MessageBox.Show("Ningún campo debe estar vacío");
            }
        }
        private void btnActualizarPorAlumno_MouseHover(object sender, EventArgs e)
        {
            this.btnActualizarPorAlumno.BackColor = Color.FromArgb(173, 209, 171);
        }

        private void btnActualizarGrupoCompleto_MouseHover(object sender, EventArgs e)
        {
            this.btnActualizarGrupoCompleto.BackColor = Color.FromArgb(173, 209, 171);
        }

        private void btnActualizarGrupoCompleto_MouseLeave(object sender, EventArgs e)
        {
            this.btnActualizarGrupoCompleto.BackColor = Color.White;
        }

        private void btnActualizarPorAlumno_MouseLeave(object sender, EventArgs e)
        {
            this.btnActualizarPorAlumno.BackColor = Color.White;
        }

        private void msActualizarVerHistorial_Click(object sender, EventArgs e)
        {
            frmVerHistorial verHistorialFrm = new frmVerHistorial();
            this.Close();
            verHistorialFrm.Show();
        }
    }
}
