using Microsoft.AspNetCore.Mvc;
using Padawan.ControleFinanceiro.Model;
using System;
using System.Collections.Generic;

namespace Padawan.ControleFinanceiro.Controllers
{
    [ApiController]
    [Route("Usuario")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        [Route("Cadastrar")]
        public ActionResult PostUsuario(Model.Usuario usuario)
        {
            var result = new Result<List<Model.Usuario>>();
            var statusNegativo = System.Net.HttpStatusCode.BadRequest;
            var statusPositivo = System.Net.HttpStatusCode.OK;
            try
            {
                if (new Util.Usuario().Senha(usuario.Senha))
                {
                    var result2 = new Util.Usuario().Valida(usuario);
                    if (result2)
                    {
                        result.ResultadoOperacao(false, statusPositivo, "Adicionado com suceso");
                        return Ok(result);
                    }
                    result.ResultadoOperacao(true, statusNegativo, "Já existe login");
                    return BadRequest(result);
                }
                else
                {
                    result.ResultadoOperacao(true, statusNegativo, "Senha Fraca");
                    return BadRequest(result);
                }
            }
            catch (Exception ex)
            {
                result.Erro = false;
                result.Status = System.Net.HttpStatusCode.BadRequest;
                result.Mensagem = "Erro:" + ex;
                return BadRequest(result);
            }
        }

        [HttpGet]
        [Route("Listar")]
        public ActionResult GetListar()
        {
            var result = new Util.Usuario();
            if (result.ListaNomeUsuarios().Count == 0)
               return BadRequest("Não Possui nenhum cadastro de Usuário");
            return Ok(result.ListaNomeUsuarios());
        }

        [HttpGet]
        [Route("Logar")]
        public ActionResult GetLogar(string usuario, string senha)
        {
            var result = new Util.Usuario();
            if (!result.ValidaLogin(usuario, senha))
                return BadRequest();
            return Ok();
        }

        [HttpPut]
        [Route("AlterarSenha")]
        public ActionResult PutAlterarSenha(string usuario, string senha)
        {
            var result = new Util.Usuario();
            if (!result.ValidaUsuario(usuario))
                return BadRequest("Usuario Incorreto");
            if (!result.AlterarSenha(usuario, senha))
                return BadRequest("Senha invalida para alteração");
            return Ok("senha alterada com sucesso");
        }
    }
}