namespace Padawan.ControleFinanceiro.View.Cadastro
{
    partial class Banco
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
            this.cmb_Usuario = new System.Windows.Forms.ComboBox();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_Usuario
            // 
            this.cmb_Usuario.FormattingEnabled = true;
            this.cmb_Usuario.Location = new System.Drawing.Point(30, 62);
            this.cmb_Usuario.Name = "cmb_Usuario";
            this.cmb_Usuario.Size = new System.Drawing.Size(209, 21);
            this.cmb_Usuario.TabIndex = 0;
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Location = new System.Drawing.Point(30, 120);
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(209, 20);
            this.txt_Descricao.TabIndex = 1;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(30, 43);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_Usuario.TabIndex = 2;
            this.lbl_Usuario.Text = "Usuário";
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Location = new System.Drawing.Point(30, 164);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(118, 23);
            this.btn_Gravar.TabIndex = 3;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.AutoSize = true;
            this.lbl_Descricao.Location = new System.Drawing.Point(27, 104);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(55, 13);
            this.lbl_Descricao.TabIndex = 4;
            this.lbl_Descricao.Text = "Descricao";
            // 
            // Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 209);
            this.Controls.Add(this.lbl_Descricao);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.txt_Descricao);
            this.Controls.Add(this.cmb_Usuario);
            this.Name = "Banco";
            this.Text = "Banco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Usuario;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Label lbl_Descricao;
    }
}