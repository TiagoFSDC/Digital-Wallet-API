namespace Bank.Management.Domain.Dtos.v1
{
    public sealed class GetTransactionDto
    {
        public Guid CustomerId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
