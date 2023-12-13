
using PruebasBackendDominio.Interfaces.Repositories;
using sdCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebasBackendDomain.Interfaces.UnitOfWork
{
    public interface IEntidadesBasicasUnitOfWork: IsdUnitOfWork
    {        
        public IMunicipiosRepositorio MunicipioRepository { get; }
        public ITipoInspeccionesRepositorio TipoInspeccionRepository  { get; }

    }
}
