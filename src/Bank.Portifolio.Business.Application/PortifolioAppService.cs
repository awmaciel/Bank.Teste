using AutoMapper;
using Bank.Portifolio.Business.Application.Interfaces;
using Bank.Portifolio.Business.Application.ViewModels;
using Bank.Portifolio.Bussines.Domain.Interfaces;
using System.Collections.Generic;

namespace Bank.Portifolio.Business.Application
{
    public class PortifolioAppService : IPortifolioAppService
    {
        private readonly IPortifolioRepository _portifolioRepository;
        public PortifolioAppService(IPortifolioRepository PortifolioRepository)
        {
            _portifolioRepository = PortifolioRepository;
        }
        public IEnumerable<PortifolioViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<PortifolioViewModel>>(_portifolioRepository.GetAll());
        }
    }
}
