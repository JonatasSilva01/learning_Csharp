﻿
namespace Banco
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextoTitular = new System.Windows.Forms.TextBox();
            this.TextoNumero = new System.Windows.Forms.TextBox();
            this.TextoSaldo = new System.Windows.Forms.TextBox();
            this.TextoValor = new System.Windows.Forms.TextBox();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.botaoDeposito = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Conta = new System.Windows.Forms.GroupBox();
            this.Conta.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextoTitular
            // 
            this.TextoTitular.Location = new System.Drawing.Point(120, 55);
            this.TextoTitular.Multiline = true;
            this.TextoTitular.Name = "TextoTitular";
            this.TextoTitular.Size = new System.Drawing.Size(151, 34);
            this.TextoTitular.TabIndex = 0;
            // 
            // TextoNumero
            // 
            this.TextoNumero.Location = new System.Drawing.Point(120, 95);
            this.TextoNumero.Multiline = true;
            this.TextoNumero.Name = "TextoNumero";
            this.TextoNumero.Size = new System.Drawing.Size(151, 31);
            this.TextoNumero.TabIndex = 1;
            // 
            // TextoSaldo
            // 
            this.TextoSaldo.Location = new System.Drawing.Point(120, 132);
            this.TextoSaldo.Multiline = true;
            this.TextoSaldo.Name = "TextoSaldo";
            this.TextoSaldo.Size = new System.Drawing.Size(151, 33);
            this.TextoSaldo.TabIndex = 2;
            // 
            // TextoValor
            // 
            this.TextoValor.Location = new System.Drawing.Point(120, 171);
            this.TextoValor.Multiline = true;
            this.TextoValor.Name = "TextoValor";
            this.TextoValor.Size = new System.Drawing.Size(151, 32);
            this.TextoValor.TabIndex = 4;
            // 
            // botaoSaque
            // 
            this.botaoSaque.Location = new System.Drawing.Point(187, 219);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(101, 34);
            this.botaoSaque.TabIndex = 5;
            this.botaoSaque.Text = "Botao Saque";
            this.botaoSaque.UseVisualStyleBackColor = true;
            this.botaoSaque.Click += new System.EventHandler(this.botaoSaque_Click);
            // 
            // botaoDeposito
            // 
            this.botaoDeposito.Location = new System.Drawing.Point(39, 219);
            this.botaoDeposito.Name = "botaoDeposito";
            this.botaoDeposito.Size = new System.Drawing.Size(96, 34);
            this.botaoDeposito.TabIndex = 6;
            this.botaoDeposito.Text = "Botao Deposito";
            this.botaoDeposito.UseVisualStyleBackColor = true;
            this.botaoDeposito.Click += new System.EventHandler(this.botaoDeposito_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(39, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor";
            // 
            // Conta
            // 
            this.Conta.Controls.Add(this.TextoTitular);
            this.Conta.Controls.Add(this.label4);
            this.Conta.Controls.Add(this.TextoNumero);
            this.Conta.Controls.Add(this.label3);
            this.Conta.Controls.Add(this.TextoSaldo);
            this.Conta.Controls.Add(this.label2);
            this.Conta.Controls.Add(this.TextoValor);
            this.Conta.Controls.Add(this.label1);
            this.Conta.Controls.Add(this.botaoSaque);
            this.Conta.Controls.Add(this.botaoDeposito);
            this.Conta.Location = new System.Drawing.Point(12, 72);
            this.Conta.Name = "Conta";
            this.Conta.Size = new System.Drawing.Size(311, 310);
            this.Conta.TabIndex = 11;
            this.Conta.TabStop = false;
            this.Conta.Text = "Conta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(this.Conta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Conta.ResumeLayout(false);
            this.Conta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextoTitular;
        private System.Windows.Forms.TextBox TextoNumero;
        private System.Windows.Forms.TextBox TextoSaldo;
        private System.Windows.Forms.TextBox TextoValor;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.Button botaoDeposito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Conta;
    }
}
