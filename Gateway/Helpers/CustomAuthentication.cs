using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace Gateway.Helpers
{
    public static class CustomAuthentication
    {
        public static void AddCustomAuthentication(this IServiceCollection services)
        {
            var key = Encoding.ASCII.GetBytes("This is Secret Key don't share with anyone");
            services.AddAuthentication(x =>
                    {
                        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    }).AddJwtBearer("Bearer", x =>
                    {
                        x.RequireHttpsMetadata = false;
                        x.SaveToken = true;

                        x.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateIssuerSigningKey = true,
                            IssuerSigningKey = new SymmetricSecurityKey(key),
                            ValidateIssuer = false,
                            ValidateAudience = false,
                        };
                    });
        }
    }
}