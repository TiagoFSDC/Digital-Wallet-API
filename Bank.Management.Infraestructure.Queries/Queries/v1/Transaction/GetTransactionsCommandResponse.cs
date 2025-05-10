using Bank.Management.Domain.Dtos.v1;

namespace Bank.Management.Infraestructure.Queries.Queries.v1.Transaction
{
    public sealed class GetTransactionsCommandResponse
    {
        public IEnumerable<WalletTransferResultDto> Transactions { get; set; }
    }
}
