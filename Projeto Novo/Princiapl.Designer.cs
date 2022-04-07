namespace Projeto_Novo
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGrupoProd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGrupoUsu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiContas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMovimento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mstiCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFinanceiro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbreCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFechaCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMovCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tmsiContaReceber = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContaPagar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBotoes = new System.Windows.Forms.ToolStrip();
            this.tsbtnPedido = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnCReceber = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
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
            this.tsmiRelatorio,
            this.tsmiSair});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1084, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "msMenus";
            // 
            // tsmiCadastros
            // 
            this.tsmiCadastros.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.tsmiCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClientes,
            this.tsmiFornecedor,
            this.toolStripSeparator1,
            this.tsmiProdutos,
            this.tsmiGrupoProd,
            this.toolStripSeparator3,
            this.tsmiFuncionario,
            this.tsmiGrupoUsu,
            this.toolStripSeparator6,
            this.tsmiContas});
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
            this.tsmiClientes.Text = "&Cliente";
            this.tsmiClientes.Click += new System.EventHandler(this.tsmiClientes_Click);
            // 
            // tsmiFornecedor
            // 
            this.tsmiFornecedor.Name = "tsmiFornecedor";
            this.tsmiFornecedor.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.tsmiFornecedor.Size = new System.Drawing.Size(166, 22);
            this.tsmiFornecedor.Text = "&Fornecedor";
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
            // tsmiGrupoUsu
            // 
            this.tsmiGrupoUsu.Name = "tsmiGrupoUsu";
            this.tsmiGrupoUsu.Size = new System.Drawing.Size(166, 22);
            this.tsmiGrupoUsu.Text = "Grupo de Usuário";
            this.tsmiGrupoUsu.Click += new System.EventHandler(this.tsmiGrupoUsu_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(163, 6);
            // 
            // tsmiContas
            // 
            this.tsmiContas.Name = "tsmiContas";
            this.tsmiContas.Size = new System.Drawing.Size(166, 22);
            this.tsmiContas.Text = "Contas";
            this.tsmiContas.Click += new System.EventHandler(this.tsmiContas_Click);
            // 
            // tsmiMovimento
            // 
            this.tsmiMovimento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPedido,
            this.tsmiConsVendas,
            this.toolStripSeparator4,
            this.mstiCompras});
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
            this.tsmiPedido.Size = new System.Drawing.Size(196, 22);
            this.tsmiPedido.Text = "Venda";
            this.tsmiPedido.Click += new System.EventHandler(this.tsmiPedido_Click);
            // 
            // tsmiConsVendas
            // 
            this.tsmiConsVendas.Name = "tsmiConsVendas";
            this.tsmiConsVendas.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsmiConsVendas.Size = new System.Drawing.Size(196, 22);
            this.tsmiConsVendas.Text = "Consulta de Vendas";
            this.tsmiConsVendas.Click += new System.EventHandler(this.tsmiConsPedido_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(193, 6);
            // 
            // mstiCompras
            // 
            this.mstiCompras.Name = "mstiCompras";
            this.mstiCompras.Size = new System.Drawing.Size(196, 22);
            this.mstiCompras.Text = "Compras";
            this.mstiCompras.Click += new System.EventHandler(this.mstiCompras_Click);
            // 
            // tsmiFinanceiro
            // 
            this.tsmiFinanceiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCaixa,
            this.tsmiMovCaixa,
            this.toolStripSeparator5,
            this.tmsiContaReceber,
            this.tsmiContaPagar});
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
            // tsmiMovCaixa
            // 
            this.tsmiMovCaixa.Name = "tsmiMovCaixa";
            this.tsmiMovCaixa.Size = new System.Drawing.Size(202, 22);
            this.tsmiMovCaixa.Text = "Movimentação de Caixa";
            this.tsmiMovCaixa.Click += new System.EventHandler(this.tsmiMovCaixa_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(199, 6);
            // 
            // tmsiContaReceber
            // 
            this.tmsiContaReceber.Name = "tmsiContaReceber";
            this.tmsiContaReceber.Size = new System.Drawing.Size(202, 22);
            this.tmsiContaReceber.Text = "Contas a Receber";
            this.tmsiContaReceber.Click += new System.EventHandler(this.tmsiContaReceber_Click);
            // 
            // tsmiContaPagar
            // 
            this.tsmiContaPagar.Name = "tsmiContaPagar";
            this.tsmiContaPagar.Size = new System.Drawing.Size(202, 22);
            this.tsmiContaPagar.Text = "Contas a Pagar";
            this.tsmiContaPagar.Click += new System.EventHandler(this.tsmiContaPagar_Click);
            // 
            // tsmiRelatorio
            // 
            this.tsmiRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.tsmiRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRelatorio.Image")));
            this.tsmiRelatorio.Name = "tsmiRelatorio";
            this.tsmiRelatorio.Size = new System.Drawing.Size(87, 20);
            this.tsmiRelatorio.Text = "Relatórios";
            this.tsmiRelatorio.Visible = false;
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
            this.tsBotoes.Size = new System.Drawing.Size(1084, 54);
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
            this.tsbtnCReceber.Text = "F2 - A Receber";
            this.tsbtnCReceber.Click += new System.EventHandler(this.tsbtnCReceber_Click);
            // 
            // tsbtnSair
            // 
            this.tsbtnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSair.Image")));
            this.tsbtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSair.Margin = new System.Windows.Forms.Padding(12, 1, 0, 2);
            this.tsbtnSair.Name = "tsbtnSair";
            this.tsbtnSair.Size = new System.Drawing.Size(36, 47);
            this.tsbtnSair.Text = "Sair";
            this.tsbtnSair.Click += new System.EventHandler(this.tsbtnSair_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.tsBotoes);
            this.Controls.Add(this.msMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
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
        private System.Windows.Forms.ToolStripMenuItem tsmiSair;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.ToolStripMenuItem tsmiMovCaixa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiGrupoUsu;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsVendas;
        private System.Windows.Forms.ToolStripMenuItem tsmiRelatorio;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiFuncionario;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbreCaixa;
        private System.Windows.Forms.ToolStripMenuItem tsmiFechaCaixa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tmsiContaReceber;
        private System.Windows.Forms.ToolStripMenuItem tsmiContaPagar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmiContas;
        private System.Windows.Forms.ToolStripMenuItem mstiCompras;
    }
}

