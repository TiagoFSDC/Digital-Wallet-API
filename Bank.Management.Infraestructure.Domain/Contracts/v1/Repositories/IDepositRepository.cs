using Bank.Management.Domain.Dtos.v1;

namespace Bank.Management.Domain.Contracts.v1.Repositories
{
    public interface IDepositRepository
    {
        Task CreateDepositAsync(DepositDto deposit);
    }
}
