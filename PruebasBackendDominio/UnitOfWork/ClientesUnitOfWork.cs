using sdDomain.Base;
using PruebasBackendDominio.Interfaces.UnitOfWork;
using PruebasBackendDominio.Interfaces.Repositories;
using PruebasBackendDomain.Context;
using PruebasBackendDominio.Repositories;


namespace PruebasBackendDominio.UnitOfWork
{
    class ClientesUnitOfWork : sdUnitOfWork, IClientesUnitOfWork
    {
        IClientesRepositorio _clientesRepositorio;

        public ClientesUnitOfWork(PruebasBackendContext context) : base(context)
        {
            _clientesRepositorio = new ClientesRepositorio(context);
        }

        public IClientesRepositorio ClientesRepositorio => _clientesRepositorio;

    }
}
