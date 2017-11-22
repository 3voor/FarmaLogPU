using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista {
    public partial class Principal : Form {

        private frmGestionProductos formGestionProd = null;
        private fmrRegistrarSolicitudSuministro formSoliSumin = null;

        public Principal() {
            InitializeComponent();
            this.formGestionProd = new frmGestionProductos();
            this.formSoliSumin = new fmrRegistrarSolicitudSuministro();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void btnBuscarProd_Click(object sender, EventArgs e) {
            frmGestionProductos frmProd = new frmGestionProductos();
            frmProd.Show();
        }

        private void btnRegSolSum_Click(object sender, EventArgs e) {
            fmrRegistrarSolicitudSuministro frmSol = new fmrRegistrarSolicitudSuministro();
            frmSol.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonMenu_Click(object sender, EventArgs e)
        {
            if(sideMenu.Width == 50)
            {
                sideMenu.Visible = false;
                sideMenu.Width = 260;
                
            }
        }

        private void Bus_Click(object sender, EventArgs e)
        {
            //this.formGestionProd = new frmGestionProductos();
            this.formGestionProd.TopLevel = false;
            this.formGestionProd.Visible = true;
            this.formSoliSumin.Visible = false;
            this.Controls.Add(this.formGestionProd);            
            this.ArrangeFormSize(1);
        }

        private void Principal_SizeChange(object sender, EventArgs e)
        {
            this.ArrangeFormSize(1);
        }

        private void ArrangeFormSize(int opcion)
        {
            if(opcion == 1)
                this.formGestionProd.Location = new Point(this.ClientSize.Width - this.formGestionProd.Width, this.ClientSize.Height - this.formGestionProd.Height);
            else if(opcion == 2)
                this.formSoliSumin.Location = new Point(this.ClientSize.Width - this.formSoliSumin.Width, this.ClientSize.Height - this.formSoliSumin.Height);
        }

        private void botonSolSumin_Click(object sender, EventArgs e)
        {
            //this.formSoliSumin = new fmrRegistrarSolicitudSuministro();
            this.formSoliSumin.TopLevel = false;
            this.formSoliSumin.Visible = true;
            this.Controls.Add(this.formSoliSumin);
            this.ArrangeFormSize(2);
        }
    }
}
