using Annonymous.Application.DTOs.Authentication;
using Annonymous.Application.DTOs.Shared;
using Annonymous.Application.Services.Interfaces.Auth;
using Annonymous.Domain.Entities.Auth;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous.Infrastructure.Services.Implementations.Auth
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public Task<Result<AuthDto>> LoginAsync(LoginDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task<Result<AuthDto>> RegisterAsync(RegisterDto dto)
        {
            if(string.IsNullOrEmpty(dto.Email) || string.IsNullOrEmpty(dto.Password))
                throw new ArgumentException("Email and password are required.");

            if (await _userManager.FindByEmailAsync(dto.Email) is not null)
                throw new InvalidOperationException("Email already exists.");
            // create app user
            var user = new ApplicationUser
            {
                UserName = dto.Email,
                Email = dto.Email,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
            };
            return null;

        }
    }
}
