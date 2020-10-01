﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
