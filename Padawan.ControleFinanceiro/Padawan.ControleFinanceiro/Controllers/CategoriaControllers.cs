using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Padawan.ControleFinanceiro.Model;

namespace Padawan.ControleFinanceiro.Controllers
{
    [Route("Categoria")]
    [ApiController]
    public class CategoriaControllers : ControllerBase
    {

        [HttpPost]
        [Route("Cadastro")]
        public ActionResult PostBanco(Categoria objeto)
        {
            Util.Categoria u1 = new Util.Categoria();

            var result = u1.Add(objeto);

            if (!result)
            {
                return BadRequest();
            }
            return Ok();

        }
    }
}
