using System;
using Android.App;
using Android.Widget;
using MySql.Data.MySqlClient;

namespace Projeto.Droid
{
    class MySQLCon
    {
        MySqlConnection sqlConnection = null;
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

        public string _connectionString = "SERVER=sql10.freemysqlhosting.net; DATABASE=sql10403566; UID=sql10403566; PWD=a28L3eqyaJ; PORT=3306";

        public void OpenConnection()
        {
            try
            {
                sqlConnection = new MySqlConnection(_connectionString);
                sqlConnection.Open();
            }
            catch(Exception ex)
            {
                Toast.MakeText(Application.Context, "Erro ao connectar", ToastLength.Long).Show();
            }
        }

        public void CloseConnection()
        {
            try
            {
                sqlConnection = new MySqlConnection(_connectionString);
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                Toast.MakeText(Application.Context, "Erro ao connectar", ToastLength.Long).Show();
            }
        }

        public void SaveUser(string name, string email, string password)
        {
            string connectionString = _connectionString;
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand("insert into Users(Name, Email, Password) values(@name,@email,@password)", sqlConnection);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        //public List<string> EditUser(string name, string email, string password)
        //{

        //}
    }
}
