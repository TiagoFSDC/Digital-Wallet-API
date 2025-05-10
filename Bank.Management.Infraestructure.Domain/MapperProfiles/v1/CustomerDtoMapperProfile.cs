using AutoMapper;
using Bank.Management.Domain.Commands.v1.Customers.Create;
using Bank.Management.Domain.Dtos.v1;

namespace Bank.Management.Domain.MapperProfiles.v1
{
    public sealed class CustomerDtoMapperProfile : Profile
    {
        public CustomerDtoMapperProfile()
        {
            CreateMap<CreateCustomerCommand, CustomerDto>(MemberList.None)
                .ForMember(dest => dest.Name, orig => orig.MapFrom(src => src.Name))
                .ForMember(dest => dest.CPF, orig => orig.MapFrom(src => src.CPF))
                .ForMember(dest => dest.Email, orig => orig.MapFrom(src => src.Email));
        }
    }
}
