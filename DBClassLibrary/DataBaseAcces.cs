using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary
{
    public class DataBaseAcces : IDataBaseAcces
    {
        private string db_port = "3306";
        private string db_user = "ugyaiyi94quop7in";
        private string db_name = "bsjaidd8wedr5rugrshv";
        private string db_host = "bsjaidd8wedr5rugrshv-mysql.services.clever-cloud.com";
        private string db_password = "BFHml9d3JpWsJ2jZBkYY";
        private string connectionString { get; set; }

        public DataBaseAcces()
		{
            connectionString = $"Server={db_host};Port={db_port};database={db_name};user={db_user};password={db_password}";
        }

        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var rows = await connection.QueryAsync<T>(sql, parameters);

                return rows.ToList();
            }
        }

        public Task SaveData<T>(string sql, T parameters)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                return connection.ExecuteAsync(sql, parameters);
            }
        }

        //private string db_port = "3306";
        //private string db_user = "uvpg5dres8zkh2jp";
        //private string db_name = "bjnwynppswqx1muubomx";
        //private string db_host = "bjnwynppswqx1muubomx-mysql.services.clever-cloud.com";
        //private string db_password = "VsXKhaq6UwALoBWbeRmU";
        //private MySqlConnection db_connection;

        //public DataBaseAcces()
        //{
        //	db_connection = new MySqlConnection($"server={db_host};user={db_user};database={db_name};port={db_port};password={db_password}");
        //}

        //public DataBaseAcces(string host, string user, string password, string name)
        //{
        //	db_user = user;
        //	db_name = name;
        //	db_host = host;
        //	db_password = password;
        //	db_connection = new MySqlConnection($"server={db_host};user={db_user};database={db_name};port={db_port};password={db_password}");
        //}

        //public void GetTabelsName()
        //{
        //	OpenConnection();
        //	string sql_cmd = "SHOW COLUMNS FROM Vesela";
        //	MySqlCommand cmd = new MySqlCommand(sql_cmd, db_connection);
        //	MySqlDataReader rdr = cmd.ExecuteReader();

        //	//while (rdr.Read())
        //	//{
        //	//	Console.WriteLine(rdr[0]);
        //	//}
        //	CloseConnection();
        //}

        //private void OpenConnection()
        //{
        //	if (db_connection.State == System.Data.ConnectionState.Closed)
        //	{
        //		db_connection.Open();
        //	}
        //}

        //private void CloseConnection()
        //{
        //	if (db_connection.State == System.Data.ConnectionState.Open)
        //	{
        //		db_connection.Close();
        //	}
        //}
    }
}
