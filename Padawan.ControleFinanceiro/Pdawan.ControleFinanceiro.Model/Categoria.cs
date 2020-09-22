using Padawan.ControleFinanceiro.Model.Interfaces;
using System.Collections.Generic;

namespace Padawan.ControleFinanceiro.Model
{
    public class Categoria : ICategoriaGeral
    {
        public Categoria()
        {
            Operacoes = new HashSet<Operacao>();
        }
        public int Id { get; set; }
        public string Descricao { get; set; }

        public ICollection<Operacao> Operacoes { get; set; }
    }
}
