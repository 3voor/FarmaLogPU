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

namespace Vista {
    public partial class BusquedaInsumo : Form {
        private InsumoBL gestorInsumo;
        private UnidadMedidaBL gestorUnidadMedida;
        private Insumo insumoSeleccionado;
        BindingList<Insumo> lista;

        public BusquedaInsumo() {
            gestorInsumo = new InsumoBL();
            gestorUnidadMedida = new UnidadMedidaBL();
            InitializeComponent();
        }

        public Insumo InsumoSeleccionado { get => insumoSeleccionado; set => insumoSeleccionado = value; }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            int index = dgvBusquedaInsumo.CurrentRow.Index;
            insumoSeleccionado = lista[index];
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreIngresado = txtInsumoBuscado.Text;
            lista = gestorInsumo.devolverListaInsumoCoincidencia(nombreIngresado);
            if (lista.Count == 0)
            {
                string message = "No se encontraron Coincidencias";
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
                string message = "Se encontraron " + lista.Count + " resultados";
                string caption = "Consulta Exitosa";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
            foreach (Insumo i in lista)
            {
                i.UnidadMedida.Nombre = gestorUnidadMedida.buscarUnidadMedida(i.UnidadMedida.IdUnidadMedida);
                dgvBusquedaInsumo.Rows.Add(new object[] { i.NombreInsumo, i.Descripcion, i.UnidadMedida.Nombre});
            }
        }
    }
}
