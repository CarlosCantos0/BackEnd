using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PruebasBackendDomain.Interfaces.UnitOfWork;
using PruebasBackendDomain.Context;
using PruebasBackendDominio.Repositories;
using PruebasBackendModelo.Modelo;
using PruebasBackendDominio.Interfaces.Repositories;

namespace PruebasBackendDominio.UnitOfWork
{
    public class EntidadesBasicasUnitOfWork: sdDomain.Base.sdUnitOfWork, IEntidadesBasicasUnitOfWork
    {
        IMunicipiosRepositorio _MunicipioRepository;
        ITipoInspeccionesRepositorio _TipoInspeccionRepository;

        public EntidadesBasicasUnitOfWork(PruebasBackendContext context) : base(context)  {            
            _MunicipioRepository = new MunicipiosRepositorio(context);
            _TipoInspeccionRepository = new TipoInspeccionesRepositorio(context);
        }

        public IMunicipiosRepositorio MunicipioRepository => _MunicipioRepository;
        public ITipoInspeccionesRepositorio TipoInspeccionRepository => _TipoInspeccionRepository;

    }
}
