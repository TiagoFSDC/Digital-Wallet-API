using Bank.Management.Domain.Contracts.v1.Repositories;
using Bank.Management.Domain.Dtos.v1;
using Bank.Management.Domain.Entities.v1;
using Bank.Management.Infraestructure.Data.PostgreSQL.Builders.v1;
using Bank.Management.Infraestructure.Domain.Entities.v1;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Bank.Management.Infraestructure.Data.PostgreSQL.Repositories.v1
{
    public class TransactionRespository : ITransactionRepository
    {
        private readonly string _connectionString;

        public TransactionRespository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("BankConnection");
        }

        public async Task CreateTransactionAsync(TransactionDto transaction)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            await connection.ExecuteAsync(TransactionQueryBuilder.CreateTransaction, transaction);
        }

        public async Task<IEnumerable<WalletTransferResultDto>> GetTransactionAsync(GetTransactionDto transaction)
        {
            using var connection = new NpgsqlConnection(_connectionString);

            var parameters = new
            {
                transaction.CustomerId,
                transaction.StartDate,
                transaction.EndDate
            };

            return await connection.QueryAsync<WalletTransferResultDto>(
                TransactionQueryBuilder.GetTransaction,
                parameters
            );
        }
    }
}
