using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padawan.ControleFinanceiro.Forms
{
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
            this.Close();
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {

        }
    }
}
