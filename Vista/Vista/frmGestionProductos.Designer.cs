namespace Vista
{
    partial class frmGestionProductos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btnComposicion = new System.Windows.Forms.Button();
            this.dgvInsumo = new System.Windows.Forms.DataGridView();
            this.NombreInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxPieChart = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unidad Medida:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(162, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(237, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(162, 87);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(237, 56);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Location = new System.Drawing.Point(162, 155);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(237, 20);
            this.txtUnidadMedida.TabIndex = 5;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.White;
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBuscar.Location = new System.Drawing.Point(418, 44);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(96, 20);
            this.btBuscar.TabIndex = 6;
            this.btBuscar.Text = "Buscar Producto";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btnComposicion
            // 
            this.btnComposicion.BackColor = System.Drawing.Color.White;
            this.btnComposicion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComposicion.Location = new System.Drawing.Point(41, 193);
            this.btnComposicion.Name = "btnComposicion";
            this.btnComposicion.Size = new System.Drawing.Size(104, 32);
            this.btnComposicion.TabIndex = 7;
            this.btnComposicion.Text = "Ver Composicion";
            this.btnComposicion.UseVisualStyleBackColor = false;
            this.btnComposicion.Click += new System.EventHandler(this.btnComposicion_Click);
            // 
            // dgvInsumo
            // 
            this.dgvInsumo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInsumo.BackgroundColor = System.Drawing.Color.White;
            this.dgvInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreInsumo,
            this.DescripcionInsumo,
            this.Cantidad,
            this.UnidadMedida});
            this.dgvInsumo.Location = new System.Drawing.Point(12, 242);
            this.dgvInsumo.Name = "dgvInsumo";
            this.dgvInsumo.Size = new System.Drawing.Size(441, 171);
            this.dgvInsumo.TabIndex = 8;
            // 
            // NombreInsumo
            // 
            this.NombreInsumo.HeaderText = "Nombre";
            this.NombreInsumo.Name = "NombreInsumo";
            // 
            // DescripcionInsumo
            // 
            this.DescripcionInsumo.FillWeight = 200F;
            this.DescripcionInsumo.HeaderText = "Descripcion";
            this.DescripcionInsumo.Name = "DescripcionInsumo";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.HeaderText = "UM";
            this.UnidadMedida.Name = "UnidadMedida";
            // 
            // pictureBoxPieChart
            // 
            this.pictureBoxPieChart.Location = new System.Drawing.Point(468, 87);
            this.pictureBoxPieChart.Name = "pictureBoxPieChart";
            this.pictureBoxPieChart.Size = new System.Drawing.Size(295, 224);
            this.pictureBoxPieChart.TabIndex = 9;
            this.pictureBoxPieChart.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmGestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(775, 456);
            this.Controls.Add(this.dgvInsumo);
            this.Controls.Add(this.pictureBoxPieChart);
            this.Controls.Add(this.btnComposicion);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtUnidadMedida);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionProductos";
            this.Text = "Gestion Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPieChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btnComposicion;
        private System.Windows.Forms.DataGridView dgvInsumo;
        private System.Windows.Forms.PictureBox pictureBoxPieChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}