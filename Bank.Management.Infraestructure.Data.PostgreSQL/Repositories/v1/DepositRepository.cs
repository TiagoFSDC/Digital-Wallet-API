using Bank.Management.Domain.Contracts.v1.Repositories;
using Bank.Management.Domain.Dtos.v1;
using Bank.Management.Infraestructure.Data.PostgreSQL.Builders.v1;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Bank.Management.Infraestructure.Data.PostgreSQL.Repositories.v1
{
    public sealed class DepositRepository : IDepositRepository
    {
        private readonly string _connectionString;

        public DepositRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("BankConnection");
        }

        public async Task CreateDepositAsync(DepositDto deposit)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            await connection.ExecuteAsync(DepositQueryBuilder.CreateDeposit, deposit);
        }
    }
}
