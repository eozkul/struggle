using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Struggle.Common;
using Struggle.Data.Requests.Contracts;
using Struggle.Data.Services.Abstractions;

namespace Struggle.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IBusService service;

        public BusController(IBusService service)
        {
            this.service = service;
        }
        [HttpGet("get/{color}")]
        public async Task<IActionResult> GetBusByColor([FromRoute] Color color, CancellationToken cancellationToken)
        {
            var result = await service.GetBusByColor(color, cancellationToken);
            return Ok(result);
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteBusById([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var result = await service.DeleteBusById(id, cancellationToken);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
   
    }
}
