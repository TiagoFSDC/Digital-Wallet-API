using MediatR;

namespace Bank.Management.Infraestructure.Queries.Queries.v1.Transaction
{
    public sealed class GetTransactionsCommand : IRequest<GetTransactionsCommandResponse>
    {
        public Guid CustomerId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
