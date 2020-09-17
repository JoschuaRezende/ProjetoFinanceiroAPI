using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace Padawan.ControleFinanceiro.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Lbl_CadastrarUsuario_Click(object sender, EventArgs e)
        {
            var forms = new CadastrarUsuario();
            forms.ShowDialog();
        }

        private void Btn_Logar_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();

            string login = txt_Login.Text;
            string senha = txt_Senha.Text;

            var URL = $"https://localhost:44360/Usuario/Logar?usuario={login}&senha={senha}";
            var result = httpClient.GetAsync(URL);
            result.Wait();
            if (result.Result.IsSuccessStatusCode)
            {
                var principal = new Principal();
                principal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login ou senha Incorreto");
            }
        }
    }
}
