using Annonymous.Domain.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annonymous.Domain.Entities.Courses
{
    public class Course
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required, MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Each course belongs to one teacher
        [ForeignKey("Teacher")]
        public int? TeacherId { get; set; }
        public Teacher Teacher { get; set; } = null!;
    }
}
