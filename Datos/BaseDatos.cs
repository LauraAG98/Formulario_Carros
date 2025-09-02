using Datos.entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class BaseDatos : ConexionDB
    {
        List<CarrosEntity> listaCarros;

        public BaseDatos()
        {
            listaCarros = new List<CarrosEntity>();
            InicializarBaseDatos();
        }

        private void InicializarBaseDatos()
        {
            string cadenaServidor = $"server={cadenaConexion.Server};user={cadenaConexion.UserID};password={cadenaConexion.Password};";
            using (MySqlConnection connection = new MySqlConnection(cadenaServidor))
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();

                command.CommandText = "CREATE DATABASE IF NOT EXISTS formulario_carros;";
                command.ExecuteNonQuery();

                command.CommandText = "USE formulario_carros;";
                command.ExecuteNonQuery();

                command.CommandText = @"CREATE TABLE IF NOT EXISTS personas (
                                            placa VARCHAR(50) PRIMARY KEY,
                                            modelo VARCHAR(100),
                                            marca VARCHAR(10),
                                            color VARCHAR(20)
                                        );";
                command.ExecuteNonQuery();
            }
        }

        public string GuardarDatos(string placa, string modelo, string marca, string color) {

            string resultado = "";

            MySqlConnection connection = new MySqlConnection(cadenaConexion.ConnectionString);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "INSERT INTO carros (placa,modelo,marca,color) values ('" + placa + "', '" + modelo + "', '" + marca + "', '" + color + "')";

            int numeroFilas = command.ExecuteNonQuery();

            if (numeroFilas > 0)
            {
                resultado = "Guardado";
            }
            else
            {
                resultado = "No se guardo";
            }

            connection.Close();

            return resultado;

        }

        public List<CarrosEntity> VerCarros() {

            listaCarros = new List<CarrosEntity>();
            MySqlConnection connection = new MySqlConnection(cadenaConexion.ConnectionString);

            connection.Open();

            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM carros";

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                CarrosEntity carroActual = new CarrosEntity();

                carroActual.placa = reader.GetString(0);
                carroActual.modelo = reader.GetString(1);
                carroActual.marca = reader.GetString(2);
                carroActual.color = reader.GetString(3);

                listaCarros.Add(carroActual);
            }
            return listaCarros;
        }

        public CarrosEntity buscarDatos(string placa) {

            CarrosEntity carroActual = new CarrosEntity();
            MySqlConnection connection = new MySqlConnection(cadenaConexion.ConnectionString);

            connection.Open();

            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM carros WHERE placa = '"+placa+"'";

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                carroActual = new CarrosEntity();

                carroActual.placa = reader.GetString(0);
                carroActual.modelo = reader.GetString(1);
                carroActual.marca = reader.GetString(2);
                carroActual.color = reader.GetString(3);

            }

            return carroActual;
        }

        public string actualizarDatos(string placa, string modelo, string marca, string color)
        {

            MySqlConnection connection = new MySqlConnection(cadenaConexion.ConnectionString);

            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE carros SET modelo = '" + modelo + "', marca = '" + marca +"', color = '"+ color + "' WHERE placa = '" + placa + "'";
            
            int filas = command.ExecuteNonQuery();

            connection.Close();

            if (filas > 0)
            {
                return "Carro actualizado correctamente";
            }
            else
            {
                return "No se encontró el carro con esa placa";
            }

        }

        public string eliminarDatos(string placa) {
            MySqlConnection connection = new MySqlConnection(cadenaConexion.ConnectionString);

            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "DELETE FROM carros WHERE placa = '" + placa + "'";

            int filas = command.ExecuteNonQuery();

            connection.Close();

            if (filas > 0)
            {
                return "Carro eliminado correctamente";
            }
            else
            {
                return "No se encontró un carro con esa placa";
            }
        }
    }
}