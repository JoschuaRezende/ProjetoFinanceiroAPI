using Padawan.ControleFinanceiro.Context;
using Padawan.ControleFinanceiro.Interfaces;
using Padawan.ControleFinanceiro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Padawan.ControleFinanceiro.Util
{
    public class Operacao
    {

        BancoUtil<Operacao> use = new BancoUtil<Operacao>();

        private bool Valida(Model.Operacao objeto)
        {
          
            if (objeto.Valor == 0)
            {
                return false;
            }
            return true;
        }

        public bool Add(Model.Operacao objeto)
        {
            if (Valida(objeto))
            {
                use.Add(objeto);
                return true;
            }
            return false;
        }

        public bool Remover(string descricao)
        {
           var objeto =  use.ListaOperacaoes().Where(p => p.Descricao == descricao).FirstOrDefault();
            use.Remove(objeto);
            return true;
        }


    }
}
