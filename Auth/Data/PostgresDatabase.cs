using System.Data;
using Auth.Models;
using Npgsql;

namespace Auth.Data
{
    public class PostgresDatabase
    {
        private readonly NpgsqlConnection _connection;
        
        public PostgresDatabase(string connectionString)
        {
            _connection = new NpgsqlConnection(connectionString);
        }

        public InternalResponse OpenConnection()
        {
            _connection.Open();
            return _connection.State == ConnectionState.Open 
                ? new InternalResponse(InternalStatusCode.Ok, "success: connection opened")
                : new InternalResponse(InternalStatusCode.Failed, "failed: could not open connection");
        }

        public InternalResponse CloseConnection()
        {
            _connection.Close();
            return new InternalResponse(InternalStatusCode.Ok, "connection closed");
        }

        public NpgsqlCommand CreateCommand(string command)
        {
            return new NpgsqlCommand(command, _connection);
        }
        
        // Do not use this method without input validation
        public static string BuildConnectionString(string host, string username, string password, string database)
        {
            return $"Host={host};Username={username};Password={password};Database={database}";
        }
    }
}