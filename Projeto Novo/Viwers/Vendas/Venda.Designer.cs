namespace Projeto_Novo
{
    partial class FrmVenda
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
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.dgvProVenda = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSourceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionTimeoutDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionStringDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mySqlConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.lblValorUnt = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.txtIdVendedor = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.txtIdVenda = new System.Windows.Forms.TextBox();
            this.lblIdVenda = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionTimeoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNome = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescontoVenda = new System.Windows.Forms.TextBox();
            this.btnExcluirProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlConnectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNome)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Arial", 11F);
            this.txtDesconto.Location = new System.Drawing.Point(733, 196);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(86, 24);
            this.txtDesconto.TabIndex = 17;
            this.txtDesconto.Text = "0";
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDesconto.Location = new System.Drawing.Point(730, 175);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(49, 18);
            this.lblDesconto.TabIndex = 16;
            this.lblDesconto.Text = "Desc.";
            // 
            // dgvProVenda
            // 
            this.dgvProVenda.AllowUserToAddRows = false;
            this.dgvProVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProVenda.AutoGenerateColumns = false;
            this.dgvProVenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao,
            this.qtd,
            this.vUnit,
            this.vDesc,
            this.vTotal,
            this.Column5,
            this.dataSourceDataGridViewTextBoxColumn1,
            this.connectionTimeoutDataGridViewTextBoxColumn1,
            this.databaseDataGridViewTextBoxColumn1,
            this.connectionStringDataGridViewTextBoxColumn1});
            this.dgvProVenda.DataSource = this.mySqlConnectionBindingSource;
            this.dgvProVenda.Location = new System.Drawing.Point(12, 226);
            this.dgvProVenda.Name = "dgvProVenda";
            this.dgvProVenda.RowHeadersWidth = 12;
            this.dgvProVenda.Size = new System.Drawing.Size(960, 301);
            this.dgvProVenda.TabIndex = 0;
            this.dgvProVenda.TabStop = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "idprod";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.Width = 386;
            // 
            // qtd
            // 
            this.qtd.DataPropertyName = "quantidade";
            this.qtd.HeaderText = "Qtd.";
            this.qtd.Name = "qtd";
            // 
            // vUnit
            // 
            this.vUnit.DataPropertyName = "valor";
            this.vUnit.HeaderText = "R$ Unit.";
            this.vUnit.Name = "vUnit";
            // 
            // vDesc
            // 
            this.vDesc.DataPropertyName = "desconto";
            this.vDesc.HeaderText = "Desc.";
            this.vDesc.Name = "vDesc";
            // 
            // vTotal
            // 
            this.vTotal.DataPropertyName = "total";
            this.vTotal.HeaderText = "R$ Total";
            this.vTotal.Name = "vTotal";
            this.vTotal.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "id";
            this.Column5.HeaderText = "id";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // dataSourceDataGridViewTextBoxColumn1
            // 
            this.dataSourceDataGridViewTextBoxColumn1.DataPropertyName = "DataSource";
            this.dataSourceDataGridViewTextBoxColumn1.HeaderText = "DataSource";
            this.dataSourceDataGridViewTextBoxColumn1.Name = "dataSourceDataGridViewTextBoxColumn1";
            this.dataSourceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataSourceDataGridViewTextBoxColumn1.Visible = false;
            // 
            // connectionTimeoutDataGridViewTextBoxColumn1
            // 
            this.connectionTimeoutDataGridViewTextBoxColumn1.DataPropertyName = "ConnectionTimeout";
            this.connectionTimeoutDataGridViewTextBoxColumn1.HeaderText = "ConnectionTimeout";
            this.connectionTimeoutDataGridViewTextBoxColumn1.Name = "connectionTimeoutDataGridViewTextBoxColumn1";
            this.connectionTimeoutDataGridViewTextBoxColumn1.ReadOnly = true;
            this.connectionTimeoutDataGridViewTextBoxColumn1.Visible = false;
            // 
            // databaseDataGridViewTextBoxColumn1
            // 
            this.databaseDataGridViewTextBoxColumn1.DataPropertyName = "Database";
            this.databaseDataGridViewTextBoxColumn1.HeaderText = "Database";
            this.databaseDataGridViewTextBoxColumn1.Name = "databaseDataGridViewTextBoxColumn1";
            this.databaseDataGridViewTextBoxColumn1.ReadOnly = true;
            this.databaseDataGridViewTextBoxColumn1.Visible = false;
            // 
            // connectionStringDataGridViewTextBoxColumn1
            // 
            this.connectionStringDataGridViewTextBoxColumn1.DataPropertyName = "ConnectionString";
            this.connectionStringDataGridViewTextBoxColumn1.HeaderText = "ConnectionString";
            this.connectionStringDataGridViewTextBoxColumn1.Name = "connectionStringDataGridViewTextBoxColumn1";
            this.connectionStringDataGridViewTextBoxColumn1.Visible = false;
            // 
            // mySqlConnectionBindingSource
            // 
            this.mySqlConnectionBindingSource.DataSource = typeof(MySql.Data.MySqlClient.MySqlConnection);
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.Font = new System.Drawing.Font("Arial", 11F);
            this.txtValorUnit.Location = new System.Drawing.Point(641, 196);
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(86, 24);
            this.txtValorUnit.TabIndex = 15;
            // 
            // lblValorUnt
            // 
            this.lblValorUnt.AutoSize = true;
            this.lblValorUnt.Font = new System.Drawing.Font("Arial", 12F);
            this.lblValorUnt.Location = new System.Drawing.Point(638, 175);
            this.lblValorUnt.Name = "lblValorUnt";
            this.lblValorUnt.Size = new System.Drawing.Size(63, 18);
            this.lblValorUnt.TabIndex = 14;
            this.lblValorUnt.Text = "R$ Unit.";
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Arial", 11F);
            this.txtQtd.Location = new System.Drawing.Point(549, 196);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(86, 24);
            this.txtQtd.TabIndex = 13;
            this.txtQtd.Text = "1";
            this.txtQtd.Leave += new System.EventHandler(this.txtQtd_Leave);
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Arial", 12F);
            this.lblQtd.Location = new System.Drawing.Point(546, 175);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(37, 18);
            this.lblQtd.TabIndex = 12;
            this.lblQtd.Text = "Qtd.";
            // 
            // txtProduto
            // 
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Font = new System.Drawing.Font("Arial", 11F);
            this.txtProduto.Location = new System.Drawing.Point(99, 196);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(446, 24);
            this.txtProduto.TabIndex = 11;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdProduto.Font = new System.Drawing.Font("Arial", 11F);
            this.txtIdProduto.Location = new System.Drawing.Point(12, 196);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(86, 24);
            this.txtIdProduto.TabIndex = 10;
            this.txtIdProduto.Leave += new System.EventHandler(this.txtIdProduto_Leave);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Arial", 12F);
            this.lblProduto.Location = new System.Drawing.Point(9, 175);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(67, 18);
            this.lblProduto.TabIndex = 9;
            this.lblProduto.Text = "Produto:";
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Font = new System.Drawing.Font("Arial", 11F);
            this.txtCliente.Location = new System.Drawing.Point(99, 126);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(446, 24);
            this.txtCliente.TabIndex = 8;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Font = new System.Drawing.Font("Arial", 11F);
            this.txtIdCliente.Location = new System.Drawing.Point(12, 126);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(86, 24);
            this.txtIdCliente.TabIndex = 7;
            this.txtIdCliente.Text = "1";
            this.txtIdCliente.Leave += new System.EventHandler(this.txtIdCliente_Leave);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCliente.Location = new System.Drawing.Point(9, 105);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(61, 18);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtVendedor
            // 
            this.txtVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendedor.Font = new System.Drawing.Font("Arial", 11F);
            this.txtVendedor.Location = new System.Drawing.Point(99, 78);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(446, 24);
            this.txtVendedor.TabIndex = 5;
            this.txtVendedor.TextChanged += new System.EventHandler(this.txtVendedor_TextChanged);
            // 
            // txtIdVendedor
            // 
            this.txtIdVendedor.Font = new System.Drawing.Font("Arial", 11F);
            this.txtIdVendedor.Location = new System.Drawing.Point(12, 78);
            this.txtIdVendedor.Name = "txtIdVendedor";
            this.txtIdVendedor.Size = new System.Drawing.Size(86, 24);
            this.txtIdVendedor.TabIndex = 4;
            this.txtIdVendedor.Text = "1";
            this.txtIdVendedor.Leave += new System.EventHandler(this.txtIdVendedor_Leave);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Arial", 12F);
            this.lblVendedor.Location = new System.Drawing.Point(9, 57);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(80, 18);
            this.lblVendedor.TabIndex = 3;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // txtIdVenda
            // 
            this.txtIdVenda.Enabled = false;
            this.txtIdVenda.Font = new System.Drawing.Font("Arial", 11F);
            this.txtIdVenda.Location = new System.Drawing.Point(12, 30);
            this.txtIdVenda.Name = "txtIdVenda";
            this.txtIdVenda.Size = new System.Drawing.Size(86, 24);
            this.txtIdVenda.TabIndex = 0;
            this.txtIdVenda.TabStop = false;
            // 
            // lblIdVenda
            // 
            this.lblIdVenda.AutoSize = true;
            this.lblIdVenda.Font = new System.Drawing.Font("Arial", 12F);
            this.lblIdVenda.Location = new System.Drawing.Point(9, 9);
            this.lblIdVenda.Name = "lblIdVenda";
            this.lblIdVenda.Size = new System.Drawing.Size(77, 18);
            this.lblIdVenda.TabIndex = 1;
            this.lblIdVenda.Text = "Nº Venda:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Arial", 11F);
            this.txtValorTotal.Location = new System.Drawing.Point(825, 196);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(86, 24);
            this.txtValorTotal.TabIndex = 19;
            this.txtValorTotal.Enter += new System.EventHandler(this.txtValorTotal_Enter);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Arial", 12F);
            this.lblValorTotal.Location = new System.Drawing.Point(822, 175);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(64, 18);
            this.lblValorTotal.TabIndex = 18;
            this.lblValorTotal.Text = "R$ Total";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnConfirmar.Location = new System.Drawing.Point(12, 543);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(125, 32);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "F3 - Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnCancelar.Location = new System.Drawing.Point(142, 543);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 32);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "F4 - Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial", 9F);
            this.btnSair.Location = new System.Drawing.Point(402, 543);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(125, 32);
            this.btnSair.TabIndex = 22;
            this.btnSair.Text = "Esc - Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowDrop = true;
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.dataSourceDataGridViewTextBoxColumn,
            this.connectionTimeoutDataGridViewTextBoxColumn,
            this.databaseDataGridViewTextBoxColumn,
            this.connectionStringDataGridViewTextBoxColumn});
            this.dgvProdutos.DataSource = this.mySqlConnectionBindingSource;
            this.dgvProdutos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvProdutos.Location = new System.Drawing.Point(795, 284);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersWidth = 12;
            this.dgvProdutos.Size = new System.Drawing.Size(715, 231);
            this.dgvProdutos.TabIndex = 23;
            this.dgvProdutos.TabStop = false;
            this.dgvProdutos.Visible = false;
            this.dgvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "descricao";
            this.Column2.HeaderText = "Descrição";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 401;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "estoque";
            this.Column3.HeaderText = "Estoque";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "pVenda";
            this.Column4.HeaderText = "R$ Unit.";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
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
            // txtValorVenda
            // 
            this.txtValorVenda.BackColor = System.Drawing.Color.Gainsboro;
            this.txtValorVenda.Enabled = false;
            this.txtValorVenda.Font = new System.Drawing.Font("Arial", 18F);
            this.txtValorVenda.Location = new System.Drawing.Point(807, 30);
            this.txtValorVenda.Multiline = true;
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(104, 34);
            this.txtValorVenda.TabIndex = 24;
            this.txtValorVenda.TabStop = false;
            this.txtValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(804, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "R$ Total:";
            // 
            // dgvNome
            // 
            this.dgvNome.AllowDrop = true;
            this.dgvNome.AllowUserToAddRows = false;
            this.dgvNome.AutoGenerateColumns = false;
            this.dgvNome.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvNome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvNome.DataSource = this.mySqlConnectionBindingSource;
            this.dgvNome.GridColor = System.Drawing.SystemColors.Control;
            this.dgvNome.Location = new System.Drawing.Point(952, 47);
            this.dgvNome.MultiSelect = false;
            this.dgvNome.Name = "dgvNome";
            this.dgvNome.ReadOnly = true;
            this.dgvNome.RowHeadersWidth = 12;
            this.dgvNome.Size = new System.Drawing.Size(533, 231);
            this.dgvNome.TabIndex = 26;
            this.dgvNome.TabStop = false;
            this.dgvNome.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 419;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DataSource";
            this.dataGridViewTextBoxColumn5.HeaderText = "DataSource";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ConnectionTimeout";
            this.dataGridViewTextBoxColumn6.HeaderText = "ConnectionTimeout";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Database";
            this.dataGridViewTextBoxColumn7.HeaderText = "Database";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ConnectionString";
            this.dataGridViewTextBoxColumn8.HeaderText = "ConnectionString";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(693, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Descontos:";
            // 
            // txtDescontoVenda
            // 
            this.txtDescontoVenda.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDescontoVenda.Enabled = false;
            this.txtDescontoVenda.Font = new System.Drawing.Font("Arial", 18F);
            this.txtDescontoVenda.Location = new System.Drawing.Point(696, 30);
            this.txtDescontoVenda.Multiline = true;
            this.txtDescontoVenda.Name = "txtDescontoVenda";
            this.txtDescontoVenda.Size = new System.Drawing.Size(104, 34);
            this.txtDescontoVenda.TabIndex = 27;
            this.txtDescontoVenda.TabStop = false;
            this.txtDescontoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnExcluirProd
            // 
            this.btnExcluirProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluirProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProd.Font = new System.Drawing.Font("Arial", 9F);
            this.btnExcluirProd.Location = new System.Drawing.Point(272, 543);
            this.btnExcluirProd.Name = "btnExcluirProd";
            this.btnExcluirProd.Size = new System.Drawing.Size(125, 32);
            this.btnExcluirProd.TabIndex = 54;
            this.btnExcluirProd.Text = "F5 - Excluir produto";
            this.btnExcluirProd.UseVisualStyleBackColor = true;
            this.btnExcluirProd.Click += new System.EventHandler(this.btnExcluirProd_Click);
            // 
            // FrmVenda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.btnExcluirProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescontoVenda);
            this.Controls.Add(this.dgvNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.dgvProVenda);
            this.Controls.Add(this.txtValorUnit);
            this.Controls.Add(this.lblValorUnt);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.txtIdVendedor);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.txtIdVenda);
            this.Controls.Add(this.lblIdVenda);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "FrmVenda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Venda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVendas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlConnectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.DataGridView dgvProVenda;
        private System.Windows.Forms.TextBox txtValorUnit;
        private System.Windows.Forms.Label lblValorUnt;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.TextBox txtIdVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.TextBox txtIdVenda;
        private System.Windows.Forms.Label lblIdVenda;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.BindingSource mySqlConnectionBindingSource;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionTimeoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescontoVenda;
        private System.Windows.Forms.Button btnExcluirProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn vUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSourceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionTimeoutDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionStringDataGridViewTextBoxColumn1;
    }
}