using Annonymous.Domain.Entities.Auth;
using Annonymous.Domain.Entities.Students;
using Annonymous.Domain.Entities.Teachers;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous.Infrastructure.Data
{
    public class ELearningDbContext : IdentityDbContext<ApplicationUser>
    {
        public ELearningDbContext(DbContextOptions options) : base(options)
        { }
       

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
