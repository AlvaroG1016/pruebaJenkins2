using APItest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APItest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MotorcycleController : ControllerBase
    {
        private readonly IMotorcycleService _motorcycleService;

        public MotorcycleController(IMotorcycleService service)
        {
            _motorcycleService = service;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_motorcycleService.GetAllMotorcycle());
        [HttpGet("{id}")]
        public IActionResult getById(int id)
        {
            var motorcycle = _motorcycleService.Get(id);
            if(motorcycle == null)
            
                return NotFound();

            return Ok(motorcycle);            
        }


    }
}
