using Newtonsoft.Json;
using Padawan.ControleFinanceiro.Model;
using System;
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

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            var user = new Usuario { 
               Login = txt_Login.Text,
               Nome = txt_Nome.Text,
               Senha = txt_Senha.Text
            };

            var novoUsuario = JsonConvert.SerializeObject(user);
            StringContent content = new StringContent(novoUsuario, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();

            var URL = "https://localhost:44360/Cadastro/Usuario";
            var result = httpClient.PostAsync($"{URL}", content);
            result.Wait();
            this.Close();
        }
    }
}
