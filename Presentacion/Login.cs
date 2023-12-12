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

    public partial class FrmLogin : Form
    {

        
        public FrmLogin()
        {
            InitializeComponent();
            
            
        }
        #region textCahnged
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.ForeColor = Color.Black;
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            txtContrasena.ForeColor = Color.Black;
            txtContrasena.MaxLength = 10;
            txtContrasena.PasswordChar = '*';
        }

        #endregion

        frmInicio iniciofrm = new frmInicio();

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = string.Empty;
            txtUsuario.ForeColor = Color.Black;
            
        }

        private void txtContrasena_Click(object sender, EventArgs e)
        {
            txtContrasena.Text = string.Empty;
            txtContrasena.ForeColor = Color.Black;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text==string.Empty)
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
            
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == string.Empty)
            {
                txtContrasena.Text = "Contraseña";
                txtContrasena.UseSystemPasswordChar = false;
                txtContrasena.PasswordChar = Char.MinValue;
                txtContrasena.ForeColor = Color.Gray;
            }
            
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(Char)(Keys.Enter))
            {
                e.Handled = true;
                btnIngresar_Click(sender, e);
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "Usuario")
            {
                if (txtContrasena.Text != "Contraseña")
                {
                    GeneralModelo usuario = new GeneralModelo();
                    var validLogin = usuario.LoginUser(txtUsuario.Text, txtContrasena.Text);
                    if (validLogin==true)
                    {
                        iniciofrm.Show();
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario o contraseña incorrecto.\n        Intenta nuevamente");
                        txtContrasena.Clear();
                        txtUsuario.Focus();
                    }
                }
                else msgError("Porfavor, ingresa tu contraseña");
            }
            else msgError("Porfavor, ingresa tu usuario");
           
                //this.Hide();
                //iniciofrm.Show();
            
        }
        private void msgError(string msg)
        {
            lblLogin.Text = "" + msg;
            lblLogin.Visible = true;
        }

        private void txtUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 08||e.KeyChar==127||e.KeyChar==13)
            {

                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se permiten letras y números", "Centro de informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            this.btnIngresar.BackColor = Color.FromArgb(173, 209, 171);
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            this.btnIngresar.BackColor = Color.White;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

        }
    }
}
