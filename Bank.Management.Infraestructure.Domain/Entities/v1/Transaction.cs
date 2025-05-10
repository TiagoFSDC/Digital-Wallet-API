namespace Bank.Management.Domain.Entities.v1
{
    public sealed class Transaction
    {
        public int TranferId { get; set; }

        public long OriginWalletId { get; set; }

        public long DestinationWalletId { get; set; }

        public decimal Amount { get; set; }

        public DateTime TransferDate { get; set; }

        public string Status { get; set; }

        public string Description { get; set; }

        public Guid OriginCustomerId { get; set; }

        public Guid DestinationCustomerId { get; set; }
    }
}
