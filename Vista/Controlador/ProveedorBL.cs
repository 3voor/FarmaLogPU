using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;

namespace Controlador
{
    public class ProveedorBL
    {
        private ProveedorDA accesoDatos;

        public ProveedorBL()
        {
            accesoDatos = new ProveedorDA();
        }

        public bool registrarProveedor(Proveedor p)
        {
            return accesoDatos.insertarProveedor(p);
        }
    }
}
