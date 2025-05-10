using Bank.Management.Domain.Dtos.v1;

namespace Bank.Management.Domain.Contracts.v1.Repositories
{
    public interface ICustomerRepository
    {
        Task CreateCustomerAsync(CustomerDto customer);
    }
}
