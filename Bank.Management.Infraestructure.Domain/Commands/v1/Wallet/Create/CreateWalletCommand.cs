using MediatR;

namespace Bank.Management.Domain.Commands.v1.Wallet.Create
{
    public class CreateWalletCommand : IRequest<CreateWalletCommandResponse>
    {
        public Guid CustomerId { get; set; }
    }
}
