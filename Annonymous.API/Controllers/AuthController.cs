using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Annonymous.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize]
    public class AuthController : ControllerBase
    {
        
    
    }
