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
    }
}
