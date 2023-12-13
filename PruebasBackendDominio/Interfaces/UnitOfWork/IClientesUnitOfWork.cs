using PruebasBackendDominio.Interfaces.Repositories;
using sdCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebasBackendDominio.Interfaces.UnitOfWork
{
    public interface IClientesUnitOfWork: IsdUnitOfWork
    {
        public IClientesRepositorio ClientesRepositorio { get; }
    }
}
