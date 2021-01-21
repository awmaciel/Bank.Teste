using AutoMapper;
using Bank.Portifolio.Business.Application.Interfaces;
using Bank.Portifolio.Business.Application.ViewModels;
using Bank.Portifolio.Bussines.Domain.Dto;
using Bank.Portifolio.Bussines.Domain.Interfaces;
using Bank.Portifolio.Bussines.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Bank.Portifolio.Business.Application
{
    public class BusinessAppService : IBusinessAppService
    {
        private readonly IServiceBusiness _serviceBusiness;
        private readonly IBusinessRepository _businessRepository;
       
        public BusinessAppService(
            IServiceBusiness ServiceBusiness,
            IBusinessRepository BusinessRepository
            )
        {
            _businessRepository = BusinessRepository;
            _serviceBusiness = ServiceBusiness;
        }
        public IEnumerable<TradeCategories> GetCategoriesByBusiness()
        {
            try
            {
                return _serviceBusiness.GetAllBusinessCategory(_businessRepository.GetAll());
            }
            catch(Exception ex)
            {
                throw ex;
            }                      
        }

        public void CreateBusiness(BusinessViewModel BusinessViewModel)
        {
            var BusinessMap = Mapper.Map<Bussines.Domain.Entities.Business>(BusinessViewModel);
            _serviceBusiness.ValidateBusiness(BusinessMap);           
        }
    }
}
