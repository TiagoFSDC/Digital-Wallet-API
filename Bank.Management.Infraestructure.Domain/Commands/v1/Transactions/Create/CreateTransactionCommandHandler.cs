using Bank.Management.Domain.Contracts.v1.Repositories;
using Bank.Management.Domain.Dtos.v1;
using MediatR;

namespace Bank.Management.Domain.Commands.v1.Transactions.Create
{
    public sealed class CreateTransactionCommandHandler : IRequestHandler<CreateTransactionCommand, CreateTransactionCommandResponse>
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IWalletRepository _walletRepository;

        public CreateTransactionCommandHandler(
            ITransactionRepository transactionRepository,
            IWalletRepository walletRepository
        )
        {
            _transactionRepository = transactionRepository;
            _walletRepository = walletRepository;
        }

        public async Task<CreateTransactionCommandResponse> Handle(CreateTransactionCommand request, CancellationToken cancellationToken)
        {
            var originWalletBalance = await _walletRepository.GetWalletBalanceAsync(request.OriginWalletId);

            if (originWalletBalance < request.Amount)
                throw new Exception("Transaction failed: Origin wallet does not have sufficient funds.");

            await _walletRepository.DebitWalletAsync(new DebitDto
            {
                WalletId = request.OriginWalletId,
                Amount = request.Amount
            });

            await _walletRepository.DepositWalletAsync(new DepositDto
            {
                WalletId = request.DestinationWalletId,
                Amount = request.Amount
            });

            await _transactionRepository.CreateTransactionAsync(new TransactionDto
            {
                OriginWalletId = request.OriginWalletId,
                DestinationWalletId = request.DestinationWalletId,
                Amount = request.Amount,
                Description = request.Description
            });

            return new CreateTransactionCommandResponse();
        }
    }
}
