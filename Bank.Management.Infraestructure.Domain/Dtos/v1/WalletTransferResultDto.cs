namespace Bank.Management.Domain.Dtos.v1
{
    public sealed class WalletTransferResultDto
    {
        public long TransferId { get; set; }
        public long OriginWalletId { get; set; }
        public long DestinationWalletId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransferDate { get; set; }
        public string Status { get; set; }
        public string? Description { get; set; }
        public Guid OriginCustomerId { get; set; }
        public Guid DestinationCustomerId { get; set; }
    }
}
