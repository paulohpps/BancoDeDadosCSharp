using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ordem_de_Serviço
{
    public class Conexao
    {
        public void Main(string comando)
        {
            //Aqui você substitui pelos seus dados
            var connString = "Server=localhost;Database=ProjetoJava;Uid=root;Pwd=1234";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = comando;
                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        public DataTable Consultar(string comando)
        {
            //Aqui você substitui pelos seus dados
            var connString = "Server=localhost;Database=projetojava;Uid=root;Pwd=1234";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "select * from usuario;";
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand(command.CommandText, connection);
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                command.ExecuteNonQuery();
                return dt;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        public void aparelho(string comando2)
        {
            //Aqui você substitui pelos seus dados
            var connString = "Server=localhost;Database=Ordem_de_Servico;Uid=root;Pwd=1234";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = comando2;
                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
