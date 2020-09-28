using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Padawan.ControleFinanceiro.Test
{
    [TestClass]
    public class TesteBanco
    {
        [TestMethod]
        public void CriarBanco_Ok()
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
                Descricao = "Banco teste",
                IdUsuario = usuarioId.Id,
            });

            if (!banco)
            {
                Assert.IsFalse(banco);
            }
            if (banco)
            {
                Assert.IsTrue(banco);
            }
        }

        [TestMethod]
        public void CriarBanco_F()
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
                Descricao = "Banco teste",
                IdUsuario = usuarioId.Id,
            });

            var banco2 = new Util.Banco().Add(new Model.Banco
            {
                Descricao = "Banco teste",
                IdUsuario = usuarioId.Id,
            });

            if (!banco2)
            {
                Assert.IsFalse(banco);
            }
        }

        [TestMethod]
        public void Renomear_OK()
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
                Descricao = "Banco teste",
                IdUsuario = usuarioId.Id,
            });

            var banco2 = new Util.Banco().Add(new Model.Banco
            {
                Descricao = "Banco teste",
                IdUsuario = usuarioId.Id,
            });

           var retorno =  new Util.Banco().Renomear("Banco teste", "Teste Carteiras Nome", "Nubank Teste");

            if (retorno)
            {
                Assert.IsTrue(retorno);
            }
            Assert.IsFalse(retorno);
        }
    }
}
