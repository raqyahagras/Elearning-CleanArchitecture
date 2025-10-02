using Annonymous.Domain.Entities.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Annonymous.Application.DTOs.Authentication
{
    public class AuthDto
    {
        public string AccessToken { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public DateTime ExpiresOn { get; set; }//for access token

        [JsonIgnore]
        public RefreshToken RefreshTokens { get; set; }
        public DateTime RefreshTokenExpiration { get; set; }
    }
}
