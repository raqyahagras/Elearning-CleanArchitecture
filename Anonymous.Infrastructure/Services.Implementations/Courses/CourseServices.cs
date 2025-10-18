using Annonymous.Application.DTOs.Courses;
using Annonymous.Application.Repositories.Interfaces;
using Annonymous.Application.Services.Interfaces.Courses;
using Annonymous.Domain.Entities.Courses;
using Anonymous.Infrastructure.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous.Infrastructure.Services.Implementations.Courses
{
    public class CourseServices : ICourseServices
    {
        private readonly ICourseRepository _courseRepository;

        public CourseServices(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<IEnumerable<CourseGetDto>> GetAllAsync()
        {
            var courses = await _courseRepository.GetAllAsync();
            return courses.Select(c => new CourseGetDto
            {
                Id = c.Id,
                Title = c.Title,
                Description = c.Description,
                Price = c.Price,
                TeacherName = c.Teacher?.User != null
            ? $"{c.Teacher.User.FirstName} {c.Teacher.User.LastName}"
            : "Unknown Teacher",
                CreatedAt = c.CreatedAt
            }
            );
        }
        public async Task<CourseGetDto?> GetByIdAsync(int id)
        {
            var course=await _courseRepository.GetByIdAsync(id);
            if (course == null) ;

            return new CourseGetDto
            {
                Id = course.Id,
                Title = course.Title,
                Description = course.Description,
                Price = course.Price,
                TeacherName = course.Teacher?.User != null
            ? $"{course.Teacher.User.FirstName} {course.Teacher.User.LastName}"
            : "Unknown Teacher",
                CreatedAt = course.CreatedAt
            };
        }
    }
}
