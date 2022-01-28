namespace Projeto_Novo
{
    partial class Princiapl
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Princiapl));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGrupos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMovimento = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFinanceiro = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadastros,
            this.tsmiMovimento,
            this.tsmiFinanceiro,
            this.tsmiSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiCadastros
            // 
            this.tsmiCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClientes,
            this.tsmiFornecedor,
            this.toolStripSeparator1,
            this.tsmiProdutos,
            this.tsmiGrupos});
            this.tsmiCadastros.Name = "tsmiCadastros";
            this.tsmiCadastros.Size = new System.Drawing.Size(71, 20);
            this.tsmiCadastros.Text = "Cadastros";
            // 
            // tsmiClientes
            // 
            this.tsmiClientes.Name = "tsmiClientes";
            this.tsmiClientes.Size = new System.Drawing.Size(180, 22);
            this.tsmiClientes.Text = "Cliente";
            this.tsmiClientes.Click += new System.EventHandler(this.tsmiClientes_Click);
            // 
            // tsmiFornecedor
            // 
            this.tsmiFornecedor.Name = "tsmiFornecedor";
            this.tsmiFornecedor.Size = new System.Drawing.Size(180, 22);
            this.tsmiFornecedor.Text = "Fornecedor";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiProdutos
            // 
            this.tsmiProdutos.Name = "tsmiProdutos";
            this.tsmiProdutos.Size = new System.Drawing.Size(180, 22);
            this.tsmiProdutos.Text = "Produtos";
            // 
            // tsmiGrupos
            // 
            this.tsmiGrupos.Name = "tsmiGrupos";
            this.tsmiGrupos.Size = new System.Drawing.Size(180, 22);
            this.tsmiGrupos.Text = "Grupos";
            // 
            // tsmiMovimento
            // 
            this.tsmiMovimento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem});
            this.tsmiMovimento.Name = "tsmiMovimento";
            this.tsmiMovimento.Size = new System.Drawing.Size(81, 20);
            this.tsmiMovimento.Text = "Movimento";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // tsmiFinanceiro
            // 
            this.tsmiFinanceiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caixaToolStripMenuItem});
            this.tsmiFinanceiro.Name = "tsmiFinanceiro";
            this.tsmiFinanceiro.Size = new System.Drawing.Size(74, 20);
            this.tsmiFinanceiro.Text = "Financeiro";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // tsmiSair
            // 
            this.tsmiSair.Name = "tsmiSair";
            this.tsmiSair.Size = new System.Drawing.Size(38, 20);
            this.tsmiSair.Text = "Sair";
            this.tsmiSair.Click += new System.EventHandler(this.tsmiSair_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(984, 46);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.MergeIndex = 0;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 43);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 43);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 70);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(984, 591);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // Princiapl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Princiapl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastros;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiFornecedor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiProdutos;
        private System.Windows.Forms.ToolStripMenuItem tsmiGrupos;
        private System.Windows.Forms.ToolStripMenuItem tsmiMovimento;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiFinanceiro;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiSair;
    }
}

