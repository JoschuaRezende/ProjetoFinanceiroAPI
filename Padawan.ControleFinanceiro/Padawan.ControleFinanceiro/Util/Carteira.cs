using Padawan.ControleFinanceiro.Context;
using System.Collections.Generic;
using System.Linq;

namespace Padawan.ControleFinanceiro.Util
{
    public class Carteira
    {
        public readonly BancoUtil<Model.Carteira> context;

        public Carteira()
        {
            context = new BancoUtil<Model.Carteira>();
        }

        public bool Add(Model.Carteira objeto)
        {
            var retorno = context.ListarCarteira().Any(p => p.Descricao == objeto.Descricao);
            if (objeto.Descricao is null)
            {
                return false;
            }
            if (!retorno)
            {
                context.Add(objeto);
                return true;
            }
            return false;
        }

        public bool AtualizarSaldo(double valor, string descricao)
        {
            var objeto = context.ListarCarteira().Find(p => p.Descricao == descricao);
            if (objeto != null)
            {
                objeto.Saldo = valor;
                context.AtualizarCarteira(objeto);
                return true;
            }
            return false;
        }

        public double CalcularSaldo(string descricao)

        {
            var carteira = new BancoUtil<Carteira>().ListarCarteira().Find(p => p.Descricao == descricao);

            var credito = new BancoUtil<Operacao>().ListaOperacaoes().Where(p => p.Tipo == 'c' && p.IdCarteira == carteira.Id).Sum(p => p.Valor);
            var debito = new BancoUtil<Operacao>().ListaOperacaoes().Where(p => p.Tipo == 'd' && p.IdCarteira == carteira.Id).Sum(p => p.Valor);
            return credito - debito;
        }

        internal List<Model.Carteira> Listar()
        {
            return context.ListarCarteira();
        }
    }
}