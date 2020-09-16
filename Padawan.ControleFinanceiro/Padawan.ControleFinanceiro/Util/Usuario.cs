using Padawan.ControleFinanceiro.Context;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Padawan.ControleFinanceiro.Util
{
    public class Usuario
    {
        BancoUtil<Usuario> banco = new BancoUtil<Usuario>();
        private BancoContext abertura = new BancoContext();
        public bool Valida(Model.Usuario usuario)
        {
            var retorno = banco.Listar().Where(p => p.Login == usuario.Login).Any();
            if (!retorno)
            {
               banco.Add(usuario);
               return true;
            }
            return false;
        }

        public bool Senha(Model.Usuario usuario)
        {
            Regex rx = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{4,}$");
            var retorno = rx.IsMatch(usuario.Senha);

            if (!retorno)
            {
                return false;
            }
            return true;
        }

        public List<string> Lista()
        {
            return banco.Listar().Select(p => p.Nome).ToList();
        }
    }
}

