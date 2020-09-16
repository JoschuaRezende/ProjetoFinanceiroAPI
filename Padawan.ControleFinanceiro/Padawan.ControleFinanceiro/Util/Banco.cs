using Padawan.ControleFinanceiro.Model;
namespace Padawan.ControleFinanceiro.Util

{
    public class Banco
    {
        private readonly Model.Banco banco;
        public Banco(Model.Banco c)
        {
            banco = c;
        }

        public void Criar(string descricao, int id)
        {
            banco.Id = id;
            banco.Descricao = descricao;
          
        }



      
    }
}
