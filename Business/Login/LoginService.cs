using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Shared.ViewModels;

namespace Business
{
    public class LoginService : ILoginService
    {


        public LoggedViewModel  Login(LogingViewModel login, string strKey, string issuer, int expires)
        {
            LoggedViewModel loggedIn = new LoggedViewModel();

            if (login.Email == "user@gmail.com" && login.Password == "123456")
            { 
            
                var user = new UserViewModel { Ext_Id = "random", Name = "Usuario", UserName = "usuario" ,};
            
                var hasEntity = true;
                var tokenString = BuildToken(user, strKey, issuer, expires);

                loggedIn.User = user;
                loggedIn.User.HasEntity = hasEntity;
                loggedIn.Token = tokenString;

            }
            return  loggedIn; ;

        }
        public string BuildToken(UserViewModel user, string  strKey, string issuer, int expires)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(strKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var claims = new[] {
              new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
              new Claim("ext_id", user.Ext_Id),
              new Claim("userName", user.UserName)
            };
            var token = new JwtSecurityToken(
              issuer,
              issuer,
              claims,
              expires: DateTime.Now.AddMinutes(expires),
              signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);

        }

    }
}
