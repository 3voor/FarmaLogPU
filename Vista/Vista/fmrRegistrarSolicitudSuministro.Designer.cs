namespace Vista {
    partial class fmrRegistrarSolicitudSuministro {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxPrioridad = new System.Windows.Forms.ComboBox();
            this.dtpFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.txtInstitucion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdministrarSolicitud = new System.Windows.Forms.Button();
            this.dgvInsumo = new System.Windows.Forms.DataGridView();
            this.btnInsertarInsumo = new System.Windows.Forms.Button();
            this.btnEliminarInsumo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.NombreInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxPrioridad);
            this.groupBox1.Controls.Add(this.dtpFechaLimite);
            this.groupBox1.Controls.Add(this.txtInstitucion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Suministro";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboxPrioridad
            // 
            this.cboxPrioridad.FormattingEnabled = true;
            this.cboxPrioridad.Location = new System.Drawing.Point(106, 70);
            this.cboxPrioridad.Name = "cboxPrioridad";
            this.cboxPrioridad.Size = new System.Drawing.Size(121, 21);
            this.cboxPrioridad.TabIndex = 11;
            // 
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.Location = new System.Drawing.Point(106, 37);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaLimite.TabIndex = 10;
            // 
            // txtInstitucion
            // 
            this.txtInstitucion.Location = new System.Drawing.Point(106, 109);
            this.txtInstitucion.Name = "txtInstitucion";
            this.txtInstitucion.Size = new System.Drawing.Size(100, 20);
            this.txtInstitucion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Institución";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prioridad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Limite";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(232, 388);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAdministrarSolicitud
            // 
            this.btnAdministrarSolicitud.Location = new System.Drawing.Point(71, 387);
            this.btnAdministrarSolicitud.Name = "btnAdministrarSolicitud";
            this.btnAdministrarSolicitud.Size = new System.Drawing.Size(94, 24);
            this.btnAdministrarSolicitud.TabIndex = 12;
            this.btnAdministrarSolicitud.Text = "RegistarSolictud";
            this.btnAdministrarSolicitud.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAdministrarSolicitud.UseVisualStyleBackColor = true;
            this.btnAdministrarSolicitud.Click += new System.EventHandler(this.btnAdministrarSolicitud_Click);
            // 
            // dgvInsumo
            // 
            this.dgvInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreInsumo,
            this.Cantidad,
            this.UnidadMedida});
            this.dgvInsumo.Location = new System.Drawing.Point(23, 221);
            this.dgvInsumo.Name = "dgvInsumo";
            this.dgvInsumo.Size = new System.Drawing.Size(346, 150);
            this.dgvInsumo.TabIndex = 14;
            // 
            // btnInsertarInsumo
            // 
            this.btnInsertarInsumo.Location = new System.Drawing.Point(23, 179);
            this.btnInsertarInsumo.Name = "btnInsertarInsumo";
            this.btnInsertarInsumo.Size = new System.Drawing.Size(101, 23);
            this.btnInsertarInsumo.TabIndex = 15;
            this.btnInsertarInsumo.Text = "Añadir Insumo";
            this.btnInsertarInsumo.UseVisualStyleBackColor = true;
            this.btnInsertarInsumo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarInsumo
            // 
            this.btnEliminarInsumo.Location = new System.Drawing.Point(268, 179);
            this.btnEliminarInsumo.Name = "btnEliminarInsumo";
            this.btnEliminarInsumo.Size = new System.Drawing.Size(101, 23);
            this.btnEliminarInsumo.TabIndex = 16;
            this.btnEliminarInsumo.Text = "Eliminar Insumo";
            this.btnEliminarInsumo.UseVisualStyleBackColor = true;
            this.btnEliminarInsumo.Click += new System.EventHandler(this.btnEliminarInsumo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(144, 179);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(106, 23);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar Cantidad";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // NombreInsumo
            // 
            this.NombreInsumo.HeaderText = "Nombre Insumo";
            this.NombreInsumo.Name = "NombreInsumo";
            this.NombreInsumo.ReadOnly = true;
            this.NombreInsumo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.HeaderText = "Unidad Medida";
            this.UnidadMedida.Name = "UnidadMedida";
            this.UnidadMedida.ReadOnly = true;
            // 
            // fmrRegistrarSolicitudSuministro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 429);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarInsumo);
            this.Controls.Add(this.btnInsertarInsumo);
            this.Controls.Add(this.dgvInsumo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdministrarSolicitud);
            this.Name = "fmrRegistrarSolicitudSuministro";
            this.Text = "Solicitud Suministro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdministrarSolicitud;
        private System.Windows.Forms.DateTimePicker dtpFechaLimite;
        private System.Windows.Forms.TextBox txtInstitucion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvInsumo;
        private System.Windows.Forms.Button btnInsertarInsumo;
        private System.Windows.Forms.Button btnEliminarInsumo;
        private System.Windows.Forms.ComboBox cboxPrioridad;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
    }
}

