using Bank.Management.Domain.Contracts.v1.Repositories;
using MediatR;

namespace Bank.Management.Infraestructure.Queries.Queries.v1.Wallet
{
    public class GetWalletBalanceCommandHandler : IRequestHandler<GetWalletBalanceCommand, GetWalletBalanceCommandResponse>
    {
        private readonly IWalletRepository _walletRepository;

        public GetWalletBalanceCommandHandler(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        public async Task<GetWalletBalanceCommandResponse> Handle(GetWalletBalanceCommand request, CancellationToken cancellationToken)
        {
            var balance = await _walletRepository.GetWalletBalanceAsync(request.WalletId);

            return new GetWalletBalanceCommandResponse
            {
                Balance = balance,
            };
        }
    }
}
