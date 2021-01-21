using AutoMapper;
using Bank.Portifolio.Business.Application.Interfaces;
using Bank.Portifolio.Business.Application.ViewModels;
using Bank.Portifolio.Bussines.Domain.Entities;
using Bank.Portifolio.Bussines.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Bank.Portifolio.Business.Application
{
    public class ClientAppService : IClienteAppService
    {
        private readonly IClientRepository _clienteRepository;
        public ClientAppService(IClientRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }     
        public IEnumerable<ClientViewModel> GetAll()
        {
            IEnumerable<ClientViewModel> result = null;
            try
            {
                result = Mapper.Map<IEnumerable<ClientViewModel>>(_clienteRepository.GetAll());
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public void CreateClient(ClientViewModel client)
        {
            try
            {
                var clientMap = Mapper.Map<Client>(client);
                _clienteRepository.Add(clientMap);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ClientViewModel GetClientByID(int id)
        {
            try
            {
                return Mapper.Map<ClientViewModel>(_clienteRepository.GetById(id));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateClient(ClientViewModel client)
        {
            try
            {
                var clientMap = Mapper.Map<Client>(client);
                _clienteRepository.Update(clientMap);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
