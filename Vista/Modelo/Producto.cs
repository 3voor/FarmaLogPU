using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Modelo
{
    public class Producto
    {
        int idProducto;
        string nombreProducto;
        string descripcion;
        UnidadMedida unidadMedida;
        BindingList<Insumo> listaInsumo;

        public Producto()
        {
            listaInsumo = new BindingList<Insumo>();
        }

        public Producto(int idProducto, string nombreProducto, string descripcion, UnidadMedida unidadMedida)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.descripcion = descripcion;
            this.unidadMedida = unidadMedida;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public UnidadMedida UnidadMedida { get => unidadMedida; set => unidadMedida = value; }
        public BindingList<Insumo> ListaInsumo { get => listaInsumo; set => listaInsumo = value; }
    }
}
