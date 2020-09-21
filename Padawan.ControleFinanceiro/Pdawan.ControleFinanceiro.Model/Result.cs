using System.Net;

namespace Padawan.ControleFinanceiro.Model
{
    public class Result<T>
    {
        public T Data { get; set; }
        public HttpStatusCode Status { get; set; }
        public bool Erro { get; set; }
        public string Mensagem { get; set; }

        public void ResultadoOperacao(bool erro, HttpStatusCode status, string mensagem)
        {
            Erro = erro;
            Status = status;
            Mensagem = mensagem;
        }
    }
}
