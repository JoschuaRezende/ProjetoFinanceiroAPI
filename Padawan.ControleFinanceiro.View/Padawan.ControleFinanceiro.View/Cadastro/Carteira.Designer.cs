namespace Padawan.ControleFinanceiro.View.Cadastro
{
    partial class Carteira
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Banco = new System.Windows.Forms.Label();
            this.lbl_Cateira = new System.Windows.Forms.Label();
            this.txt_Carteira = new System.Windows.Forms.TextBox();
            this.cmb_Banco = new System.Windows.Forms.ComboBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Banco
            // 
            this.lbl_Banco.AutoSize = true;
            this.lbl_Banco.Location = new System.Drawing.Point(74, 48);
            this.lbl_Banco.Name = "lbl_Banco";
            this.lbl_Banco.Size = new System.Drawing.Size(38, 13);
            this.lbl_Banco.TabIndex = 0;
            this.lbl_Banco.Text = "Banco";
            // 
            // lbl_Cateira
            // 
            this.lbl_Cateira.AutoSize = true;
            this.lbl_Cateira.Location = new System.Drawing.Point(74, 111);
            this.lbl_Cateira.Name = "lbl_Cateira";
            this.lbl_Cateira.Size = new System.Drawing.Size(43, 13);
            this.lbl_Cateira.TabIndex = 1;
            this.lbl_Cateira.Text = "Carteira";
            // 
            // txt_Carteira
            // 
            this.txt_Carteira.Location = new System.Drawing.Point(77, 127);
            this.txt_Carteira.Name = "txt_Carteira";
            this.txt_Carteira.Size = new System.Drawing.Size(245, 20);
            this.txt_Carteira.TabIndex = 2;
            // 
            // cmb_Banco
            // 
            this.cmb_Banco.FormattingEnabled = true;
            this.cmb_Banco.Location = new System.Drawing.Point(77, 64);
            this.cmb_Banco.Name = "cmb_Banco";
            this.cmb_Banco.Size = new System.Drawing.Size(245, 21);
            this.cmb_Banco.TabIndex = 3;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(77, 165);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(105, 23);
            this.btn_cadastrar.TabIndex = 4;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // Carteira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 227);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.cmb_Banco);
            this.Controls.Add(this.txt_Carteira);
            this.Controls.Add(this.lbl_Cateira);
            this.Controls.Add(this.lbl_Banco);
            this.Name = "Carteira";
            this.Text = "Carteira";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Banco;
        private System.Windows.Forms.Label lbl_Cateira;
        private System.Windows.Forms.TextBox txt_Carteira;
        private System.Windows.Forms.ComboBox cmb_Banco;
        private System.Windows.Forms.Button btn_cadastrar;
    }
}