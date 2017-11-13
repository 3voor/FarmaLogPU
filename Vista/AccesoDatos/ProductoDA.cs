using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.ComponentModel;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class ProductoDA
    {

        public BindingList<Producto> obtenerListaProductos()
        {
            BindingList<Producto> lista = new BindingList<Producto>();
            try
            {
                String cadena = "server=200.16.7.96; user=inf282g1; database=inf282g1;password=BRXRKa3O5JUiqJWn;";
                MySqlConnection conn =
                new MySqlConnection(cadena);
                conn.Open();
                System.Console.WriteLine("Conexion exitosa");
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM PRODUCTO";
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Producto p = new Producto();
                    int id = reader.GetInt32("ID");
                    String nombre = reader.GetString("Nombres");
                    p.IdProducto = id;
                    p.NombreProducto = nombre;
                    lista.Add(p);
                }                

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }

        public BindingList<Producto> obtenerListaProductosCoincidencia(string nombreBuscado)
        {
            BindingList<Producto> lista = new BindingList<Producto>();
            try
            {
                String cadena = "server=200.16.7.96; user=inf282g1; database=inf282g1;password=BRXRKa3O5JUiqJWn;";
                MySqlConnection conn =
                new MySqlConnection(cadena);
                conn.Open();
                System.Console.WriteLine("Conexion exitosa");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "BUSCAR_PRODUCTO_NOMBRE";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nomb", nombreBuscado);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Producto p = new Producto();
                    int id = reader.GetInt32("idProducto");
                    String nombre = reader.GetString("nombre");
                    String descripcion = reader.GetString("descripcion");
                    int idUM = reader.GetInt32("idUnidadMedida");
                    p.IdProducto = id;
                    p.NombreProducto = nombre;
                    p.Descripcion = descripcion;
                    UnidadMedida u = new UnidadMedida();
                    u.IdUnidadMedida = idUM;
                    p.UnidadMedida = u;
                    lista.Add(p);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }

        public void obtenerDatosInsumoComponene(Producto p)
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
                cmd.CommandText = "OBTENER_INSUMOS";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", p.IdProducto);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Insumo i = new Insumo();
                    i.IdInsumo = reader.GetInt32("idInsumo");
                    i.NombreInsumo = reader.GetString("nombre");
                    i.Descripcion = reader.GetString("descripcion");
                    i.UnidadMedida.IdUnidadMedida = reader.GetInt32("idUnidadMedida");
                    i.Cantidad = reader.GetDouble("cantidad");
                    i.Composicion = reader.GetDouble("composicion");
                    p.ListaInsumo.Add(i);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
