using Padawan.ControleFinanceiro.Context;
using System.Collections.Generic;
using System.Linq;

namespace Padawan.ControleFinanceiro.Util
{
    public class Categoria
    {
        private readonly BancoUtil<Categoria> context;
        public Categoria()
        {
            context = new BancoUtil<Categoria>();
        }
        public bool Add(Model.Categoria objeto)
        {
            var retorno = context.ListarCategoria().Any(p => p.Descricao == objeto.Descricao);
            if (!retorno)
            {
                context.Add(objeto);
                return true;
            }
            return false;
        }

        private bool ValidaCategoriaOperacao(Model.Categoria objeto)
        {
            return context.ListaOperacaoes().Any(p => p.IdCategoria == objeto.Id);
        }
        public bool Remove(string categoria)
        {
            var objeto = context.ListarCategoria().Find(p => p.Descricao == categoria);
            if (objeto is null)
            {
                return false;
            }
            if (ValidaCategoriaOperacao(objeto))
            {
                return false;
            }
            context.Remove(objeto);
            return true;
        }

        public bool Renomear(string categoria, string novaCategoria)
        {
            var filtro = context.ListarCategoria().Find(p => p.Descricao == categoria);
            filtro.Descricao = novaCategoria;

            context.AtualizarCarteira(filtro);

            return true;
        }

        internal List<Model.Categoria> Listar()
        {
            return context.ListarCategoria();
        }
    }
}
