using Microsoft.AspNetCore.Mvc;
using Padawan.ControleFinanceiro.Model;
using System.Linq;

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
            objeto.Saldo = 0;
            var result = new Util.Carteira().Add(objeto);

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
            var carteira = new Util.Carteira();

            if (carteira.AtualizarSaldo(carteira.CalcularSaldo(descricao), descricao))
            {
                return Ok("Saldo calculado com sucesso");
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("Listar")]
        public ActionResult ListaCadastrados()
        {
            var lista = new Util.Carteira().Listar().Select(p => p.Descricao).ToList();
            return Ok(lista);
        }
    }
}
