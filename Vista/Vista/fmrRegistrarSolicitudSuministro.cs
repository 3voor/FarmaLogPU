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

        public fmrRegistrarSolicitudSuministro() {
            gestor = new SolicitudSuministroBL();
            InitializeComponent();
            cboxPrioridad.ValueMember = "";
            cboxPrioridad.Items.Add("Alta"); 
            cboxPrioridad.Items.Add("Media"); 
            cboxPrioridad.Items.Add("Baja"); 
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusquedaInsumo bq = new BusquedaInsumo();
            if (bq.ShowDialog() == DialogResult.OK)
            {
                insumo = bq.InsumoSeleccionado;
                dgvInsumo.Rows.Add(new object[] { insumo.NombreInsumo, "0",insumo.UnidadMedida.Nombre });
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
