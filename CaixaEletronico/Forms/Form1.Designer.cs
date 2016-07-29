namespace CaixaEletronico.Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numeroTxt = new System.Windows.Forms.TextBox();
            this.titularTxt = new System.Windows.Forms.TextBox();
            this.SaldoTxt = new System.Windows.Forms.TextBox();
            this.valorParaOperacaoTxt = new System.Windows.Forms.TextBox();
            this.efetuaDepositoBtn = new System.Windows.Forms.Button();
            this.efetuaSaqueBtn = new System.Windows.Forms.Button();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.comboContasParaTEDDOC = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.novaContaBtn = new System.Windows.Forms.Button();
            this.excluir_Conta_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Títular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Saldo: R$";
            // 
            // numeroTxt
            // 
            this.numeroTxt.Location = new System.Drawing.Point(91, 63);
            this.numeroTxt.Name = "numeroTxt";
            this.numeroTxt.Size = new System.Drawing.Size(121, 20);
            this.numeroTxt.TabIndex = 4;
            // 
            // titularTxt
            // 
            this.titularTxt.Location = new System.Drawing.Point(91, 96);
            this.titularTxt.Name = "titularTxt";
            this.titularTxt.Size = new System.Drawing.Size(121, 20);
            this.titularTxt.TabIndex = 5;
            // 
            // SaldoTxt
            // 
            this.SaldoTxt.Location = new System.Drawing.Point(91, 130);
            this.SaldoTxt.Name = "SaldoTxt";
            this.SaldoTxt.Size = new System.Drawing.Size(121, 20);
            this.SaldoTxt.TabIndex = 6;
            // 
            // valorParaOperacaoTxt
            // 
            this.valorParaOperacaoTxt.Location = new System.Drawing.Point(72, 207);
            this.valorParaOperacaoTxt.Name = "valorParaOperacaoTxt";
            this.valorParaOperacaoTxt.Size = new System.Drawing.Size(128, 20);
            this.valorParaOperacaoTxt.TabIndex = 7;
            // 
            // efetuaDepositoBtn
            // 
            this.efetuaDepositoBtn.Location = new System.Drawing.Point(72, 233);
            this.efetuaDepositoBtn.Name = "efetuaDepositoBtn";
            this.efetuaDepositoBtn.Size = new System.Drawing.Size(61, 23);
            this.efetuaDepositoBtn.TabIndex = 8;
            this.efetuaDepositoBtn.Text = "Depositar";
            this.efetuaDepositoBtn.UseVisualStyleBackColor = true;
            this.efetuaDepositoBtn.Click += new System.EventHandler(this.efetuaDepositoBtn_Click);
            // 
            // efetuaSaqueBtn
            // 
            this.efetuaSaqueBtn.Location = new System.Drawing.Point(139, 233);
            this.efetuaSaqueBtn.Name = "efetuaSaqueBtn";
            this.efetuaSaqueBtn.Size = new System.Drawing.Size(61, 23);
            this.efetuaSaqueBtn.TabIndex = 9;
            this.efetuaSaqueBtn.Text = "Sacar";
            this.efetuaSaqueBtn.UseVisualStyleBackColor = true;
            this.efetuaSaqueBtn.Click += new System.EventHandler(this.efetuaSaqueBtn_Click);
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(37, 12);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(216, 21);
            this.comboContas.TabIndex = 10;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboContasParaTEDDOC
            // 
            this.comboContasParaTEDDOC.FormattingEnabled = true;
            this.comboContasParaTEDDOC.Location = new System.Drawing.Point(12, 180);
            this.comboContasParaTEDDOC.Name = "comboContasParaTEDDOC";
            this.comboContasParaTEDDOC.Size = new System.Drawing.Size(140, 21);
            this.comboContasParaTEDDOC.TabIndex = 11;
            this.comboContasParaTEDDOC.SelectedIndexChanged += new System.EventHandler(this.comboContasParaTEDDOC_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Transferir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // novaContaBtn
            // 
            this.novaContaBtn.Location = new System.Drawing.Point(158, 34);
            this.novaContaBtn.Name = "novaContaBtn";
            this.novaContaBtn.Size = new System.Drawing.Size(75, 23);
            this.novaContaBtn.TabIndex = 13;
            this.novaContaBtn.Text = "Nova Conta";
            this.novaContaBtn.UseVisualStyleBackColor = true;
            this.novaContaBtn.Click += new System.EventHandler(this.novaContaBtn_Click);
            // 
            // excluir_Conta_Btn
            // 
            this.excluir_Conta_Btn.Location = new System.Drawing.Point(77, 34);
            this.excluir_Conta_Btn.Name = "excluir_Conta_Btn";
            this.excluir_Conta_Btn.Size = new System.Drawing.Size(75, 23);
            this.excluir_Conta_Btn.TabIndex = 14;
            this.excluir_Conta_Btn.Text = "Excluir";
            this.excluir_Conta_Btn.UseVisualStyleBackColor = true;
            this.excluir_Conta_Btn.Click += new System.EventHandler(this.excluir_Conta_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.excluir_Conta_Btn);
            this.Controls.Add(this.novaContaBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboContasParaTEDDOC);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.efetuaSaqueBtn);
            this.Controls.Add(this.efetuaDepositoBtn);
            this.Controls.Add(this.valorParaOperacaoTxt);
            this.Controls.Add(this.SaldoTxt);
            this.Controls.Add(this.titularTxt);
            this.Controls.Add(this.numeroTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numeroTxt;
        private System.Windows.Forms.TextBox titularTxt;
        private System.Windows.Forms.TextBox SaldoTxt;
        private System.Windows.Forms.TextBox valorParaOperacaoTxt;
        private System.Windows.Forms.Button efetuaDepositoBtn;
        private System.Windows.Forms.Button efetuaSaqueBtn;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.ComboBox comboContasParaTEDDOC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button novaContaBtn;
        private System.Windows.Forms.Button excluir_Conta_Btn;
    }
}

