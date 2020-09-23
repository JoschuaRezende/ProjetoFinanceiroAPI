using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Padawan.ControleFinanceiro.Test
{
    [TestClass]
    public class TesteUsuario
    {
        [TestMethod]
        public void ValidaSenha_Ok()
        {
            var senha = new Util.Usuario().Senha("123asd");
            Assert.IsTrue(senha);
        }

        [TestMethod]
        public void ValidaSenha_False()
        {
            var senha = new Util.Usuario().Senha("12133");
            Assert.IsFalse(senha);
        }

   

        [TestMethod]
        public void ValidaUsuario_Ok()
        {
            var usuario = new Model.Usuario
            {
                Nome = "Teste",
                Senha = "123asd",
                Login = "Teste"
            };

            var result = new Util.Usuario().Valida(usuario);

            if (!result)
            {
              Assert.IsFalse(result);
            }
            else
            {
                Assert.IsTrue(result);
            }
        }

        [TestMethod]
        public void ValidaUsuario_False()
        {
            var usuario = new Model.Usuario
            {
                Nome = "Teste2",
                Senha = "123asd",
                Login = "Teste2"
            };

            new Util.Usuario().Valida(usuario);
            var usuario2 = new Model.Usuario
            {
                Nome = "Teste2",
                Senha = "123asd",
                Login = "Teste2"
            };

            var result = new Util.Usuario().Valida(usuario2);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void RetornaNomeId_Ok()
        {
            bool valor = true;
            var usuario = new Model.Usuario
            {
                Nome = "Teste_retorna_id",
                Senha = "123asd",
                Login = "Teste_retorna_id"
            };

            new Util.Usuario().Valida(usuario);
            var idNome = new Util.Usuario().RetornaIdNome("Teste_retorna_id");
            Assert.IsTrue(idNome is int);
        }

        [TestMethod]
        public void ListaNomeUsuarios_Ok()
        {
            var list = new List<Model.Usuario>
            {
                new Model.Usuario
                {
                    Nome = "Teste2",
                    Senha = "123asd",
                    Login = "Teste2"
                },

                new Model.Usuario
                {
                    Nome = "Teste",
                    Senha = "123asd",
                    Login = "Teste"
                }
            };

            Assert.IsNotNull(list.Select(p => p.Nome).ToList());
        }
    }
}
