using Padawan.ControleFinanceiro.Context;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Padawan.ControleFinanceiro.Util
{
    public class Usuario
    {
        public readonly BancoUtil<Model.Usuario> context;
        public Usuario()
        {
            context = new BancoUtil<Model.Usuario>();
        }
        public bool Valida(Model.Usuario usuario)
        {
            var retorno = context.ListarUsuario().Any(p => p.Login == usuario.Login);
            if (!retorno)
            {
               context.Add(usuario);
               return true;
            }
            return false;
        }

        public bool Senha(Model.Usuario usuario)
        {
            Regex rx = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{4,}$");
            var retorno = rx.IsMatch(usuario.Senha);

            return retorno;
        }

        public List<string> ListaNomeUsuarios()
        {
            return context.ListarUsuario().Select(p => p.Nome).ToList();
        }

        public int RetornaIdNome(string usuario)
        {
            var objeto = context.ListarUsuario().First(p => p.Nome == usuario);
            return objeto.Id;
        }

        public bool ValidaLogin(string usuario, string senha)
        {
            var result = new Util.Usuario();

            return result.Listar().Any(p => p.Login == usuario && p.Senha == senha);
        }

        public List<Model.Usuario> Listar()
        {
           return context.ListarUsuario();
        }

        public bool AlterarSenha(string usuario, string senha)
        {
            var filtro = context.ListarUsuario().Find(p => p.Login == usuario);
            filtro.Senha = senha;
            if (!Senha(filtro))
            {
                return false;
            }
            context.AlterarSenha(filtro);
            return true;
        }

        public bool ValidaUsuario(string usuario)
        {
            return context.ListarUsuario().Any(p => p.Login == usuario);
        }
    }
}

