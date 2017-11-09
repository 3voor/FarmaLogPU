using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class SolicitudSuministroDA
    {
        public bool registratSolicitud(SolicitudSuministro s)
        {
            try
            {
                String cadena = "server=200.16.7.96; user=inf282g1; database=inf282g1;password=BRXRKa3O5JUiqJWn;";
                SqlConnection conn = new SqlConnection(cadena);
                conn.Open();
                Console.WriteLine("La conexion se ha realizado con exito");
                MySqlCommand cmd = new MySqlCommand();
                String sql = "INSERT INTO SolicitudSumnistros " + "(idSolicitudSuministro, fechaPeticion, fechaLimite, institucion, Prioridad_idPrioridad, Empleados_idEmpleado) " + "VALUES (" + 
                    s.IdSolicitudSuministro + ",'" + s.FechaPeticion + "','" + s.FechaLimite;
                //cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }


    }
}
