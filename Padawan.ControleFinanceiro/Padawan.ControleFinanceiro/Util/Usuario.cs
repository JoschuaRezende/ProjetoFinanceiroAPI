using Padawan.ControleFinanceiro.Context;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Padawan.ControleFinanceiro.Util
{
    public class Usuario
    {
        BancoUtil<Model.Usuario> banco = new BancoUtil<Model.Usuario>();
       
        public bool Valida(Model.Usuario usuario)
        {
            var retorno = banco.ListarUsuario().Where(p => p.Login == usuario.Login).Any();
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

        public List<string> ListaNomeUsuarios()
        {
            return banco.ListarUsuario().Select(p => p.Nome).ToList();
        }

        public bool ValidaLogin(string usuario, string senha)
        {
            var result = new Util.Usuario();

            if (!result.Listar().Where(p => p.Login == usuario && p.Senha == senha).Any())
            {
                return false;
            }
            return true;

        }

        public List<Model.Usuario> Listar()
        {
           return banco.ListarUsuario();
        }
    }
}

