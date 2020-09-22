using System;
using System.Collections.Generic;
using System.Text;

namespace Padawan.ControleFinanceiro.Model.Interfaces
{
    public interface IOperacao
    {
        string Descricao { get; set; }
        double Valor { get; set; }
        DateTime Data { get; set; }
        Categoria Categoria { get; set; }
    }
}
