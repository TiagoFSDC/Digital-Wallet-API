using Bank.Management.Domain.Contracts.v1.Repositories;
using Bank.Management.Domain.Dtos.v1;
using MediatR;

namespace Bank.Management.Domain.Commands.v1.Deposit.Create
{
    public class CreateDepositCommandHandler : IRequestHandler<CreateDepositCommand, CreateDepositCommandResponse>
    {
        private readonly IWalletRepository _walletRepository;
        private readonly IDepositRepository _depositRepository;

        public CreateDepositCommandHandler(IWalletRepository walletRepository, IDepositRepository depositRepository)
        {
            _walletRepository = walletRepository;
            _depositRepository = depositRepository;
        }

        public async Task<CreateDepositCommandResponse> Handle(CreateDepositCommand request, CancellationToken cancellationToken)
        {
            var deposit = new DepositDto
            {
                WalletId = request.WalletId,
                Amount = request.Amount,
            };

            await _walletRepository.DepositWalletAsync(deposit);

            await _depositRepository.CreateDepositAsync(deposit);

            return new CreateDepositCommandResponse();
        }
    }
}
