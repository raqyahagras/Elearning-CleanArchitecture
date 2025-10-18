using Annonymous.Application.Repositories.Interfaces;
using Annonymous.Application.Services.Interfaces.Courses;
using Annonymous.Domain.Entities.Auth;
using Anonymous.Infrastructure.Data;
using Anonymous.Infrastructure.Repositories.Implementations;
using Anonymous.Infrastructure.Services.Implementations.Courses;
using Anonymous.Shared.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous.Infrastructure.DependencyInjection
{
    public static class AddInfrastructureDI
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)

        {
            #region Add DBContext & Identity
            services.AddDbContext<ELearningDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString(AppSettingsConstants.DefaultConnection));
            });

            services.AddIdentityCore<ApplicationUser>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
            })
               .AddRoles<IdentityRole>()
               .AddEntityFrameworkStores<ELearningDbContext>();
            #endregion
            #region Courses
            // Register Repositories
            services.AddScoped<ICourseRepository, CourseRepository>();

            // Register Services
            services.AddScoped<ICourseServices, CourseServices>(); 
            #endregion


            return services;
        }
    }
}
