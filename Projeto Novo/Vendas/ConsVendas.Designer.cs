namespace Projeto_Novo
{
    partial class FrmConsVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsVendas));
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsGrupoProduto = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddVenda = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditVenda = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.pnlConsPedidos = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mtxDtFinal = new System.Windows.Forms.MaskedTextBox();
            this.txtDtInicial = new System.Windows.Forms.MaskedTextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.tsGrupoProduto.SuspendLayout();
            this.pnlConsPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // tsGrupoProduto
            // 
            this.tsGrupoProduto.BackColor = System.Drawing.SystemColors.Control;
            this.tsGrupoProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsGrupoProduto.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsGrupoProduto.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.tsGrupoProduto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddVenda,
            this.tsbtnEditVenda,
            this.tsbtnCancelar,
            this.toolStripSeparator,
            this.tsbtnImprimir,
            this.toolStripSeparator1,
            this.tsbtnSair});
            this.tsGrupoProduto.Location = new System.Drawing.Point(0, 0);
            this.tsGrupoProduto.Name = "tsGrupoProduto";
            this.tsGrupoProduto.Size = new System.Drawing.Size(983, 29);
            this.tsGrupoProduto.TabIndex = 9;
            this.tsGrupoProduto.Text = "toolStrip1";
            // 
            // tsbtnAddVenda
            // 
            this.tsbtnAddVenda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddVenda.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddVenda.Image")));
            this.tsbtnAddVenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddVenda.Name = "tsbtnAddVenda";
            this.tsbtnAddVenda.Size = new System.Drawing.Size(26, 26);
            this.tsbtnAddVenda.Text = "Novo";
            this.tsbtnAddVenda.Click += new System.EventHandler(this.tsbtnAddVenda_Click);
            // 
            // tsbtnEditVenda
            // 
            this.tsbtnEditVenda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEditVenda.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditVenda.Image")));
            this.tsbtnEditVenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditVenda.Name = "tsbtnEditVenda";
            this.tsbtnEditVenda.Size = new System.Drawing.Size(26, 26);
            this.tsbtnEditVenda.Text = "Editar";
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
            this.txtPesquisa.Size = new System.Drawing.Size(307, 20);
            this.txtPesquisa.TabIndex = 1;
            // 
            // pnlConsPedidos
            // 
            this.pnlConsPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlConsPedidos.Controls.Add(this.dataGridView1);
            this.pnlConsPedidos.Controls.Add(this.mtxDtFinal);
            this.pnlConsPedidos.Controls.Add(this.txtDtInicial);
            this.pnlConsPedidos.Controls.Add(this.lblPeriodo);
            this.pnlConsPedidos.Controls.Add(this.lblPesquisa);
            this.pnlConsPedidos.Controls.Add(this.txtPesquisa);
            this.pnlConsPedidos.Controls.Add(this.tsGrupoProduto);
            this.pnlConsPedidos.Location = new System.Drawing.Point(0, 0);
            this.pnlConsPedidos.Name = "pnlConsPedidos";
            this.pnlConsPedidos.Size = new System.Drawing.Size(983, 590);
            this.pnlConsPedidos.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(977, 529);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
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
            // FrmConsVendas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.pnlConsPedidos);
            this.KeyPreview = true;
            this.Name = "FrmConsVendas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsVendas_KeyDown);
            this.tsGrupoProduto.ResumeLayout(false);
            this.tsGrupoProduto.PerformLayout();
            this.pnlConsPedidos.ResumeLayout(false);
            this.pnlConsPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStripButton tsbtnEditVenda;
        private System.Windows.Forms.ToolStripButton tsbtnAddVenda;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStrip tsGrupoProduto;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Panel pnlConsPedidos;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.MaskedTextBox mtxDtFinal;
        private System.Windows.Forms.MaskedTextBox txtDtInicial;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}