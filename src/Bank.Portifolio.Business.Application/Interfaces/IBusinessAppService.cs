using Bank.Portifolio.Business.Application.ViewModels;
using Bank.Portifolio.Bussines.Domain.Dto;
using System.Collections.Generic;

namespace Bank.Portifolio.Business.Application.Interfaces
{
    public interface IBusinessAppService
    {
        IEnumerable<TradeCategories> GetCategoriesByBusiness();
        void CreateBusiness(BusinessViewModel BusinessViewModel);
    }
}
