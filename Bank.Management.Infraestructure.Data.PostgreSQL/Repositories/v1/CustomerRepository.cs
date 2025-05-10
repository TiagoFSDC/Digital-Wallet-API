using Bank.Management.Domain.Contracts.v1.Repositories;
using Bank.Management.Domain.Dtos.v1;
using Bank.Management.Infraestructure.Data.PostgreSQL.Builders.v1;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Bank.Management.Infraestructure.Data.PostgreSQL.Repositories.v1
{
    public sealed class CustomerRepository : ICustomerRepository
    {
        private readonly string _connectionString;

        public CustomerRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("BankConnection");
        }

        public async Task CreateCustomerAsync(CustomerDto customer)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            await connection.ExecuteAsync(CustomerQueryBuilder.CreateCustomer, customer);
        }
    }
}
