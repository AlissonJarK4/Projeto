using System;
using System.Collections.Generic;
using Android.App;
using Android.Widget;
using MySql.Data.MySqlClient;
using Projeto.Models;

namespace Projeto
{
    public class MySQLCon
    {
        MySqlConnection sqlConnection = null;
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

        public string _connectionString = "SERVER=sql10.freemysqlhosting.net; DATABASE=sql10403566; UID=sql10403566; PWD=a28L3eqyaJ; PORT=3306";

        public async void OpenConnection()
        {
            try
            {
                sqlConnection = new MySqlConnection(_connectionString);
                await sqlConnection.OpenAsync();
            }
            catch(Exception ex)
            {
                Toast.MakeText(Application.Context, "Erro ao abrir conexão: " + ex, ToastLength.Long).Show();
            }
        }

        public async void CloseConnection()
        {
            try
            {
                sqlConnection = new MySqlConnection(_connectionString);
                await sqlConnection.CloseAsync();
            }
            catch (Exception ex)
            {
                Toast.MakeText(Application.Context, "Erro ao fechar conexão: " + ex, ToastLength.Long).Show();
            }
        }

        public async void SaveUser(string name, string email, string password)
        {
            string connectionString = _connectionString;
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    OpenConnection();

                    MySqlCommand cmd = new MySqlCommand("Insert into Users(Name, Email, Password) values(@name,@email,@password)");
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<Quiz> FilterQuizzes(string filter)
        {
            string connectionString = _connectionString;
            using (var connection = new MySqlConnection(connectionString))
            {
                OpenConnection();

                List<Quiz> quizzes = new List<Quiz>();

                MySqlCommand cmd = new MySqlCommand("Select * from Quizzes where QuizType = @filter");
                cmd.Parameters.AddWithValue("@filter", filter);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        quizzes.Add(new Quiz
                        {
                            Id = (int)reader.GetInt64("Id"),
                            Image = reader.GetString("Image"),
                            Question = reader.GetString("Question"),
                            Answer1 = reader.GetString("Answer1"),
                            Answer2 = reader.GetString("Answer2"),
                            Answer3 = reader.GetString("Answer3"),
                            CorrectAnswer = (int)reader.GetInt64("CorrectAnswer"),
                        });

                    }
                }

                CloseConnection();
                return quizzes;
            }
        }

        public List<Quiz> SearchQuizzes(string query)
        {
            string connectionString = _connectionString;
            using (var connection = new MySqlConnection(connectionString))
            {
                OpenConnection();

                List<Quiz> quizzes = new List<Quiz>();

                MySqlCommand cmd = new MySqlCommand("Select * from Quizzes where Name like @query OR QuizType like @query");
                cmd.Parameters.AddWithValue("@filter", query);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        quizzes.Add(new Quiz
                        {
                            Id = (int)reader.GetInt64("Id"),
                            Image = reader.GetString("Image"),
                            Question = reader.GetString("Question"),
                            Answer1 = reader.GetString("Answer1"),
                            Answer2 = reader.GetString("Answer2"),
                            Answer3 = reader.GetString("Answer3"),
                            CorrectAnswer = (int)reader.GetInt64("CorrectAnswer"),
                        });

                    }
                }

                CloseConnection();
                return quizzes;
            }
        }

        //public List<string> EditUser(string name, string email, string password)
        //{
        //string connectionString = _connectionString;
        //try
        //{
        //    using (var connection = new MySqlConnection(connectionString))
        //    {
        //        OpenConnection();

        //        MySqlCommand cmd = new MySqlCommand("Insert into Users(Name, Email, Password) values(@name,@email,@password)");
        //        cmd.Parameters.AddWithValue("@name", name);
        //        cmd.Parameters.AddWithValue("@email", email);
        //        cmd.Parameters.AddWithValue("@password", password);
        //        await cmd.ExecuteNonQueryAsync();
        //    }
        //}
        //catch (Exception ex)
        //{

        //}
        //finally
        //{
        //    CloseConnection();
        //}
        //}

        //public QuizPage LoadQuiz(string name, string email, string password)
        //{

        //}
    }
}
