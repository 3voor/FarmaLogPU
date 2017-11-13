using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class SolicitudSuministro
    {
        private int idSolicitudSuministro;
        private DateTime fechaPeticion;
        private DateTime fechaLimite;
        private string institucion;
        private int prioridad;
        private Empleado empleado;
        

        public SolicitudSuministro()
        {

        }

        public SolicitudSuministro(int idSolicitudSuministro, DateTime fechaPeticion, DateTime fechaLimite, string institucion, int prioridad, Empleado empleado)
        {
            this.IdSolicitudSuministro = idSolicitudSuministro;
            this.FechaPeticion = fechaPeticion;
            this.FechaLimite = fechaLimite;
            this.Institucion = institucion;
            this.prioridad = prioridad;
            this.empleado = empleado;
        }

        public int IdSolicitudSuministro { get => idSolicitudSuministro; set => idSolicitudSuministro = value; }
        public DateTime FechaPeticion { get => fechaPeticion; set => fechaPeticion = value; }
        public DateTime FechaLimite { get => fechaLimite; set => fechaLimite = value; }
        public string Institucion { get => institucion; set => institucion = value; }
        public int Prioridad { get => prioridad; set => prioridad = value; }
        public int Empleado { get => Empleado; set => Empleado = value; }
    }
}
