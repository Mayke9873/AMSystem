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
            this.tsmiGrupoProd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGrupoUsu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMovimento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFinanceiro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBotoes = new System.Windows.Forms.ToolStrip();
            this.tsbtnPedido = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnCReceber = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.tsmiAbreCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFechaCaixa = new System.Windows.Forms.ToolStripMenuItem();
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
            this.msMenu.Size = new System.Drawing.Size(984, 24);
            this.msMenu.Stretch = false;
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "msMenus";
            // 
            // tsmiCadastros
            // 
            this.tsmiCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClientes,
            this.tsmiFornecedor,
            this.toolStripSeparator1,
            this.tsmiProdutos,
            this.tsmiGrupoProd,
            this.toolStripSeparator3,
            this.tsmiFuncionario,
            this.tsmiUsuario,
            this.tsmiGrupoUsu});
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
            this.tsmiProdutos.Click += new System.EventHandler(this.tsmiProdutos_Click);
            // 
            // tsmiGrupoProd
            // 
            this.tsmiGrupoProd.Name = "tsmiGrupoProd";
            this.tsmiGrupoProd.Size = new System.Drawing.Size(166, 22);
            this.tsmiGrupoProd.Text = "Grupos";
            this.tsmiGrupoProd.Click += new System.EventHandler(this.tsmiGrupoProd_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(163, 6);
            // 
            // tsmiFuncionario
            // 
            this.tsmiFuncionario.Name = "tsmiFuncionario";
            this.tsmiFuncionario.Size = new System.Drawing.Size(166, 22);
            this.tsmiFuncionario.Text = "Funcionário";
            this.tsmiFuncionario.Click += new System.EventHandler(this.tsmiFuncionario_Click);
            // 
            // tsmiUsuario
            // 
            this.tsmiUsuario.Name = "tsmiUsuario";
            this.tsmiUsuario.Size = new System.Drawing.Size(166, 22);
            this.tsmiUsuario.Text = "Usuários";
            this.tsmiUsuario.Click += new System.EventHandler(this.tsmiUsuario_Click);
            // 
            // tsmiGrupoUsu
            // 
            this.tsmiGrupoUsu.Name = "tsmiGrupoUsu";
            this.tsmiGrupoUsu.Size = new System.Drawing.Size(166, 22);
            this.tsmiGrupoUsu.Text = "Grupo de Usuário";
            this.tsmiGrupoUsu.Click += new System.EventHandler(this.tsmiGrupoUsu_Click);
            // 
            // tsmiMovimento
            // 
            this.tsmiMovimento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPedido,
            this.tsmiConsVendas});
            this.tsmiMovimento.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMovimento.Image")));
            this.tsmiMovimento.Name = "tsmiMovimento";
            this.tsmiMovimento.Size = new System.Drawing.Size(97, 20);
            this.tsmiMovimento.Text = "Movimento";
            // 
            // tsmiPedido
            // 
            this.tsmiPedido.Name = "tsmiPedido";
            this.tsmiPedido.ShortcutKeyDisplayString = "F1";
            this.tsmiPedido.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsmiPedido.Size = new System.Drawing.Size(177, 22);
            this.tsmiPedido.Text = "Venda";
            this.tsmiPedido.Click += new System.EventHandler(this.tsmiPedido_Click);
            // 
            // tsmiConsVendas
            // 
            this.tsmiConsVendas.Name = "tsmiConsVendas";
            this.tsmiConsVendas.Size = new System.Drawing.Size(177, 22);
            this.tsmiConsVendas.Text = "Consulta de Vendas";
            this.tsmiConsVendas.Click += new System.EventHandler(this.tsmiConsPedido_Click);
            // 
            // tsmiFinanceiro
            // 
            this.tsmiFinanceiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCaixa,
            this.movimentaçãoDeCaixaToolStripMenuItem});
            this.tsmiFinanceiro.Image = ((System.Drawing.Image)(resources.GetObject("tsmiFinanceiro.Image")));
            this.tsmiFinanceiro.Name = "tsmiFinanceiro";
            this.tsmiFinanceiro.Size = new System.Drawing.Size(90, 20);
            this.tsmiFinanceiro.Text = "Financeiro";
            // 
            // tsmiCaixa
            // 
            this.tsmiCaixa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbreCaixa,
            this.tsmiFechaCaixa});
            this.tsmiCaixa.Name = "tsmiCaixa";
            this.tsmiCaixa.Size = new System.Drawing.Size(202, 22);
            this.tsmiCaixa.Text = "Caixa";
            // 
            // movimentaçãoDeCaixaToolStripMenuItem
            // 
            this.movimentaçãoDeCaixaToolStripMenuItem.Name = "movimentaçãoDeCaixaToolStripMenuItem";
            this.movimentaçãoDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.movimentaçãoDeCaixaToolStripMenuItem.Text = "Movimentação de Caixa";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relatóriosToolStripMenuItem.Image")));
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
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
            this.tsBotoes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tsBotoes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBotoes.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnPedido,
            this.toolStripSeparator2,
            this.tsbtnCReceber,
            this.tsbtnSair});
            this.tsBotoes.Location = new System.Drawing.Point(0, 24);
            this.tsBotoes.Name = "tsBotoes";
            this.tsBotoes.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tsBotoes.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
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
            this.tsbtnPedido.Size = new System.Drawing.Size(36, 47);
            this.tsbtnPedido.Text = "Pedido";
            this.tsbtnPedido.Click += new System.EventHandler(this.tsbtnPedido_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // tsbtnCReceber
            // 
            this.tsbtnCReceber.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCReceber.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCReceber.Image")));
            this.tsbtnCReceber.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCReceber.Name = "tsbtnCReceber";
            this.tsbtnCReceber.Size = new System.Drawing.Size(36, 47);
            this.tsbtnCReceber.Text = "A Receber";
            // 
            // tsbtnSair
            // 
            this.tsbtnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSair.Image")));
            this.tsbtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSair.Name = "tsbtnSair";
            this.tsbtnSair.Size = new System.Drawing.Size(36, 47);
            this.tsbtnSair.Text = "Sair";
            this.tsbtnSair.Click += new System.EventHandler(this.tsbtnSair_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.pnlPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 78);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(984, 583);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // tsmiAbreCaixa
            // 
            this.tsmiAbreCaixa.Name = "tsmiAbreCaixa";
            this.tsmiAbreCaixa.Size = new System.Drawing.Size(188, 22);
            this.tsmiAbreCaixa.Text = "Abertura de Caixa";
            this.tsmiAbreCaixa.Click += new System.EventHandler(this.tsmiAbreCaixa_Click);
            // 
            // tsmiFechaCaixa
            // 
            this.tsmiFechaCaixa.Name = "tsmiFechaCaixa";
            this.tsmiFechaCaixa.Size = new System.Drawing.Size(188, 22);
            this.tsmiFechaCaixa.Text = "Fechamento de Caixa";
            this.tsmiFechaCaixa.Click += new System.EventHandler(this.tsmiFechaCaixa_Click);
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
        private System.Windows.Forms.ToolStripMenuItem tsmiGrupoProd;
        private System.Windows.Forms.ToolStripMenuItem tsmiMovimento;
        private System.Windows.Forms.ToolStripMenuItem tsmiPedido;
        private System.Windows.Forms.ToolStripMenuItem tsmiFinanceiro;
        private System.Windows.Forms.ToolStripMenuItem tsmiCaixa;
        private System.Windows.Forms.ToolStrip tsBotoes;
        private System.Windows.Forms.ToolStripButton tsbtnPedido;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnCReceber;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiSair;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoDeCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiGrupoUsu;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsVendas;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiFuncionario;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbreCaixa;
        private System.Windows.Forms.ToolStripMenuItem tsmiFechaCaixa;
    }
}

