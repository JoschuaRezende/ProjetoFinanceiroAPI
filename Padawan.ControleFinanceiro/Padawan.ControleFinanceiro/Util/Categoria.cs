using Padawan.ControleFinanceiro.Context;

namespace Padawan.ControleFinanceiro.Util
{
    public class Categoria
    {
        //protected BancoContext context = new BancoContext();
        
        public void Criar(string descricao)
        {
            var categoria = new Padawan.ControleFinanceiro.Model.Categoria();
            categoria.Descricao = descricao;


        }
    }
}
