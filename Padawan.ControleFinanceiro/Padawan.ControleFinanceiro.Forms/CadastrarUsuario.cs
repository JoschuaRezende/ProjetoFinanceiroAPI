using System;
using System.Windows.Forms;

namespace Padawan.ControleFinanceiro.Forms
{
    public partial class CadastrarUsuario : Form
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            var user = new Model.Usuario();
        }
    }
}
