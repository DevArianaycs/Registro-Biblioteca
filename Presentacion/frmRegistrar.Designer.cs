
namespace Presentacion
{
    partial class frmRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrar));
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.txtApP = new System.Windows.Forms.TextBox();
            this.txtApM = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pbRegistrar = new System.Windows.Forms.PictureBox();
            this.msRegistrar = new System.Windows.Forms.MenuStrip();
            this.msRegistrarInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.msRegistrarVerHistorial = new System.Windows.Forms.ToolStripMenuItem();
            this.msRegistrarRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.msRegistrarModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.msRegistrarModificarEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.msRegistrarModificarActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.msRegistrarCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistrar)).BeginInit();
            this.msRegistrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "CENTRO DE INFORMACIÓN";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtMatricula.Location = new System.Drawing.Point(544, 308);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(326, 31);
            this.txtMatricula.TabIndex = 1;
            this.txtMatricula.Text = "Matricula";
            this.txtMatricula.Click += new System.EventHandler(this.txtMatricula_Click);
            this.txtMatricula.TextChanged += new System.EventHandler(this.txtMatricula_TextChanged);
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
            this.txtMatricula.Leave += new System.EventHandler(this.txtMatricula_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtNombre.Location = new System.Drawing.Point(544, 357);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(326, 31);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtGrupo
            // 
            this.txtGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrupo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtGrupo.Location = new System.Drawing.Point(544, 526);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(326, 31);
            this.txtGrupo.TabIndex = 5;
            this.txtGrupo.Text = "Grupo";
            this.txtGrupo.Click += new System.EventHandler(this.txtGrupo_Click);
            this.txtGrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrupo_KeyPress);
            this.txtGrupo.Leave += new System.EventHandler(this.txtGrupo_Leave);
            // 
            // txtApP
            // 
            this.txtApP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApP.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtApP.Location = new System.Drawing.Point(544, 410);
            this.txtApP.Name = "txtApP";
            this.txtApP.Size = new System.Drawing.Size(326, 31);
            this.txtApP.TabIndex = 3;
            this.txtApP.Text = "Apellido Paterno";
            this.txtApP.Click += new System.EventHandler(this.txtApP_Click);
            this.txtApP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApP_KeyPress);
            this.txtApP.Leave += new System.EventHandler(this.txtApP_Leave);
            // 
            // txtApM
            // 
            this.txtApM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApM.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtApM.Location = new System.Drawing.Point(544, 470);
            this.txtApM.Name = "txtApM";
            this.txtApM.Size = new System.Drawing.Size(326, 31);
            this.txtApM.TabIndex = 4;
            this.txtApM.Text = "Apellido Materno";
            this.txtApM.Click += new System.EventHandler(this.txtApM_Click);
            this.txtApM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApM_KeyPress);
            this.txtApM.Leave += new System.EventHandler(this.txtApM_Leave);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(648, 591);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(118, 40);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnRegistrar.MouseHover += new System.EventHandler(this.btnRegistrar_MouseHover);
            // 
            // pbRegistrar
            // 
            this.pbRegistrar.Image = global::Presentacion.Properties.Resources.logo_conalep;
            this.pbRegistrar.Location = new System.Drawing.Point(582, 126);
            this.pbRegistrar.Name = "pbRegistrar";
            this.pbRegistrar.Size = new System.Drawing.Size(208, 164);
            this.pbRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRegistrar.TabIndex = 8;
            this.pbRegistrar.TabStop = false;
            // 
            // msRegistrar
            // 
            this.msRegistrar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msRegistrarInicio,
            this.msRegistrarVerHistorial,
            this.msRegistrarRegistrar,
            this.msRegistrarModificar,
            this.msRegistrarCerrarSesion});
            this.msRegistrar.Location = new System.Drawing.Point(0, 0);
            this.msRegistrar.Name = "msRegistrar";
            this.msRegistrar.Size = new System.Drawing.Size(1134, 28);
            this.msRegistrar.TabIndex = 16;
            this.msRegistrar.Text = "menuStrip1";
            // 
            // msRegistrarInicio
            // 
            this.msRegistrarInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msRegistrarInicio.Name = "msRegistrarInicio";
            this.msRegistrarInicio.Size = new System.Drawing.Size(58, 24);
            this.msRegistrarInicio.Text = "Inicio";
            this.msRegistrarInicio.Click += new System.EventHandler(this.msRegistrarInicio_Click);
            // 
            // msRegistrarVerHistorial
            // 
            this.msRegistrarVerHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msRegistrarVerHistorial.Name = "msRegistrarVerHistorial";
            this.msRegistrarVerHistorial.Size = new System.Drawing.Size(104, 24);
            this.msRegistrarVerHistorial.Text = "Ver historial";
            this.msRegistrarVerHistorial.Click += new System.EventHandler(this.msRegistrarVerHistorial_Click_1);
            // 
            // msRegistrarRegistrar
            // 
            this.msRegistrarRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msRegistrarRegistrar.Name = "msRegistrarRegistrar";
            this.msRegistrarRegistrar.Size = new System.Drawing.Size(86, 24);
            this.msRegistrarRegistrar.Text = "Registrar";
            this.msRegistrarRegistrar.Click += new System.EventHandler(this.msRegistrarRegistrar_Click);
            // 
            // msRegistrarModificar
            // 
            this.msRegistrarModificar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msRegistrarModificarEliminar,
            this.msRegistrarModificarActualizar});
            this.msRegistrarModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msRegistrarModificar.Name = "msRegistrarModificar";
            this.msRegistrarModificar.Size = new System.Drawing.Size(85, 24);
            this.msRegistrarModificar.Text = "Modificar";
            // 
            // msRegistrarModificarEliminar
            // 
            this.msRegistrarModificarEliminar.Name = "msRegistrarModificarEliminar";
            this.msRegistrarModificarEliminar.Size = new System.Drawing.Size(148, 24);
            this.msRegistrarModificarEliminar.Text = "Eliminar";
            this.msRegistrarModificarEliminar.Click += new System.EventHandler(this.msRegistrarModificarEliminar_Click);
            // 
            // msRegistrarModificarActualizar
            // 
            this.msRegistrarModificarActualizar.Name = "msRegistrarModificarActualizar";
            this.msRegistrarModificarActualizar.Size = new System.Drawing.Size(148, 24);
            this.msRegistrarModificarActualizar.Text = "Actualizar";
            this.msRegistrarModificarActualizar.Click += new System.EventHandler(this.msRegistrarModificarActualizar_Click);
            // 
            // msRegistrarCerrarSesion
            // 
            this.msRegistrarCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msRegistrarCerrarSesion.Name = "msRegistrarCerrarSesion";
            this.msRegistrarCerrarSesion.Size = new System.Drawing.Size(115, 24);
            this.msRegistrarCerrarSesion.Text = "Cerrar sesión";
            this.msRegistrarCerrarSesion.Click += new System.EventHandler(this.msRegistrarCerrarSesion_Click);
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 677);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtApM);
            this.Controls.Add(this.txtApP);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbRegistrar);
            this.Controls.Add(this.msRegistrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrar";
            this.Text = "Centro de información";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistrar)).EndInit();
            this.msRegistrar.ResumeLayout(false);
            this.msRegistrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRegistrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.TextBox txtApP;
        private System.Windows.Forms.TextBox txtApM;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.MenuStrip msRegistrar;
        private System.Windows.Forms.ToolStripMenuItem msRegistrarInicio;
        private System.Windows.Forms.ToolStripMenuItem msRegistrarVerHistorial;
        private System.Windows.Forms.ToolStripMenuItem msRegistrarRegistrar;
        private System.Windows.Forms.ToolStripMenuItem msRegistrarModificar;
        private System.Windows.Forms.ToolStripMenuItem msRegistrarModificarEliminar;
        private System.Windows.Forms.ToolStripMenuItem msRegistrarModificarActualizar;
        private System.Windows.Forms.ToolStripMenuItem msRegistrarCerrarSesion;
    }
}