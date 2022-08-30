using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Struggle.Common;
using Struggle.Data.Requests.Contracts;
using Struggle.Data.Services.Abstractions;

namespace Struggle.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService service;

        public CarController(ICarService service)
        {
            this.service = service;
        }
        [HttpGet("get/{color}")]
        public async Task<IActionResult> GetCarByColor([FromRoute]Color color,CancellationToken cancellationToken)
        {
            var result = await service.GetCarByColor(color, cancellationToken);
            return Ok(result);
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteCarById([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var result = await service.DeleteCarById(id, cancellationToken);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        //HttpPut ile de yapılabilirdi.
        [HttpPost("update")]
        public async Task<IActionResult> UpdateCar([FromBody] UpdateCarDto data, CancellationToken cancellationToken)
        {
            var result = await service.UpdateCar(data, cancellationToken);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
