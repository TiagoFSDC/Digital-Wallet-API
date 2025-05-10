using Bank.Management.Domain.Dtos.v1;

namespace Bank.Management.Domain.Contracts.v1.Repositories
{
    public interface ITransactionRepository
    {
        Task CreateTransactionAsync(TransactionDto transaction);

        Task<IEnumerable<WalletTransferResultDto>> GetTransactionAsync(GetTransactionDto transaction);
    }
}
