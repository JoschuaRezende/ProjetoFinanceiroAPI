using Microsoft.VisualStudio.TestTools.UnitTesting;
using Padawan.ControleFinanceiro.Context;
using Padawan.ControleFinanceiro.Model;
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

            if (!carteira)
            {
                var result = new BancoUtil<Carteira>().ListarCarteira().Select(p => p.Descricao == "Teste Investimentos").Any();
                Assert.IsTrue(result);
            }
            if (carteira)
            {
                Assert.IsTrue(carteira);
            }
        }

        [TestMethod]
        public void Cadastro_False()
        {
            var usuario = new Util.Usuario().Valida(new Model.Usuario
            {
                Login = "Teste Carteira",
                Nome = "Teste Carteiras Nome",
                Senha = "1234teste"
            });

            var usuarioId = new Util.Usuario().ListaNomeUsuarios().Find(p => p.Nome == "Teste Carteiras Nome");
            var banco = new Util.Banco().Add(new Model.Banco
            {
                Descricao = "Banco do brasil",
                IdUsuario = usuarioId.Id,
            });

            var bancoId = new Util.Banco().Lista().Find(p => p.Descricao == "Banco do brasil");

            var carteira = new Util.Carteira().Add(new Model.Carteira
            {
                IdBanco = bancoId.Id,
                Descricao = null,
                Saldo = 0
            });

            Assert.IsFalse(carteira);
        }

        [TestMethod]
        public void CalcularSaldo_OK()
        {
            CriarCarteira();

            var valor = new Util.Carteira().CalcularSaldo("Teste Investimentos");

            Assert.IsTrue(valor == 0);
        }

        [TestMethod]
        public void CalcularSaldo_False()
        {
            CriarCarteira();

            var valor = new Util.Carteira().CalcularSaldo("Naoexiste");

            Assert.IsTrue(valor == -1);
        }

        public void CriarCarteira()
        {
            var usuario = new Util.Usuario().Valida(new Model.Usuario
            {
                Login = "Teste Carteira",
                Nome = "Teste Carteiras Nome",
                Senha = "1234teste"
            });

            var usuarioId = new Util.Usuario().ListaNomeUsuarios().Find(p => p.Nome == "Teste Carteiras Nome");
            var banco = new Util.Banco().Add(new Model.Banco
            {
                Descricao = "Banco do brasil",
                IdUsuario = usuarioId.Id,
            });

            var bancoId = new Util.Banco().Lista().Find(p => p.Descricao == "Banco do brasil");

            var carteira = new Util.Carteira().Add(new Model.Carteira
            {
                IdBanco = bancoId.Id,
                Descricao = "Teste Investimentos",
                Saldo = 100
            });

            if (!carteira)
            {
                var result = new BancoUtil<Carteira>().ListarCarteira().Select(p => p.Descricao == "Teste Investimentos").Any();
                Assert.IsTrue(result);
            }
            if (carteira)
            {
                Assert.IsTrue(carteira);
            }
        }

        [TestMethod]
        public void AtualizarSaldo_OK()
        {
            CriarCarteira();

            var result = new Util.Carteira().AtualizarSaldo(new Util.Carteira().CalcularSaldo("Teste Investimentos"), "Teste Investimentos");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AtualizarSaldo_False()
        {
            CriarCarteira();

            var result = new Util.Carteira().AtualizarSaldo(new Util.Carteira().CalcularSaldo("Teste Investimentos"), "TesteNaoExiste");

            Assert.IsFalse(result);
        }
    }
}
