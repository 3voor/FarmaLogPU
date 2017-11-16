using Controlador;
using Modelo;
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
    public partial class Logueo : Form {
        private Usuario u;
        private UsuarioBL usuarioBL;
        public Logueo() {
            InitializeComponent();
            u = new Usuario();
            usuarioBL = new UsuarioBL();
        }

        private void btnIngresar_Click(object sender, EventArgs e) {
            u.Nombre = txtUsuarios.Text;
            u.Pass = txtContraseña.Text;
            if (usuarioBL.validarUsuario(u)) {
                System.Console.WriteLine("Entro!");
                MessageBox.Show("Datos correctos!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Principal frmPrincipal = new Principal();
                frmPrincipal.Show();
            }
            else MessageBox.Show("Intentelo de nuevo!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
