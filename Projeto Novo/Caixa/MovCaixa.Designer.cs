namespace Projeto_Novo.Caixa
{
    partial class FrmMovCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovCaixa));
            this.dgvMovCaixa = new System.Windows.Forms.DataGridView();
            this.lblPesquisaConta = new System.Windows.Forms.Label();
            this.pnlMovCaixa = new System.Windows.Forms.Panel();
            this.mtxDtFinal = new System.Windows.Forms.MaskedTextBox();
            this.mtxDtInicial = new System.Windows.Forms.MaskedTextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.cmbConta = new System.Windows.Forms.ComboBox();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.tsGrupoProduto = new System.Windows.Forms.ToolStrip();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovCaixa)).BeginInit();
            this.pnlMovCaixa.SuspendLayout();
            this.tsGrupoProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMovCaixa
            // 
            this.dgvMovCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovCaixa.Location = new System.Drawing.Point(3, 59);
            this.dgvMovCaixa.Name = "dgvMovCaixa";
            this.dgvMovCaixa.Size = new System.Drawing.Size(977, 528);
            this.dgvMovCaixa.TabIndex = 0;
            this.dgvMovCaixa.TabStop = false;
            // 
            // lblPesquisaConta
            // 
            this.lblPesquisaConta.AutoSize = true;
            this.lblPesquisaConta.Location = new System.Drawing.Point(12, 35);
            this.lblPesquisaConta.Name = "lblPesquisaConta";
            this.lblPesquisaConta.Size = new System.Drawing.Size(38, 13);
            this.lblPesquisaConta.TabIndex = 11;
            this.lblPesquisaConta.Text = "Conta:";
            // 
            // pnlMovCaixa
            // 
            this.pnlMovCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMovCaixa.Controls.Add(this.tsGrupoProduto);
            this.pnlMovCaixa.Controls.Add(this.lblFuncionario);
            this.pnlMovCaixa.Controls.Add(this.cmbFuncionario);
            this.pnlMovCaixa.Controls.Add(this.cmbConta);
            this.pnlMovCaixa.Controls.Add(this.dgvMovCaixa);
            this.pnlMovCaixa.Controls.Add(this.mtxDtFinal);
            this.pnlMovCaixa.Controls.Add(this.mtxDtInicial);
            this.pnlMovCaixa.Controls.Add(this.lblPeriodo);
            this.pnlMovCaixa.Controls.Add(this.lblPesquisaConta);
            this.pnlMovCaixa.Location = new System.Drawing.Point(0, 0);
            this.pnlMovCaixa.Name = "pnlMovCaixa";
            this.pnlMovCaixa.Size = new System.Drawing.Size(983, 590);
            this.pnlMovCaixa.TabIndex = 2;
            // 
            // mtxDtFinal
            // 
            this.mtxDtFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxDtFinal.Location = new System.Drawing.Point(704, 32);
            this.mtxDtFinal.Mask = "00/00/0000";
            this.mtxDtFinal.Name = "mtxDtFinal";
            this.mtxDtFinal.Size = new System.Drawing.Size(80, 20);
            this.mtxDtFinal.TabIndex = 3;
            this.mtxDtFinal.ValidatingType = typeof(System.DateTime);
            // 
            // mtxDtInicial
            // 
            this.mtxDtInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxDtInicial.Location = new System.Drawing.Point(618, 32);
            this.mtxDtInicial.Mask = "00/00/0000";
            this.mtxDtInicial.Name = "mtxDtInicial";
            this.mtxDtInicial.Size = new System.Drawing.Size(80, 20);
            this.mtxDtInicial.TabIndex = 2;
            this.mtxDtInicial.ValidatingType = typeof(System.DateTime);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(566, 35);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(46, 13);
            this.lblPeriodo.TabIndex = 12;
            this.lblPeriodo.Text = "Periodo:";
            // 
            // cmbConta
            // 
            this.cmbConta.FormattingEnabled = true;
            this.cmbConta.Location = new System.Drawing.Point(74, 32);
            this.cmbConta.Name = "cmbConta";
            this.cmbConta.Size = new System.Drawing.Size(170, 21);
            this.cmbConta.TabIndex = 1;
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(353, 32);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(173, 21);
            this.cmbFuncionario.TabIndex = 2;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(282, 35);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(65, 13);
            this.lblFuncionario.TabIndex = 15;
            this.lblFuncionario.Text = "Funcionario:";
            // 
            // tsGrupoProduto
            // 
            this.tsGrupoProduto.BackColor = System.Drawing.SystemColors.Control;
            this.tsGrupoProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsGrupoProduto.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsGrupoProduto.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.tsGrupoProduto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnImprimir,
            this.toolStripSeparator1,
            this.tsbtnSair});
            this.tsGrupoProduto.Location = new System.Drawing.Point(0, 0);
            this.tsGrupoProduto.Name = "tsGrupoProduto";
            this.tsGrupoProduto.Size = new System.Drawing.Size(983, 29);
            this.tsGrupoProduto.TabIndex = 16;
            this.tsGrupoProduto.Text = "toolStrip1";
            // 
            // tsbtnImprimir
            // 
            this.tsbtnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnImprimir.Image")));
            this.tsbtnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnImprimir.Name = "tsbtnImprimir";
            this.tsbtnImprimir.Size = new System.Drawing.Size(26, 26);
            this.tsbtnImprimir.Text = "Imprimir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbtnSair
            // 
            this.tsbtnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSair.Image")));
            this.tsbtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSair.Name = "tsbtnSair";
            this.tsbtnSair.Size = new System.Drawing.Size(26, 26);
            this.tsbtnSair.Text = "Sair";
            this.tsbtnSair.Click += new System.EventHandler(this.tsbtnSair_Click);
            // 
            // FrmMovCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.pnlMovCaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmMovCaixa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Movimentação de Caixa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMovCaixa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovCaixa)).EndInit();
            this.pnlMovCaixa.ResumeLayout(false);
            this.pnlMovCaixa.PerformLayout();
            this.tsGrupoProduto.ResumeLayout(false);
            this.tsGrupoProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovCaixa;
        private System.Windows.Forms.Label lblPesquisaConta;
        private System.Windows.Forms.Panel pnlMovCaixa;
        private System.Windows.Forms.MaskedTextBox mtxDtFinal;
        private System.Windows.Forms.MaskedTextBox mtxDtInicial;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.ComboBox cmbConta;
        private System.Windows.Forms.ToolStrip tsGrupoProduto;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
    }
}