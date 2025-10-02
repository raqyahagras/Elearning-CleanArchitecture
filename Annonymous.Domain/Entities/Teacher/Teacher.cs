using Annonymous.Domain.Entities.Auth;
using Annonymous.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annonymous.Domain.Entities.Teachers
{
    public class Teacher
    {
        public int Id { get; set; }
        public Specialization Specialization { get; set; }

        [ForeignKey(nameof(User))]
        public string ApplicationUserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
    }
}
