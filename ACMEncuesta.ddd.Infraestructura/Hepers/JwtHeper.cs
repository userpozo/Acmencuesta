using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ACMEncuesta.ddd.Infraestructura.Hepers
{
    public class JwtHeper
    {
        public readonly byte[] SecretKey;

        public JwtHeper(string @secretKey)
        {
            this.SecretKey = Encoding.ASCII.GetBytes(secretKey);
        }

        public string CrearToken(string @codigoEncuesta)
        {
            var claims = new ClaimsIdentity();
            claims.AddClaim(new Claim(ClaimTypes.NameIdentifier, @codigoEncuesta));

            var descripcionToken = new SecurityTokenDescriptor()
            {
                Subject = claims,
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(this.SecretKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenCreado = tokenHandler.CreateToken(descripcionToken);

            return tokenHandler.WriteToken(tokenCreado);
        }
    }
}
