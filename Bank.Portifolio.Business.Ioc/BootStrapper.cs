using Bank.Portifolio.Business.Application;
using Bank.Portifolio.Business.Application.Interfaces;
using Bank.Portifolio.Business.Infra.Data.Repository;
using Bank.Portifolio.Bussines.Domain.Interfaces;
using Bank.Portifolio.Bussines.Domain.Interfaces.Services;
using Bank.Portifolio.Bussines.Domain.Services;
using SimpleInjector;

namespace Bank.Portifolio.Business.Ioc
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            // Lifestyle.Transient => Uma instancia para cada solicitacao;
            // Lifestyle.Singleton => Uma instancia unica para a classe
            // Lifestyle.Scoped => Uma instancia unica para o request

            // Repository
            container.Register<IClienteAppService, ClientAppService>(Lifestyle.Scoped);
            container.Register<IClientRepository, ClientRepository>(Lifestyle.Scoped);
            container.Register<IBusinessRepository, BusinessRepository>(Lifestyle.Scoped);
            container.Register<ICategoryRepository, CategoryRepository>(Lifestyle.Scoped);
            container.Register<IPortifolioRepository, PortifolioRepository>(Lifestyle.Scoped);

            //App
            container.Register<IBusinessAppService, BusinessAppService>(Lifestyle.Scoped);
            container.Register<ICategoryAppService, CategoryAppService>(Lifestyle.Scoped);
            container.Register<IPortifolioAppService, PortifolioAppService>(Lifestyle.Scoped);
            
            //Domain
            container.Register<IServiceBusiness, BusinessService>(Lifestyle.Scoped);
        }
    }
}
