using PruebasBackendDomain.Context;
using PruebasBackendDominio.Interfaces.Repositories;
using PruebasBackendModelo.Modelo;
using sdCommon.Interfaces;
using sdDomain.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PruebasBackendDominio.Repositories
{
    public class MunicipiosRepositorio : sdRepository<Municipio>, IMunicipiosRepositorio
    {
        public MunicipiosRepositorio(PruebasBackendContext context): base(context)
        {            

        }

        public async Task<IEnumerable<dynamic>> GetMunicipios()
        {
            try
            {
                string spName = "[dbo].spGetMunicipios";

                var data = await ExecuteProcedureAsync(spName);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
    
}
