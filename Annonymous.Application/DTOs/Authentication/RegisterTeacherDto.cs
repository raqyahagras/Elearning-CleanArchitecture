using Annonymous.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annonymous.Application.DTOs.Authentication
{
    public class RegisterTeacherDto:RegisterDto
    {
        public Specialization Specialization { get; set; }

    }
}
