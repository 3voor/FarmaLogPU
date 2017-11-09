using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;

namespace Controlador
{
    public class SolicitudSuministroBL
    {
        private SolicitudSuministroDA accesoDatos;

        public SolicitudSuministroBL()
        {
            accesoDatos = new SolicitudSuministroDA();
        }

        public bool registrarSolicitudSuministro(SolicitudSuministro s)
        {
            return accesoDatos.registratSolicitud(s);
        }

    }
}
