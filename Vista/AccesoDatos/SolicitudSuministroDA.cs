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
                MySqlConnection conn =
                new MySqlConnection(cadena);
                conn.Open();
                System.Console.WriteLine("Conexion exitosa");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "REGISTRAR_SOLICITUD_SUMINISTRO";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_idEmpleado", s.Empleado);
                cmd.Parameters.AddWithValue("_prioridad", s.Prioridad);
                cmd.Parameters.AddWithValue("_fechaPeticion", s.FechaPeticion);
                cmd.Parameters.AddWithValue("_institucion", s.Institucion);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


    }
}
