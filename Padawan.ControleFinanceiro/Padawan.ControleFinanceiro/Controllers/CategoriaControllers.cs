using Microsoft.AspNetCore.Mvc;
using Padawan.ControleFinanceiro.Model;

namespace Padawan.ControleFinanceiro.Controllers
{
    [ApiController]
    [Route("Categoria")]
    public class CategoriaControllers : ControllerBase
    {
        public readonly Util.Categoria categoria;

        public CategoriaControllers()
        {
            categoria = new Util.Categoria();
        }

        [HttpPost]
        [Route("Cadastro")]
        public ActionResult PostBanco(Categoria objeto)
        {
            var result = categoria.Add(objeto);

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
            Util.Categoria u1 = new Util.Categoria();
            if (u1.Remove(objeto))
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

            u1.Renomear(categoria, novacategoria);

            return Ok("Atualizado com Sucesso");
        }
    }
}
