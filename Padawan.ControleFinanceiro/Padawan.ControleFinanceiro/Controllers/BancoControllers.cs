using Microsoft.AspNetCore.Mvc;
using Padawan.ControleFinanceiro.Model;
using System;
using System.Collections.Generic;

namespace Padawan.ControleFinanceiro.Controllers
{
    [ApiController]
    [Route("Banco")]
    public class BancoControllers : ControllerBase
    {
        private const System.Net.HttpStatusCode statusNegativo = System.Net.HttpStatusCode.BadRequest;
        private const System.Net.HttpStatusCode statusPositivo = System.Net.HttpStatusCode.OK;
        private readonly Result<List<Banco>> status;
        private readonly Util.Banco banco;

        public BancoControllers()
        {
            status = new Result<List<Model.Banco>>();
            banco = new Util.Banco();
        }

        [HttpPost]
        [Route("Cadastro")]
        public ActionResult PostBanco(Banco usuario)
        {
            try
            
            {
                if (!banco.Add(usuario))
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

        [HttpPut]
        [Route("Atualizar")]
        public ActionResult Atualizar(string descricao, string usuario, string novadescricao)
        {
            try
            {
                if (banco.Renomear(descricao, usuario, novadescricao))
                {
                    status.ResultadoOperacao(false, statusPositivo, "Renomeado com sucesso");
                    return Ok(status);
                }
                status.ResultadoOperacao(true, statusNegativo, "Erro ao renomear");
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
        public ActionResult ListaCadastrada()
        {
            try
            {
                var lista = new Util.Banco().Lista();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                status.ResultadoOperacao(true, statusNegativo, "Erro: " + ex);
                return BadRequest(status);
            }
        }
    }
}
