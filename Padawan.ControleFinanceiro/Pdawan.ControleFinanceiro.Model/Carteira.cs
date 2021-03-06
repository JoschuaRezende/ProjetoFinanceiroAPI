﻿
using Padawan.ControleFinanceiro.Model.Interfaces;
using System.Collections.Generic;

namespace Padawan.ControleFinanceiro.Model
{
    public class Carteira : ICategoriaGeral
    {
        public Carteira()
        {
            Operacoes = new HashSet<Operacao>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdBanco { get; set; }
        public double Saldo { get; set; }
        public virtual Banco Banco { get; set; }
        public virtual ICollection<Operacao> Operacoes { get; set; }
    }
}
