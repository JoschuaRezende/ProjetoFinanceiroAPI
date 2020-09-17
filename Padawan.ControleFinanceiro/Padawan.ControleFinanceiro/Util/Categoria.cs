using Padawan.ControleFinanceiro.Context;
using System.Linq;

namespace Padawan.ControleFinanceiro.Util
{
    public class Categoria
    {
        //protected BancoContext context = new BancoContext();
        BancoUtil<Categoria> use = new BancoUtil<Categoria>();
        public bool Add(Model.Categoria objeto)
        {
            var retorno = use.ListarCategoria().Where(p => p.Descricao == objeto.Descricao).Any();
            if (!retorno)
            {
                use.Add(objeto);
                return true;
            }
            return false;
        }

        private bool ValidaCategoriaOperacao(Model.Categoria objeto)
        {

            if (use.ListaOperacaoes().Any(p => p.IdCategoria == objeto.Id))
            {
                return true;
            }
            return false;
        }
        public bool Remove(string categoria)
        {
            var objeto = use.ListarCategoria().Where(p => p.Descricao == categoria).FirstOrDefault();

            if (ValidaCategoriaOperacao(objeto))
            {
                return false;
            }
            use.Remove(objeto);
            return true;
        }

        public bool Renomear(string categoria, string novaCategoria)
        {
            var filtro = use.ListarCategoria().Where(p => p.Descricao == categoria).FirstOrDefault();
            filtro.Descricao = novaCategoria;

            use.AtualizarCategoria(filtro);
            return true;
        }
    }
}
