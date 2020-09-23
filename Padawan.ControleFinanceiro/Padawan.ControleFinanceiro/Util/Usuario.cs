using Padawan.ControleFinanceiro.Context;
using System;
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

        public bool Senha(string senha)
        {
            Regex rx = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{4,}$");
            var retorno = rx.IsMatch(senha);

            return retorno;
        }

        public List<Model.Usuario> ListaNomeUsuarios()
        {
            return context.ListarUsuario();
        }

        public int RetornaIdNome(string usuario)
        {
            try
            {
                var objeto = context.ListarUsuario().First(p => p.Nome == usuario);
                return objeto.Id;
            }
            catch (Exception)
            {
                return -1;
            }
       
        }

        public bool ValidaLogin(string usuario, string senha)
        {
            var result = new Usuario();

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
            if (!Senha(filtro.Senha))
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

        public bool Remove(string objeto)
        {
            var result = context.ListarUsuario().Find(p => p.Login == objeto);
            if (result == null)
            {
                return false;
            }

            context.Remove(result);
            return true;
        }
    }
}

