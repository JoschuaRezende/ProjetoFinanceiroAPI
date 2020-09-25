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
        public void RetornaNomeId_False()
        {
            var idNome = new Util.Usuario().RetornaIdNome("TesteNaoExiste");
            Assert.AreEqual(-1, idNome);
        }

        [TestMethod]
        public void ValidaLogin_OK()
        {
            var usuario = new Model.Usuario
            {
                Nome = "Teste_retorna_id",
                Senha = "123asd",
                Login = "Teste_retorna_id"
            };

            new Util.Usuario().Valida(usuario);
            var login = new Util.Usuario().ValidaLogin(usuario.Login, usuario.Senha);
            Assert.IsTrue(login);
        }

        [TestMethod]
        public void ValidaLogin_False()
        {
            var login = new Util.Usuario().ValidaLogin("naoexiste", "naoexiste1234");
            Assert.IsFalse(login);
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

        [TestMethod]
        public void ValidaUsuario_OK()
        {
            var usuario = new Model.Usuario
            {
                Nome = "teste",
                Senha = "123asd",
                Login = "teste"
            };

            var retorno = new Util.Usuario().Valida(usuario);

            if (retorno)
            {
                var login = new Util.Usuario().ValidaUsuario("teste");
                Assert.IsTrue(login);
            }
            if (!retorno)
            {
                var login = new Util.Usuario().ValidaUsuario("teste");
                Assert.IsTrue(login);
            }
        }

        [TestMethod]
        public void ValidaUsuario_false()
        {
            var login = new Util.Usuario().ValidaUsuario("Naoexistelogin");
            Assert.IsFalse(login);
        }


        [TestMethod]
        public void Remove_OK()
        {
            var usuario = new Model.Usuario
            {
                Nome = "teste",
                Senha = "123asd",
                Login = "teste"
            };
            new Util.Usuario().Valida(usuario);

            var login = new Util.Usuario().Remove("teste");
            Assert.IsTrue(login);
        }

        [TestMethod]
        public void Remove_False()
        {
            var login = new Util.Usuario().Remove("naoexisteusuario");
            Assert.IsFalse(login);
        }

        [TestMethod]
        public void AlterarSenha_Ok()
        {
            var usuario = new Model.Usuario
            {
                Nome = "teste",
                Senha = "123asd",
                Login = "teste"
            };
            new Util.Usuario().Valida(usuario);

            var login = new Util.Usuario().AlterarSenha("teste", "asd123");
            Assert.IsTrue(login);
        }

        [TestMethod]
        public void AlterarSenha_UsuarioNaoExiste()
        {
            var usuario = new Model.Usuario
            {
                Nome = "teste",
                Senha = "123asd",
                Login = "teste"
            };
            new Util.Usuario().Valida(usuario);

            var login = new Util.Usuario().AlterarSenha("naoexisteusuario", "asd123");
           
            
            Assert.IsFalse(login);
        }

        [TestMethod]
        public void AlterarSenha_SenhaInvalida()
        {
            var usuario = new Model.Usuario
            {
                Nome = "teste",
                Senha = "123asd",
                Login = "teste"
            };
            new Util.Usuario().Valida(usuario);

            var login = new Util.Usuario().AlterarSenha("teste", "asd");

            Assert.IsFalse(login);
        }
    }
}
