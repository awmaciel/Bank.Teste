using Bank.Portifolio.Business.Application.ViewModels;
using System.Collections.Generic;

namespace Bank.Portifolio.Business.Application.Interfaces
{
    public interface IPortifolioAppService
    {
        IEnumerable<PortifolioViewModel> GetAll();
    }
}
