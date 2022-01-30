namespace Projeto_Novo
{
    partial class FrmPrinciapl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrinciapl));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGrupos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMovimento = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFinanceiro = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBotoes = new System.Windows.Forms.ToolStrip();
            this.tsbtnPedido = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnCReceber = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.msMenu.SuspendLayout();
            this.tsBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadastros,
            this.tsmiMovimento,
            this.tsmiFinanceiro,
            this.relatóriosToolStripMenuItem,
            this.tsmiSair});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.msMenu.Size = new System.Drawing.Size(984, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmiCadastros
            // 
            this.tsmiCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClientes,
            this.tsmiFornecedor,
            this.toolStripSeparator1,
            this.tsmiProdutos,
            this.tsmiGrupos,
            this.toolStripSeparator3,
            this.funcionáriosToolStripMenuItem,
            this.grupoDeUsuárioToolStripMenuItem});
            this.tsmiCadastros.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCadastros.Image")));
            this.tsmiCadastros.Name = "tsmiCadastros";
            this.tsmiCadastros.Size = new System.Drawing.Size(87, 20);
            this.tsmiCadastros.Text = "Cadastros";
            // 
            // tsmiClientes
            // 
            this.tsmiClientes.Name = "tsmiClientes";
            this.tsmiClientes.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmiClientes.Size = new System.Drawing.Size(166, 22);
            this.tsmiClientes.Text = "Cliente";
            this.tsmiClientes.Click += new System.EventHandler(this.tsmiClientes_Click);
            // 
            // tsmiFornecedor
            // 
            this.tsmiFornecedor.Name = "tsmiFornecedor";
            this.tsmiFornecedor.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.tsmiFornecedor.Size = new System.Drawing.Size(166, 22);
            this.tsmiFornecedor.Text = "Fornecedor";
            this.tsmiFornecedor.Click += new System.EventHandler(this.tsmiFornecedor_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // tsmiProdutos
            // 
            this.tsmiProdutos.Name = "tsmiProdutos";
            this.tsmiProdutos.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.tsmiProdutos.Size = new System.Drawing.Size(166, 22);
            this.tsmiProdutos.Text = "Produtos";
            // 
            // tsmiGrupos
            // 
            this.tsmiGrupos.Name = "tsmiGrupos";
            this.tsmiGrupos.Size = new System.Drawing.Size(166, 22);
            this.tsmiGrupos.Text = "Grupos";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(163, 6);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.funcionáriosToolStripMenuItem.Text = "Usuários";
            // 
            // grupoDeUsuárioToolStripMenuItem
            // 
            this.grupoDeUsuárioToolStripMenuItem.Name = "grupoDeUsuárioToolStripMenuItem";
            this.grupoDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.grupoDeUsuárioToolStripMenuItem.Text = "Grupo de Usuário";
            // 
            // tsmiMovimento
            // 
            this.tsmiMovimento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.consultaDeVendasToolStripMenuItem});
            this.tsmiMovimento.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMovimento.Image")));
            this.tsmiMovimento.Name = "tsmiMovimento";
            this.tsmiMovimento.Size = new System.Drawing.Size(97, 20);
            this.tsmiMovimento.Text = "Movimento";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // consultaDeVendasToolStripMenuItem
            // 
            this.consultaDeVendasToolStripMenuItem.Name = "consultaDeVendasToolStripMenuItem";
            this.consultaDeVendasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaDeVendasToolStripMenuItem.Text = "Consulta de Vendas";
            // 
            // tsmiFinanceiro
            // 
            this.tsmiFinanceiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caixaToolStripMenuItem,
            this.movimentaçãoDeCaixaToolStripMenuItem});
            this.tsmiFinanceiro.Image = ((System.Drawing.Image)(resources.GetObject("tsmiFinanceiro.Image")));
            this.tsmiFinanceiro.Name = "tsmiFinanceiro";
            this.tsmiFinanceiro.Size = new System.Drawing.Size(90, 20);
            this.tsmiFinanceiro.Text = "Financeiro";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // movimentaçãoDeCaixaToolStripMenuItem
            // 
            this.movimentaçãoDeCaixaToolStripMenuItem.Name = "movimentaçãoDeCaixaToolStripMenuItem";
            this.movimentaçãoDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.movimentaçãoDeCaixaToolStripMenuItem.Text = "Movimentação de Caixa";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relatóriosToolStripMenuItem.Image")));
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // tsmiSair
            // 
            this.tsmiSair.Name = "tsmiSair";
            this.tsmiSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmiSair.Size = new System.Drawing.Size(38, 20);
            this.tsmiSair.Text = "Sair";
            this.tsmiSair.Click += new System.EventHandler(this.tsmiSair_Click);
            // 
            // tsBotoes
            // 
            this.tsBotoes.AutoSize = false;
            this.tsBotoes.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnPedido,
            this.toolStripSeparator2,
            this.tsbtnCReceber,
            this.tsbtnSair});
            this.tsBotoes.Location = new System.Drawing.Point(0, 24);
            this.tsBotoes.Name = "tsBotoes";
            this.tsBotoes.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsBotoes.Size = new System.Drawing.Size(984, 54);
            this.tsBotoes.TabIndex = 1;
            this.tsBotoes.Text = "Botoes";
            // 
            // tsbtnPedido
            // 
            this.tsbtnPedido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPedido.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPedido.Image")));
            this.tsbtnPedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPedido.MergeIndex = 0;
            this.tsbtnPedido.Name = "tsbtnPedido";
            this.tsbtnPedido.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsbtnPedido.Size = new System.Drawing.Size(36, 51);
            this.tsbtnPedido.Text = "Pedido";
            this.tsbtnPedido.Click += new System.EventHandler(this.tsbtnPedido_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // tsbtnCReceber
            // 
            this.tsbtnCReceber.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCReceber.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCReceber.Image")));
            this.tsbtnCReceber.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCReceber.Name = "tsbtnCReceber";
            this.tsbtnCReceber.Size = new System.Drawing.Size(36, 51);
            this.tsbtnCReceber.Text = "A Receber";
            // 
            // tsbtnSair
            // 
            this.tsbtnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSair.Image")));
            this.tsbtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSair.Name = "tsbtnSair";
            this.tsbtnSair.Size = new System.Drawing.Size(36, 51);
            this.tsbtnSair.Text = "Sair";
            this.tsbtnSair.Click += new System.EventHandler(this.tsbtnSair_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 78);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(984, 583);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // FrmPrinciapl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.tsBotoes);
            this.Controls.Add(this.msMenu);
            this.KeyPreview = true;
            this.Name = "FrmPrinciapl";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AmSystem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrPrinciapl_KeyDown);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.tsBotoes.ResumeLayout(false);
            this.tsBotoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
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
        private System.Windows.Forms.ToolStrip tsBotoes;
        private System.Windows.Forms.ToolStripButton tsbtnPedido;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnCReceber;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiSair;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoDeCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
    }
}

