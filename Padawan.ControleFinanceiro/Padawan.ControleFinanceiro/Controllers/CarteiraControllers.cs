using Microsoft.AspNetCore.Mvc;
using Padawan.ControleFinanceiro.Model;
using System;
using System.Collections.Generic;

namespace Padawan.ControleFinanceiro.Controllers
{
    [ApiController]
    [Route("Carteira")]
    public class CarteiraControllers : ControllerBase
    {
        private const System.Net.HttpStatusCode statusNegativo = System.Net.HttpStatusCode.BadRequest;
        private const System.Net.HttpStatusCode statusPositivo = System.Net.HttpStatusCode.OK;
        private readonly Result<List<Carteira>> status;
        private readonly Util.Carteira carteira;

        public CarteiraControllers()
        {
            status = new Result<List<Carteira>>();
            carteira = new Util.Carteira();
        }
        [HttpPost]
        [Route("Cadastro")]
        public ActionResult PostBanco(Carteira objeto)
        {
            try
            {
                objeto.Saldo = 0;
                if (!carteira.Add(objeto))
                {
                    status.ResultadoOperacao(true, statusNegativo, "Erro ao adicionar");
                    return BadRequest(status);
                }
                
                status.ResultadoOperacao(false, statusPositivo, "Adicionado com sucesso");
                return Ok(status);
            }
            catch (Exception ex)
            {
                status.ResultadoOperacao(true, statusNegativo, "Erro: " + ex);
                return BadRequest(status);
            }
        }

        [HttpPost]
        [Route("Saldo")]
        public ActionResult GetSaldo(string descricao)
        {
            try
            {
                if (carteira.AtualizarSaldo(carteira.CalcularSaldo(descricao), descricao))
                {
                    status.ResultadoOperacao(true, statusPositivo, "Saldo calculado com sucesso");
                    return Ok(status);
                }
                status.ResultadoOperacao(false, statusNegativo, "Erro ao calcular saldo");
                return BadRequest(status);
            }
            catch (Exception ex)
            {
                status.ResultadoOperacao(true, statusNegativo, "Erro: " + ex);
                return BadRequest(status);
            }
        }

        [HttpGet]
        [Route("Listar")]
        public ActionResult ListaCadastrados()
        {
            try
            {
                status.Data = carteira.Listar();
                return Ok(status);
            }
            catch (Exception ex)
            {
                status.ResultadoOperacao(true, statusNegativo, "Erro: " + ex);
                return BadRequest(status);
            }
        }
    }
}
