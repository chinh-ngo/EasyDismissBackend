using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/v1/[controller]")]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public IActionResult Authenticate([FromBody]AuthRequest request)
        {
            var response = _authService.Authenticate(request);

            if (response == null)
                return BadRequest(new { message = "Invalid username or password!" });

            return Ok(response);
        }
    }
}

