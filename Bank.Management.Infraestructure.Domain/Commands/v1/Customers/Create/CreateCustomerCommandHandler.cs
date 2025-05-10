using AutoMapper;
using Bank.Management.Domain.Contracts.v1.Repositories;
using Bank.Management.Domain.Dtos.v1;
using MediatR;

namespace Bank.Management.Domain.Commands.v1.Customers.Create
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;

        public CreateCustomerCommandHandler(
            IMapper mapper,
            ICustomerRepository customerRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task<bool> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = _mapper.Map<CustomerDto>(request);

            await _customerRepository.CreateCustomerAsync(customer);

            return await Task.FromResult(true);
        }
    }
}
