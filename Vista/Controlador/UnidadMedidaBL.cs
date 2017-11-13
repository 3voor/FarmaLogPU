using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using AccesoDatos;

namespace Controlador
{
    public class UnidadMedidaBL
    {
        private UnidadMedidaDA accesoDatos;

        public UnidadMedidaBL()
        {
            accesoDatos = new UnidadMedidaDA();
        }

        public string buscarUnidadMedida(int id)
        {
            return accesoDatos.buscarUnidadMedida(id);
        }

    }
}
