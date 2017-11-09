using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Proveedor
    {
        private int idProveedor;
        private string nombreProveedor;
        private string correo;
        private string telefono;

        public Proveedor(int idProveedor, string nombreProveedor, string correo, string telefono)
        {
            this.IdProveedor = idProveedor;
            this.NombreProveedor = nombreProveedor;
            this.Correo = correo;
            this.Telefono = telefono;
        }

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string NombreProveedor { get => nombreProveedor; set => nombreProveedor = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
