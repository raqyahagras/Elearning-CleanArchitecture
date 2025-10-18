using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annonymous.Application.DTOs.Courses
{
    public class CourseGetDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string TeacherName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
