using Bank.Portifolio.Bussines.Domain.Entities;
using Bank.Portifolio.Bussines.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Bank.Portifolio.Bussines.Domain.Services
{
    public class BusinessService
    {
        private readonly IBusinessRepository _businessRepository;

        public BusinessService(IBusinessRepository BusinessRepository)
        {
            _businessRepository = BusinessRepository;
        }

        public IEnumerable<Category> GetAllBusinessCategory(IEnumerable<Business> LstBusiness)
        {
            var result = _businessRepository.ListBusiness(LstBusiness).AsEnumerable();
            return null; //_businessRepository.ListBusiness(LstBusiness).AsEnumerable(); //pegar da app e enviar pra cá            
        }
    }
}
