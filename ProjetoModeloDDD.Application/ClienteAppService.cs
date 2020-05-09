using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService serviceBase) : base(serviceBase)
        {
            _clienteService = serviceBase;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais()
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }

    }
}
