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
    public class InsumoBL
    {
        private InsumoDA accesoDatos;

        public InsumoBL()
        {
            accesoDatos = new InsumoDA();
        }

        public BindingList<Insumo> devolverListaInsumoCoincidencia(string nombre)
        {
            return accesoDatos.obtenerListaInsumosCoincidencia(nombre);
        }
    }
}
