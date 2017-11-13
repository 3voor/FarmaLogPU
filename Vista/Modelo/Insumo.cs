using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Insumo
    {
        private int idInsumo;
        private string nombreInsumo;
        private string descripcion;
        private UnidadMedida unidadMedida;
        private double cantidad;
        private double composicion;

        public Insumo()
        {
            this.unidadMedida = new UnidadMedida();
        }

        public int IdInsumo { get => idInsumo; set => idInsumo = value; }
        public string NombreInsumo { get => nombreInsumo; set => nombreInsumo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public UnidadMedida UnidadMedida { get => unidadMedida; set => unidadMedida = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }
        public double Composicion { get => composicion; set => composicion = value; }
    }
}
