using Annonymous.Application.DTOs.Authentication;
using Annonymous.Application.DTOs.Shared;
namespace Annonymous.Application.Services.Interfaces.Auth
{
    public interface IAuthService
    {
        Task<Result<AuthDto>> LoginAsync(LoginDto dto);
        Task<Result<AuthDto>> RegisterAsync(RegisterDto dto);


    }
}
