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
            //fr.TopLevel = false;
            //fr.Visible = false;
            //this.Controls.Add(fr);
            fr.Location = new Point(this.ClientSize.Width - this.Width, this.ClientSize.Height - this.Height);
            if (fr.ShowDialog() == DialogResult.OK)
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
            Color[] color = { Color.Aqua, Color.BlueViolet, Color.Coral, Color.BurlyWood, Color.Aquamarine, Color.Indigo };
            Rectangle rect = new Rectangle(30, 10, 130, 130);
            
            double total = 0.0;
            int rec = 0;
            foreach (Insumo i in producto.ListaInsumo)
            {
                componentes.Add(i.Composicion);
                total += i.Composicion;                
            }
            componentes.Add(100.00 - total);

            
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
            leyenda(producto.ListaInsumo);
        }

        private void leyenda(BindingList<Insumo> lista)
        {            
            Color[] color = { Color.Aqua, Color.BlueViolet, Color.Coral, Color.BurlyWood, Color.Aquamarine, Color.Indigo };
            int rec = 1;
            foreach (Insumo i in lista)
            {                
                if(lista.Count == 2)
                {
                    if (rec == 1)
                    {
                        lblComponente1.Text = i.NombreInsumo;
                        lblComponente1.BackColor = color[rec - 1];
                    }
                    else if (rec == 2){
                        lblComponente2.Text = i.NombreInsumo;
                        lblComponente2.BackColor = color[rec - 1];
                    }
                    else if (rec == 3) {
                        lblComponente3.Text = "Otros insumos";
                        lblComponente2.BackColor = color[rec - 1];
                    }
                    rec++;
                }
                else if(lista.Count == 3)
                {
                    if (rec == 1) lblComponente1.Text = i.NombreInsumo;
                    else if (rec == 2) lblComponente2.Text = i.NombreInsumo;
                    else if (rec == 3) lblComponente3.Text = i.NombreInsumo;
                    else lblComponente4.Text = "Otros Insumos";
                    rec++;
                }
                
            }           

        }

        private void frmGestionProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
