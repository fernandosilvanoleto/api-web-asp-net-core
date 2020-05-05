using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace api_web_asp_net_core.Util
{
    public class DAL
    {
        private static string Server = "localhost";
        private static string Database = "dbcliente";
        private static string User = "root";
        private static string Password = "12345678";
        private MySqlConnection Connection;

        private string ConnectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password};Sslmode=none;";

        public DAL()
        {
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
        }

        // Executa: insert - update - delete
        public void ExecutarComandoSql(string sql)
        {
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            Command.ExecuteNonQuery();

        }

        //BUSCAR DADOS DO BD
        public DataTable RetornarDataTable(string sql)
        {
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            MySqlDataAdapter DataAdaptar = new MySqlDataAdapter(Command);
            DataTable Dados = new DataTable();
            DataAdaptar.Fill(Dados);
            return Dados;
        }

    }
}
