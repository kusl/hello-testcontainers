using Testcontainers.PostgreSql; // Keep this if DbConnectionProvider or other parts need it directly in tests, but for this specific test, it's used indirectly.
// using Xunit; // This is now globally included via the <Using Include="Xunit"/> in your .csproj

namespace CustomerService.Tests;

public sealed class CustomerServiceTest15 : IAsyncLifetime
{
    private readonly PostgreSqlContainer _postgres = new PostgreSqlBuilder()
        .WithImage("postgres:15-alpine")
        .Build();

    public Task InitializeAsync()
    {
        return _postgres.StartAsync();
    }

    public Task DisposeAsync()
    {
        return _postgres.DisposeAsync().AsTask();
    }

    [Fact]
    public void ShouldReturnThreeCustomers() // Renamed test method to reflect the actual assertion
    {
        // Given
        CustomerService customerService = new CustomerService(new DbConnectionProvider(_postgres.GetConnectionString()));

        // When
        customerService.Create(new Customer(1, "George"));
        customerService.Create(new Customer(2, "John"));
        customerService.Create(new Customer(3, "Mary"));
        IEnumerable<Customer> customers = customerService.GetCustomers();

        // Then
        Assert.Equal(3, customers.Count());
    }
}