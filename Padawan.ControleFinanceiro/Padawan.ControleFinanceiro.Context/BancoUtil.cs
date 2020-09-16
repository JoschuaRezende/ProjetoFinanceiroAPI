using Padawan.ControleFinanceiro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Linq;

namespace Padawan.ControleFinanceiro.Context
{
    public class BancoUtil<T>
    {
        private  BancoContext banco;

        public BancoUtil()
        {
        }

        //public void Add(T objeto)
        //{
        //    banco = new BancoContext();
        //    using (banco)
        //    {
        //        banco.GetType(obje;
        //        banco.SaveChanges();
        //    }
        //}

        public void Add(Usuario usuario)
        {
            banco = new BancoContext();
            using (banco)
            {
                banco.Usuarios.Add(usuario);
                banco.SaveChanges();
            }
        }

        public void Remove(T objeto)
        {
            banco = new BancoContext();
            using (banco)
            {
                banco.Remove(objeto);
                banco.SaveChanges();
            }
        }

        public List<Usuario> Listar()
        {
            banco = new BancoContext();
            List<Usuario> result;
            using (banco)
            {
               result = banco.Usuarios.ToList();
            }
            return result;
        }

    }
}
