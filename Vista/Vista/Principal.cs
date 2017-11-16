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
        public Principal() {
            InitializeComponent();
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
    }
}
