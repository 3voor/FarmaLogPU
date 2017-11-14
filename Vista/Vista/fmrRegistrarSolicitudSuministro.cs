using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;
using System.Globalization;

namespace Vista {
    public partial class fmrRegistrarSolicitudSuministro : Form {
        private SolicitudSuministroBL gestor;
        private Insumo insumo;
        BindingList<Insumo> listaInsumos;

        public fmrRegistrarSolicitudSuministro() {
            gestor = new SolicitudSuministroBL();
            InitializeComponent();
            cboxPrioridad.ValueMember = "";
            cboxPrioridad.Items.Add("Alta"); 
            cboxPrioridad.Items.Add("Media"); 
            cboxPrioridad.Items.Add("Baja");
            dgvInsumo.Enabled = false;
            listaInsumos = new BindingList<Insumo>();
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void btnAdministrarSolicitud_Click(object sender, EventArgs e)
        {
            SolicitudSuministro s = new SolicitudSuministro();
            s.Institucion = txtInstitucion.Text;
            string prior = Convert.ToString(cboxPrioridad.SelectedItem);
            if (prior == "Alta") s.Prioridad = 1;
            else if (prior == "Media") s.Prioridad = 2;
            else s.Prioridad = 3;
            s.FechaLimite = Convert.ToDateTime(dtpFechaLimite.Text, CultureInfo.CurrentCulture);
            
            try
            {
                gestor.registrarSolicitudSuministro(s, listaInsumos);
                string message = "Solicitud Suministro Ingresada";
                string caption = "Exito";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch(Exception)
            {
                string message = "No se pudo insgresar la Solictud";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusquedaInsumo bq = new BusquedaInsumo();
            if (bq.ShowDialog() == DialogResult.OK)
            {
                insumo = bq.InsumoSeleccionado;
                listaInsumos.Add(insumo);
                dgvInsumo.Rows.Add(new object[] { insumo.NombreInsumo, insumo.Cantidad ,insumo.UnidadMedida.Nombre });
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
