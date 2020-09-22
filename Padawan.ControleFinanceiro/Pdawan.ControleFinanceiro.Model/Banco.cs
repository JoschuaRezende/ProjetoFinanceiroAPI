using Padawan.ControleFinanceiro.Model.Interfaces;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Padawan.ControleFinanceiro.Model
{
    public class Banco : ICategoriaGeral
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Descricao { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<Carteira> Carteiras { get; set; }
    }
}
