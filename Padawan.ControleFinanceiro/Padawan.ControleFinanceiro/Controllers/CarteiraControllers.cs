using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Padawan.ControleFinanceiro.Model;

namespace Padawan.ControleFinanceiro.Controllers
{
    [Route("Carteira")]
    [ApiController]
    public class CarteiraControllers : ControllerBase
    {

        [HttpPost]
        [Route("Cadastro")]
        public ActionResult PostBanco(Carteira objeto)
        {
            Util.Carteira u1 = new Util.Carteira();

            var result = u1.Add(objeto);

            if (!result)
            {
                return BadRequest();
            }
            return Ok();

        }
    }
}
