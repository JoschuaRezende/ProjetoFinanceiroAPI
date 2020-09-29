using Newtonsoft.Json;
using Padawan.ControleFinanceiro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
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
            const string URL = "https://localhost:44360/Usuario/Cadastrar";
            var user = new Usuario
            {
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

            var resultadoCorpo = JsonConvert.DeserializeObject<Result<List<Usuario>>>(resultado.Result);
            MessageBox.Show(resultadoCorpo.Mensagem);

            this.Close();
        }
    }
}
