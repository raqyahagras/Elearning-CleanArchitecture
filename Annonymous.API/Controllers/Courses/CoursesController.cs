using Annonymous.Application.Services.Interfaces.Courses;
using Anonymous.Infrastructure.Services.Implementations.Courses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Annonymous.API.Controllers.Courses
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseServices _courseServices;

        public CoursesController(ICourseServices courseServices)
        {
            _courseServices = courseServices;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _courseServices.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var course = await _courseServices.GetByIdAsync(id);
            if (course == null) return NotFound();
            return Ok(course);
        }
    }
}
