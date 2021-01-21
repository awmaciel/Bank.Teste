using Bank.Portifolio.Bussines.Domain.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Bank.Portifolio.Business.Infra.Data.Repository
{
    public class BusinessRepository : RepositoryBase<Bank.Portifolio.Bussines.Domain.Entities.Business>, IBusinessRepository
    {
        public IQueryable<Bank.Portifolio.Bussines.Domain.Entities.Business> ListBusinessHighRisk()
        {
            return Db.Business.Include("Client").Include("Category").Include("Portifolio").AsNoTracking().Where(x => x.IdCategory == 1);
        }

        public IQueryable<Bank.Portifolio.Bussines.Domain.Entities.Business> ListBusinessMediumRisk()
        {
            return Db.Business.Include("Client").Include("Category").Include("Portifolio").AsNoTracking().Where(x => x.IdCategory == 2);
        }

        public IQueryable<Bank.Portifolio.Bussines.Domain.Entities.Business> ListBusinessLowRisk()
        {
            return Db.Business.Include("Client").Include("Category").Include("Portifolio").AsNoTracking().Where(x => x.IdCategory == 3);
        }

        public IQueryable<Bank.Portifolio.Bussines.Domain.Entities.Business> ListBusiness()
        {
            return  Db.Business.Include("Client").Include("Category").Include("Portifolio").AsNoTracking().AsNoTracking();
        }
    }
}
