using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

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
                
                cmd.Parameters.AddWithValue("@codEmp", 1);
                cmd.Parameters["@codEmp"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@prior", s.Prioridad);
                cmd.Parameters["@prior"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@fPeticion", s.FechaPeticion);
                cmd.Parameters["@fPeticion"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@insti", s.Institucion);
                cmd.Parameters["@insti"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@idSolicitudSumnistro", MySqlDbType.Int32);
                cmd.Parameters["@idSolicitudSumnistro"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                int id = Convert.ToInt32(cmd.Parameters["@idSolicitudSumnistro"].Value);
                s.IdSolicitudSuministro = id;
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool registratDetalleSolicitud(int id, Insumo i)
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
                cmd.CommandText = "INSERTAR_DETALLE_SOLICITUD";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idSolSumi", id);
                cmd.Parameters["@idSolSumi"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@idIns", i.IdInsumo);
                cmd.Parameters["@idIns"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@cant", i.Cantidad);
                cmd.Parameters["@cant"].Direction = ParameterDirection.Input;                
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
