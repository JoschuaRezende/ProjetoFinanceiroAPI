using Padawan.ControleFinanceiro.Context;
using System.Linq;
namespace Padawan.ControleFinanceiro.Util

{
    public class Banco
    {

        BancoUtil<Banco> use = new BancoUtil<Banco>();

        public bool Add(Model.Banco banco)
        {
            var retorno = use.ListarBanco().Where(p => p.Descricao == banco.Descricao).Any();
            if (!retorno)
            {
                use.Add(banco);
                return true;
            }
            return false;
        }
    }
}
