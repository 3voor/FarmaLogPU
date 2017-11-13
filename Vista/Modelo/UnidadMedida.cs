using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class UnidadMedida
    {
        int idUnidadMedida;
        string nombre;
        string abreviatura;

        public UnidadMedida()
        {

        }

        public UnidadMedida(int idUnidadMedida, string nombre, string abreviatura)
        {
            this.idUnidadMedida = idUnidadMedida;
            this.nombre = nombre;
            this.abreviatura = abreviatura;
        }

        public int IdUnidadMedida { get => idUnidadMedida; set => idUnidadMedida = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Abreviatura { get => abreviatura; set => abreviatura = value; }
    }
}
