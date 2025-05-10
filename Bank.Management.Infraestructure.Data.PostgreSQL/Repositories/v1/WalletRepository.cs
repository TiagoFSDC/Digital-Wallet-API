using Bank.Management.Domain.Contracts.v1.Repositories;
using Bank.Management.Domain.Dtos.v1;
using Bank.Management.Infraestructure.Data.PostgreSQL.Builders.v1;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Bank.Management.Infraestructure.Data.PostgreSQL.Repositories.v1
{
    public sealed class WalletRepository : IWalletRepository
    {
        private readonly string _connectionString;

        public WalletRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("BankConnection");
        }

        public async Task<long> CreateWalletAsync(WalletDto wallet)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            await connection.ExecuteAsync(WalletQueryBuilder.CreateWallet, wallet);
            return wallet.Id;
        }

        public async Task DepositWalletAsync(DepositDto deposit)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            await connection.ExecuteAsync(WalletQueryBuilder.CreditWallet, deposit);
        }

        public async Task DebitWalletAsync(DebitDto debit)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            await connection.ExecuteAsync(WalletQueryBuilder.DebitWallet, debit);
        }

        public async Task<long> GetWalletBalanceAsync(long walletId)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            return await connection.ExecuteScalarAsync<long>(WalletQueryBuilder.GetWalletBalance, new { walletId });
        }
    }
}
