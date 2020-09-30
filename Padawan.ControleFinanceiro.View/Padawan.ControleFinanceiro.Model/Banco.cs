using System.Collections.Generic;

namespace Padawan.ControleFinanceiro.Model
{
    public class Banco
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Descricao { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<Carteira> Carteiras { get; set; }
    }
}
