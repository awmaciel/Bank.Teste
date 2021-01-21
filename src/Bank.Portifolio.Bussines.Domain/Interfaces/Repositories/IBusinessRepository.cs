using Bank.Portifolio.Bussines.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Bank.Portifolio.Bussines.Domain.Interfaces
{
    public interface IBusinessRepository : IRepositoryBase<Business>
    {
        IQueryable<Entities.Business> ListBusinessHighRisk();
        IQueryable<Entities.Business> ListBusinessMediumRisk();
        IQueryable<Entities.Business> ListBusinessLowRisk();
        IQueryable<Bank.Portifolio.Bussines.Domain.Entities.Business> ListBusiness();
    }
}
