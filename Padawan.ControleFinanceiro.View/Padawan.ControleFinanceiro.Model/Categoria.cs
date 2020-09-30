using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padawan.ControleFinanceiro.Model
{
    public class Categoria 
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
