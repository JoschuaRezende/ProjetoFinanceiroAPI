using Microsoft.AspNetCore.Mvc;
using Padawan.ControleFinanceiro.Model;
using System;
using System.Collections.Generic;

namespace Padawan.ControleFinanceiro.Controllers
{
    [ApiController]
    [Route("Categoria")]
    public class CategoriaControllers : ControllerBase
    {
        private const System.Net.HttpStatusCode statusNegativo = System.Net.HttpStatusCode.BadRequest;
        private const System.Net.HttpStatusCode statusPositivo = System.Net.HttpStatusCode.OK;
        private readonly Result<List<Categoria>> status;
        private readonly Util.Categoria categoria;

        public CategoriaControllers()
        {
            status = new Result<List<Model.Categoria>>();
            categoria = new Util.Categoria();
        }
        [HttpPost]
        [Route("Cadastro")]
        public ActionResult PostBanco(Categoria objeto)
        {
            try
            {
                if (!categoria.Add(objeto))
                {
                    status.ResultadoOperacao(true, statusNegativo, "Erro ao Adicionar");
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

        [HttpDelete]
        [Route("Deletar")]
        public ActionResult Delete(string objeto)
        {
            try
            {
                if (categoria.Remove(objeto))
                {
                    status.ResultadoOperacao(false, statusPositivo, "Removido com sucesso");
                    return Ok(status);
                }
                status.ResultadoOperacao(true, statusNegativo, "Existe Operações que utilizam a categoria");
                return BadRequest(status);
            }
            catch (Exception ex)
            {
                status.ResultadoOperacao(false, statusNegativo, "Erro: " + ex);
                return BadRequest(status);
            }
        }

        [HttpPut]
        [Route("Atualizar")]
        public ActionResult Atualizar(string cat, string novacategoria)
        {
            try
            {
                categoria.Renomear(cat, novacategoria);
                status.ResultadoOperacao(false, statusPositivo, "Renomeado com sucessos");
                return Ok(status);
            }
            catch (Exception ex)
            {
                status.ResultadoOperacao(false, statusNegativo, "Erro: " + ex);
                return BadRequest(status);
            }
        }

        [HttpGet]
        [Route("Listar")]
        public ActionResult ListarCadastrados()
        {
            var lista = new Util.Categoria().Listar();
            return Ok(lista);
        }
    }
}
