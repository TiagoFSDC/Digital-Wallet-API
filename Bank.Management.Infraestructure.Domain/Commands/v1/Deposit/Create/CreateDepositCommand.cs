using MediatR;

namespace Bank.Management.Domain.Commands.v1.Deposit.Create
{
    public sealed class CreateDepositCommand : IRequest<CreateDepositCommandResponse>
    {
        public long WalletId { get; set; }

        public decimal Amount { get; set; }
    }
}
