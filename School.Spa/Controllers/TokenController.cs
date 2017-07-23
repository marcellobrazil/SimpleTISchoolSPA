using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using School.AppServices.DTOs;
using School.AppServices.Interfaces;
using School_Spa.Auth;

namespace School_Spa.Controllers
{
    [Route("api/[controller]")]
    public class TokenController : Controller
    {
        private readonly IUserAppService service;

        public TokenController(IUserAppService service)
        {
            this.service = service;

        }

        // POST api/authorize
        [HttpPost]
        public string Authorize([FromBody]UserDTO user)
        {
            var userDTO = this.service.GetByLogin(user.Login);

            var existUser = (userDTO != null) && (userDTO.Password == "1234");

            if (existUser)
            {
                var requestAt = DateTime.Now;
                var expiresIn = requestAt + TokenAuthOption.ExpiresSpan;
                var token = GenerateToken(userDTO, expiresIn);

                return JsonConvert.SerializeObject(new
                {
                    stateCode = 1,
                    requertAt = requestAt,
                    expiresIn = TokenAuthOption.ExpiresSpan.TotalSeconds,
                    accessToken = token
                });
            }
            else
            {
                return JsonConvert.SerializeObject(new { stateCode = -1, errors = "Username or password is invalid" });
            }
        }

        private string GenerateToken(UserDTO user, DateTime expires)
        {
            var handler = new JwtSecurityTokenHandler();

            ClaimsIdentity identity = new ClaimsIdentity(
                new GenericIdentity(user.Login, "TokenAuth"),
                new[] { new Claim("ID", user.Login) }
            );

            var securityToken = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = TokenAuthOption.Issuer,
                Audience = TokenAuthOption.Audience,
                SigningCredentials = TokenAuthOption.SigningCredentials,
                Subject = identity,
                NotBefore = expires.AddSeconds(-5),
                Expires = expires
            });
            return handler.WriteToken(securityToken);
        }
    }
}
