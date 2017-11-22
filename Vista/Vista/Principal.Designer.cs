namespace Vista {
    partial class Principal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sideMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.botonSolSumin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Bus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMenu)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sideMenu.Controls.Add(this.pictureBox1);
            this.sideMenu.Controls.Add(this.botonMenu);
            this.sideMenu.Controls.Add(this.botonSolSumin);
            this.sideMenu.Controls.Add(this.Bus);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 61);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(239, 478);
            this.sideMenu.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.tuboEnsayo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // botonMenu
            // 
            this.botonMenu.BackColor = System.Drawing.Color.Transparent;
            this.botonMenu.Image = global::Vista.Properties.Resources.botonMenu;
            this.botonMenu.ImageActive = null;
            this.botonMenu.Location = new System.Drawing.Point(12, 22);
            this.botonMenu.Name = "botonMenu";
            this.botonMenu.Size = new System.Drawing.Size(41, 38);
            this.botonMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonMenu.TabIndex = 5;
            this.botonMenu.TabStop = false;
            this.botonMenu.Zoom = 10;
            this.botonMenu.Click += new System.EventHandler(this.botonMenu_Click);
            // 
            // botonSolSumin
            // 
            this.botonSolSumin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.botonSolSumin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.botonSolSumin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonSolSumin.BorderRadius = 0;
            this.botonSolSumin.ButtonText = "Solicitudes de Suministro";
            this.botonSolSumin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSolSumin.DisabledColor = System.Drawing.Color.Gray;
            this.botonSolSumin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSolSumin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonSolSumin.Iconcolor = System.Drawing.Color.Transparent;
            this.botonSolSumin.Iconimage = null;
            this.botonSolSumin.Iconimage_right = null;
            this.botonSolSumin.Iconimage_right_Selected = null;
            this.botonSolSumin.Iconimage_Selected = null;
            this.botonSolSumin.IconMarginLeft = 0;
            this.botonSolSumin.IconMarginRight = 0;
            this.botonSolSumin.IconRightVisible = true;
            this.botonSolSumin.IconRightZoom = 0D;
            this.botonSolSumin.IconVisible = true;
            this.botonSolSumin.IconZoom = 90D;
            this.botonSolSumin.IsTab = false;
            this.botonSolSumin.Location = new System.Drawing.Point(58, 150);
            this.botonSolSumin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonSolSumin.Name = "botonSolSumin";
            this.botonSolSumin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.botonSolSumin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.botonSolSumin.OnHoverTextColor = System.Drawing.Color.White;
            this.botonSolSumin.selected = false;
            this.botonSolSumin.Size = new System.Drawing.Size(173, 59);
            this.botonSolSumin.TabIndex = 4;
            this.botonSolSumin.Text = "Solicitudes de Suministro";
            this.botonSolSumin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonSolSumin.Textcolor = System.Drawing.Color.White;
            this.botonSolSumin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSolSumin.Click += new System.EventHandler(this.botonSolSumin_Click);
            // 
            // Bus
            // 
            this.Bus.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Bus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Bus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bus.BorderRadius = 0;
            this.Bus.ButtonText = "Gestion de Productos";
            this.Bus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bus.DisabledColor = System.Drawing.Color.Gray;
            this.Bus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bus.Iconcolor = System.Drawing.Color.Transparent;
            this.Bus.Iconimage = null;
            this.Bus.Iconimage_right = null;
            this.Bus.Iconimage_right_Selected = null;
            this.Bus.Iconimage_Selected = null;
            this.Bus.IconMarginLeft = 0;
            this.Bus.IconMarginRight = 0;
            this.Bus.IconRightVisible = true;
            this.Bus.IconRightZoom = 0D;
            this.Bus.IconVisible = true;
            this.Bus.IconZoom = 90D;
            this.Bus.IsTab = false;
            this.Bus.Location = new System.Drawing.Point(58, 83);
            this.Bus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bus.Name = "Bus";
            this.Bus.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Bus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Bus.OnHoverTextColor = System.Drawing.Color.White;
            this.Bus.selected = false;
            this.Bus.Size = new System.Drawing.Size(173, 59);
            this.Bus.TabIndex = 2;
            this.Bus.Text = "Gestion de Productos";
            this.Bus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bus.Textcolor = System.Drawing.Color.White;
            this.Bus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bus.Click += new System.EventHandler(this.Bus_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.bunifuImageButton1);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1211, 61);
            this.header.TabIndex = 3;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1154, 19);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(33, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(28, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(158, 35);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "FarmaLog";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1041, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 478);
            this.panel1.TabIndex = 4;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1211, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Principal";
            this.sideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMenu)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuFlatButton Bus;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton botonSolSumin;
        private Bunifu.Framework.UI.BunifuImageButton botonMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
    }
}