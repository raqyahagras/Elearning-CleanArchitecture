using Annonymous.Domain.Entities.Auth;
using Annonymous.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annonymous.Domain.Entities.Students
{
    public class Student
    {
        public int Id { get; set; }
        public Level Level { get; set; }

        [ForeignKey(nameof(User))]
        public string ApplicationUserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = null!;
    }
}
