using Bank.Portifolio.Bussines.Domain.Dto;
using Bank.Portifolio.Bussines.Domain.Entities;
using Bank.Portifolio.Bussines.Domain.Interfaces;
using Bank.Portifolio.Bussines.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace Bank.Portifolio.Bussines.Domain.Services
{
    public class BusinessService : IServiceBusiness
    {
        private readonly IBusinessRepository _businessRepository;
        private readonly IClientRepository _clientRepository;

        public BusinessService(
            IBusinessRepository BusinessRepository,
            IClientRepository ClientRepository)
        {
            _businessRepository = BusinessRepository;
            _clientRepository = ClientRepository;
        }

        public IEnumerable<TradeCategories> GetAllBusinessCategory(IEnumerable<Business> LstBusiness)
        {
            List<TradeCategories> Lsttrade = new List<TradeCategories>();
            TradeCategories trade = null;

            var result = _businessRepository.ListBusiness().ToList();
            foreach (var item in result)
            {
                trade = new TradeCategories()
                {
                    ClientSector = item.Client.SectorClient,
                    NameCategory = item.Category.NameCategory,
                    NameClient = item.Client.NameClient,
                    ValueBusiness = item.ValueBusiness
                };
                Lsttrade.Add(trade);
            }

            return Lsttrade;           
        }

        public void ValidateBusiness(Business business)
        {
            var Client = _clientRepository.GetById(business.IdClient);
            Business bus = new Business();
            
            _businessRepository.Add(bus.ValidateBusiness(business,Client));
            
        }
    }
}
