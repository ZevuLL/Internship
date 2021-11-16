using System;
using System.Data.SqlClient;

namespace Logg
{
    class DataBaseLogWriter : ILogWriter
    {
        private static string connectionString = @"Data Source=DESKTOP-8RRH1VN;Initial Catalog=Log;Integrated Security=True";
        public void Write(AppEvent appEvent)
        {
            string sqlExpression = String.Format("INSERT INTO Logs (Date, Time, LogLevel, Message) VALUES (@Date, @Time, @LogLevel, @Message)");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                    connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@Date", appEvent.EventTime.ToShortDateString());
                command.Parameters.AddWithValue("@Time", appEvent.EventTime.ToLongTimeString());
                command.Parameters.AddWithValue("@LogLevel", appEvent.Level.ToString());
                command.Parameters.AddWithValue("@Message", appEvent.Message);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Добавлено объектов: {0}", number);
            }
        }
    }
}
