using MySql.Data.MySqlClient;
using PROJETOSIGOS.Conexão;
using System;
using System.Data;

namespace PROJETOSIGOS.Conexão
{
    public class Conexao
    {
        private readonly string connectionString =
            "Server=127.0.0.1;Port=3307;Database=SIGOSDB;Uid=root;Pwd=;";

        public MySqlConnection Conectar()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);

                conn.Open();

                return conn;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }
    }
}