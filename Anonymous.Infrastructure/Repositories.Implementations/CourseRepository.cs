using Annonymous.Application.Repositories.Interfaces;
using Annonymous.Domain.Entities.Courses;
using Anonymous.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous.Infrastructure.Repositories.Implementations
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ELearningDbContext _context;

        public CourseRepository(ELearningDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Course>> GetAllAsync()
        {
            return await _context.courses.AsNoTracking()
                                 .Include(c=>c.Teacher)
                                 .ToListAsync();
        }

        public async Task<Course?> GetByIdAsync(int id)
        {
            return await _context.courses.AsNoTracking()
                                 .Include(c => c.Teacher)
                                 .ThenInclude(t => t.User)
                                 .FirstOrDefaultAsync(c=>c.Id == id);
        }
    }
}
