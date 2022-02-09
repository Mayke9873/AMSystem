namespace Projeto_Novo
{
    partial class FrmConsCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsCompras));
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsCompra = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddCompra = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditCompra = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.pnlConsCompras = new System.Windows.Forms.Panel();
            this.mtxDtFinal = new System.Windows.Forms.MaskedTextBox();
            this.txtDtInicial = new System.Windows.Forms.MaskedTextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.tsCompra.SuspendLayout();
            this.pnlConsCompras.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCompras
            // 
            this.dgvCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(3, 58);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.Size = new System.Drawing.Size(977, 529);
            this.dgvCompras.TabIndex = 0;
            this.dgvCompras.TabStop = false;
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
            // tsCompra
            // 
            this.tsCompra.BackColor = System.Drawing.SystemColors.Control;
            this.tsCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsCompra.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsCompra.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.tsCompra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddCompra,
            this.tsbtnEditCompra,
            this.tsbtnSalvar,
            this.tsbtnCancelar,
            this.toolStripSeparator,
            this.tsbtnImprimir,
            this.toolStripSeparator1,
            this.tsbtnSair});
            this.tsCompra.Location = new System.Drawing.Point(0, 0);
            this.tsCompra.Name = "tsCompra";
            this.tsCompra.Size = new System.Drawing.Size(983, 29);
            this.tsCompra.TabIndex = 9;
            this.tsCompra.Text = "toolStrip1";
            // 
            // tsbtnAddCompra
            // 
            this.tsbtnAddCompra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddCompra.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddCompra.Image")));
            this.tsbtnAddCompra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddCompra.Name = "tsbtnAddCompra";
            this.tsbtnAddCompra.Size = new System.Drawing.Size(26, 26);
            this.tsbtnAddCompra.Text = "Novo";
            this.tsbtnAddCompra.Click += new System.EventHandler(this.tsbtnAddCompra_Click);
            // 
            // tsbtnEditCompra
            // 
            this.tsbtnEditCompra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEditCompra.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditCompra.Image")));
            this.tsbtnEditCompra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditCompra.Name = "tsbtnEditCompra";
            this.tsbtnEditCompra.Size = new System.Drawing.Size(26, 26);
            this.tsbtnEditCompra.Text = "Editar";
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
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(12, 35);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(64, 13);
            this.lblFornecedor.TabIndex = 11;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(76, 32);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(307, 20);
            this.txtPesquisa.TabIndex = 1;
            // 
            // pnlConsCompras
            // 
            this.pnlConsCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlConsCompras.Controls.Add(this.dgvCompras);
            this.pnlConsCompras.Controls.Add(this.mtxDtFinal);
            this.pnlConsCompras.Controls.Add(this.txtDtInicial);
            this.pnlConsCompras.Controls.Add(this.lblPeriodo);
            this.pnlConsCompras.Controls.Add(this.lblFornecedor);
            this.pnlConsCompras.Controls.Add(this.txtPesquisa);
            this.pnlConsCompras.Controls.Add(this.tsCompra);
            this.pnlConsCompras.Location = new System.Drawing.Point(0, 0);
            this.pnlConsCompras.Name = "pnlConsCompras";
            this.pnlConsCompras.Size = new System.Drawing.Size(983, 590);
            this.pnlConsCompras.TabIndex = 2;
            // 
            // mtxDtFinal
            // 
            this.mtxDtFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxDtFinal.Location = new System.Drawing.Point(543, 32);
            this.mtxDtFinal.Mask = "00/00/0000";
            this.mtxDtFinal.Name = "mtxDtFinal";
            this.mtxDtFinal.Size = new System.Drawing.Size(80, 20);
            this.mtxDtFinal.TabIndex = 3;
            this.mtxDtFinal.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtInicial
            // 
            this.txtDtInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDtInicial.Location = new System.Drawing.Point(457, 32);
            this.txtDtInicial.Mask = "00/00/0000";
            this.txtDtInicial.Name = "txtDtInicial";
            this.txtDtInicial.Size = new System.Drawing.Size(80, 20);
            this.txtDtInicial.TabIndex = 2;
            this.txtDtInicial.ValidatingType = typeof(System.DateTime);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(405, 35);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(46, 13);
            this.lblPeriodo.TabIndex = 12;
            this.lblPeriodo.Text = "Periodo:";
            // 
            // FrmConsCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.pnlConsCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmConsCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Compras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsCompras_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.tsCompra.ResumeLayout(false);
            this.tsCompra.PerformLayout();
            this.pnlConsCompras.ResumeLayout(false);
            this.pnlConsCompras.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStrip tsCompra;
        private System.Windows.Forms.ToolStripButton tsbtnAddCompra;
        private System.Windows.Forms.ToolStripButton tsbtnEditCompra;
        private System.Windows.Forms.ToolStripButton tsbtnSalvar;
        private System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Panel pnlConsCompras;
        private System.Windows.Forms.MaskedTextBox mtxDtFinal;
        private System.Windows.Forms.MaskedTextBox txtDtInicial;
        private System.Windows.Forms.Label lblPeriodo;
    }
}