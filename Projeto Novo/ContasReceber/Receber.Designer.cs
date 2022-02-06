namespace Projeto_Novo
{
    partial class FrmReceber
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
            this.pnlReceber = new System.Windows.Forms.Panel();
            this.dgvReceber = new System.Windows.Forms.DataGridView();
            this.mtxDtFinal = new System.Windows.Forms.MaskedTextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.mtxDtInicial = new System.Windows.Forms.MaskedTextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pnlReceber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReceber
            // 
            this.pnlReceber.Controls.Add(this.btnExcluir);
            this.pnlReceber.Controls.Add(this.btnPagar);
            this.pnlReceber.Controls.Add(this.btnNovo);
            this.pnlReceber.Controls.Add(this.dgvReceber);
            this.pnlReceber.Controls.Add(this.mtxDtFinal);
            this.pnlReceber.Controls.Add(this.lblPeriodo);
            this.pnlReceber.Controls.Add(this.mtxDtInicial);
            this.pnlReceber.Controls.Add(this.lblPesquisa);
            this.pnlReceber.Controls.Add(this.txtPesquisa);
            this.pnlReceber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReceber.Location = new System.Drawing.Point(0, 0);
            this.pnlReceber.Name = "pnlReceber";
            this.pnlReceber.Size = new System.Drawing.Size(1084, 661);
            this.pnlReceber.TabIndex = 2;
            // 
            // dgvReceber
            // 
            this.dgvReceber.AllowUserToOrderColumns = true;
            this.dgvReceber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceber.Location = new System.Drawing.Point(3, 43);
            this.dgvReceber.Name = "dgvReceber";
            this.dgvReceber.Size = new System.Drawing.Size(1078, 571);
            this.dgvReceber.TabIndex = 16;
            // 
            // mtxDtFinal
            // 
            this.mtxDtFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxDtFinal.Location = new System.Drawing.Point(653, 13);
            this.mtxDtFinal.Mask = "00/00/0000";
            this.mtxDtFinal.Name = "mtxDtFinal";
            this.mtxDtFinal.Size = new System.Drawing.Size(75, 20);
            this.mtxDtFinal.TabIndex = 15;
            this.mtxDtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxDtFinal.ValidatingType = typeof(System.DateTime);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(518, 16);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(48, 13);
            this.lblPeriodo.TabIndex = 14;
            this.lblPeriodo.Text = "Período:";
            // 
            // mtxDtInicial
            // 
            this.mtxDtInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxDtInicial.Location = new System.Drawing.Point(572, 13);
            this.mtxDtInicial.Mask = "00/00/0000";
            this.mtxDtInicial.Name = "mtxDtInicial";
            this.mtxDtInicial.Size = new System.Drawing.Size(75, 20);
            this.mtxDtInicial.TabIndex = 12;
            this.mtxDtInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxDtInicial.ValidatingType = typeof(System.DateTime);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(12, 16);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(42, 13);
            this.lblPesquisa.TabIndex = 11;
            this.lblPesquisa.Text = "Cliente:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(76, 13);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(358, 20);
            this.txtPesquisa.TabIndex = 10;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 9F);
            this.btnExcluir.Location = new System.Drawing.Point(201, 621);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(96, 32);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "F3 - Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnPagar.Location = new System.Drawing.Point(102, 621);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(96, 32);
            this.btnPagar.TabIndex = 21;
            this.btnPagar.Text = "F2 - Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Arial", 9F);
            this.btnNovo.Location = new System.Drawing.Point(3, 621);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(96, 32);
            this.btnNovo.TabIndex = 20;
            this.btnNovo.Text = "F1 - Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // FrmReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.pnlReceber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReceber";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Receber";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmReceber_KeyDown);
            this.pnlReceber.ResumeLayout(false);
            this.pnlReceber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReceber;
        private System.Windows.Forms.DataGridView dgvReceber;
        private System.Windows.Forms.MaskedTextBox mtxDtFinal;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.MaskedTextBox mtxDtInicial;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnNovo;
    }
}