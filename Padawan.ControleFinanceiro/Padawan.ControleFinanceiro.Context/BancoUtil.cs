using Padawan.ControleFinanceiro.Model;
using System.Collections.Generic;
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

    

        public void Add(Operacao usuario)
        {
            banco = new BancoContext();
            using (banco)
            {
                banco.Operacoes.Add(usuario);
                banco.SaveChanges();
            }
        }

        public void Remove(Operacao objeto)
        {
            banco = new BancoContext();
            using (banco)
            {
                banco.Operacoes.Remove(objeto);

                banco.SaveChanges();
            }
        }

        public void Remove(Categoria objeto)
        {
            banco = new BancoContext();
            using (banco)
            {
                banco.Categorias.Remove(objeto);

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
        public List<Operacao> ListaOperacaoes()
        {
            banco = new BancoContext();
            List<Operacao> result;
            using (banco)
            {
                result = banco.Operacoes.ToList();
            }
            return result;
        }

        public bool AtualizarCategoria(Categoria objeto)
        {
            banco = new BancoContext();
            List<Categoria> result;
            using (banco)
            {
                banco.Update(objeto);
                banco.SaveChanges();
            }
            return true;
        }

        public bool AtualizarSaldoCarteira(Carteira carteira)
        {
            banco = new BancoContext();
            
            using (banco)
            {
                banco.Update(carteira);
                banco.SaveChanges();
            }
            return true;
        }
        public bool AtualizarBanco(Banco filtro)
        {
            banco = new BancoContext();
            using (banco)
            {
                banco.Update(filtro);
                banco.SaveChanges();
                return true;
            }
        }

        public bool AtualizarCarteira(Categoria objeto)
        {
            banco = new BancoContext();
            List<Carteira> result;
            using (banco)
            {
                banco.Update(objeto);
                banco.SaveChanges();
            }
            return true;
        }

        public bool AlterarSenha(Usuario objeto)
        {
            banco = new BancoContext();
            List<Carteira> result;
            using (banco)
            {
                banco.Update(objeto);
                banco.SaveChanges();
            }
            return true;
        }

        public bool AtualizarCarteira(Carteira objeto)
        {
            banco = new BancoContext();
            List<Carteira> result;
            using (banco)
            {
                banco.Update(objeto);
                banco.SaveChanges();
            }
            return true;
        }
    }
}
