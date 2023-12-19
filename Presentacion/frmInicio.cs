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
    public partial class frmInicio : Form

    {
        public frmInicio()
        {
            InitializeComponent();
            cbxInvitado.Items.Add("Alumno Invitado");
            cbxInvitado.Items.Add("Docente");
            cbxInvitado.Items.Add("Administrativo");
            cbxInvitado.Items.Add("Otro");
            msMenu.ForeColor = Color.White;
            
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.WindowState = FormWindowState.Maximized;
            cbxInvitado.Enabled = false;
            this.msMenu.BackColor = Color.FromArgb(0,123,95);
            this.ActiveControl = label2;
        }
        private void msInicioInicio_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        private void msInicioRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrar registrarFrm = new frmRegistrar();
            this.Close();
            registrarFrm.Show();
        }
        private void msInicioModificarEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar eliminarFrm = new frmEliminar();
            this.Close();
            eliminarFrm.Show();
        }
        private void msInicioModificarActualizar_Click(object sender, EventArgs e)
        {
            frmActualizar actualizarFrm = new frmActualizar();
            this.Close();
            actualizarFrm.Show();
        }
        private void msInicioCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin loginFrm = new FrmLogin();
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Centro de información", botones, MessageBoxIcon.Question);
            if (dr==DialogResult.Yes)
            {
                this.Close();
                loginFrm.ShowDialog();
            }
            if (dr==DialogResult.No)
            {
            }
        }
        private void txtIngresarMatricula_Click(object sender, EventArgs e)
        {
            txtIngresarMatricula.Text = string.Empty;
            txtIngresarMatricula.ForeColor = Color.Black;
            if (txtIngresarMatricula.Text != "Matricula")
            {
            }
            else msgError("Ingresa la matricula");
        }
        private void msgError(string msg)
        {
            lblValidacionMatricula.Text = "" + msg;
            lblValidacionMatricula.Visible = true;
        }
        private void txtIngresarMatricula_Leave(object sender, EventArgs e)
        {
            if (txtIngresarMatricula.Text == string.Empty)
            {
                txtIngresarMatricula.Text = "Matricula";
                txtIngresarMatricula.ForeColor = Color.Gray;
            }   
        }
        private void txtIngresarMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (chkInvitado.Checked == false)
            {
                if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 08 || e.KeyChar == 45 || e.KeyChar == 127||e.KeyChar==13)
                {
                    e.Handled = false;
                    if (e.KeyChar == (Char)(Keys.Enter))
                    {
                        e.Handled = true;
                        btnAceptar_Click(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Caracter no valido", "Centro de informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                }
            }
            if (chkInvitado.Checked == true)
            {
                if (char.IsLetter(e.KeyChar) || e.KeyChar == 32 || e.KeyChar == 08 || e.KeyChar == 127||e.KeyChar==13)
                {
                    e.Handled = false;
                    if (e.KeyChar == (Char)(Keys.Enter))
                    {
                        e.Handled = true;
                        btnAceptar_Click(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Solo se permiten letras", "Centro de informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                }
            }
        }
        private void chkInvitado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInvitado.Checked==true)
            {     
                cbxInvitado.Enabled = true;
                txtIngresarMatricula.Text = "Nombre Completo";
                txtIngresarMatricula.ForeColor = Color.Gray;             
                cbxInvitado.DropDownStyle = ComboBoxStyle.DropDownList;
                txtBuscar.Enabled = false;
                dataGridView1.Enabled = false;
            }
            if (chkInvitado.Checked==false)
            {
                cbxInvitado.SelectedIndex = -1;
                cbxInvitado.Enabled = false;
                txtIngresarMatricula.Text = "Matricula";
                txtIngresarMatricula.ForeColor = Color.Gray;
                txtBuscar.Enabled = true;
                dataGridView1.Enabled = true;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {           
            if (chkInvitado.Checked == true)
            {
                msgErrorInicio(" ");
                try
                {
                    if (txtIngresarMatricula.Text!="Nombre Completo" && cbxInvitado?.SelectedIndex>=0)
                    {  
                            GeneralModelo insertarInvitado = new GeneralModelo();
                            insertarInvitado.InsertarDatosTablaInvitado(txtIngresarMatricula.Text, cbxInvitado.SelectedItem.ToString());
                            MessageBox.Show("Gracias por visitarnos");
                        cbxInvitado.SelectedItem = -1;
                    }
                    else
                    {
                        if (txtIngresarMatricula.Text=="Nombre Completo")
                        {
                            msgErrorInicio("Ingresa el nombre");
                        }
                        if (cbxInvitado?.SelectedIndex >= 0||txtIngresarMatricula.Text=="Nombre Completo")
                        {
                            msgErrorInicio("Ingresa el nombre");
                        }
                        else
                        {
                            msgErrorInicio("Selecciona una ocupación");
                        }
                    }       
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }  
             if (chkInvitado.Checked==false)
                {
                msgErrorInicio(" ");
                if (txtIngresarMatricula.Text!="Matricula")
                {
                    try
                    {
                        GeneralModelo validarMatricula = new GeneralModelo();
                        validarMatricula.InsertarMatricula(txtIngresarMatricula.Text);
                        validarMatricula.InsertarRegistroAlumno(txtIngresarMatricula.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    msgErrorInicio("Ingresa la matricula");
                }
                txtIngresarMatricula.Text = string.Empty;  
            }  
        }
        private void msgErrorInicio(string msg)
        {
            lblValidacionMatricula.Text = "" + msg;
            lblValidacionMatricula.Visible = true;
        }
        private void btnAceptar_MouseHover(object sender, EventArgs e)
        {
            this.btnAceptar.BackColor=Color.FromArgb(173, 209, 171);
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            this.btnAceptar.BackColor = Color.White;
        }

        private void msInicioInicio_MouseHover(object sender, EventArgs e)
        {
            msInicioInicio.ForeColor = Color.Black;
        }

        private void msInicioVerHistorial_Click(object sender, EventArgs e)
        {
            frmVerHistorial verHistorialFrm = new frmVerHistorial();
            this.Close();
            verHistorialFrm.Show();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            GeneralModelo generalModelo = new GeneralModelo();
            txtBuscar.ForeColor = Color.Black;
            dataGridView1.DataSource = generalModelo.Buscar(txtBuscar.Text);
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = string.Empty;
            cbxInvitado.Enabled = false; 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIngresarMatricula.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtIngresarMatricula.ForeColor = Color.Black;
            txtBuscar.ForeColor = Color.Black;
            
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
