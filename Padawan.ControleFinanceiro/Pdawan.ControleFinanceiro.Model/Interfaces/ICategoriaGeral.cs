using System;
using System.Collections.Generic;
using System.Text;

namespace Padawan.ControleFinanceiro.Model.Interfaces
{
    public interface ICategoriaGeral
    {
        public int Id { get; set; }
        string Descricao { get; set; }
    }
}
