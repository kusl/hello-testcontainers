using DotNet.Testcontainers.Builders;
using FluentAssertions;
using Testcontainers.PostgreSql;

namespace CustomerService.Tests;

public sealed class CustomerServiceTest : IAsyncLifetime
{
    private readonly PostgreSqlContainer _postgres = new PostgreSqlBuilder()
        .WithImage("postgres:latest")
        .Build();

    public async Task InitializeAsync()
    {
        // return _postgres.StartAsync();
        Console.WriteLine($"Starting container with ID: {_postgres.Id}");
        await _postgres.StartAsync();
        Console.WriteLine($"Container {_postgres.Id} started.");
    }

    public Task DisposeAsync()
    {
        return _postgres.DisposeAsync().AsTask();
    }

    [Fact]
    public void ShouldReturnTwoCustomers()
    {
        // Given
        CustomerService customerService = new CustomerService(new DbConnectionProvider(_postgres.GetConnectionString()));

        // When
        customerService.Create(new Customer(1, "George"));
        customerService.Create(new Customer(2, "John"));
        customerService.Create(new Customer(3, "Mary"));
        IEnumerable<Customer> customers = customerService.GetCustomers();
        

        // Then
        // Assert.Equal(3, customers.Count());
        customers.Count().Should().Be(3);
    }
}