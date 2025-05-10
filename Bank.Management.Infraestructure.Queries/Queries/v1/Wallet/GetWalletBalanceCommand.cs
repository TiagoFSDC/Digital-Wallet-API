using MediatR;

namespace Bank.Management.Infraestructure.Queries.Queries.v1.Wallet
{
    public sealed class GetWalletBalanceCommand : IRequest<GetWalletBalanceCommandResponse>
    {
        public long WalletId { get; set; }
    }
}
