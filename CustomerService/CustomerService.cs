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
        using var connection = _dbConnectionProvider.GetDbConnection();
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT id, name FROM Customers";
        command.Connection?.Open();
        
        using var dataReader = command.ExecuteReader();
        while (dataReader.Read())
        {
            var id = dataReader.GetInt64(0);
            var name = dataReader.GetString(1);
            customers.Add(new Customer(id, name));
        }
        return customers;
    }

    public void Create(Customer customer)
    {
        using var connection = _dbConnectionProvider.GetDbConnection();
        using var command = connection.CreateCommand();
        
        var id = command.CreateParameter();
        id.ParameterName = "id";
        id.Value = customer.Id;
        
        var name = command.CreateParameter();
        name.ParameterName = "name";
        name.Value = customer.Name;
        
        command.CommandText = "INSERT INTO Customers (id, name) VALUES (@id, @name)";
        command.Parameters.Add(id);
        command.Parameters.Add(name);
        command.Connection?.Open();
        command.ExecuteNonQuery();
    }

    private void CreateCustomersTable()
    {
        using var connection = _dbConnectionProvider.GetDbConnection();
        using var command = connection.CreateCommand();
        command.CommandText =
            "create table if not exists customers (id bigint not null, name varchar not null, primary key (id))";
        command.Connection?.Open();
        command.ExecuteNonQuery();
    }
}