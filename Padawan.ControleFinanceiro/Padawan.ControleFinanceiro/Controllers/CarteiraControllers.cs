using Microsoft.AspNetCore.Mvc;
using Padawan.ControleFinanceiro.Model;

namespace Padawan.ControleFinanceiro.Controllers
{
    [ApiController]
    [Route("Carteira")]

    public class CarteiraControllers : ControllerBase
    {
        [HttpPost]
        [Route("Cadastro")]
        public ActionResult PostBanco(Carteira objeto)
        {
            Util.Carteira u1 = new Util.Carteira();
            objeto.Saldo = 0;
            var result = u1.Add(objeto);

            if (!result)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPost]
        [Route("Saldo")]
        public ActionResult GetSaldo(string descricao)
        {
            Util.Carteira u1 = new Util.Carteira();
            var saldo =  u1.AtualizarSaldo(u1.CalcularSaldo(descricao), descricao);

            return Ok("Saldo calculado com sucesso");
        }
    }
}
