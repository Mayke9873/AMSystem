namespace Projeto_Novo
{
    partial class FrmAberturaCaixa
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
            this.lblValorAnterior = new System.Windows.Forms.Label();
            this.lblSenhaUsu = new System.Windows.Forms.Label();
            this.lblValorAbertura = new System.Windows.Forms.Label();
            this.txtSenhaUsu = new System.Windows.Forms.TextBox();
            this.txtValorAbertura = new System.Windows.Forms.TextBox();
            this.txtValFechamento = new System.Windows.Forms.TextBox();
            this.btnAbrirCaixa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorAnterior
            // 
            this.lblValorAnterior.AutoSize = true;
            this.lblValorAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblValorAnterior.Location = new System.Drawing.Point(116, 23);
            this.lblValorAnterior.Name = "lblValorAnterior";
            this.lblValorAnterior.Size = new System.Drawing.Size(73, 20);
            this.lblValorAnterior.TabIndex = 0;
            this.lblValorAnterior.Text = "Em caixa";
            // 
            // lblSenhaUsu
            // 
            this.lblSenhaUsu.AutoSize = true;
            this.lblSenhaUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSenhaUsu.Location = new System.Drawing.Point(124, 88);
            this.lblSenhaUsu.Name = "lblSenhaUsu";
            this.lblSenhaUsu.Size = new System.Drawing.Size(56, 20);
            this.lblSenhaUsu.TabIndex = 1;
            this.lblSenhaUsu.Text = "Senha";
            // 
            // lblValorAbertura
            // 
            this.lblValorAbertura.AutoSize = true;
            this.lblValorAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblValorAbertura.Location = new System.Drawing.Point(97, 161);
            this.lblValorAbertura.Name = "lblValorAbertura";
            this.lblValorAbertura.Size = new System.Drawing.Size(110, 20);
            this.lblValorAbertura.TabIndex = 2;
            this.lblValorAbertura.Text = "Valor abertura";
            // 
            // txtSenhaUsu
            // 
            this.txtSenhaUsu.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSenhaUsu.Location = new System.Drawing.Point(82, 111);
            this.txtSenhaUsu.Name = "txtSenhaUsu";
            this.txtSenhaUsu.Size = new System.Drawing.Size(140, 26);
            this.txtSenhaUsu.TabIndex = 4;
            this.txtSenhaUsu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenhaUsu.UseSystemPasswordChar = true;
            // 
            // txtValorAbertura
            // 
            this.txtValorAbertura.Font = new System.Drawing.Font("Arial", 12F);
            this.txtValorAbertura.Location = new System.Drawing.Point(82, 184);
            this.txtValorAbertura.Name = "txtValorAbertura";
            this.txtValorAbertura.Size = new System.Drawing.Size(140, 26);
            this.txtValorAbertura.TabIndex = 5;
            this.txtValorAbertura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValFechamento
            // 
            this.txtValFechamento.Font = new System.Drawing.Font("Arial", 12F);
            this.txtValFechamento.Location = new System.Drawing.Point(82, 46);
            this.txtValFechamento.Name = "txtValFechamento";
            this.txtValFechamento.Size = new System.Drawing.Size(140, 26);
            this.txtValFechamento.TabIndex = 3;
            this.txtValFechamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAbrirCaixa.Location = new System.Drawing.Point(82, 231);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(140, 30);
            this.btnAbrirCaixa.TabIndex = 6;
            this.btnAbrirCaixa.Text = "Abrir caixa";
            this.btnAbrirCaixa.UseVisualStyleBackColor = true;
            // 
            // FrmAberturaCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 281);
            this.Controls.Add(this.btnAbrirCaixa);
            this.Controls.Add(this.txtValorAbertura);
            this.Controls.Add(this.txtSenhaUsu);
            this.Controls.Add(this.txtValFechamento);
            this.Controls.Add(this.lblValorAbertura);
            this.Controls.Add(this.lblSenhaUsu);
            this.Controls.Add(this.lblValorAnterior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAberturaCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Abertura de Caixa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAberturaCaixa_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorAnterior;
        private System.Windows.Forms.Label lblSenhaUsu;
        private System.Windows.Forms.Label lblValorAbertura;
        private System.Windows.Forms.TextBox txtSenhaUsu;
        private System.Windows.Forms.TextBox txtValorAbertura;
        private System.Windows.Forms.TextBox txtValFechamento;
        private System.Windows.Forms.Button btnAbrirCaixa;
    }
}