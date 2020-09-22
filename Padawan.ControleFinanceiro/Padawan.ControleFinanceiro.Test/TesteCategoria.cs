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
                Descricao = "Casa",
            });
            Assert.IsTrue(categoria);
        }

        [TestMethod]
        public void Cadastro_Erro()
        {
            var categoria = new Util.Categoria().Add(new Model.Categoria
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
            var result = new Util.Categoria().Remove("teste");
            if (result)
            {
                Assert.IsTrue(result);
            }
        }

        [TestMethod]
        public void Delete_Erro()
        {
            var result = new Util.Categoria().Remove("teste");
            Assert.IsFalse(result);
        }
    }
}
