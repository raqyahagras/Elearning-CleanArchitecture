using Anonymous.Infrastructure.Settings;
using Anonymous.Shared.Constants;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Text.Json.Serialization;

namespace Annonymous.API.DependencyInjection
{
    public static class AddAPIDI
    {
        public static IServiceCollection AddAPIServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers()
               .AddJsonOptions(options =>
               {
                   options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
               });
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            #region Add JWT 
            var jwtSettings = configuration.GetSection(AppSettingsConstants.JWT).Get<JWTSettings>();
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
                {
                    options.SaveToken = true;
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = jwtSettings?.Issuer ?? "",
                        ValidAudience = jwtSettings?.Audience ?? "",
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings?.SecretKey ?? "")),
                        ClockSkew = TimeSpan.Zero,
                    };
                });
            #endregion
            return services;
        }
    }
}
