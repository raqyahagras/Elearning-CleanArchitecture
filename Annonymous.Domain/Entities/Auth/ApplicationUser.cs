using Annonymous.Domain.Entities.Students;
using Annonymous.Domain.Entities.Students;
using Annonymous.Domain.Entities.Teachers;
using Annonymous.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Annonymous.Domain.Entities.Auth
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public string? ProfilePictureUrl { get; set; } = string.Empty;
        public Student Student { get; set; } = null!;
        public Teacher Teacher { get; set; } = null!;
    }
}
