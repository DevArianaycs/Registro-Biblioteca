
namespace Presentacion
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.txtIngresarMatricula = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkInvitado = new System.Windows.Forms.CheckBox();
            this.cbxInvitado = new System.Windows.Forms.ComboBox();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.msInicioInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.msInicioVerHistorial = new System.Windows.Forms.ToolStripMenuItem();
            this.msInicioRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.msInicioModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.msInicioModificarEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.msInicioModificarActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.msInicioCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.lblValidacionMatricula = new System.Windows.Forms.Label();
            this.pbInicio = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIngresarMatricula
            // 
            this.txtIngresarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresarMatricula.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtIngresarMatricula.Location = new System.Drawing.Point(34, 54);
            this.txtIngresarMatricula.Name = "txtIngresarMatricula";
            this.txtIngresarMatricula.Size = new System.Drawing.Size(300, 31);
            this.txtIngresarMatricula.TabIndex = 0;
            this.txtIngresarMatricula.Text = "Matricula";
            this.txtIngresarMatricula.Click += new System.EventHandler(this.txtIngresarMatricula_Click);
            this.txtIngresarMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngresarMatricula_KeyPress);
            this.txtIngresarMatricula.Leave += new System.EventHandler(this.txtIngresarMatricula_Leave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(348, 54);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(108, 35);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.btnAceptar_MouseLeave);
            this.btnAceptar.MouseHover += new System.EventHandler(this.btnAceptar_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "CENTRO DE INFORMACIÓN";
            // 
            // chkInvitado
            // 
            this.chkInvitado.AutoSize = true;
            this.chkInvitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInvitado.Location = new System.Drawing.Point(34, 156);
            this.chkInvitado.Name = "chkInvitado";
            this.chkInvitado.Size = new System.Drawing.Size(106, 29);
            this.chkInvitado.TabIndex = 9;
            this.chkInvitado.Text = "Invitado";
            this.chkInvitado.UseVisualStyleBackColor = true;
            this.chkInvitado.CheckedChanged += new System.EventHandler(this.chkInvitado_CheckedChanged);
            // 
            // cbxInvitado
            // 
            this.cbxInvitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxInvitado.FormattingEnabled = true;
            this.cbxInvitado.Location = new System.Drawing.Point(156, 216);
            this.cbxInvitado.Name = "cbxInvitado";
            this.cbxInvitado.Size = new System.Drawing.Size(300, 33);
            this.cbxInvitado.TabIndex = 10;
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.SystemColors.Window;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msInicioInicio,
            this.msInicioVerHistorial,
            this.msInicioRegistrar,
            this.msInicioModificar,
            this.msInicioCerrarSesion});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1370, 28);
            this.msMenu.TabIndex = 11;
            this.msMenu.Text = "menuStrip1";
            // 
            // msInicioInicio
            // 
            this.msInicioInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msInicioInicio.Name = "msInicioInicio";
            this.msInicioInicio.Size = new System.Drawing.Size(58, 24);
            this.msInicioInicio.Text = "Inicio";
            this.msInicioInicio.Click += new System.EventHandler(this.msInicioInicio_Click);
            // 
            // msInicioVerHistorial
            // 
            this.msInicioVerHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msInicioVerHistorial.Name = "msInicioVerHistorial";
            this.msInicioVerHistorial.Size = new System.Drawing.Size(104, 24);
            this.msInicioVerHistorial.Text = "Ver historial";
            this.msInicioVerHistorial.Click += new System.EventHandler(this.msInicioVerHistorial_Click);
            // 
            // msInicioRegistrar
            // 
            this.msInicioRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msInicioRegistrar.Name = "msInicioRegistrar";
            this.msInicioRegistrar.Size = new System.Drawing.Size(86, 24);
            this.msInicioRegistrar.Text = "Registrar";
            this.msInicioRegistrar.Click += new System.EventHandler(this.msInicioRegistrar_Click);
            // 
            // msInicioModificar
            // 
            this.msInicioModificar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msInicioModificarEliminar,
            this.msInicioModificarActualizar});
            this.msInicioModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msInicioModificar.Name = "msInicioModificar";
            this.msInicioModificar.Size = new System.Drawing.Size(85, 24);
            this.msInicioModificar.Text = "Modificar";
            // 
            // msInicioModificarEliminar
            // 
            this.msInicioModificarEliminar.Name = "msInicioModificarEliminar";
            this.msInicioModificarEliminar.Size = new System.Drawing.Size(148, 24);
            this.msInicioModificarEliminar.Text = "Eliminar";
            this.msInicioModificarEliminar.Click += new System.EventHandler(this.msInicioModificarEliminar_Click);
            // 
            // msInicioModificarActualizar
            // 
            this.msInicioModificarActualizar.Name = "msInicioModificarActualizar";
            this.msInicioModificarActualizar.Size = new System.Drawing.Size(148, 24);
            this.msInicioModificarActualizar.Text = "Actualizar";
            this.msInicioModificarActualizar.Click += new System.EventHandler(this.msInicioModificarActualizar_Click);
            // 
            // msInicioCerrarSesion
            // 
            this.msInicioCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msInicioCerrarSesion.Name = "msInicioCerrarSesion";
            this.msInicioCerrarSesion.Size = new System.Drawing.Size(115, 24);
            this.msInicioCerrarSesion.Text = "Cerrar sesión";
            this.msInicioCerrarSesion.Click += new System.EventHandler(this.msInicioCerrarSesion_Click);
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupacion.Location = new System.Drawing.Point(29, 216);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(121, 25);
            this.lblOcupacion.TabIndex = 12;
            this.lblOcupacion.Text = "Ocupación:";
            // 
            // lblValidacionMatricula
            // 
            this.lblValidacionMatricula.AutoSize = true;
            this.lblValidacionMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidacionMatricula.ForeColor = System.Drawing.Color.DarkRed;
            this.lblValidacionMatricula.Location = new System.Drawing.Point(31, 100);
            this.lblValidacionMatricula.Name = "lblValidacionMatricula";
            this.lblValidacionMatricula.Size = new System.Drawing.Size(44, 20);
            this.lblValidacionMatricula.TabIndex = 13;
            this.lblValidacionMatricula.Text = "Error";
            this.lblValidacionMatricula.Visible = false;
            // 
            // pbInicio
            // 
            this.pbInicio.Image = global::Presentacion.Properties.Resources.logo_conalep;
            this.pbInicio.Location = new System.Drawing.Point(556, 145);
            this.pbInicio.Name = "pbInicio";
            this.pbInicio.Size = new System.Drawing.Size(314, 241);
            this.pbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInicio.TabIndex = 7;
            this.pbInicio.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBuscar.Location = new System.Drawing.Point(19, 34);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(563, 26);
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.Text = "Nombre";
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(95)))));
            this.dataGridView1.Location = new System.Drawing.Point(19, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(563, 176);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(712, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 267);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar alumno";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtIngresarMatricula);
            this.groupBox3.Controls.Add(this.lblValidacionMatricula);
            this.groupBox3.Controls.Add(this.cbxInvitado);
            this.groupBox3.Controls.Add(this.chkInvitado);
            this.groupBox3.Controls.Add(this.lblOcupacion);
            this.groupBox3.Controls.Add(this.btnAceptar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(186, 408);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 267);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registrar entrada";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de información";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIngresarMatricula;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbInicio;
        private System.Windows.Forms.CheckBox chkInvitado;
        private System.Windows.Forms.ComboBox cbxInvitado;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem msInicioInicio;
        private System.Windows.Forms.ToolStripMenuItem msInicioVerHistorial;
        private System.Windows.Forms.ToolStripMenuItem msInicioRegistrar;
        private System.Windows.Forms.ToolStripMenuItem msInicioModificar;
        private System.Windows.Forms.ToolStripMenuItem msInicioModificarEliminar;
        private System.Windows.Forms.ToolStripMenuItem msInicioModificarActualizar;
        private System.Windows.Forms.ToolStripMenuItem msInicioCerrarSesion;
        private System.Windows.Forms.Label lblOcupacion;
        private System.Windows.Forms.Label lblValidacionMatricula;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}