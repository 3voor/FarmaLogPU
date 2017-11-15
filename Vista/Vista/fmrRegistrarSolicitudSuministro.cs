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
            dgvInsumo.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void btnAdministrarSolicitud_Click(object sender, EventArgs e)
        {
            bool ok = true;
            SolicitudSuministro s = new SolicitudSuministro();
            if(txtInstitucion.Text == "")
            {
                string message = "No se ha ingresado la Institucion";
                string caption = "Alerta";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
                ok = false;
            }
            else
            {
                s.Institucion = txtInstitucion.Text;
            }
            if (cboxPrioridad.SelectedItem == null)
            {
                string message = "No se ha seleccionado la prioridad";
                string caption = "Alerta";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
                ok = false;
            }
            else
            {
                string prior = Convert.ToString(cboxPrioridad.SelectedItem);
                if (prior == "Alta") s.Prioridad = 1;
                else if (prior == "Media") s.Prioridad = 2;
                else s.Prioridad = 3;
            }            
            s.FechaLimite = Convert.ToDateTime(dtpFechaLimite.Text, CultureInfo.CurrentCulture);
            if (listaInsumos.Count == 0)
            {
                string message = "No se ha ingresado insumos";
                string caption = "Alerta";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
                ok = false;
            }
            if (ok)
            {
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
                catch (Exception)
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
            int selectedRowCount = dgvInsumo.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount != 1)
            {
                string message = "No se ha seleccionado un insumo";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                DataGridViewRow row = new DataGridViewRow();
                //row.Cells["Cantidad"];
                int index = dgvInsumo.CurrentRow.Index;
                listaInsumos[index].Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
            }
        }

        private void btnEliminarInsumo_Click(object sender, EventArgs e)
        {            
            int selectedRowCount = dgvInsumo.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount != 1)
            {
                string message = "No se ha seleccionado un insumo";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                int index = dgvInsumo.CurrentRow.Index;
                listaInsumos.RemoveAt(index);
                dgvInsumo.Rows.RemoveAt(index);                
            }
        }
    }
}
