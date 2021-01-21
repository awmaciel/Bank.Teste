using Bank.Portifolio.Bussines.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Bank.Portifolio.Business.Infra.Data.Repository
{
    public class BusinessRepository : RepositoryBase<Bank.Portifolio.Bussines.Domain.Entities.Business>, IBusinessRepository
    {
        public IQueryable<Bank.Portifolio.Bussines.Domain.Entities.Business> ListBusinessHighRisk()
        {
            return Db.Businesses.Include("Client").Include("Category").Include("Portifolio").AsNoTracking().Where(x => x.IdCategory == 1);
        }

        public IQueryable<Bank.Portifolio.Bussines.Domain.Entities.Business> ListBusinessMediumRisk()
        {
            return Db.Businesses.Include("Client").Include("Category").Include("Portifolio").AsNoTracking().Where(x => x.IdCategory == 2);
        }

        public IQueryable<Bank.Portifolio.Bussines.Domain.Entities.Business> ListBusinessLowRisk()
        {
            return Db.Businesses.Include("Client").Include("Category").Include("Portifolio").AsNoTracking().Where(x => x.IdCategory == 3);
        }

        public IQueryable<Bank.Portifolio.Bussines.Domain.Entities.Business> ListBusiness(IEnumerable<Bank.Portifolio.Bussines.Domain.Entities.Business> LstBusiness)
        {
            return Db.Businesses.Include("Client").Include("Category").Include("Portifolio").AsNoTracking();
        }
    }
}
