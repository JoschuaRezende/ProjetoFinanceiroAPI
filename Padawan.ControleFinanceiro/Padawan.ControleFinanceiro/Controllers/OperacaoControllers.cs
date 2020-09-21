using Microsoft.AspNetCore.Mvc;
using Padawan.ControleFinanceiro.Model;
using System;

namespace Padawan.ControleFinanceiro.Controllers
{
    [ApiController]
    [Route("Operacao")]
    public class OperacaoControllers : ControllerBase
    {
        [HttpPost]
        [Route("Cadastro")]
        public ActionResult PostBanco(Operacao objeto)
        {
            objeto.Data = DateTime.Now;

            var result = new Util.Operacao().Add(objeto);

            if (!result)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete]
        [Route("Deletar")]
        public ActionResult Delete(string objeto)
        {
            if (new Util.Operacao().Remover(objeto))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("Listar")]
        public ActionResult ListarCadastrados(Operacao objeto)
        {
            objeto.Data = DateTime.Now;

            var result = new Util.Operacao().Add(objeto);

            if (!result)
            {
                return BadRequest();
            }
            return Ok();
        }

    }
}
