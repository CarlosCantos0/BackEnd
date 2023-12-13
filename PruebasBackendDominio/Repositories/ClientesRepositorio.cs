using System;
using System.Collections.Generic;
using System.Text;
using sdDomain.Base;
using PruebasBackendModelo.Modelo;
using PruebasBackendDominio.Interfaces.Repositories;
using PruebasBackendDomain.Context;
using System.Threading.Tasks;

namespace PruebasBackendDominio.Repositories
{
    public class ClientesRepositorio: sdRepository<Cliente>, IClientesRepositorio
    {
        public ClientesRepositorio(PruebasBackendContext context) : base(context){}

    }
}
