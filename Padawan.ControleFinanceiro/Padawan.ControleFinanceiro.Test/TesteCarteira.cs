using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Padawan.ControleFinanceiro.Test
{
    [TestClass]
    public class TesteCarteira
    {
        [TestMethod]
        public void Cadastro_Ok()
        {
            var usuario = new Util.Usuario().Valida(new Model.Usuario {
                Login = "Teste Carteira",
                Nome = "Teste Carteiras Nome",
                Senha = "1234teste"
            });

            var usuarioId = new Util.Usuario().ListaNomeUsuarios().Find(p => p.Nome == "Teste Carteiras Nome");
            var banco = new Util.Banco().Add(new Model.Banco {
                Descricao = "Banco do brasil",
                IdUsuario = usuarioId.Id,
            });

            var bancoId = new Util.Banco().Lista().Find(p => p.Descricao == "Banco do brasil");

            var carteira = new Util.Carteira().Add(new Model.Carteira
            {
               IdBanco = bancoId.Id,
               Descricao = "Teste Investimentos",
               Saldo = 0
            });

            Assert.IsTrue(carteira);
        }
    }
}
