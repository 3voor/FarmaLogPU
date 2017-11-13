using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using Modelo;
using Controlador;

namespace Vista
{
    public partial class fmrBusquedaProducto : Form
    {
        private ProductoBL gestorProducto;
        private Producto productoSeleccionado;
        BindingList<Producto> lista;

        public Producto ProductoSeleccionado { get => productoSeleccionado; set => productoSeleccionado = value; }

        public fmrBusquedaProducto()
        {
            gestorProducto = new ProductoBL();
            //productoSeleccionado = new Producto();
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreIngresado = txtProducto.Text;
            lista = gestorProducto.devolverListaProductoCoincidencia(nombreIngresado);
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
            foreach (Producto p in lista)
            {
                dgvProducto.Rows.Add(new object[] {p.NombreProducto, p.Descripcion});
            }            

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int index = dgvProducto.CurrentRow.Index;
            productoSeleccionado = lista[index];
            this.DialogResult = DialogResult.OK;
        }
    }
}
