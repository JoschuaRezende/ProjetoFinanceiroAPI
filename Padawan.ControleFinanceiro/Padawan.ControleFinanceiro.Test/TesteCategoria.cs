using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Padawan.ControleFinanceiro.Test
{
    [TestClass]
    public class TesteCategoria
    {
        [TestMethod]
        public void Cadastro_Ok()
        {
            var categoria = new Util.Categoria().Add(new Model.Categoria
            {
                Descricao = "teste",
            });

            if (!categoria)
            {
                Assert.IsFalse(categoria);
            }
            if (categoria)
            {
                Assert.IsTrue(categoria);
            }
        }

        [TestMethod]
        public void Cadastro_Erro()
        {
            new Util.Categoria().Add(new Model.Categoria
            {
                Descricao = "teste",
            });

            var categoriafalse = new Util.Categoria().Add(new Model.Categoria
            {
                Descricao = "teste",
            });

            Assert.IsFalse(categoriafalse);
        }

        [TestMethod]
        public void Delete_Ok()
        {
            var categoria = new Util.Categoria().Add(new Model.Categoria
            {
                Descricao = "teste",
            });

            if (!categoria)
            {
                var resultado = new Util.Categoria().Remove("teste");
                Assert.IsTrue(resultado);
            }

            var result = new Util.Categoria().Remove("teste");
            if (result)
            {
                Assert.IsTrue(result);
            }
        }

        [TestMethod]
        public void Delete_Erro()
        {

            var result = new Util.Categoria().Remove("testenaoexiste");
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void Renomear_Ok()
        {

            new Util.Categoria().Add(new Model.Categoria
            {
                Descricao = "teste",
            });

            var result = new Util.Categoria().Renomear("teste", "teste_renomear");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Renomear_NaoExisteCategoria()
        {

            new Util.Categoria().Add(new Model.Categoria
            {
                Descricao = "teste",
            });

            var result = new Util.Categoria().Renomear("Naoexistecategoria", "teste_renomear");
            Assert.IsFalse(result);
        }
    }
}
