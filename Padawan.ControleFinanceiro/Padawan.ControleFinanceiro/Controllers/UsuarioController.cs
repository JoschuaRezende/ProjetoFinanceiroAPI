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
        const System.Net.HttpStatusCode statusNegativo = System.Net.HttpStatusCode.BadRequest;
        const System.Net.HttpStatusCode statusPositivo = System.Net.HttpStatusCode.OK;
        readonly Result<List<Model.Usuario>> status;
        readonly Util.Usuario user;

        public UsuarioController()
        {
            status = new Result<List<Model.Usuario>>();
            user = new Util.Usuario();
        }

        [HttpPost]
        [Route("Cadastrar")]
        public ActionResult PostUsuario(Model.Usuario usuario)
        {
            try
            {
                if (user.Senha(usuario.Senha))
                {
                    var result2 = user.Valida(usuario);
                    if (result2)
                    {
                        status.ResultadoOperacao(false, statusPositivo, "Adicionado com sucesso");
                        return Ok(status);
                    }
                    status.ResultadoOperacao(true, statusNegativo, "Já existe login");
                    return BadRequest(status);
                }
                else
                {
                    status.ResultadoOperacao(true, statusNegativo, "Senha Fraca");
                    return BadRequest(status);
                }
            }
            catch (Exception ex)
            {
                status.ResultadoOperacao(false, statusNegativo, "Erro: " + ex);
                return BadRequest(status);
            }
        }

        [HttpGet]
        [Route("Listar")]
        public ActionResult GetListar()
        {
            try
            {
                if (user.ListaNomeUsuarios().Count == 0)
                {
                    status.ResultadoOperacao(true, statusNegativo, "Não Possui nenhum cadastro de Usuário");
                    return BadRequest(status);
                }
                else
                {
                    status.Data = user.ListaNomeUsuarios();
                    return Ok(status);
                }
            }
            catch (Exception ex)
            {
                status.ResultadoOperacao(false, statusNegativo, "Erro: " + ex);
                return BadRequest(status);
            }
        }

        [HttpGet]
        [Route("Logar")]
        public ActionResult GetLogar(string usuario, string senha)
        {
            try
            {
                if (!user.ValidaLogin(usuario, senha))
                    status.ResultadoOperacao(false, statusNegativo, "Login invalido");
                return Ok();
            }
            catch (Exception ex)
            {
                status.ResultadoOperacao(false, statusNegativo, "Erro: " + ex);
                return BadRequest(status);
            }
        }

        [HttpPut]
        [Route("AlterarSenha")]
        public ActionResult PutAlterarSenha(string usuario, string senha)
        {

            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
            var user = new Util.Usuario();
            if (!user.ValidaUsuario(usuario))
                return BadRequest("Usuario Incorreto");
            if (!user.AlterarSenha(usuario, senha))
                return BadRequest("Senha invalida para alteração");
            return Ok("senha alterada com sucesso");
        }
    }
}