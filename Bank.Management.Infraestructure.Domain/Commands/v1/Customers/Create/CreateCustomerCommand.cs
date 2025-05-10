using MediatR;

namespace Bank.Management.Domain.Commands.v1.Customers.Create
{
    public sealed class CreateCustomerCommand : IRequest<bool>
    {
        public string Name { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }
    }
}
