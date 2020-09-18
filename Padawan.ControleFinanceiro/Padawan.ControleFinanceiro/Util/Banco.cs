using Padawan.ControleFinanceiro.Context;
using System.Linq;

namespace Padawan.ControleFinanceiro.Util

{
    public class Banco
    {
        public readonly BancoUtil<Banco> context;
        public Banco()
        {
         context = new BancoUtil<Banco>();
        }
        public bool Add(Model.Banco banco)
        {
            var retorno = context.ListarBanco().Any(p => p.Descricao == banco.Descricao);
            if (!retorno)
            {
                context.Add(banco);
                return true;
            }
            return false;
        }
        public bool Renomear(string descricao, string usuario, string novadescricao)
        {
            var filtro = context.ListarBanco().Find(p => p.Descricao == descricao);

            var usuarioId = new Util.Usuario();
            filtro.Descricao = novadescricao;
            filtro.IdUsuario = usuarioId.RetornaIdNome(usuario);

            return context.AtualizarBanco(filtro);
        }
    }
}
