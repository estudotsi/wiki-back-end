using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WikiGC.Models;
using WikiGC.Repositories.Repository;
using WikiGC.Service;

namespace WikiGC.Controllers
{
    [ApiController]
    public class TokenController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public ActionResult<dynamic> Cadastrar([FromBody] Usuario usuario)
        {
            /*var user = UserRepository.Get(usuario.Name, usuario.Password);
            return Ok(user);*/
            // Recupera o usuário
            var user = UserRepository.Get(usuario.Name, usuario.Password);

            // Verifica se o usuário existe
            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            // Gera o Token
            var token = TokenService.GenerateToken(user);

            // Oculta a senha
            user.Password = "";

            // Retorna os dados
            return new
            {
                user = user,
                token = token
            };
        }


        // Chamada para autenticar
       /* [HttpPost]
        [AllowAnonymous]
        public ActionResult<dynamic> Autenticar([FromBody] Usuario model)
        {
            // Recupera o usuário
            var user = UserRepository.Get(model.Name, model.Password);

            // Verifica se o usuário existe
            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            // Gera o Token
            var token = TokenService.GenerateToken(user);

            // Oculta a senha
            user.Password = "";

            // Retorna os dados
            return new
            {
                user = user,
                token = token
            };
        }*/
    }
}
