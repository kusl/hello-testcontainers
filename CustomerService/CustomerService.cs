using System.Data.Common;

namespace CustomerService;

public sealed class CustomerService
{
    private readonly DbConnectionProvider _dbConnectionProvider;

    public CustomerService(DbConnectionProvider dbConnectionProvider)
    {
        _dbConnectionProvider = dbConnectionProvider;
        CreateCustomersTable();
    }

    public IEnumerable<Customer> GetCustomers()
    {
        IList<Customer> customers = new List<Customer>();

        using DbConnection connection = _dbConnectionProvider.GetConnection();
        using DbCommand command = connection.CreateCommand();
        command.CommandText = "SELECT id, name FROM customers";
        command.Connection?.Open();

        using DbDataReader dataReader = command.ExecuteReader();
        while (dataReader.Read())
        {
            long id = dataReader.GetInt64(0);
            string name = dataReader.GetString(1);
            customers.Add(new Customer(id, name));
        }

        return customers;
    }

    public void Create(Customer customer)
    {
        using DbConnection connection = _dbConnectionProvider.GetConnection();
        using DbCommand command = connection.CreateCommand();

        DbParameter id = command.CreateParameter();
        id.ParameterName = "@id";
        id.Value = customer.Id;

        DbParameter name = command.CreateParameter();
        name.ParameterName = "@name";
        name.Value = customer.Name;

        command.CommandText = "INSERT INTO customers (id, name) VALUES(@id, @name)";
        command.Parameters.Add(id);
        command.Parameters.Add(name);
        command.Connection?.Open();
        command.ExecuteNonQuery();
    }

    private void CreateCustomersTable()
    {
        using DbConnection connection = _dbConnectionProvider.GetConnection();
        using DbCommand command = connection.CreateCommand();
        command.CommandText = "CREATE TABLE IF NOT EXISTS customers (id BIGINT NOT NULL, name VARCHAR NOT NULL, PRIMARY KEY (id))";
        command.Connection?.Open();
        command.ExecuteNonQuery();
    }
}