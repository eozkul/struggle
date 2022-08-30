using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Struggle.Common;
using Struggle.Data.Requests.Contracts;
using Struggle.Data.Services.Abstractions;

namespace Struggle.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        private readonly IBoatService service;

        public BoatController(IBoatService service)
        {
            this.service = service;
        }
        [HttpGet("get/{color}")]
        public async Task<IActionResult> GetBoatByColor([FromRoute] Color color, CancellationToken cancellationToken)
        {
            var result = await service.GetBoatByColor(color, cancellationToken);
            return Ok(result);
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteBoatById([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var result = await service.DeleteBoatById(id, cancellationToken);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
     
    }
}
