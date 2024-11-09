using System.Data.Common;
using Npgsql;

namespace CustomerService;

public class DbConnectionProvider
{
    private readonly string _connectionString;

    public DbConnectionProvider(string connectionString)
    {
        _connectionString = connectionString;
    }

    public DbConnection GetDbConnection()
    {
        return new NpgsqlConnection(_connectionString);
    }
}