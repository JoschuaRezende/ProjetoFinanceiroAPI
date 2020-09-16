using System.Collections.Generic;

namespace Padawan.ControleFinanceiro.Interfaces
{
    public interface IBalanco
    {
        //void Add(IOperacao operacao);
        void Delete(IOperacao operacao);
        List<IOperacao> Operacoes { get; }
        double Saldo { get; }
    }
}
