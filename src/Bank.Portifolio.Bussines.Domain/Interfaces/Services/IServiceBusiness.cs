using Bank.Portifolio.Bussines.Domain.Dto;
using Bank.Portifolio.Bussines.Domain.Entities;
using System.Collections.Generic;

namespace Bank.Portifolio.Bussines.Domain.Interfaces.Services
{
    public interface IServiceBusiness
    {
        IEnumerable<TradeCategories> GetAllBusinessCategory(IEnumerable<Business> LstBusiness);
        void ValidateBusiness(Business business);
    }
}
