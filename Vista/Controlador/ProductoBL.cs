using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using AccesoDatos;
using System.ComponentModel;

namespace Controlador
{
    public class ProductoBL
    {
        private ProductoDA accesoDatos;

        public ProductoBL()
        {
            accesoDatos = new ProductoDA();
        }

        public BindingList<Producto> devolverListaProductoCoincidencia(string nombre)
        {
            return accesoDatos.obtenerListaProductosCoincidencia(nombre);
        }

        public void actualizarDatosInsumos(Producto p)
        {
            accesoDatos.obtenerDatosInsumoComponene(p);
        }

    }
}
