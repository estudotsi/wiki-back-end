using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Data;
using WikiGC.Models;
using WikiGC.Repositories.Interface;

namespace WikiGC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PortalController : Controller
    {
        private readonly IPortaisRepository _portalRepository;

        public PortalController(IPortaisRepository portalRepository)
        {
            _portalRepository = portalRepository;
        }
     
        [HttpGet]
        //[Authorize(Roles = "admin")]
        public async Task<ActionResult<List<Portais>>> ListarPortais()
        {
            try
            {
                List<Portais> portais = await _portalRepository.GetPortais();

                return Ok(portais);
            }
            catch (Exception e)
            {
               return BadRequest(e.Message);
            }

          
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Portais>>> BuscarPorId(int id)
        {
            Portais portais = await _portalRepository.GetoPortalById(id);

            return Ok(portais);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<Portais>> Cadastrar([FromBody] Portais portal)
        {
            Portais portalAdicionado =  await _portalRepository.AddPortal(portal);
            return Ok(portalAdicionado);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<Portais>> Atualizar([FromBody] Portais portal, int id)
        {
            portal.Id = id;
            Portais portalAtualizado = await _portalRepository.UpdatePortal(portal, id);
            return Ok(portalAtualizado);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<Portais>> Deletar(int id)
        {
            await _portalRepository.DeletePortal(id);
            return NoContent();

        }
    }
}
