
namespace Presentacion
{
    partial class frmEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminar));
            this.pbActualizar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbEliminarAlumno = new System.Windows.Forms.GroupBox();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.msEliminar = new System.Windows.Forms.MenuStrip();
            this.msEliminarInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.msEliminarVerHistorial = new System.Windows.Forms.ToolStripMenuItem();
            this.msEliminarRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.msEliminarModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.msEliminarModificarEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.msEliminarModificarActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.msEliminarCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).BeginInit();
            this.gbEliminarAlumno.SuspendLayout();
            this.msEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbActualizar
            // 
            this.pbActualizar.Image = global::Presentacion.Properties.Resources.logo_conalep;
            this.pbActualizar.Location = new System.Drawing.Point(536, 182);
            this.pbActualizar.Name = "pbActualizar";
            this.pbActualizar.Size = new System.Drawing.Size(314, 241);
            this.pbActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbActualizar.TabIndex = 8;
            this.pbActualizar.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "CENTRO DE INFORMACIÓN";
            // 
            // gbEliminarAlumno
            // 
            this.gbEliminarAlumno.Controls.Add(this.btnEliminarAlumno);
            this.gbEliminarAlumno.Controls.Add(this.textBox1);
            this.gbEliminarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEliminarAlumno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbEliminarAlumno.Location = new System.Drawing.Point(442, 464);
            this.gbEliminarAlumno.Name = "gbEliminarAlumno";
            this.gbEliminarAlumno.Size = new System.Drawing.Size(494, 194);
            this.gbEliminarAlumno.TabIndex = 11;
            this.gbEliminarAlumno.TabStop = false;
            this.gbEliminarAlumno.Text = "Eliminar alumno";
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.Location = new System.Drawing.Point(196, 141);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(105, 33);
            this.btnEliminarAlumno.TabIndex = 2;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            this.btnEliminarAlumno.MouseLeave += new System.EventHandler(this.btnEliminarAlumno_MouseLeave);
            this.btnEliminarAlumno.MouseHover += new System.EventHandler(this.btnEliminarAlumno_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(140, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Matricula";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // msEliminar
            // 
            this.msEliminar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msEliminarInicio,
            this.msEliminarVerHistorial,
            this.msEliminarRegistrar,
            this.msEliminarModificar,
            this.msEliminarCerrarSesion});
            this.msEliminar.Location = new System.Drawing.Point(0, 0);
            this.msEliminar.Name = "msEliminar";
            this.msEliminar.Size = new System.Drawing.Size(1134, 28);
            this.msEliminar.TabIndex = 12;
            this.msEliminar.Text = "menuStrip1";
            // 
            // msEliminarInicio
            // 
            this.msEliminarInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msEliminarInicio.Name = "msEliminarInicio";
            this.msEliminarInicio.Size = new System.Drawing.Size(58, 24);
            this.msEliminarInicio.Text = "Inicio";
            this.msEliminarInicio.Click += new System.EventHandler(this.msEliminarInicio_Click);
            // 
            // msEliminarVerHistorial
            // 
            this.msEliminarVerHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msEliminarVerHistorial.Name = "msEliminarVerHistorial";
            this.msEliminarVerHistorial.Size = new System.Drawing.Size(104, 24);
            this.msEliminarVerHistorial.Text = "Ver historial";
            this.msEliminarVerHistorial.Click += new System.EventHandler(this.msEliminarVerHistorial_Click);
            // 
            // msEliminarRegistrar
            // 
            this.msEliminarRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msEliminarRegistrar.Name = "msEliminarRegistrar";
            this.msEliminarRegistrar.Size = new System.Drawing.Size(86, 24);
            this.msEliminarRegistrar.Text = "Registrar";
            this.msEliminarRegistrar.Click += new System.EventHandler(this.msEliminarRegistrar_Click);
            // 
            // msEliminarModificar
            // 
            this.msEliminarModificar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msEliminarModificarEliminar,
            this.msEliminarModificarActualizar});
            this.msEliminarModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msEliminarModificar.Name = "msEliminarModificar";
            this.msEliminarModificar.Size = new System.Drawing.Size(85, 24);
            this.msEliminarModificar.Text = "Modificar";
            // 
            // msEliminarModificarEliminar
            // 
            this.msEliminarModificarEliminar.Name = "msEliminarModificarEliminar";
            this.msEliminarModificarEliminar.Size = new System.Drawing.Size(148, 24);
            this.msEliminarModificarEliminar.Text = "Eliminar";
            this.msEliminarModificarEliminar.Click += new System.EventHandler(this.msEliminarModificarEliminar_Click);
            // 
            // msEliminarModificarActualizar
            // 
            this.msEliminarModificarActualizar.Name = "msEliminarModificarActualizar";
            this.msEliminarModificarActualizar.Size = new System.Drawing.Size(148, 24);
            this.msEliminarModificarActualizar.Text = "Actualizar";
            this.msEliminarModificarActualizar.Click += new System.EventHandler(this.msEliminarModificarActualizar_Click);
            // 
            // msEliminarCerrarSesion
            // 
            this.msEliminarCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msEliminarCerrarSesion.Name = "msEliminarCerrarSesion";
            this.msEliminarCerrarSesion.Size = new System.Drawing.Size(115, 24);
            this.msEliminarCerrarSesion.Text = "Cerrar sesión";
            this.msEliminarCerrarSesion.Click += new System.EventHandler(this.msEliminarCerrarSesion_Click);
            // 
            // frmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 749);
            this.Controls.Add(this.gbEliminarAlumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbActualizar);
            this.Controls.Add(this.msEliminar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msEliminar;
            this.Name = "frmEliminar";
            this.Text = "Centro de información";
            this.Load += new System.EventHandler(this.FrmActualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).EndInit();
            this.gbEliminarAlumno.ResumeLayout(false);
            this.gbEliminarAlumno.PerformLayout();
            this.msEliminar.ResumeLayout(false);
            this.msEliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbActualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbEliminarAlumno;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.MenuStrip msEliminar;
        private System.Windows.Forms.ToolStripMenuItem msEliminarInicio;
        private System.Windows.Forms.ToolStripMenuItem msEliminarVerHistorial;
        private System.Windows.Forms.ToolStripMenuItem msEliminarRegistrar;
        private System.Windows.Forms.ToolStripMenuItem msEliminarModificar;
        private System.Windows.Forms.ToolStripMenuItem msEliminarModificarEliminar;
        private System.Windows.Forms.ToolStripMenuItem msEliminarModificarActualizar;
        private System.Windows.Forms.ToolStripMenuItem msEliminarCerrarSesion;
    }
}