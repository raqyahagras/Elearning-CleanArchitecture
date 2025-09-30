using Annonymous.Domain.Entities.Auth;
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
       

        
    }
}
