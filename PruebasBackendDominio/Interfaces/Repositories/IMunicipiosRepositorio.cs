using sdCommon.Interfaces;
using PruebasBackendModelo.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PruebasBackendDominio.Interfaces.Repositories
{
    public interface IMunicipiosRepositorio: IsdRepository<Municipio>
    {
        Task<IEnumerable<dynamic>> GetMunicipios();
    }
}
