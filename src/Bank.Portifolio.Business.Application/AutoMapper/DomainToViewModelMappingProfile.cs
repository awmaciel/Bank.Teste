using AutoMapper;
using Bank.Portifolio.Business.Application.ViewModels;
using Bank.Portifolio.Bussines.Domain.Entities;

namespace Bank.Portifolio.Business.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Client, ClientViewModel>();
            CreateMap<Category, CategoryViewModel>();
            CreateMap<Bank.Portifolio.Bussines.Domain.Entities.Portifolio, PortifolioViewModel>();
            CreateMap<Bank.Portifolio.Bussines.Domain.Entities.Business, BusinessViewModel>();            
        }
    }
}
