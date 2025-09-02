using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ConexionDB
    {
        public MySqlConnectionStringBuilder cadenaConexion;
        public ConexionDB() 
        {
            cadenaConexion = new MySqlConnectionStringBuilder()
            {
                Server = "localhost",
                Database = "formulario_carros",
                UserID = "root",
                Password = ""
            };
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(cadenaConexion.ConnectionString);
        }
    }
}