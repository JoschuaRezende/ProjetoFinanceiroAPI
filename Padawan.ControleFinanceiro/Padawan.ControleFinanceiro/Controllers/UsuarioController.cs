using Microsoft.AspNetCore.Mvc;
using Padawan.ControleFinanceiro.Model;

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
            if (new Util.Usuario().Senha(usuario.Senha))
            {
                var result2 = new Util.Usuario().Valida(usuario);
                if (result2)
                  return Ok("Adicionado com sucesso");
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
            if (result.ListaNomeUsuarios().Count == 0)
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