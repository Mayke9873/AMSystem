namespace Projeto_Novo
{
    partial class FrmCompra
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.lblValorUnt = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtIdCompra = new System.Windows.Forms.TextBox();
            this.lblIdCompra = new System.Windows.Forms.Label();
            this.mySqlConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionTimeoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNome = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProdCompra = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSourceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionTimeoutDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionStringDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescontoCompra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlConnectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial", 9F);
            this.btnSair.Location = new System.Drawing.Point(214, 543);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(96, 32);
            this.btnSair.TabIndex = 45;
            this.btnSair.Text = "Esc - Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnCancelar.Location = new System.Drawing.Point(113, 543);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 32);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "F4 - Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnConfirmar.Location = new System.Drawing.Point(12, 543);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(96, 32);
            this.btnConfirmar.TabIndex = 43;
            this.btnConfirmar.Text = "F3 - Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Arial", 11F);
            this.txtValorTotal.Location = new System.Drawing.Point(825, 142);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(86, 24);
            this.txtValorTotal.TabIndex = 9;
            this.txtValorTotal.Enter += new System.EventHandler(this.txtValorTotal_Enter);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Arial", 12F);
            this.lblValorTotal.Location = new System.Drawing.Point(822, 121);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(64, 18);
            this.lblValorTotal.TabIndex = 41;
            this.lblValorTotal.Text = "R$ Total";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Arial", 11F);
            this.txtDesconto.Location = new System.Drawing.Point(733, 142);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(86, 24);
            this.txtDesconto.TabIndex = 8;
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDesconto.Location = new System.Drawing.Point(730, 121);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(49, 18);
            this.lblDesconto.TabIndex = 39;
            this.lblDesconto.Text = "Desc.";
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.Font = new System.Drawing.Font("Arial", 11F);
            this.txtValorUnit.Location = new System.Drawing.Point(641, 142);
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(86, 24);
            this.txtValorUnit.TabIndex = 7;
            this.txtValorUnit.Enter += new System.EventHandler(this.txtValorUnit_Enter);
            // 
            // lblValorUnt
            // 
            this.lblValorUnt.AutoSize = true;
            this.lblValorUnt.Font = new System.Drawing.Font("Arial", 12F);
            this.lblValorUnt.Location = new System.Drawing.Point(638, 121);
            this.lblValorUnt.Name = "lblValorUnt";
            this.lblValorUnt.Size = new System.Drawing.Size(63, 18);
            this.lblValorUnt.TabIndex = 37;
            this.lblValorUnt.Text = "R$ Unit.";
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Arial", 11F);
            this.txtQtd.Location = new System.Drawing.Point(549, 142);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(86, 24);
            this.txtQtd.TabIndex = 6;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Arial", 12F);
            this.lblQtd.Location = new System.Drawing.Point(546, 121);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(37, 18);
            this.lblQtd.TabIndex = 35;
            this.lblQtd.Text = "Qtd.";
            // 
            // txtProduto
            // 
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Font = new System.Drawing.Font("Arial", 11F);
            this.txtProduto.Location = new System.Drawing.Point(99, 142);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(446, 24);
            this.txtProduto.TabIndex = 4;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdProduto.Font = new System.Drawing.Font("Arial", 11F);
            this.txtIdProduto.Location = new System.Drawing.Point(12, 142);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(86, 24);
            this.txtIdProduto.TabIndex = 3;
            this.txtIdProduto.Leave += new System.EventHandler(this.txtIdProduto_Leave);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Arial", 12F);
            this.lblProduto.Location = new System.Drawing.Point(9, 121);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(67, 18);
            this.lblProduto.TabIndex = 32;
            this.lblProduto.Text = "Produto:";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.Font = new System.Drawing.Font("Arial", 11F);
            this.txtFornecedor.Location = new System.Drawing.Point(99, 86);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(446, 24);
            this.txtFornecedor.TabIndex = 2;
            this.txtFornecedor.TextChanged += new System.EventHandler(this.txtFornecedor_TextChanged);
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdFornecedor.Font = new System.Drawing.Font("Arial", 11F);
            this.txtIdFornecedor.Location = new System.Drawing.Point(12, 86);
            this.txtIdFornecedor.MaxLength = 10;
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(86, 24);
            this.txtIdFornecedor.TabIndex = 1;
            this.txtIdFornecedor.Leave += new System.EventHandler(this.txtIdFornecedor_Leave);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Arial", 12F);
            this.lblFornecedor.Location = new System.Drawing.Point(9, 65);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(93, 18);
            this.lblFornecedor.TabIndex = 29;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // txtIdCompra
            // 
            this.txtIdCompra.Enabled = false;
            this.txtIdCompra.Font = new System.Drawing.Font("Arial", 11F);
            this.txtIdCompra.Location = new System.Drawing.Point(12, 30);
            this.txtIdCompra.Name = "txtIdCompra";
            this.txtIdCompra.Size = new System.Drawing.Size(86, 24);
            this.txtIdCompra.TabIndex = 24;
            this.txtIdCompra.TabStop = false;
            // 
            // lblIdCompra
            // 
            this.lblIdCompra.AutoSize = true;
            this.lblIdCompra.Font = new System.Drawing.Font("Arial", 12F);
            this.lblIdCompra.Location = new System.Drawing.Point(9, 9);
            this.lblIdCompra.Name = "lblIdCompra";
            this.lblIdCompra.Size = new System.Drawing.Size(89, 18);
            this.lblIdCompra.TabIndex = 25;
            this.lblIdCompra.Text = "Nº Compra:";
            // 
            // mySqlConnectionBindingSource
            // 
            this.mySqlConnectionBindingSource.DataSource = typeof(MySql.Data.MySqlClient.MySqlConnection);
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
            this.dgvProdutos.TabIndex = 46;
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
            this.Column4.DataPropertyName = "pCompra";
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
            this.dgvNome.TabIndex = 47;
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
            // dgvProdCompra
            // 
            this.dgvProdCompra.AllowUserToAddRows = false;
            this.dgvProdCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdCompra.AutoGenerateColumns = false;
            this.dgvProdCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProdCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao,
            this.qtd,
            this.vUnit,
            this.vDesc,
            this.vTotal,
            this.dataSourceDataGridViewTextBoxColumn1,
            this.connectionTimeoutDataGridViewTextBoxColumn1,
            this.databaseDataGridViewTextBoxColumn1,
            this.connectionStringDataGridViewTextBoxColumn1});
            this.dgvProdCompra.DataSource = this.mySqlConnectionBindingSource;
            this.dgvProdCompra.Location = new System.Drawing.Point(12, 172);
            this.dgvProdCompra.Name = "dgvProdCompra";
            this.dgvProdCompra.RowHeadersWidth = 12;
            this.dgvProdCompra.Size = new System.Drawing.Size(959, 355);
            this.dgvProdCompra.TabIndex = 48;
            this.dgvProdCompra.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(693, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "Descontos:";
            // 
            // txtDescontoCompra
            // 
            this.txtDescontoCompra.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDescontoCompra.Enabled = false;
            this.txtDescontoCompra.Font = new System.Drawing.Font("Arial", 18F);
            this.txtDescontoCompra.Location = new System.Drawing.Point(696, 30);
            this.txtDescontoCompra.Multiline = true;
            this.txtDescontoCompra.Name = "txtDescontoCompra";
            this.txtDescontoCompra.Size = new System.Drawing.Size(104, 34);
            this.txtDescontoCompra.TabIndex = 51;
            this.txtDescontoCompra.TabStop = false;
            this.txtDescontoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(804, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "R$ Total:";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.BackColor = System.Drawing.Color.Gainsboro;
            this.txtValorCompra.Enabled = false;
            this.txtValorCompra.Font = new System.Drawing.Font("Arial", 18F);
            this.txtValorCompra.Location = new System.Drawing.Point(807, 30);
            this.txtValorCompra.Multiline = true;
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(104, 34);
            this.txtValorCompra.TabIndex = 49;
            this.txtValorCompra.TabStop = false;
            this.txtValorCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmCompra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescontoCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.dgvNome);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.dgvProdCompra);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.txtValorUnit);
            this.Controls.Add(this.lblValorUnt);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtIdFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txtIdCompra);
            this.Controls.Add(this.lblIdCompra);
            this.KeyPreview = true;
            this.Name = "FrmCompra";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Compras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCompra_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.mySqlConnectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox txtValorUnit;
        private System.Windows.Forms.Label lblValorUnt;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtIdFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtIdCompra;
        private System.Windows.Forms.Label lblIdCompra;
        private System.Windows.Forms.BindingSource mySqlConnectionBindingSource;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridView dgvNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView dgvProdCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn vUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSourceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionTimeoutDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionStringDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionTimeoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescontoCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorCompra;
    }
}