using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Padawan.ControleFinanceiro.View
{
    public class objetoLogin
    {
        public string login;
        public string senha;
      
    }

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lbl_Cadastrar_Click(object sender, EventArgs e)
        {
            var forms = new CadastrarUsuario();

            forms.ShowDialog();
            forms.Close();
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            var login = new objetoLogin { 
              login = txt_Login.Text,
              senha = txt_Senha.Text
            };

            var novoUsuario = JsonConvert.SerializeObject(login);
            StringContent content = new StringContent(novoUsuario, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();

            var URL = "https://localhost:44360//Cadastro/Lista";
            var result = httpClient.PostAsync($"{URL}", content);
            result.Wait();
        }
    }
}
