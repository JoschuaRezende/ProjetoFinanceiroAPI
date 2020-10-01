using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padawan.ControleFinanceiro.Model
{
    public class Carteira
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
