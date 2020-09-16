using Padawan.ControleFinanceiro.Model;
using System;

namespace Padawan.ControleFinanceiro.Interfaces
{
    public interface IOperacao
    {
        string Descricao { get; set; }
        double Valor { get; set; }
        DateTime Data { get; set; }
        Categoria Categoria { get; set; }
    }
}
