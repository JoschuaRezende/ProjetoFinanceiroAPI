using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
