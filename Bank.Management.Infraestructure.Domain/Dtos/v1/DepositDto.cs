namespace Bank.Management.Domain.Dtos.v1
{
    public class DepositDto
    {
        public long WalletId { get; set; }

        public decimal Amount { get; set; }
    }
}
