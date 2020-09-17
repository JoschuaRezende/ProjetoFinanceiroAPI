using Microsoft.AspNetCore.Mvc;
using Padawan.ControleFinanceiro.Model;
using System.Linq;

namespace Padawan.ControleFinanceiro.Controllers
{
    [ApiController]
    [Route("Usuario")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        [Route("Cadastrar")]
        public ActionResult PostUsuario(Usuario usuario)
        {
            Util.Usuario u1 = new Util.Usuario();
            var result = u1.Senha(usuario);
            if (result)
            {
                var result2 = u1.Valida(usuario);
                if (result2)
                {
                  return Ok("Adicionado com sucesso");
                }
                
                return BadRequest("Já existe login");
            }
            else
            {
                return BadRequest("Senha Fraca");
            }
        }

        [HttpGet]
        [Route("Listar")]
        public ActionResult GetListar()
        {
            var result = new Util.Usuario();
         
            if (!result.ListaNomeUsuarios().Any())
               return BadRequest("Não Possui nenhum cadastro de Usuário");
            return Ok(result.ListaNomeUsuarios());
        }

        [HttpGet]
        [Route("Logar")]
        public ActionResult GetLogar(string usuario, string senha)
        {
            var result = new Util.Usuario();
           
            if (!result.ValidaLogin(usuario, senha))
                return BadRequest();
            return Ok();
        }

        [HttpPut]
        [Route("AlterarSenha")]
        public ActionResult PutAlterarSenha(string usuario, string senha)
        {
            var result = new Util.Usuario();
            if (!result.ValidaUsuario(usuario))
                return BadRequest("Usuario Incorreto");
            
            if (!result.AlterarSenha(usuario, senha))
                return BadRequest("Senha invalida para alteração");
            return Ok("senha alterada com sucesso");
        }
        
    }
}