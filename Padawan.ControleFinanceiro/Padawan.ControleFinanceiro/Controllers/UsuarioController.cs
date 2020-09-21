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
        private const System.Net.HttpStatusCode statusNegativo = System.Net.HttpStatusCode.BadRequest;
        private const System.Net.HttpStatusCode statusPositivo = System.Net.HttpStatusCode.OK;
        private readonly Result<List<Usuario>> status;
        private readonly Util.Usuario user;

        public UsuarioController()
        {
            status = new Result<List<Model.Usuario>>();
            user = new Util.Usuario();
        }

        [HttpPost]
        [Route("Cadastrar")]
        public ActionResult PostUsuario(Usuario usuario)
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
                {
                    status.ResultadoOperacao(true, statusNegativo, "Login invalido");
                    return BadRequest(status);
                }
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
                if (!user.ValidaUsuario(usuario))
                {
                    status.ResultadoOperacao(true, statusNegativo, "Usuario Incorreto, não consta no banco");
                    return BadRequest(status);
                }
                else if (!user.AlterarSenha(usuario, senha))
                {
                    status.ResultadoOperacao(true, statusNegativo, "Senha invalida para alteração");
                    return BadRequest(status);
                }
                else
                {
                    status.ResultadoOperacao(false, statusPositivo, "senha alterada com sucesso");
                    return Ok(status);
                }
            }
            catch (Exception ex)
            {
                status.ResultadoOperacao(false, statusNegativo, "Erro: " + ex);
                return BadRequest(status);
            }
        }

        [HttpDelete]
        [Route("Deletar")]
        public ActionResult Delete(string objeto)
        {
            try
            {
                if (user.Remove(objeto))
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
    }
}