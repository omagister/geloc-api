using Geloc.Api.Auth;
using Geloc.Dados;
using Geloc.Dominio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNetCore.Cors;

namespace Geloc.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/login")]
    [EnableCors("AllowAllOrigins")]
    public class LoginController : Controller
    {
        //private Contexto db = new Contexto();
        private readonly Contexto _context;
        public LoginController(Contexto context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpPost]
        public object Post(

            [FromBody]User usuario,
            
            [FromServices]SigningConfigurations signingConfigurations,

            [FromServices]TokenConfigurations tokenConfigurations)

        {

            bool credenciaisValidas = false;

            if (usuario != null & !String.IsNullOrEmpty(usuario.Email))

            {

                //var usuarioBase = usersDAO.Find(usuario.UserId);
                var usuarioBase = new User();
                var usuarios = _context.Users.Where(u => u.Email == usuario.Email).ToList();
                if (usuarios.Count > 0)
                {
                    usuarioBase = usuarios[0];
                }

                credenciaisValidas = (usuarioBase != null &&

                    usuario.Email == usuarioBase.Email &&

                    usuario.Password == usuarioBase.Password);

            }

            if (credenciaisValidas)

            {

                ClaimsIdentity identity = new ClaimsIdentity(

                    new GenericIdentity(usuario.Email, "Login"),

                    new[] {

                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),

                        new Claim(JwtRegisteredClaimNames.UniqueName, usuario.Email)

                    }

                );



                DateTime dataCriacao = DateTime.Now;

                DateTime dataExpiracao = dataCriacao +

                    TimeSpan.FromSeconds(tokenConfigurations.Seconds);



                var handler = new JwtSecurityTokenHandler();

                var securityToken = handler.CreateToken(new SecurityTokenDescriptor

                {

                    Issuer = tokenConfigurations.Issuer,

                    Audience = tokenConfigurations.Audience,

                    SigningCredentials = signingConfigurations.SigningCredentials,

                    Subject = identity,

                    NotBefore = dataCriacao,

                    Expires = dataExpiracao

                });

                var token = handler.WriteToken(securityToken);

                return new

                {

                    authenticated = true,

                    created = dataCriacao.ToString("yyyy-MM-dd HH:mm:ss"),

                    expiration = dataExpiracao.ToString("yyyy-MM-dd HH:mm:ss"),

                    accessToken = token,

                    message = "OK"

                };

            }

            else

            {

                return new

                {

                    authenticated = false,

                    message = "Falha ao autenticar"

                };

            }

        }
    }
}