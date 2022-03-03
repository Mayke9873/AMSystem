namespace Projeto_Novo
{
    partial class FrmProduto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.pnlProdutos = new System.Windows.Forms.Panel();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.tsProduto = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddProduto = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditProduto = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.tcProdutos = new System.Windows.Forms.TabControl();
            this.tpProduto = new System.Windows.Forms.TabPage();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.mySqlConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpDadosProd = new System.Windows.Forms.TabPage();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtValVenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValLucro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoProdInativo = new System.Windows.Forms.RadioButton();
            this.rdoProdAtivo = new System.Windows.Forms.RadioButton();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.txtIdCli = new System.Windows.Forms.TextBox();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.txtValCompra = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.lblDescProd = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLucro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionTimeoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProdutos.SuspendLayout();
            this.tsProduto.SuspendLayout();
            this.tcProdutos.SuspendLayout();
            this.tpProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlConnectionBindingSource)).BeginInit();
            this.tpDadosProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProdutos
            // 
            this.pnlProdutos.Controls.Add(this.lblPesquisa);
            this.pnlProdutos.Controls.Add(this.txtPesquisa);
            this.pnlProdutos.Controls.Add(this.tsProduto);
            this.pnlProdutos.Controls.Add(this.tcProdutos);
            this.pnlProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProdutos.Location = new System.Drawing.Point(0, 0);
            this.pnlProdutos.Name = "pnlProdutos";
            this.pnlProdutos.Size = new System.Drawing.Size(983, 590);
            this.pnlProdutos.TabIndex = 0;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(12, 35);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisa.TabIndex = 13;
            this.lblPesquisa.Text = "Pesquisar:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(74, 32);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(257, 20);
            this.txtPesquisa.TabIndex = 12;
            this.txtPesquisa.TabStop = false;
            // 
            // tsProduto
            // 
            this.tsProduto.BackColor = System.Drawing.SystemColors.Control;
            this.tsProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsProduto.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsProduto.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.tsProduto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddProduto,
            this.tsbtnEditProduto,
            this.tsbtnSalvar,
            this.tsbtnCancelar,
            this.toolStripSeparator,
            this.tsbtnImprimir,
            this.toolStripSeparator1,
            this.tsbtnSair});
            this.tsProduto.Location = new System.Drawing.Point(0, 0);
            this.tsProduto.Name = "tsProduto";
            this.tsProduto.Size = new System.Drawing.Size(983, 29);
            this.tsProduto.TabIndex = 7;
            this.tsProduto.Text = "toolStrip1";
            // 
            // tsbtnAddProduto
            // 
            this.tsbtnAddProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddProduto.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddProduto.Image")));
            this.tsbtnAddProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddProduto.Name = "tsbtnAddProduto";
            this.tsbtnAddProduto.Size = new System.Drawing.Size(26, 26);
            this.tsbtnAddProduto.Text = "Novo";
            this.tsbtnAddProduto.Click += new System.EventHandler(this.tsbtnAddProduto_Click);
            // 
            // tsbtnEditProduto
            // 
            this.tsbtnEditProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEditProduto.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditProduto.Image")));
            this.tsbtnEditProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditProduto.Name = "tsbtnEditProduto";
            this.tsbtnEditProduto.Size = new System.Drawing.Size(26, 26);
            this.tsbtnEditProduto.Text = "Editar";
            // 
            // tsbtnSalvar
            // 
            this.tsbtnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSalvar.Enabled = false;
            this.tsbtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSalvar.Image")));
            this.tsbtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSalvar.Name = "tsbtnSalvar";
            this.tsbtnSalvar.Size = new System.Drawing.Size(26, 26);
            this.tsbtnSalvar.Text = "Salvar";
            this.tsbtnSalvar.Click += new System.EventHandler(this.tsbtnSalvar_Click);
            // 
            // tsbtnCancelar
            // 
            this.tsbtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCancelar.Enabled = false;
            this.tsbtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancelar.Image")));
            this.tsbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancelar.Name = "tsbtnCancelar";
            this.tsbtnCancelar.Size = new System.Drawing.Size(26, 26);
            this.tsbtnCancelar.Text = "Cancelar";
            this.tsbtnCancelar.Click += new System.EventHandler(this.tsbtnCancelar_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 29);
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
            // tcProdutos
            // 
            this.tcProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcProdutos.Controls.Add(this.tpProduto);
            this.tcProdutos.Controls.Add(this.tpDadosProd);
            this.tcProdutos.Location = new System.Drawing.Point(-1, 58);
            this.tcProdutos.Multiline = true;
            this.tcProdutos.Name = "tcProdutos";
            this.tcProdutos.SelectedIndex = 0;
            this.tcProdutos.Size = new System.Drawing.Size(984, 532);
            this.tcProdutos.TabIndex = 6;
            this.tcProdutos.TabStop = false;
            // 
            // tpProduto
            // 
            this.tpProduto.Controls.Add(this.dgvProduto);
            this.tpProduto.Location = new System.Drawing.Point(4, 22);
            this.tpProduto.Name = "tpProduto";
            this.tpProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tpProduto.Size = new System.Drawing.Size(976, 506);
            this.tpProduto.TabIndex = 0;
            this.tpProduto.Text = "Produtos";
            this.tpProduto.UseVisualStyleBackColor = true;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToOrderColumns = true;
            this.dgvProduto.AutoGenerateColumns = false;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descricao,
            this.unidade,
            this.estoque,
            this.pCompra,
            this.pLucro,
            this.pVenda,
            this.grupo,
            this.dtRegistro,
            this.ativo,
            this.dataSourceDataGridViewTextBoxColumn,
            this.connectionTimeoutDataGridViewTextBoxColumn,
            this.databaseDataGridViewTextBoxColumn,
            this.connectionStringDataGridViewTextBoxColumn});
            this.dgvProduto.DataSource = this.mySqlConnectionBindingSource;
            this.dgvProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduto.Location = new System.Drawing.Point(3, 3);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProduto.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(970, 500);
            this.dgvProduto.TabIndex = 2;
            this.dgvProduto.TabStop = false;
            // 
            // mySqlConnectionBindingSource
            // 
            this.mySqlConnectionBindingSource.DataSource = typeof(MySql.Data.MySqlClient.MySqlConnection);
            // 
            // tpDadosProd
            // 
            this.tpDadosProd.Controls.Add(this.cbGrupo);
            this.tpDadosProd.Controls.Add(this.lblGrupo);
            this.tpDadosProd.Controls.Add(this.txtEstoque);
            this.tpDadosProd.Controls.Add(this.lblEstoque);
            this.tpDadosProd.Controls.Add(this.txtValVenda);
            this.tpDadosProd.Controls.Add(this.label2);
            this.tpDadosProd.Controls.Add(this.txtValLucro);
            this.tpDadosProd.Controls.Add(this.label1);
            this.tpDadosProd.Controls.Add(this.rdoProdInativo);
            this.tpDadosProd.Controls.Add(this.rdoProdAtivo);
            this.tpDadosProd.Controls.Add(this.txtUnidade);
            this.tpDadosProd.Controls.Add(this.txtIdCli);
            this.tpDadosProd.Controls.Add(this.lblIdCli);
            this.tpDadosProd.Controls.Add(this.txtValCompra);
            this.tpDadosProd.Controls.Add(this.txtDescricao);
            this.tpDadosProd.Controls.Add(this.lblEndereco);
            this.tpDadosProd.Controls.Add(this.lblUnidade);
            this.tpDadosProd.Controls.Add(this.lblDescProd);
            this.tpDadosProd.Location = new System.Drawing.Point(4, 22);
            this.tpDadosProd.Name = "tpDadosProd";
            this.tpDadosProd.Padding = new System.Windows.Forms.Padding(3);
            this.tpDadosProd.Size = new System.Drawing.Size(976, 506);
            this.tpDadosProd.TabIndex = 1;
            this.tpDadosProd.Text = "Dados";
            this.tpDadosProd.UseVisualStyleBackColor = true;
            // 
            // cbGrupo
            // 
            this.cbGrupo.DataSource = this.mySqlConnectionBindingSource;
            this.cbGrupo.Font = new System.Drawing.Font("Arial", 12F);
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(12, 210);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(217, 26);
            this.cbGrupo.TabIndex = 8;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Arial", 12F);
            this.lblGrupo.Location = new System.Drawing.Point(9, 189);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(55, 18);
            this.lblGrupo.TabIndex = 7;
            this.lblGrupo.Text = "Grupo:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEstoque.Location = new System.Drawing.Point(11, 150);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(90, 26);
            this.txtEstoque.TabIndex = 3;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEstoque.Location = new System.Drawing.Point(8, 129);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(70, 18);
            this.lblEstoque.TabIndex = 0;
            this.lblEstoque.Text = "Estoque:";
            // 
            // txtValVenda
            // 
            this.txtValVenda.Font = new System.Drawing.Font("Arial", 12F);
            this.txtValVenda.Location = new System.Drawing.Point(331, 150);
            this.txtValVenda.Name = "txtValVenda";
            this.txtValVenda.Size = new System.Drawing.Size(90, 26);
            this.txtValVenda.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(328, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "R$ Venda:";
            // 
            // txtValLucro
            // 
            this.txtValLucro.Font = new System.Drawing.Font("Arial", 12F);
            this.txtValLucro.Location = new System.Drawing.Point(235, 150);
            this.txtValLucro.Name = "txtValLucro";
            this.txtValLucro.Size = new System.Drawing.Size(90, 26);
            this.txtValLucro.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(232, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lucro (%):";
            // 
            // rdoProdInativo
            // 
            this.rdoProdInativo.AutoSize = true;
            this.rdoProdInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoProdInativo.Location = new System.Drawing.Point(354, 36);
            this.rdoProdInativo.Name = "rdoProdInativo";
            this.rdoProdInativo.Size = new System.Drawing.Size(67, 21);
            this.rdoProdInativo.TabIndex = 0;
            this.rdoProdInativo.Text = "Inativo";
            this.rdoProdInativo.UseVisualStyleBackColor = true;
            // 
            // rdoProdAtivo
            // 
            this.rdoProdAtivo.AutoSize = true;
            this.rdoProdAtivo.Checked = true;
            this.rdoProdAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoProdAtivo.Location = new System.Drawing.Point(291, 36);
            this.rdoProdAtivo.Name = "rdoProdAtivo";
            this.rdoProdAtivo.Size = new System.Drawing.Size(57, 21);
            this.rdoProdAtivo.TabIndex = 0;
            this.rdoProdAtivo.TabStop = true;
            this.rdoProdAtivo.Text = "Ativo";
            this.rdoProdAtivo.UseVisualStyleBackColor = true;
            // 
            // txtUnidade
            // 
            this.txtUnidade.Font = new System.Drawing.Font("Arial", 12F);
            this.txtUnidade.Location = new System.Drawing.Point(356, 91);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(65, 26);
            this.txtUnidade.TabIndex = 2;
            // 
            // txtIdCli
            // 
            this.txtIdCli.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtIdCli.Enabled = false;
            this.txtIdCli.Font = new System.Drawing.Font("Arial", 12F);
            this.txtIdCli.Location = new System.Drawing.Point(11, 34);
            this.txtIdCli.Name = "txtIdCli";
            this.txtIdCli.Size = new System.Drawing.Size(77, 26);
            this.txtIdCli.TabIndex = 0;
            // 
            // lblIdCli
            // 
            this.lblIdCli.AutoSize = true;
            this.lblIdCli.Font = new System.Drawing.Font("Arial", 12F);
            this.lblIdCli.Location = new System.Drawing.Point(8, 13);
            this.lblIdCli.Name = "lblIdCli";
            this.lblIdCli.Size = new System.Drawing.Size(64, 18);
            this.lblIdCli.TabIndex = 0;
            this.lblIdCli.Text = "Código:";
            // 
            // txtValCompra
            // 
            this.txtValCompra.Font = new System.Drawing.Font("Arial", 12F);
            this.txtValCompra.Location = new System.Drawing.Point(139, 150);
            this.txtValCompra.Name = "txtValCompra";
            this.txtValCompra.Size = new System.Drawing.Size(90, 26);
            this.txtValCompra.TabIndex = 4;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(11, 91);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(339, 26);
            this.txtDescricao.TabIndex = 1;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEndereco.Location = new System.Drawing.Point(136, 129);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(93, 18);
            this.lblEndereco.TabIndex = 0;
            this.lblEndereco.Text = "R$ Compra:";
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Font = new System.Drawing.Font("Arial", 12F);
            this.lblUnidade.Location = new System.Drawing.Point(353, 70);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(31, 18);
            this.lblUnidade.TabIndex = 0;
            this.lblUnidade.Text = "Un.";
            // 
            // lblDescProd
            // 
            this.lblDescProd.AutoSize = true;
            this.lblDescProd.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDescProd.Location = new System.Drawing.Point(8, 70);
            this.lblDescProd.Name = "lblDescProd";
            this.lblDescProd.Size = new System.Drawing.Size(84, 18);
            this.lblDescProd.TabIndex = 0;
            this.lblDescProd.Text = "Descrição:";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // unidade
            // 
            this.unidade.DataPropertyName = "unidade";
            this.unidade.HeaderText = "Un";
            this.unidade.Name = "unidade";
            this.unidade.ReadOnly = true;
            // 
            // estoque
            // 
            this.estoque.DataPropertyName = "estoque";
            this.estoque.HeaderText = "Estoque";
            this.estoque.Name = "estoque";
            this.estoque.ReadOnly = true;
            // 
            // pCompra
            // 
            this.pCompra.DataPropertyName = "pCompra";
            this.pCompra.HeaderText = "Preço de Compra";
            this.pCompra.Name = "pCompra";
            this.pCompra.ReadOnly = true;
            this.pCompra.Width = 120;
            // 
            // pLucro
            // 
            this.pLucro.DataPropertyName = "pLucro";
            this.pLucro.HeaderText = "Lucro";
            this.pLucro.Name = "pLucro";
            this.pLucro.ReadOnly = true;
            // 
            // pVenda
            // 
            this.pVenda.DataPropertyName = "pVenda";
            this.pVenda.HeaderText = "Preço de Venda";
            this.pVenda.Name = "pVenda";
            this.pVenda.ReadOnly = true;
            this.pVenda.Width = 120;
            // 
            // grupo
            // 
            this.grupo.DataPropertyName = "grupo";
            this.grupo.HeaderText = "Grupo";
            this.grupo.Name = "grupo";
            this.grupo.ReadOnly = true;
            // 
            // dtRegistro
            // 
            this.dtRegistro.DataPropertyName = "dtRegistro";
            this.dtRegistro.HeaderText = "Dt Registro";
            this.dtRegistro.Name = "dtRegistro";
            this.dtRegistro.ReadOnly = true;
            // 
            // ativo
            // 
            this.ativo.DataPropertyName = "ativo";
            this.ativo.HeaderText = "Ativo";
            this.ativo.Name = "ativo";
            this.ativo.ReadOnly = true;
            // 
            // dataSourceDataGridViewTextBoxColumn
            // 
            this.dataSourceDataGridViewTextBoxColumn.DataPropertyName = "DataSource";
            this.dataSourceDataGridViewTextBoxColumn.HeaderText = "DataSource";
            this.dataSourceDataGridViewTextBoxColumn.Name = "dataSourceDataGridViewTextBoxColumn";
            this.dataSourceDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataSourceDataGridViewTextBoxColumn.Visible = false;
            // 
            // connectionTimeoutDataGridViewTextBoxColumn
            // 
            this.connectionTimeoutDataGridViewTextBoxColumn.DataPropertyName = "ConnectionTimeout";
            this.connectionTimeoutDataGridViewTextBoxColumn.HeaderText = "ConnectionTimeout";
            this.connectionTimeoutDataGridViewTextBoxColumn.Name = "connectionTimeoutDataGridViewTextBoxColumn";
            this.connectionTimeoutDataGridViewTextBoxColumn.ReadOnly = true;
            this.connectionTimeoutDataGridViewTextBoxColumn.Visible = false;
            // 
            // databaseDataGridViewTextBoxColumn
            // 
            this.databaseDataGridViewTextBoxColumn.DataPropertyName = "Database";
            this.databaseDataGridViewTextBoxColumn.HeaderText = "Database";
            this.databaseDataGridViewTextBoxColumn.Name = "databaseDataGridViewTextBoxColumn";
            this.databaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.databaseDataGridViewTextBoxColumn.Visible = false;
            // 
            // connectionStringDataGridViewTextBoxColumn
            // 
            this.connectionStringDataGridViewTextBoxColumn.DataPropertyName = "ConnectionString";
            this.connectionStringDataGridViewTextBoxColumn.HeaderText = "ConnectionString";
            this.connectionStringDataGridViewTextBoxColumn.Name = "connectionStringDataGridViewTextBoxColumn";
            this.connectionStringDataGridViewTextBoxColumn.ReadOnly = true;
            this.connectionStringDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmProduto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.pnlProdutos);
            this.KeyPreview = true;
            this.Name = "FrmProduto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProduto_KeyDown);
            this.pnlProdutos.ResumeLayout(false);
            this.pnlProdutos.PerformLayout();
            this.tsProduto.ResumeLayout(false);
            this.tsProduto.PerformLayout();
            this.tcProdutos.ResumeLayout(false);
            this.tpProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlConnectionBindingSource)).EndInit();
            this.tpDadosProd.ResumeLayout(false);
            this.tpDadosProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProdutos;
        private System.Windows.Forms.ToolStrip tsProduto;
        private System.Windows.Forms.ToolStripButton tsbtnAddProduto;
        private System.Windows.Forms.ToolStripButton tsbtnEditProduto;
        private System.Windows.Forms.ToolStripButton tsbtnSalvar;
        private System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.TabControl tcProdutos;
        private System.Windows.Forms.TabPage tpProduto;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TabPage tpDadosProd;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox txtValVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValLucro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoProdInativo;
        private System.Windows.Forms.RadioButton rdoProdAtivo;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.TextBox txtIdCli;
        private System.Windows.Forms.Label lblIdCli;
        private System.Windows.Forms.TextBox txtValCompra;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.Label lblDescProd;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.BindingSource mySqlConnectionBindingSource;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLucro;
        private System.Windows.Forms.DataGridViewTextBoxColumn pVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionTimeoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionStringDataGridViewTextBoxColumn;
    }
}