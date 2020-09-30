using Newtonsoft.Json;
using Padawan.ControleFinanceiro.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Padawan.ControleFinanceiro.View.Cadastro
{
    public partial class Banco : Form
    {
        public Banco()
        {
            InitializeComponent();
            CarregarLista();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            const string URL = "https://localhost:44360/Banco/Cadastro";
         
            var banco = new Model.Banco
            {
                IdUsuario = ((Model.Usuario)cmb_Usuario.SelectedItem).Id,
                Descricao = txt_Descricao.Text
            };

            var novobanco = JsonConvert.SerializeObject(banco);
            StringContent content = new StringContent(novobanco, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();

            var result = httpClient.PostAsync(URL, content);
            result.Wait();

            var resultado = result.Result.Content.ReadAsStringAsync();
            result.Wait();

            var resultadoCorpo = JsonConvert.DeserializeObject<Result<List<Model.Usuario>>>(resultado.Result);
            MessageBox.Show(resultadoCorpo.Mensagem);
        }

        public void CarregarLista()
        {
            var httpClient = new HttpClient();
            var URL = "https://localhost:44360/Usuario/Listar";
            var result = httpClient.GetAsync(URL);
            result.Wait();

            var resultado = result.Result.Content.ReadAsStringAsync();
            result.Wait();

            var resultadoCorpo = JsonConvert.DeserializeObject<Result<List<Model.Usuario>>>(resultado.Result);
            MessageBox.Show(resultadoCorpo.Mensagem);

            var list = resultadoCorpo.Data;
            
            foreach (var item in list)
            {
                cmb_Usuario.Items.Add(item);
            }

           
        }
    }
}
