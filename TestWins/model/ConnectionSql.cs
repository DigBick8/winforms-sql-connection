namespace TestWins.Model;

//dotnet add package MySql.Data
using MySql.Data.MySqlClient;

    public class ConnectionSql
    {
        private readonly string _connectionString = "server=localhost;database=student;uid=root;pwd=root;";
        private MySqlConnection _conn;

        public MySqlConnection connectSql()
        {
            Console.WriteLine("Connecting to DB");

            _conn = new MySqlConnection(_connectionString);
            _conn.Open();

            Console.WriteLine(_conn.State == System.Data.ConnectionState.Open
                ? "Database connection successful"
                : "Database Connection Failed");

            return _conn;
        }
    }

