using Padawan.ControleFinanceiro.Context;
using System.Linq;


namespace Padawan.ControleFinanceiro.Util
{
    public class Carteira {

        BancoUtil<Model.Carteira> use = new BancoUtil<Model.Carteira>();

        public bool Add(Model.Carteira objeto)
        {

            var retorno = use.ListarCarteira().Where(p => p.Descricao == objeto.Descricao).Any();
            if (!retorno)
            {
                use.Add(objeto);
                return true;
            }
            return false;
        }

        //ainda não sei como fazer essa parte 

        //public bool Renomear(string descricao, string novaDescricao, int novoIdBanco, Model.Carteira objeto)
        //{
        //    var filtro = use.ListarCategoria().Where(p => p.Descricao == descricao).FirstOrDefault();
        //    filtro.Descricao = novaDescricao;

        //    use.AtualizarCategoria(filtro);
        //    return true;
        //}
    }

        


    //{
    //    private const string caminho = @"C:\Users\joschua.silva\Documents\GitHub\ProjetoFinanceiroAPI\Padawan.ControleFinanceiro\";
    //    private const string arquivoNome = "BancoFinanceiro.db";

    //public void Criar()
    //{
    //    var carteira = new Pdawan.ControleFinanceiro.Model.Carteira();
    //    carteira.Saldo = CalcularSaldo();

    //}

    //public double CalcularSaldo()
    //{
    //    double result = 0;

    //    using (var db = new LiteDatabase(caminho + arquivoNome))
    //    {
    //        var teste = db.GetCollection<IOperacao>();
    //        var colecao = teste.FindAll();

    //        colecao.ToList().ForEach(p =>
    //        {
    //            if (p is Debito)
    //            {
    //                result -= p.Valor;
    //            }
    //            if (p is Credito)
    //            {
    //                result += p.Valor;
    //            }
    //        });
    //    }
    //    return result;
    //}


    //    public double CalcularDebitos()
    //    {
    //        double result = 0;
    //        using (var db = new LiteDatabase(caminho + arquivoNome))
    //        {
    //            var teste = db.GetCollection<IOperacao>();
    //            var colecao = teste.FindAll();

    //            colecao.ToList().ForEach(p =>
    //            {
    //                if (p is Debito)
    //                {
    //                    result -= p.Valor;
    //                }
    //            });
    //        }
    //        return result;
    //    }

    //    public double CalcularCredito()
    //    {
    //        double result = 0;
    //        using (var db = new LiteDatabase(caminho + arquivoNome))
    //        {
    //            var teste = db.GetCollection<IOperacao>();
    //            var colecao = teste.FindAll();

    //            colecao.Where(p => p is Credito).Sum(p => p.Valor);
    //        }
    //        return result;
    //    }



    //    //public void Add(IOperacao operacao)
    //    //{
    //    //    using (var db = new LiteDatabase(@"C:\Users\joschua.silva\Documents\GitHub\ControleFinanceiro_Padawan\Banco\Banco.db"))
    //    //    {
    //    //        var teste = db.GetCollection<IOperacao>();
    //    //        teste.Insert(operacao);
    //    //    }
    //    //}

    //    public void Delete(IOperacao operacao)
    //    {
    //        using (var db = new LiteDatabase(caminho + arquivoNome))
    //        {
    //            var teste = db.GetCollection<IOperacao>();
    //            // teste.Delete()
    //        }
    //    }

    //}
}
