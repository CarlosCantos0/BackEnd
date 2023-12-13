using PruebasBackendModelo.Modelo;
using sdCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebasBackendDominio.Interfaces.Repositories
{
    // Esto me obliga a tener una dependencia con el Modelo que no sé si me interesa. Por ahora lo pongo en Dominio. Estudiar ¿?
    public interface ITipoInspeccionesRepositorio: IsdRepository<TipoInspeccion>
    {

    }


}
