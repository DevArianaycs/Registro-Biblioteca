
namespace Presentacion
{
    partial class frmActualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizar));
            this.gbActualizarGrupo = new System.Windows.Forms.GroupBox();
            this.gbCompleto = new System.Windows.Forms.GroupBox();
            this.btnActualizarGrupoCompleto = new System.Windows.Forms.Button();
            this.txtNuevoGrupoCompleto = new System.Windows.Forms.TextBox();
            this.txtGrupoActualCompleto = new System.Windows.Forms.TextBox();
            this.gbPorAlumno = new System.Windows.Forms.GroupBox();
            this.btnActualizarPorAlumno = new System.Windows.Forms.Button();
            this.txtGrupoActualizar = new System.Windows.Forms.TextBox();
            this.txtMatriculaActualizar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.msActualizar = new System.Windows.Forms.MenuStrip();
            this.msActualizarInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.msActualizarVerHistorial = new System.Windows.Forms.ToolStripMenuItem();
            this.msActualizarRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.msActualizarModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.msActualizarModificarEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.msActualizarModificarActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.msActualizarCerrarSesión = new System.Windows.Forms.ToolStripMenuItem();
            this.pbActualizar = new System.Windows.Forms.PictureBox();
            this.gbActualizarGrupo.SuspendLayout();
            this.gbCompleto.SuspendLayout();
            this.gbPorAlumno.SuspendLayout();
            this.msActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbActualizarGrupo
            // 
            this.gbActualizarGrupo.Controls.Add(this.gbCompleto);
            this.gbActualizarGrupo.Controls.Add(this.gbPorAlumno);
            this.gbActualizarGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActualizarGrupo.Location = new System.Drawing.Point(412, 319);
            this.gbActualizarGrupo.Name = "gbActualizarGrupo";
            this.gbActualizarGrupo.Size = new System.Drawing.Size(590, 340);
            this.gbActualizarGrupo.TabIndex = 0;
            this.gbActualizarGrupo.TabStop = false;
            this.gbActualizarGrupo.Text = "Actualizar Grupo";
            // 
            // gbCompleto
            // 
            this.gbCompleto.Controls.Add(this.btnActualizarGrupoCompleto);
            this.gbCompleto.Controls.Add(this.txtNuevoGrupoCompleto);
            this.gbCompleto.Controls.Add(this.txtGrupoActualCompleto);
            this.gbCompleto.Location = new System.Drawing.Point(302, 64);
            this.gbCompleto.Name = "gbCompleto";
            this.gbCompleto.Size = new System.Drawing.Size(241, 227);
            this.gbCompleto.TabIndex = 1;
            this.gbCompleto.TabStop = false;
            this.gbCompleto.Text = "Grupo completo";
            // 
            // btnActualizarGrupoCompleto
            // 
            this.btnActualizarGrupoCompleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarGrupoCompleto.Location = new System.Drawing.Point(53, 158);
            this.btnActualizarGrupoCompleto.Name = "btnActualizarGrupoCompleto";
            this.btnActualizarGrupoCompleto.Size = new System.Drawing.Size(120, 36);
            this.btnActualizarGrupoCompleto.TabIndex = 6;
            this.btnActualizarGrupoCompleto.Text = "Actualizar";
            this.btnActualizarGrupoCompleto.UseVisualStyleBackColor = true;
            this.btnActualizarGrupoCompleto.Click += new System.EventHandler(this.btnActualizarGrupoCompleto_Click);
            this.btnActualizarGrupoCompleto.MouseLeave += new System.EventHandler(this.btnActualizarGrupoCompleto_MouseLeave);
            this.btnActualizarGrupoCompleto.MouseHover += new System.EventHandler(this.btnActualizarGrupoCompleto_MouseHover);
            // 
            // txtNuevoGrupoCompleto
            // 
            this.txtNuevoGrupoCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoGrupoCompleto.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtNuevoGrupoCompleto.Location = new System.Drawing.Point(33, 94);
            this.txtNuevoGrupoCompleto.Name = "txtNuevoGrupoCompleto";
            this.txtNuevoGrupoCompleto.Size = new System.Drawing.Size(175, 31);
            this.txtNuevoGrupoCompleto.TabIndex = 5;
            this.txtNuevoGrupoCompleto.Text = "Nuevo grupo";
            this.txtNuevoGrupoCompleto.Click += new System.EventHandler(this.txtNuevoGrupoCompleto_Click);
            this.txtNuevoGrupoCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNuevoGrupoCompleto_KeyPress);
            this.txtNuevoGrupoCompleto.Leave += new System.EventHandler(this.txtNuevoGrupoCompleto_Leave);
            // 
            // txtGrupoActualCompleto
            // 
            this.txtGrupoActualCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrupoActualCompleto.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtGrupoActualCompleto.Location = new System.Drawing.Point(33, 48);
            this.txtGrupoActualCompleto.Name = "txtGrupoActualCompleto";
            this.txtGrupoActualCompleto.Size = new System.Drawing.Size(175, 31);
            this.txtGrupoActualCompleto.TabIndex = 4;
            this.txtGrupoActualCompleto.Text = "Grupo";
            this.txtGrupoActualCompleto.Click += new System.EventHandler(this.txtGrupoActualCompleto_Click);
            this.txtGrupoActualCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrupoActualCompleto_KeyPress);
            this.txtGrupoActualCompleto.Leave += new System.EventHandler(this.txtGrupoActualCompleto_Leave);
            // 
            // gbPorAlumno
            // 
            this.gbPorAlumno.Controls.Add(this.btnActualizarPorAlumno);
            this.gbPorAlumno.Controls.Add(this.txtGrupoActualizar);
            this.gbPorAlumno.Controls.Add(this.txtMatriculaActualizar);
            this.gbPorAlumno.Location = new System.Drawing.Point(33, 64);
            this.gbPorAlumno.Name = "gbPorAlumno";
            this.gbPorAlumno.Size = new System.Drawing.Size(239, 227);
            this.gbPorAlumno.TabIndex = 0;
            this.gbPorAlumno.TabStop = false;
            this.gbPorAlumno.Text = "Por alumno";
            // 
            // btnActualizarPorAlumno
            // 
            this.btnActualizarPorAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarPorAlumno.Location = new System.Drawing.Point(51, 158);
            this.btnActualizarPorAlumno.Name = "btnActualizarPorAlumno";
            this.btnActualizarPorAlumno.Size = new System.Drawing.Size(125, 36);
            this.btnActualizarPorAlumno.TabIndex = 3;
            this.btnActualizarPorAlumno.Text = "Actualizar";
            this.btnActualizarPorAlumno.UseVisualStyleBackColor = true;
            this.btnActualizarPorAlumno.Click += new System.EventHandler(this.btnActualizarPorAlumno_Click);
            this.btnActualizarPorAlumno.MouseLeave += new System.EventHandler(this.btnActualizarPorAlumno_MouseLeave);
            this.btnActualizarPorAlumno.MouseHover += new System.EventHandler(this.btnActualizarPorAlumno_MouseHover);
            // 
            // txtGrupoActualizar
            // 
            this.txtGrupoActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrupoActualizar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtGrupoActualizar.Location = new System.Drawing.Point(34, 94);
            this.txtGrupoActualizar.Name = "txtGrupoActualizar";
            this.txtGrupoActualizar.Size = new System.Drawing.Size(175, 31);
            this.txtGrupoActualizar.TabIndex = 2;
            this.txtGrupoActualizar.Text = "Nuevo grupo";
            this.txtGrupoActualizar.Click += new System.EventHandler(this.txtGrupoActualizar_Click);
            this.txtGrupoActualizar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrupoActualizar_KeyPress);
            this.txtGrupoActualizar.Leave += new System.EventHandler(this.txtGrupoActualizar_Leave);
            // 
            // txtMatriculaActualizar
            // 
            this.txtMatriculaActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatriculaActualizar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtMatriculaActualizar.Location = new System.Drawing.Point(34, 48);
            this.txtMatriculaActualizar.Name = "txtMatriculaActualizar";
            this.txtMatriculaActualizar.Size = new System.Drawing.Size(175, 31);
            this.txtMatriculaActualizar.TabIndex = 1;
            this.txtMatriculaActualizar.Text = "Matricula";
            this.txtMatriculaActualizar.Click += new System.EventHandler(this.txtMatriculaActualizar_Click);
            this.txtMatriculaActualizar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatriculaActualizar_KeyPress);
            this.txtMatriculaActualizar.Leave += new System.EventHandler(this.txtMatriculaActualizar_Leave);
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
            // msActualizar
            // 
            this.msActualizar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msActualizarInicio,
            this.msActualizarVerHistorial,
            this.msActualizarRegistrar,
            this.msActualizarModificar,
            this.msActualizarCerrarSesión});
            this.msActualizar.Location = new System.Drawing.Point(0, 0);
            this.msActualizar.Name = "msActualizar";
            this.msActualizar.Size = new System.Drawing.Size(1370, 28);
            this.msActualizar.TabIndex = 12;
            this.msActualizar.Text = "menuStrip1";
            // 
            // msActualizarInicio
            // 
            this.msActualizarInicio.BackColor = System.Drawing.SystemColors.Window;
            this.msActualizarInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msActualizarInicio.ForeColor = System.Drawing.Color.Black;
            this.msActualizarInicio.Name = "msActualizarInicio";
            this.msActualizarInicio.Size = new System.Drawing.Size(58, 24);
            this.msActualizarInicio.Text = "Inicio";
            this.msActualizarInicio.Click += new System.EventHandler(this.msActualizarInicio_Click);
            // 
            // msActualizarVerHistorial
            // 
            this.msActualizarVerHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msActualizarVerHistorial.ForeColor = System.Drawing.Color.Black;
            this.msActualizarVerHistorial.Name = "msActualizarVerHistorial";
            this.msActualizarVerHistorial.Size = new System.Drawing.Size(104, 24);
            this.msActualizarVerHistorial.Text = "Ver historial";
            this.msActualizarVerHistorial.Click += new System.EventHandler(this.msActualizarVerHistorial_Click);
            // 
            // msActualizarRegistrar
            // 
            this.msActualizarRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msActualizarRegistrar.ForeColor = System.Drawing.Color.Black;
            this.msActualizarRegistrar.Name = "msActualizarRegistrar";
            this.msActualizarRegistrar.Size = new System.Drawing.Size(86, 24);
            this.msActualizarRegistrar.Text = "Registrar";
            this.msActualizarRegistrar.Click += new System.EventHandler(this.msActualizarRegistrar_Click);
            // 
            // msActualizarModificar
            // 
            this.msActualizarModificar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msActualizarModificarEliminar,
            this.msActualizarModificarActualizar});
            this.msActualizarModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msActualizarModificar.ForeColor = System.Drawing.Color.Black;
            this.msActualizarModificar.Name = "msActualizarModificar";
            this.msActualizarModificar.Size = new System.Drawing.Size(85, 24);
            this.msActualizarModificar.Text = "Modificar";
            // 
            // msActualizarModificarEliminar
            // 
            this.msActualizarModificarEliminar.Name = "msActualizarModificarEliminar";
            this.msActualizarModificarEliminar.Size = new System.Drawing.Size(148, 24);
            this.msActualizarModificarEliminar.Text = "Eliminar";
            this.msActualizarModificarEliminar.Click += new System.EventHandler(this.msActualizarModificarEliminar_Click);
            // 
            // msActualizarModificarActualizar
            // 
            this.msActualizarModificarActualizar.Name = "msActualizarModificarActualizar";
            this.msActualizarModificarActualizar.Size = new System.Drawing.Size(148, 24);
            this.msActualizarModificarActualizar.Text = "Actualizar";
            this.msActualizarModificarActualizar.Click += new System.EventHandler(this.msActualizarModificarActualizar_Click);
            // 
            // msActualizarCerrarSesión
            // 
            this.msActualizarCerrarSesión.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msActualizarCerrarSesión.ForeColor = System.Drawing.Color.Black;
            this.msActualizarCerrarSesión.Name = "msActualizarCerrarSesión";
            this.msActualizarCerrarSesión.Size = new System.Drawing.Size(115, 24);
            this.msActualizarCerrarSesión.Text = "Cerrar sesión";
            this.msActualizarCerrarSesión.Click += new System.EventHandler(this.msActualizarCerrarSesión_Click);
            // 
            // pbActualizar
            // 
            this.pbActualizar.Image = global::Presentacion.Properties.Resources.logo_conalep;
            this.pbActualizar.Location = new System.Drawing.Point(582, 126);
            this.pbActualizar.Name = "pbActualizar";
            this.pbActualizar.Size = new System.Drawing.Size(208, 164);
            this.pbActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbActualizar.TabIndex = 11;
            this.pbActualizar.TabStop = false;
            // 
            // frmActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pbActualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbActualizarGrupo);
            this.Controls.Add(this.msActualizar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msActualizar;
            this.Name = "frmActualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de información";
            this.Load += new System.EventHandler(this.frmActualizar_Load);
            this.gbActualizarGrupo.ResumeLayout(false);
            this.gbCompleto.ResumeLayout(false);
            this.gbCompleto.PerformLayout();
            this.gbPorAlumno.ResumeLayout(false);
            this.gbPorAlumno.PerformLayout();
            this.msActualizar.ResumeLayout(false);
            this.msActualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbActualizarGrupo;
        private System.Windows.Forms.GroupBox gbCompleto;
        private System.Windows.Forms.TextBox txtNuevoGrupoCompleto;
        private System.Windows.Forms.TextBox txtGrupoActualCompleto;
        private System.Windows.Forms.GroupBox gbPorAlumno;
        private System.Windows.Forms.Button btnActualizarPorAlumno;
        private System.Windows.Forms.TextBox txtGrupoActualizar;
        private System.Windows.Forms.TextBox txtMatriculaActualizar;
        private System.Windows.Forms.Button btnActualizarGrupoCompleto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbActualizar;
        private System.Windows.Forms.MenuStrip msActualizar;
        private System.Windows.Forms.ToolStripMenuItem msActualizarInicio;
        private System.Windows.Forms.ToolStripMenuItem msActualizarVerHistorial;
        private System.Windows.Forms.ToolStripMenuItem msActualizarRegistrar;
        private System.Windows.Forms.ToolStripMenuItem msActualizarModificar;
        private System.Windows.Forms.ToolStripMenuItem msActualizarModificarEliminar;
        private System.Windows.Forms.ToolStripMenuItem msActualizarModificarActualizar;
        private System.Windows.Forms.ToolStripMenuItem msActualizarCerrarSesión;
    }
}