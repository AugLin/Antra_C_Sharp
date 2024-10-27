using System.Data.SqlClient;

namespace MovieApplication.Infrastructure.Data
{
    public class SqlDbConnection
    {
        public SqlConnection GetConnection()
        {
            var conn = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build()
                .GetConnectionString("MoviesDatabase");

            return new SqlConnection(conn);
        }
    }
}