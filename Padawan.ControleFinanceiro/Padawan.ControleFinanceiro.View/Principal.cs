using System;
using System.Windows.Forms;

namespace Padawan.ControleFinanceiro.View
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Btn_Financeiro_Click(object sender, EventArgs e)
        {
            var operacaofinanceira = new OperacaoFinanceira();
            operacaofinanceira.ShowDialog();
        }
    }
}
