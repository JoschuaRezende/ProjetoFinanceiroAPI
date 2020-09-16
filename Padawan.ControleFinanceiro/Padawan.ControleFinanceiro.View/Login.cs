using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

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
       
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
