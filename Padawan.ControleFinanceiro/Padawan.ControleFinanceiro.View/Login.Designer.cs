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
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.lbl_Cadastrar = new System.Windows.Forms.Label();
            this.btn_Logar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(98, 81);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(37, 15);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Login";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(98, 125);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(39, 15);
            this.lbl_senha.TabIndex = 0;
            this.lbl_senha.Text = "Senha";
            // 
            // txt_Login
            // 
            this.txt_Login.Location = new System.Drawing.Point(98, 99);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(172, 23);
            this.txt_Login.TabIndex = 1;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(98, 141);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(172, 23);
            this.txt_Senha.TabIndex = 1;
            // 
            // lbl_Cadastrar
            // 
            this.lbl_Cadastrar.AutoSize = true;
            this.lbl_Cadastrar.Location = new System.Drawing.Point(98, 167);
            this.lbl_Cadastrar.Name = "lbl_Cadastrar";
            this.lbl_Cadastrar.Size = new System.Drawing.Size(57, 15);
            this.lbl_Cadastrar.TabIndex = 0;
            this.lbl_Cadastrar.Text = "Cadastrar";
            this.lbl_Cadastrar.Click += new System.EventHandler(this.lbl_Cadastrar_Click);
            // 
            // btn_Logar
            // 
            this.btn_Logar.Location = new System.Drawing.Point(142, 199);
            this.btn_Logar.Name = "btn_Logar";
            this.btn_Logar.Size = new System.Drawing.Size(75, 23);
            this.btn_Logar.TabIndex = 2;
            this.btn_Logar.Text = "Logar";
            this.btn_Logar.UseVisualStyleBackColor = true;
            this.btn_Logar.Click += new System.EventHandler(this.btn_Logar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 350);
            this.Controls.Add(this.btn_Logar);
            this.Controls.Add(this.lbl_Cadastrar);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Login);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_login);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label lbl_Cadastrar;
        private System.Windows.Forms.Button btn_Logar;
    }
}