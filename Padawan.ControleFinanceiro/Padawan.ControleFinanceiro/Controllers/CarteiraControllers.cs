﻿using Microsoft.AspNetCore.Mvc;
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
    }
}
