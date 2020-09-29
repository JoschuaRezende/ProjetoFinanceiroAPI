namespace Padawan.ControleFinanceiro.View
{
    partial class Login
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
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.lbl_CadastrarNovo = new System.Windows.Forms.Label();
            this.btn_Logar = new System.Windows.Forms.Button();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Location = new System.Drawing.Point(31, 60);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(33, 13);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "Login";
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Location = new System.Drawing.Point(31, 118);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(38, 13);
            this.lbl_Senha.TabIndex = 1;
            this.lbl_Senha.Text = "Senha";
            // 
            // lbl_CadastrarNovo
            // 
            this.lbl_CadastrarNovo.AutoSize = true;
            this.lbl_CadastrarNovo.Location = new System.Drawing.Point(31, 157);
            this.lbl_CadastrarNovo.Name = "lbl_CadastrarNovo";
            this.lbl_CadastrarNovo.Size = new System.Drawing.Size(116, 13);
            this.lbl_CadastrarNovo.TabIndex = 2;
            this.lbl_CadastrarNovo.Text = "Cadastrar novo usuário";
            this.lbl_CadastrarNovo.Click += new System.EventHandler(this.lbl_CadastrarNovo_Click);
            // 
            // btn_Logar
            // 
            this.btn_Logar.Location = new System.Drawing.Point(75, 199);
            this.btn_Logar.Name = "btn_Logar";
            this.btn_Logar.Size = new System.Drawing.Size(175, 23);
            this.btn_Logar.TabIndex = 3;
            this.btn_Logar.Text = "Logar";
            this.btn_Logar.UseVisualStyleBackColor = true;
            this.btn_Logar.Click += new System.EventHandler(this.btn_Logar_Click);
            // 
            // txt_Login
            // 
            this.txt_Login.Location = new System.Drawing.Point(34, 76);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(260, 20);
            this.txt_Login.TabIndex = 4;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(34, 134);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(260, 20);
            this.txt_Senha.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 303);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Login);
            this.Controls.Add(this.btn_Logar);
            this.Controls.Add(this.lbl_CadastrarNovo);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.lbl_Login);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.Label lbl_CadastrarNovo;
        private System.Windows.Forms.Button btn_Logar;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.TextBox txt_Senha;
    }
}

