using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Business.Models;
using Microsoft.IdentityModel.Tokens;

namespace Api.Auth
{
    public class AuthManager : IAuthManager
    {
        private int _expiresIn = 60;

        public AuthManager()
        {
        }

        public AuthResponse? Auth(UserModel user)
        {
            AuthResponse rett = new AuthResponse();

            if (user == null)
            {
                throw new Exception("USER_NON_EXIST");
            }

            try
            {
                rett.Token = this.GetToken(user.UserName);
                rett.ExpiresIn = this._expiresIn.ToString();
                return rett;
            }
            catch (Exception ex)
            {
                throw new Exception("INVALID_TOKEN_REQUEST");
            }
        }

        private string GetToken(string userName)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Startup.AppSecret);

            Claim[] claims = new Claim[] {
                new Claim(ClaimTypes.NameIdentifier, userName)
            };

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(this._expiresIn),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            return tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));
        }
    }
}