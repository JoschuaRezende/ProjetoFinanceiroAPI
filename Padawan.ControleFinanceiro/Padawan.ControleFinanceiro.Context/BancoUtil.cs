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

        public void Add(T usuario)
        {
            banco = new BancoContext();
            using (banco)
            {
                banco.Add(usuario);
                banco.SaveChanges();
            }
        }

        public void Add(Banco usuario)
        {
            banco = new BancoContext();
            using (banco)
            {
                banco.Bancos.Add(usuario);
                banco.SaveChanges();
            }
        }

        public void Add(Categoria usuario)
        {
            banco = new BancoContext();
            using (banco)
            {
                banco.Categorias.Add(usuario);
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

        public List<Usuario> ListarUsuario()
        {
            banco = new BancoContext();
            List<Usuario> result;
            using (banco)
            {
               result = banco.Usuarios.ToList();
            }
            return result;
        }
        public List<Banco> ListarBanco()
        {
            banco = new BancoContext();
            List<Banco> result;
            using (banco)
            {
                result = banco.Bancos.ToList();
            }
            return result;
        }
        public List<Categoria> ListarCategoria()
        {
            banco = new BancoContext();
            List<Categoria> result;
            using (banco)
            {
                result = banco.Categorias.ToList();
            }
            return result;
        }

        public List<Carteira> ListarCarteira()
        {
            banco = new BancoContext();
            List<Carteira> result;
            using (banco)
            {
                result = banco.Carteiras.ToList();
            }
            return result;
        }

    }
}
