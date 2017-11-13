using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Modelo;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class UnidadMedidaDA
    {

        public BindingList<UnidadMedida> obtenerListaProductos()
        {
            BindingList<UnidadMedida> lista = new BindingList<UnidadMedida>();
            try
            {
                String cadena = "server=200.16.7.96; user=inf282g1; database=inf282g1;password=BRXRKa3O5JUiqJWn;";
                MySqlConnection conn =
                new MySqlConnection(cadena);
                conn.Open();
                System.Console.WriteLine("Conexion exitosa");
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM UNIDAD_MEDIDA";
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    UnidadMedida u = new UnidadMedida();
                    int id = reader.GetInt32("IdUnidadMedida");
                    String nombre = reader.GetString("nombre");
                    String abreviatura = reader.GetString("abrev");
                    u.IdUnidadMedida = id;
                    u.Nombre = nombre;
                    u.Abreviatura = abreviatura;
                    lista.Add(u);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }

        public string buscarUnidadMedida(int id)
        {
            try
            {
                String cadena = "server=200.16.7.96; user=inf282g1; database=inf282g1;password=BRXRKa3O5JUiqJWn;";
                MySqlConnection conn =
                new MySqlConnection(cadena);
                conn.Open();
                System.Console.WriteLine("Conexion exitosa");
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT nombre FROM inf282g1.UnidadMedida WHERE IdUnidadMedida = " + id;
                cmd.Connection = conn;
                string str = Convert.ToString(cmd.ExecuteScalar());                
                conn.Close();
                return str;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
       
    }
}
