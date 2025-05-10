using Bank.Management.Domain.Contracts.v1.Repositories;
using Bank.Management.Domain.Dtos.v1;
using MediatR;

namespace Bank.Management.Infraestructure.Queries.Queries.v1.Transaction
{
    public class GetTransactionsCommandHandler : IRequestHandler<GetTransactionsCommand, GetTransactionsCommandResponse>
    {
        private readonly ITransactionRepository _transactionRepository;
        public GetTransactionsCommandHandler(
            ITransactionRepository transactionRepository
        )
        {
            _transactionRepository = transactionRepository;
        }

        public async Task<GetTransactionsCommandResponse> Handle(GetTransactionsCommand request, CancellationToken cancellationToken)
        {
            var getTransaction = new GetTransactionDto
            {
                CustomerId = request.CustomerId,
                StartDate = request.StartDate,
                EndDate = request.EndDate
            };

            var response = await _transactionRepository.GetTransactionAsync(getTransaction);

            return new GetTransactionsCommandResponse
            {
                Transactions = response
            };
        }
    }
}
