using Annonymous.Domain.Entities.Auth;
using Annonymous.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Annonymous.Application.DTOs.Authentication
{
    public class RegisterStudentDto:RegisterDto
    {
        public Level Level { get; set; }

    }
}
