using Bank.Management.Domain.Dtos.v1;

namespace Bank.Management.Domain.Contracts.v1.Repositories
{
    public interface IWalletRepository
    {
        Task<long> CreateWalletAsync(WalletDto wallet);

        Task DepositWalletAsync(DepositDto deposit);

        Task DebitWalletAsync(DebitDto debit);

        Task<long> GetWalletBalanceAsync(long walletId);
    }
}
