using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
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

        public bool registrarSolicitudSuministro(SolicitudSuministro s, BindingList<Insumo> lista)
        {
            try
            {
                accesoDatos.registratSolicitud(s);
                foreach(Insumo i in lista)
                {
                    accesoDatos.registratDetalleSolicitud(s.IdSolicitudSuministro, i);
                }
                return true;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        
    }
}
