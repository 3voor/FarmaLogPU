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
        private int idPrioridad;
        private int idEmpleado;

        public SolicitudSuministro(int idSolicitudSuministro, DateTime fechaPeticion, DateTime fechaLimite, string institucion, int idPrioridad, int idEmpleado)
        {
            this.IdSolicitudSuministro = idSolicitudSuministro;
            this.FechaPeticion = fechaPeticion;
            this.FechaLimite = fechaLimite;
            this.Institucion = institucion;
            this.IdPrioridad = idPrioridad;
            this.IdEmpleado = idEmpleado;
        }

        public int IdSolicitudSuministro { get => idSolicitudSuministro; set => idSolicitudSuministro = value; }
        public DateTime FechaPeticion { get => fechaPeticion; set => fechaPeticion = value; }
        public DateTime FechaLimite { get => fechaLimite; set => fechaLimite = value; }
        public string Institucion { get => institucion; set => institucion = value; }
        public int IdPrioridad { get => idPrioridad; set => idPrioridad = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
    }
}
