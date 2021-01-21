using Bank.Portifolio.Business.Application.ViewModels;
using System.Collections.Generic;

namespace Bank.Portifolio.Business.Application.Interfaces
{
    public interface IClienteAppService
    {
        IEnumerable<ClientViewModel> GetAll();
        void CreateClient(ClientViewModel client);
        ClientViewModel GetClientByID(int id);
        void UpdateClient(ClientViewModel client);
    }
}
