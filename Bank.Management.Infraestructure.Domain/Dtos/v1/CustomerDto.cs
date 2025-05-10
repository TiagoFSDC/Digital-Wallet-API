using System.Text.Json.Serialization;

namespace Bank.Management.Domain.Dtos.v1
{
    public sealed class CustomerDto
    {
        [JsonIgnore]
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }
    }
}
