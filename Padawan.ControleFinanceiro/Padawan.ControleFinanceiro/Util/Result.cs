using System.Net;

namespace Padawan.ControleFinanceiro.Util
{
    public class Result<T>
    {
        public T Data { get; set; }
        public HttpStatusCode Status { get; set; }
        public bool Erro { get; set; }
        public string Mensagem { get; set; }

    }
}
