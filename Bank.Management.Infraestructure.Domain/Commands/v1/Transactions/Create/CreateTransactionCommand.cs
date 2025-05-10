using MediatR;

namespace Bank.Management.Domain.Commands.v1.Transactions.Create
{
    public sealed class CreateTransactionCommand : IRequest<CreateTransactionCommandResponse>
    {
        public long OriginWalletId { get; set; }
        public long DestinationWalletId { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }
    }
}
