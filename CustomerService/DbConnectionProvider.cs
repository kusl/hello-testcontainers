using System.Data.Common;
using Npgsql;

namespace CustomerService;

public sealed class DbConnectionProvider(string connectionString)
{
    public DbConnection GetConnection()
    {
        return new NpgsqlConnection(connectionString);
    }
}