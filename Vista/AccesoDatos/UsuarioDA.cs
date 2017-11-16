using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos {
    public class UsuarioDA {
        public UsuarioDA() {

        }
        public bool validarUsuario(Usuario u) {
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
            while (dr.Read()) {
                System.Console.WriteLine(dr.GetString(0));
                System.Console.WriteLine(dr.GetString(1));
                if (u.Nombre == dr.GetString(0)) {
                    if (u.Pass == dr.GetString(1))
                        return true;
                }
                    
            }
            con.Close();
            return false;
        }
    }
}
