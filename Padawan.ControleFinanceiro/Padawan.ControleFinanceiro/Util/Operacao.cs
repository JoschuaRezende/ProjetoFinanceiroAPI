using Padawan.ControleFinanceiro.Context;
using System;
using System.Collections.Generic;

namespace Padawan.ControleFinanceiro.Util
{
    public class Operacao
    {
        public readonly BancoUtil<Operacao> context;
        public Operacao()
        {
            context = new BancoUtil<Operacao>();
        }

        private bool Valida(Model.Operacao objeto)
        {
            return objeto.Valor != 0;
        }

        public bool Add(Model.Operacao objeto)
        {
            if (Valida(objeto))
            {
                context.Add(objeto);
                return true;
            }
            return false;
        }

        public bool Remover(string descricao)
        {
           var objeto =  context.ListaOperacaoes().Find(p => p.Descricao == descricao);
            context.Remove(objeto);
            return true;
        }
    }
}
