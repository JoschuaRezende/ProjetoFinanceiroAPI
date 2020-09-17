using System;
using System.Windows.Forms;

namespace Padawan.ControleFinanceiro.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lbl_CadastrarUsuario_Click(object sender, EventArgs e)
        {
            var forms = new CadastrarUsuario();
            forms.ShowDialog();
        }
    }
}
