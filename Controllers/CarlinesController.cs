using Backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CarlinesController : ControllerBase
    {
        private readonly CarlinesService _carlinesService;
        public CarlinesController(CarlinesService carlinesService)
        {
            _carlinesService = carlinesService;
        }

        [HttpGet]
        public IActionResult Carlines()
        {
            var response = _carlinesService.Carlines();
            if(response == null)
                return NotFound();
            return Ok(response);
        }
    }
}
