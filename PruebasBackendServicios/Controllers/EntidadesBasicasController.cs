using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sdCommon.Interfaces;
using PruebasBackendDominio.UnitOfWork;
using PruebasBackendDomain.Interfaces.UnitOfWork;
using Microsoft.AspNetCore.Authorization;

namespace PruebasBackendServicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class EntidadesBasicasController : sdController.Base.sdController
    {
        IEntidadesBasicasUnitOfWork _unitOfWork;
        public EntidadesBasicasController(IEntidadesBasicasUnitOfWork unitOfWork) : base()
        {           
            _unitOfWork = unitOfWork;
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> GetMunicipios()
        {
            try
            {
                var data = await _unitOfWork.MunicipioRepository.GetMunicipios();
                return Ok(data,"Lista de Municipios");
            }
            catch (Exception ex)
            {
                 return BadRequest("Se ha producido un error al intentar obtener la lista de municipios", ex, true);
            }
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetTiposInspecciones()
        {
            // Prueba llamando a método de EE
            try
            {
                var data = await _unitOfWork.TipoInspeccionRepository.AllAsync();
                return Ok(data, "Lista de Tipos de Inspecciones");
            }
            catch (Exception ex)
            {
                return BadRequest("Se ha producido un error al intentar obtener la lista de Tipos de Inspecciones", ex);
            }
        }
    }
}
