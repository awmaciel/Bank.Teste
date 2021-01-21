using AutoMapper;
using Bank.Portifolio.Business.Application.ViewModels;
using Bank.Portifolio.Bussines.Domain.Entities;

namespace Bank.Portifolio.Business.Application.AutoMapper
{
    class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<ClientViewModel, Client>();
            CreateMap<CategoryViewModel, CategoryViewModel>();
            CreateMap<PortifolioViewModel, Bank.Portifolio.Bussines.Domain.Entities.Portifolio>();
            CreateMap<BusinessViewModel, Bank.Portifolio.Bussines.Domain.Entities.Business>();
        }
    }
}
