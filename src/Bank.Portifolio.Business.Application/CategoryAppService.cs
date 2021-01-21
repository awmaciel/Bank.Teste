using AutoMapper;
using Bank.Portifolio.Business.Application.Interfaces;
using Bank.Portifolio.Business.Application.ViewModels;
using Bank.Portifolio.Bussines.Domain.Interfaces;
using System.Collections.Generic;

namespace Bank.Portifolio.Business.Application
{
    public class CategoryAppService : ICategoryAppService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryAppService(ICategoryRepository CategoryRepository)
        {
            _categoryRepository = CategoryRepository;
        }
        public IEnumerable<CategoryViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<CategoryViewModel>>(_categoryRepository.GetAll());            
        }
    }
}
