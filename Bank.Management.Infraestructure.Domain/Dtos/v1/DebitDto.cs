namespace Bank.Management.Domain.Dtos.v1
{
    public class DebitDto
    {
        public long WalletId { get; set; }

        public decimal Amount { get; set; }
    }
}
