using Newtonsoft.Json;
using Padawan.ControleFinanceiro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padawan.ControleFinanceiro.View.Cadastro
{
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {

            var categoria = new Model.Categoria
            {
                Descricao = txt_Descricao.Text
            };

            var httpClient = new HttpClient();

            var URL = $"https://localhost:44360/Categoria/Cadastro";
            var novacategoria = JsonConvert.SerializeObject(categoria);
            StringContent content = new StringContent(novacategoria, Encoding.UTF8, "application/json");
            var result = httpClient.PostAsync(URL, content);
            result.Wait();

            var resultado = result.Result.Content.ReadAsStringAsync();
            result.Wait();

            var resultadoCorpo = JsonConvert.DeserializeObject<Result<List<Usuario>>>(resultado.Result);

            MessageBox.Show(resultadoCorpo.Mensagem);

        }
    }
}
