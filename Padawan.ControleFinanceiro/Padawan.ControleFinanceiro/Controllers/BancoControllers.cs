using Microsoft.AspNetCore.Mvc;
using Padawan.ControleFinanceiro.Model;

namespace Padawan.ControleFinanceiro.Controllers
{
    [ApiController]
    [Route("Banco")]
    
    public class BancoControllers : ControllerBase
    {
        [HttpPost]
        [Route("Cadastro")]
        public ActionResult PostBanco(Banco usuario)
        {
            Util.Banco u1 = new Util.Banco();

             var result = u1.Add(usuario);
            if (!result)
                return BadRequest();
            return Ok();

        }
    }
}
