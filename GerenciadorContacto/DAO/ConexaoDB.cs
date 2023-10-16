using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorContacto.DAO
{
    public class ConexaoDB
    {
        private string connectionString;
        private MySqlConnection connection;
        string server = "localhost";
        string database = "contactobissega";
        string username = "root";
        string password = "faiane01";

        public ConexaoDB()
        {
            // Construa a string de conexão
            connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection AbrirConexao()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public void FecharConexao()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}