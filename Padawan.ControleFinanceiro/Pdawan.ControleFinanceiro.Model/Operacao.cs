using Padawan.ControleFinanceiro.Model.Interfaces;
using System;

namespace Padawan.ControleFinanceiro.Model
{
    public class Operacao : IOperacao
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public int IdCarteira { get; set; }
        public char Tipo { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual Carteira Carteira { get; set; }
    }
}
