using Padawan.ControleFinanceiro.Context;
using System.Linq;

namespace Padawan.ControleFinanceiro.Util
{
    public class Categoria
    {

        BancoUtil<Categoria> context;
        public Categoria()
        {
            context = new BancoUtil<Categoria>();
        }
            
        public bool Add(Model.Categoria objeto)
        {
            var retorno = context.ListarCategoria().Where(p => p.Descricao == objeto.Descricao).Any();
            if (!retorno)
            {
                context.Add(objeto);
                return true;
            }
            return false;
        }

        private bool ValidaCategoriaOperacao(Model.Categoria objeto)
        {

            if (context.ListaOperacaoes().Any(p => p.IdCategoria == objeto.Id))
            {
                return true;
            }
            return false;
        }
        public bool Remove(string categoria)
        {
            var objeto = context.ListarCategoria().Where(p => p.Descricao == categoria).FirstOrDefault();

            if (ValidaCategoriaOperacao(objeto))
            {
                return false;
            }
            context.Remove(objeto);
            return true;
        }

        public bool Renomear(string categoria, string novaCategoria)
        {
            var filtro = context.ListarCategoria().Where(p => p.Descricao == categoria).FirstOrDefault();
            filtro.Descricao = novaCategoria;

            context.AtualizarCarteira(filtro);

            return true;
        }
    }
}
