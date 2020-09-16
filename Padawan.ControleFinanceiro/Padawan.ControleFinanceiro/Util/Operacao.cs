using Padawan.ControleFinanceiro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Padawan.ControleFinanceiro.Util
{
    public class Operacao
    {

        public static List<Operacao> listaOperacao = new List<Operacao>();
        public void Criar()
        {
            var operacao = new Model.Operacao();
        }
    }
}
