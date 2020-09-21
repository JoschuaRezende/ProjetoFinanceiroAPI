using Newtonsoft.Json;
using Padawan.ControleFinanceiro.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Padawan.ControleFinanceiro.View
{
    public partial class CadastrarUsuario : Form
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            const string URL = "https://localhost:44360/Usuario/Cadastrar";
            var user = new Usuario {
               Login = txt_Login.Text,
               Nome = txt_Nome.Text,
               Senha = txt_Senha.Text
            };

            var novoUsuario = JsonConvert.SerializeObject(user);
            StringContent content = new StringContent(novoUsuario, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();

            var result = httpClient.PostAsync(URL, content);
            result.Wait();

            var resultado = result.Result.Content.ReadAsStringAsync();
            result.Wait();

            var resultadoCorpo = JsonConvert.DeserializeObject<Result<List<Model.Usuario>>>(resultado.Result);
            MessageBox.Show(resultadoCorpo.Mensagem);

            this.Close();
        }

        private void Txt_Senha_TextChanged(object sender, EventArgs e)
        {
        }

        private void CadastrarUsuario_Load(object sender, EventArgs e)
        {
        }
    }
}
