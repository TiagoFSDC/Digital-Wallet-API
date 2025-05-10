using AutoMapper;
using Bank.Management.Domain.Commands.v1.Transactions.Create;
using Bank.Management.Domain.Dtos.v1;

namespace Bank.Management.Domain.MapperProfiles.v1
{
    public class TransactionDtoMapperProfile : Profile
    {
        public TransactionDtoMapperProfile()
        {
            CreateMap<CreateTransactionCommand, TransactionDto>(MemberList.None);
        }
    }
}
