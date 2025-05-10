using Bank.Management.Domain.Contracts.v1.Repositories;
using Bank.Management.Domain.Dtos.v1;
using MediatR;

namespace Bank.Management.Domain.Commands.v1.Wallet.Create
{
    public class CreateWalletCommandHandler : IRequestHandler<CreateWalletCommand, CreateWalletCommandResponse>
    {
        private readonly IWalletRepository _walletRepository;

        public CreateWalletCommandHandler(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        public async Task<CreateWalletCommandResponse> Handle(CreateWalletCommand request, CancellationToken cancellationToken)
        {
            var wallet = new WalletDto
            {
                CreatedAt = DateTime.UtcNow,
                CustomerId = request.CustomerId,
            };

            var walletNumber = await _walletRepository.CreateWalletAsync(wallet);

            return new CreateWalletCommandResponse
            {
                WalletNumber = walletNumber,
            };
        }
    }
}
