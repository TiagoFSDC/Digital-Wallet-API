using System.Text.Json.Serialization;

namespace Bank.Management.Domain.Dtos.v1
{
    public sealed class WalletDto
    {
        [JsonIgnore]
        public long Id { get; set; } = DateTime.UtcNow.Ticks;

        public decimal Balance { get; set; } = 0.00M;

        public string Agency { get; set; } = "00555";

        public DateTime CreatedAt { get; set; }

        public Guid CustomerId{ get; set; }
    }
}
