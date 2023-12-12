namespace Presentacion
{
    partial class frmVerHistorial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerHistorial));
            this.btnRevisarConexion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.visualizarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.msVerHistorial = new System.Windows.Forms.MenuStrip();
            this.msVerHistorialInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.msVerHistorialVerHistorial = new System.Windows.Forms.ToolStripMenuItem();
            this.msVerHistorialRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.msVerHistorialModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.msVerHistorialModificarEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.msVerHistorialModificarActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.msVerHistorialCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVisualizarInvitados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.msVerHistorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRevisarConexion
            // 
            this.btnRevisarConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevisarConexion.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevisarConexion.Location = new System.Drawing.Point(12, 52);
            this.btnRevisarConexion.Name = "btnRevisarConexion";
            this.btnRevisarConexion.Size = new System.Drawing.Size(133, 23);
            this.btnRevisarConexion.TabIndex = 0;
            this.btnRevisarConexion.Text = "Revisar Conexión";
            this.btnRevisarConexion.UseVisualStyleBackColor = true;
            this.btnRevisarConexion.Click += new System.EventHandler(this.btnRevisarConexion_Click);
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
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(95)))));
            this.dataGridView1.Location = new System.Drawing.Point(221, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(707, 540);
            this.dataGridView1.TabIndex = 1;
            // 
            // visualizarBtn
            // 
            this.visualizarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.visualizarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualizarBtn.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizarBtn.Location = new System.Drawing.Point(12, 81);
            this.visualizarBtn.Name = "visualizarBtn";
            this.visualizarBtn.Size = new System.Drawing.Size(133, 23);
            this.visualizarBtn.TabIndex = 2;
            this.visualizarBtn.Text = "Historial Alumnos";
            this.visualizarBtn.UseVisualStyleBackColor = true;
            this.visualizarBtn.Click += new System.EventHandler(this.visualizarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // msVerHistorial
            // 
            this.msVerHistorial.BackColor = System.Drawing.SystemColors.Window;
            this.msVerHistorial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msVerHistorialInicio,
            this.msVerHistorialVerHistorial,
            this.msVerHistorialRegistrar,
            this.msVerHistorialModificar,
            this.msVerHistorialCerrarSesion});
            this.msVerHistorial.Location = new System.Drawing.Point(0, 0);
            this.msVerHistorial.Name = "msVerHistorial";
            this.msVerHistorial.Size = new System.Drawing.Size(1059, 28);
            this.msVerHistorial.TabIndex = 4;
            this.msVerHistorial.Text = "menuStrip1";
            // 
            // msVerHistorialInicio
            // 
            this.msVerHistorialInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msVerHistorialInicio.Name = "msVerHistorialInicio";
            this.msVerHistorialInicio.Size = new System.Drawing.Size(58, 24);
            this.msVerHistorialInicio.Text = "Inicio";
            this.msVerHistorialInicio.Click += new System.EventHandler(this.msVerHistorialInicio_Click);
            // 
            // msVerHistorialVerHistorial
            // 
            this.msVerHistorialVerHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msVerHistorialVerHistorial.Name = "msVerHistorialVerHistorial";
            this.msVerHistorialVerHistorial.Size = new System.Drawing.Size(104, 24);
            this.msVerHistorialVerHistorial.Text = "Ver historial";
            this.msVerHistorialVerHistorial.Click += new System.EventHandler(this.msVerHistorialVerHistorial_Click);
            // 
            // msVerHistorialRegistrar
            // 
            this.msVerHistorialRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msVerHistorialRegistrar.Name = "msVerHistorialRegistrar";
            this.msVerHistorialRegistrar.Size = new System.Drawing.Size(86, 24);
            this.msVerHistorialRegistrar.Text = "Registrar";
            this.msVerHistorialRegistrar.Click += new System.EventHandler(this.msVerHistorialRegistrar_Click);
            // 
            // msVerHistorialModificar
            // 
            this.msVerHistorialModificar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msVerHistorialModificarEliminar,
            this.msVerHistorialModificarActualizar});
            this.msVerHistorialModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msVerHistorialModificar.Name = "msVerHistorialModificar";
            this.msVerHistorialModificar.Size = new System.Drawing.Size(85, 24);
            this.msVerHistorialModificar.Text = "Modificar";
            // 
            // msVerHistorialModificarEliminar
            // 
            this.msVerHistorialModificarEliminar.Name = "msVerHistorialModificarEliminar";
            this.msVerHistorialModificarEliminar.Size = new System.Drawing.Size(148, 24);
            this.msVerHistorialModificarEliminar.Text = "Eliminar";
            this.msVerHistorialModificarEliminar.Click += new System.EventHandler(this.msVerHistorialModificarEliminar_Click);
            // 
            // msVerHistorialModificarActualizar
            // 
            this.msVerHistorialModificarActualizar.Name = "msVerHistorialModificarActualizar";
            this.msVerHistorialModificarActualizar.Size = new System.Drawing.Size(148, 24);
            this.msVerHistorialModificarActualizar.Text = "Actualizar";
            this.msVerHistorialModificarActualizar.Click += new System.EventHandler(this.msVerHistorialModificarActualizar_Click);
            // 
            // msVerHistorialCerrarSesion
            // 
            this.msVerHistorialCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msVerHistorialCerrarSesion.Name = "msVerHistorialCerrarSesion";
            this.msVerHistorialCerrarSesion.Size = new System.Drawing.Size(115, 24);
            this.msVerHistorialCerrarSesion.Text = "Cerrar sesión";
            this.msVerHistorialCerrarSesion.Click += new System.EventHandler(this.msVerHistorialCerrarSesion_Click);
            // 
            // btnVisualizarInvitados
            // 
            this.btnVisualizarInvitados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVisualizarInvitados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarInvitados.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarInvitados.Location = new System.Drawing.Point(12, 110);
            this.btnVisualizarInvitados.Name = "btnVisualizarInvitados";
            this.btnVisualizarInvitados.Size = new System.Drawing.Size(133, 23);
            this.btnVisualizarInvitados.TabIndex = 5;
            this.btnVisualizarInvitados.Text = "Historial Invitados";
            this.btnVisualizarInvitados.UseVisualStyleBackColor = true;
            this.btnVisualizarInvitados.Click += new System.EventHandler(this.btnVisualizarInvitados_Click);
            // 
            // frmVerHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1059, 618);
            this.Controls.Add(this.btnVisualizarInvitados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.visualizarBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRevisarConexion);
            this.Controls.Add(this.msVerHistorial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msVerHistorial;
            this.Name = "frmVerHistorial";
            this.Text = "Centro de información";
            this.Load += new System.EventHandler(this.frmVerHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.msVerHistorial.ResumeLayout(false);
            this.msVerHistorial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRevisarConexion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button visualizarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip msVerHistorial;
        private System.Windows.Forms.ToolStripMenuItem msVerHistorialInicio;
        private System.Windows.Forms.ToolStripMenuItem msVerHistorialVerHistorial;
        private System.Windows.Forms.ToolStripMenuItem msVerHistorialRegistrar;
        private System.Windows.Forms.ToolStripMenuItem msVerHistorialModificar;
        private System.Windows.Forms.ToolStripMenuItem msVerHistorialModificarEliminar;
        private System.Windows.Forms.ToolStripMenuItem msVerHistorialModificarActualizar;
        private System.Windows.Forms.ToolStripMenuItem msVerHistorialCerrarSesion;
        private System.Windows.Forms.Button btnVisualizarInvitados;
    }
}

