﻿namespace CaixaEletronico
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numeroTxt = new System.Windows.Forms.TextBox();
            this.titularTxt = new System.Windows.Forms.TextBox();
            this.SaldoTxt = new System.Windows.Forms.TextBox();
            this.valorParaOperacaoTxt = new System.Windows.Forms.TextBox();
            this.efetuaDepositoBtn = new System.Windows.Forms.Button();
            this.efetuaSaqueBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Títular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Saldo: R$";
            // 
            // numeroTxt
            // 
            this.numeroTxt.Location = new System.Drawing.Point(92, 32);
            this.numeroTxt.Name = "numeroTxt";
            this.numeroTxt.Size = new System.Drawing.Size(121, 20);
            this.numeroTxt.TabIndex = 4;
            // 
            // titularTxt
            // 
            this.titularTxt.Location = new System.Drawing.Point(92, 65);
            this.titularTxt.Name = "titularTxt";
            this.titularTxt.Size = new System.Drawing.Size(121, 20);
            this.titularTxt.TabIndex = 5;
            // 
            // SaldoTxt
            // 
            this.SaldoTxt.Location = new System.Drawing.Point(92, 99);
            this.SaldoTxt.Name = "SaldoTxt";
            this.SaldoTxt.Size = new System.Drawing.Size(121, 20);
            this.SaldoTxt.TabIndex = 6;
            // 
            // valorParaOperacaoTxt
            // 
            this.valorParaOperacaoTxt.Location = new System.Drawing.Point(72, 183);
            this.valorParaOperacaoTxt.Name = "valorParaOperacaoTxt";
            this.valorParaOperacaoTxt.Size = new System.Drawing.Size(128, 20);
            this.valorParaOperacaoTxt.TabIndex = 7;
            // 
            // efetuaDepositoBtn
            // 
            this.efetuaDepositoBtn.Location = new System.Drawing.Point(72, 209);
            this.efetuaDepositoBtn.Name = "efetuaDepositoBtn";
            this.efetuaDepositoBtn.Size = new System.Drawing.Size(61, 23);
            this.efetuaDepositoBtn.TabIndex = 8;
            this.efetuaDepositoBtn.Text = "Depositar";
            this.efetuaDepositoBtn.UseVisualStyleBackColor = true;
            this.efetuaDepositoBtn.Click += new System.EventHandler(this.efetuaDepositoBtn_Click);
            // 
            // efetuaSaqueBtn
            // 
            this.efetuaSaqueBtn.Location = new System.Drawing.Point(139, 209);
            this.efetuaSaqueBtn.Name = "efetuaSaqueBtn";
            this.efetuaSaqueBtn.Size = new System.Drawing.Size(61, 23);
            this.efetuaSaqueBtn.TabIndex = 9;
            this.efetuaSaqueBtn.Text = "Sacar";
            this.efetuaSaqueBtn.UseVisualStyleBackColor = true;
            this.efetuaSaqueBtn.Click += new System.EventHandler(this.efetuaSaqueBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.efetuaSaqueBtn);
            this.Controls.Add(this.efetuaDepositoBtn);
            this.Controls.Add(this.valorParaOperacaoTxt);
            this.Controls.Add(this.SaldoTxt);
            this.Controls.Add(this.titularTxt);
            this.Controls.Add(this.numeroTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numeroTxt;
        private System.Windows.Forms.TextBox titularTxt;
        private System.Windows.Forms.TextBox SaldoTxt;
        private System.Windows.Forms.TextBox valorParaOperacaoTxt;
        private System.Windows.Forms.Button efetuaDepositoBtn;
        private System.Windows.Forms.Button efetuaSaqueBtn;
    }
}
