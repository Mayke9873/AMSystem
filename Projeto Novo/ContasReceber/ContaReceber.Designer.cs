namespace Projeto_Novo
{
    partial class FrmContaReceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContaReceber));
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsC_Receber = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddC_Receber = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditC_Receber = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.pnlContasReceber = new System.Windows.Forms.Panel();
            this.dgvCliAReceber = new System.Windows.Forms.DataGridView();
            this.mtxDtFinal = new System.Windows.Forms.MaskedTextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.mtxDtInicial = new System.Windows.Forms.MaskedTextBox();
            this.tsC_Receber.SuspendLayout();
            this.pnlContasReceber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliAReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 29);
            // 
            // tsC_Receber
            // 
            this.tsC_Receber.BackColor = System.Drawing.SystemColors.Control;
            this.tsC_Receber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsC_Receber.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsC_Receber.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.tsC_Receber.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddC_Receber,
            this.tsbtnEditC_Receber,
            this.tsbtnSalvar,
            this.tsbtnCancelar,
            this.toolStripSeparator,
            this.tsbtnImprimir,
            this.toolStripSeparator1,
            this.tsbtnSair});
            this.tsC_Receber.Location = new System.Drawing.Point(0, 0);
            this.tsC_Receber.Name = "tsC_Receber";
            this.tsC_Receber.Size = new System.Drawing.Size(983, 29);
            this.tsC_Receber.TabIndex = 9;
            this.tsC_Receber.Text = "Contas a Receber";
            // 
            // tsbtnAddC_Receber
            // 
            this.tsbtnAddC_Receber.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddC_Receber.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddC_Receber.Image")));
            this.tsbtnAddC_Receber.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddC_Receber.Name = "tsbtnAddC_Receber";
            this.tsbtnAddC_Receber.Size = new System.Drawing.Size(26, 26);
            this.tsbtnAddC_Receber.Text = "Novo";
            // 
            // tsbtnEditC_Receber
            // 
            this.tsbtnEditC_Receber.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEditC_Receber.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditC_Receber.Image")));
            this.tsbtnEditC_Receber.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditC_Receber.Name = "tsbtnEditC_Receber";
            this.tsbtnEditC_Receber.Size = new System.Drawing.Size(26, 26);
            this.tsbtnEditC_Receber.Text = "Editar";
            this.tsbtnEditC_Receber.Click += new System.EventHandler(this.tsbtnEditC_Receber_Click);
            // 
            // tsbtnSalvar
            // 
            this.tsbtnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSalvar.Image")));
            this.tsbtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSalvar.Name = "tsbtnSalvar";
            this.tsbtnSalvar.Size = new System.Drawing.Size(26, 26);
            this.tsbtnSalvar.Text = "Salvar";
            // 
            // tsbtnCancelar
            // 
            this.tsbtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancelar.Image")));
            this.tsbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancelar.Name = "tsbtnCancelar";
            this.tsbtnCancelar.Size = new System.Drawing.Size(26, 26);
            this.tsbtnCancelar.Text = "Cancelar";
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
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(12, 35);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(42, 13);
            this.lblPesquisa.TabIndex = 11;
            this.lblPesquisa.Text = "Cliente:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(76, 32);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(257, 20);
            this.txtPesquisa.TabIndex = 1;
            // 
            // pnlContasReceber
            // 
            this.pnlContasReceber.Controls.Add(this.dgvCliAReceber);
            this.pnlContasReceber.Controls.Add(this.mtxDtFinal);
            this.pnlContasReceber.Controls.Add(this.lblPeriodo);
            this.pnlContasReceber.Controls.Add(this.mtxDtInicial);
            this.pnlContasReceber.Controls.Add(this.lblPesquisa);
            this.pnlContasReceber.Controls.Add(this.txtPesquisa);
            this.pnlContasReceber.Controls.Add(this.tsC_Receber);
            this.pnlContasReceber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContasReceber.Location = new System.Drawing.Point(0, 0);
            this.pnlContasReceber.Name = "pnlContasReceber";
            this.pnlContasReceber.Size = new System.Drawing.Size(983, 590);
            this.pnlContasReceber.TabIndex = 1;
            // 
            // dgvCliAReceber
            // 
            this.dgvCliAReceber.AllowUserToOrderColumns = true;
            this.dgvCliAReceber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliAReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliAReceber.Location = new System.Drawing.Point(3, 58);
            this.dgvCliAReceber.Name = "dgvCliAReceber";
            this.dgvCliAReceber.Size = new System.Drawing.Size(977, 529);
            this.dgvCliAReceber.TabIndex = 0;
            this.dgvCliAReceber.TabStop = false;
            // 
            // mtxDtFinal
            // 
            this.mtxDtFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxDtFinal.Location = new System.Drawing.Point(552, 32);
            this.mtxDtFinal.Mask = "00/00/0000";
            this.mtxDtFinal.Name = "mtxDtFinal";
            this.mtxDtFinal.Size = new System.Drawing.Size(75, 20);
            this.mtxDtFinal.TabIndex = 3;
            this.mtxDtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxDtFinal.ValidatingType = typeof(System.DateTime);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(417, 35);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(48, 13);
            this.lblPeriodo.TabIndex = 14;
            this.lblPeriodo.Text = "Período:";
            // 
            // mtxDtInicial
            // 
            this.mtxDtInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxDtInicial.Location = new System.Drawing.Point(471, 32);
            this.mtxDtInicial.Mask = "00/00/0000";
            this.mtxDtInicial.Name = "mtxDtInicial";
            this.mtxDtInicial.Size = new System.Drawing.Size(75, 20);
            this.mtxDtInicial.TabIndex = 2;
            this.mtxDtInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxDtInicial.ValidatingType = typeof(System.DateTime);
            // 
            // FrmContaReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.pnlContasReceber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmContaReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contas a Receber";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmContaReceber_KeyDown);
            this.tsC_Receber.ResumeLayout(false);
            this.tsC_Receber.PerformLayout();
            this.pnlContasReceber.ResumeLayout(false);
            this.pnlContasReceber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliAReceber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStripButton tsbtnSalvar;
        private System.Windows.Forms.ToolStripButton tsbtnEditC_Receber;
        private System.Windows.Forms.ToolStripButton tsbtnAddC_Receber;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStrip tsC_Receber;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Panel pnlContasReceber;
        private System.Windows.Forms.MaskedTextBox mtxDtFinal;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.MaskedTextBox mtxDtInicial;
        private System.Windows.Forms.DataGridView dgvCliAReceber;
    }
}