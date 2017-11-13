using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class InsumoDA
    {
        public BindingList<Insumo> obtenerListaInsumosCoincidencia(string nombreBuscado)
        {
            BindingList<Insumo> lista = new BindingList<Insumo>();
            try
            {
                String cadena = "server=200.16.7.96; user=inf282g1; database=inf282g1;password=BRXRKa3O5JUiqJWn;";
                MySqlConnection conn =
                new MySqlConnection(cadena);
                conn.Open();
                System.Console.WriteLine("Conexion exitosa");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "BUSCAR_INSUMO_NOMBRE";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nomb", nombreBuscado);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Insumo i = new Insumo();
                    int id = reader.GetInt32("idInsumo");
                    String nombre = reader.GetString("nombre");
                    String descripcion = reader.GetString("descripcion");
                    int idUM = reader.GetInt32("idUnidadMedida");
                    i.IdInsumo = id;
                    i.NombreInsumo = nombre;
                    i.Descripcion = descripcion;
                    UnidadMedida u = new UnidadMedida();
                    u.IdUnidadMedida = idUM;
                    i.UnidadMedida = u;
                    lista.Add(i);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }
    }
}
