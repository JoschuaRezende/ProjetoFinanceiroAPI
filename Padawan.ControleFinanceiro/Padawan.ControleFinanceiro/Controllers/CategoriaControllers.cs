using Microsoft.AspNetCore.Mvc;
using Padawan.ControleFinanceiro.Model;
using System.Linq;

namespace Padawan.ControleFinanceiro.Controllers
{
    [ApiController]
    [Route("Categoria")]
    public class CategoriaControllers : ControllerBase
    {

        [HttpPost]
        [Route("Cadastro")]
        public ActionResult PostBanco(Categoria objeto)
        {
            var result = new Util.Categoria().Add(objeto);

            if (!result)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete]
        [Route("Deletar")]
        public ActionResult Delete(string objeto)
        {
            if (new Util.Categoria().Remove(objeto))
            {
                return Ok();
            }
            return BadRequest("Existe Operações que utilizam a categoria");
        }

        [HttpPut]
        [Route("Atualizar")]
        public ActionResult Atualizar(string categoria, string novacategoria)
        {
            Util.Categoria u1 = new Util.Categoria();

            new Util.Categoria().Renomear(categoria, novacategoria);

            return Ok("Atualizado com Sucesso");
        }

        [HttpGet]
        [Route("Listar")]
        public ActionResult ListarCadastrados()
        {
            var lista = new Util.Categoria().Listar().Select(p => p.Descricao).ToList();
            return Ok(lista);
        }
    }
}
