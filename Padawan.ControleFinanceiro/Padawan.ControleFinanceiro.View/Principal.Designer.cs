﻿namespace Padawan.ControleFinanceiro.View
{
    partial class Principal
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
            this.btn_EditarLogin = new System.Windows.Forms.Button();
            this.btn_Financeiro = new System.Windows.Forms.Button();
            this.btn_CadastroBanco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_EditarLogin
            // 
            this.btn_EditarLogin.Location = new System.Drawing.Point(699, 12);
            this.btn_EditarLogin.Name = "btn_EditarLogin";
            this.btn_EditarLogin.Size = new System.Drawing.Size(98, 34);
            this.btn_EditarLogin.TabIndex = 0;
            this.btn_EditarLogin.Text = "Editar Usuario";
            this.btn_EditarLogin.UseVisualStyleBackColor = true;
            // 
            // btn_Financeiro
            // 
            this.btn_Financeiro.Location = new System.Drawing.Point(213, 12);
            this.btn_Financeiro.Name = "btn_Financeiro";
            this.btn_Financeiro.Size = new System.Drawing.Size(172, 105);
            this.btn_Financeiro.TabIndex = 0;
            this.btn_Financeiro.Text = "Operações Financeiras";
            this.btn_Financeiro.UseVisualStyleBackColor = true;
            this.btn_Financeiro.Click += new System.EventHandler(this.Btn_Financeiro_Click);
            // 
            // btn_CadastroBanco
            // 
            this.btn_CadastroBanco.Location = new System.Drawing.Point(12, 18);
            this.btn_CadastroBanco.Name = "btn_CadastroBanco";
            this.btn_CadastroBanco.Size = new System.Drawing.Size(75, 23);
            this.btn_CadastroBanco.TabIndex = 1;
            this.btn_CadastroBanco.Text = "Bancos";
            this.btn_CadastroBanco.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CadastroBanco);
            this.Controls.Add(this.btn_EditarLogin);
            this.Controls.Add(this.btn_Financeiro);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_EditarLogin;
        private System.Windows.Forms.Button btn_Financeiro;
        private System.Windows.Forms.Button btn_CadastroBanco;
    }
}