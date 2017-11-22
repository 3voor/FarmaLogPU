using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AccesoDatos {
    public class UsuarioDA
    {
        public UsuarioDA()
        {

        }
        public bool validarUsuario(Usuario u)
        {
            String url;
            url = "server=200.16.7.96; user=inf282g1; database=inf282g1;password=BRXRKa3O5JUiqJWn;";
            MySqlConnection con = new MySqlConnection(url);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            comando.CommandText = "GET_ADMIN";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = comando.ExecuteReader();
            System.Console.WriteLine("todo ok!");
            while (dr.Read())
            {
                System.Console.WriteLine(dr.GetString(0));
                System.Console.WriteLine(dr.GetString(1));
                if (u.Nombre == dr.GetString(0))
                {
                    if (u.Pass == dr.GetString(1))
                        return true;
                }

            }
            con.Close();
            return false;
        }


        public BindingList<Empleado> obtenerEmpleadosConectados()
        {
            BindingList<Empleado> lista = new BindingList<Empleado>();
            try
            {
                String cadena = "server=200.16.7.96; user=inf282g1; database=inf282g1;password=BRXRKa3O5JUiqJWn;";
                MySqlConnection conn =
                new MySqlConnection(cadena);
                conn.Open();
                System.Console.WriteLine("Conexion exitosa");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "LISTAR_EMPLEADOS_CONECTADOS";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("oyoyoy");
                    Empleado e = new Empleado();
                    int idE = reader.GetInt32("idEmpleado");
                    int idA = reader.GetInt32("idArea");
                    String nombre = reader.GetString("nombres");
                    String apellidos = reader.GetString("apellidos");
                    String correo = reader.GetString("correo");
                    String telefono = reader.GetString("telefono");
                    e.IdEmpleado = idE;
                    e.IdArea = idA;
                    e.NombreEmpleado = nombre;
                    e.ApellidosEmpleado = apellidos;
                    e.Telefono = telefono;
                    e.Correo = correo;
                    lista.Add(e);
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
