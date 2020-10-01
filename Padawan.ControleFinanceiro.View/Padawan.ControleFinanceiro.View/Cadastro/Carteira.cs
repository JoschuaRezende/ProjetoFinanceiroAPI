using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace Padawan.ControleFinanceiro.View.Cadastro
{
    public partial class Carteira : Form
    {
        public Carteira()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

        }


        public void CarregarLista()
        {

            var httpClient = new HttpClient();
            var URL = "https://localhost:44360/Banco/Listar";
            var result = httpClient.GetAsync(URL);
            result.Wait();

            var resultado = result.Result.Content.ReadAsStringAsync();
            result.Wait();

            var resultadoCorpo = JsonConvert.DeserializeObject<Result<List<Model.Banco>>>(resultado.Result);
            MessageBox.Show(resultadoCorpo.Mensagem);

            var list = resultadoCorpo.Data;

            foreach (var item in list)
            {
                cmb_Banco.Items.Add(item);
            }
        }
    }
}
