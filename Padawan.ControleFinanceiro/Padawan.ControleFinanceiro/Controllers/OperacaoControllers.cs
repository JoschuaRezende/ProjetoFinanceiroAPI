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
            Util.Operacao u1 = new Util.Operacao();
            objeto.Data = DateTime.Now;

            var result = u1.Add(objeto);

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
            Util.Operacao u1 = new Util.Operacao();

            
            if (u1.Remover(objeto))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
