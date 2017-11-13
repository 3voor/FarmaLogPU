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

namespace Vista
{
    public partial class frmGestionProductos : Form
    {
        private Producto producto;
        private UnidadMedidaBL gestorUnidadMedida;
        private ProductoBL gestorProducto;

        public frmGestionProductos()
        {
            gestorUnidadMedida = new UnidadMedidaBL();
            gestorProducto = new ProductoBL();
            InitializeComponent();
            txtNombre.ReadOnly = true;
            txtDescripcion.ReadOnly = true;
            txtUnidadMedida.ReadOnly = true;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            fmrBusquedaProducto fr = new fmrBusquedaProducto();
            if(fr.ShowDialog() == DialogResult.OK)
            {
                producto = fr.ProductoSeleccionado;
                txtNombre.Text = Convert.ToString(producto.NombreProducto);
                txtDescripcion.Text = Convert.ToString(producto.Descripcion);
                producto.UnidadMedida.Nombre = gestorUnidadMedida.buscarUnidadMedida(producto.UnidadMedida.IdUnidadMedida);
                txtUnidadMedida.Text = producto.UnidadMedida.Nombre;
            }
        }

        private void btnComposicion_Click(object sender, EventArgs e)
        {
            gestorProducto.actualizarDatosInsumos(producto);
            foreach (Insumo i in producto.ListaInsumo)
            {
                i.UnidadMedida.Nombre = gestorUnidadMedida.buscarUnidadMedida(i.UnidadMedida.IdUnidadMedida);
                dgvInsumo.Rows.Add(new object[] { i.NombreInsumo, i.Descripcion, i.Cantidad, i.UnidadMedida.Nombre });                
            }
            createPie();
            
        }

        private void createPie()
        {
            List<Double> componentes = new List<Double>();
            double total = 0.0;
            foreach (Insumo i in producto.ListaInsumo)
            {
                componentes.Add(i.Composicion);
                total += i.Composicion;
            }
            componentes.Add(100.00 - total);

            Color[] color = { Color.Aqua, Color.BlueViolet, Color.Coral, Color.BurlyWood, Color.Aquamarine, Color.Indigo };
            Rectangle rect = new Rectangle(30, 10, 130, 130);

            Graphics graphics = pictureBoxPieChart.CreateGraphics();
            graphics.Clear(pictureBoxPieChart.BackColor);

            float fDegValue = 0.0f;
            float fDegSum = 0.0f;

            for (int iCnt = 0; iCnt < componentes.Count; iCnt++)
            {
                fDegValue = Convert.ToSingle((componentes[iCnt] / total) * 360);
                Brush brush = new SolidBrush(color[iCnt]);
                graphics.FillPie(brush, rect, fDegSum, fDegValue);
                fDegSum += fDegValue;
            }
        }
    }
}
