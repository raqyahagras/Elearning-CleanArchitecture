using Annonymous.Application.DTOs;
using Annonymous.Domain.Entities.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annonymous.Application.Services.Interfaces
{
    public interface IJwtService
    {
        Task<JwtTokenDto> GenerateToken(ApplicationUser user);
        RefreshToken GenerateRefreshToken(ApplicationUser user);
    }
}
