namespace Bank.Management.Domain.Dtos.v1
{
    public class TransactionDto
    {
        public long OriginWalletId { get; set; }
        public long DestinationWalletId { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }
    }
}
