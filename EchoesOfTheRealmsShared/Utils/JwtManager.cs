using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EotR.App.Utils
{
    public class JwtManager
    {
        private readonly JwtSecurityTokenHandler _handler = new();

        private readonly SecurityKey _securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("EchoesOfTheRealms by Haku!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"));


        public string CreateToken(int ID, string NickName, List<string> Role)
        {
            JwtSecurityToken t = new(
            
                "EchoesOfTheRealms",
                null,
                [
                
                    new Claim(ClaimTypes.NameIdentifier, ID.ToString(), ClaimValueTypes.Integer),
                    new Claim(ClaimTypes.Name, NickName),
                    ..Role.Select(r => new Claim(ClaimTypes.Role, r))
                    
                ],
                DateTime.UtcNow,
                DateTime.UtcNow.AddHours(15),
                new SigningCredentials(_securityKey, SecurityAlgorithms.HmacSha256)
            );

            return _handler.WriteToken(t);
        }

        public ClaimsPrincipal? ValidateToken(string token)
        {
            try
            {
                return _handler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    IssuerSigningKey = _securityKey,
                    ClockSkew = TimeSpan.FromMinutes(1)
                }, out SecurityToken key);
            }
            catch (Exception)
            {
                return null;
            }
        }



    }
}
