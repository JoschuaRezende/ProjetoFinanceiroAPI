using Microsoft.AspNetCore.Mvc;
using Padawan.ControleFinanceiro.Model;

namespace Padawan.ControleFinanceiro.Controllers
{
    [ApiController]
    [Route("Banco")]
    public class BancoControllers : ControllerBase
    {
        public readonly Util.Banco context;

        public BancoControllers()
        {
            context = new Util.Banco();
        }

        [HttpPost]
        [Route("Cadastro")]
        public ActionResult PostBanco(Banco usuario)
        {
            var result = context.Add(usuario);
            if (!result)
                return BadRequest();
            return Ok();
        }
        [HttpPut]
        [Route("Atualizar")]
        public ActionResult Delete(string descricao, string usuario, string novadescricao)
        {
            if (context.Renomear(descricao, usuario, novadescricao))
            {
                return Ok("Atualizado com sucesso");
            }
            return BadRequest("Erro ao atualizar");
        }
    }
}
