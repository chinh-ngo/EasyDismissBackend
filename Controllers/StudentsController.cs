using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private StudentsService _studentsService;
        
        public StudentsController(StudentsService studentsService)
        {
            _studentsService = studentsService;
        }

        [HttpGet]
        public IActionResult Students()
        {
            var response = _studentsService.Students();
            if(response == null)
                return NotFound();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudent(long id)
        {
            var item = _studentsService.GetStudentById(id);

            if (item == null)
                return NotFound();

            return Ok(item);
        }



    }
}
