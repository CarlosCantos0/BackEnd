using PruebasBackendDominio.Interfaces.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PruebasBackendServicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : sdController.Base.sdController
    {
        IClientesUnitOfWork _unitOfWork;

        public ClientesController(IClientesUnitOfWork unitOfWork) : base()
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> GetClientes()
        {
            // Prueba llamando a método de EE
            try
            {
                var data = await _unitOfWork.ClientesRepositorio.AllAsync();
                return Ok(data, "Lista de Clientes");
            }
            catch (Exception ex)
            {
                return BadRequest("Se ha producido un error al intentar obtener la lista de Clientes", ex);
            }
        }


    }
}
