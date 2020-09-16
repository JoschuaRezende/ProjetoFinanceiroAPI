using System.Collections.Generic;

namespace Padawan.ControleFinanceiro.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public ICollection<Banco> Bancos { get; set; }

        public Usuario()
        {
            Bancos = new HashSet<Banco>();
        }
    }
}
