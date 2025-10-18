using Annonymous.Application.DTOs.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annonymous.Application.Services.Interfaces.Courses
{
    public interface ICourseServices
    {
        public Task<IEnumerable<CourseGetDto>> GetAllAsync();
        public  Task<CourseGetDto?> GetByIdAsync(int id);



    }
}
