using Microsoft.AspNetCore.Mvc;
using Padawan.ControleFinanceiro.Model;
using System;
using System.Collections.Generic;

namespace Padawan.ControleFinanceiro.Controllers
{
    [ApiController]
    [Route("Operacao")]
    public class OperacaoControllers : ControllerBase
    {
        private const System.Net.HttpStatusCode statusNegativo = System.Net.HttpStatusCode.BadRequest;
        private const System.Net.HttpStatusCode statusPositivo = System.Net.HttpStatusCode.OK;
        private readonly Result<List<Operacao>> status;
        private readonly Util.Operacao oper;

        public OperacaoControllers()
        {
            status = new Result<List<Operacao>>();
            oper = new Util.Operacao();
        }

        [HttpPost]
        [Route("Cadastro")]
        public ActionResult PostBanco(Operacao objeto)
        {
            try
            {
                objeto.Data = DateTime.Now;

                if (!oper.Add(objeto))
                {
                    status.ResultadoOperacao(true, statusNegativo, "Erro ao adicionar");
                    return BadRequest(status);
                }
                return Ok();
            }
            catch (Exception ex)
            {
                status.ResultadoOperacao(true, statusNegativo, "Erro: " + ex);
                return BadRequest(status);
            }
        }

        [HttpDelete]
        [Route("Deletar")]
        public ActionResult Delete(string objeto)
        {
            try
            {
                if (oper.Remover(objeto))
                {
                    status.ResultadoOperacao(false, statusPositivo, "Deletado com sucesso");
                    return Ok(status);
                }
                status.ResultadoOperacao(true, statusNegativo, "Erro ao deletar");
                return BadRequest(status);
            }
            catch (Exception ex)
            {
                status.ResultadoOperacao(true, statusNegativo, "Erro: " + ex);
                return BadRequest(status);
            }
        }
    }
}
