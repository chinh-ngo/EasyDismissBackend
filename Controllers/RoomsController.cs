using Backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly RoomsService _roomsService;

        public RoomsController(RoomsService roomsService)
        {
            _roomsService = roomsService;
        }

        [HttpGet]
        public IActionResult Rooms()
        {
            var response = _roomsService.Rooms();
            if (response == null)
                return BadRequest(new { message = "No Rooms" });
            
            return Ok(response);
        }
    }
}
