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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lbl_CadastrarNovo_Click(object sender, EventArgs e)
        {
            var forms = new CadastrarUsuario();
            forms.ShowDialog();
            this.Close();
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();

            string login = txt_Login.Text;
            string senha = txt_Senha.Text;

            var URL = $"https://localhost:44360/Usuario/Logar?usuario={login}&senha={senha}";
            var result = httpClient.GetAsync(URL);
            result.Wait();

            var resultado = result.Result.Content.ReadAsStringAsync();
            result.Wait();

            var resultadoCorpo = JsonConvert.DeserializeObject<Result<List<Usuario>>>(resultado.Result);

            if (result.Result.IsSuccessStatusCode)
            {
                var principal = new Principal();
                principal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(resultadoCorpo.Mensagem);
            }
        }
    }
}
