namespace Projeto_Novo
{
    partial class FrmFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFornecedor));
            this.pnlFornecedor = new System.Windows.Forms.Panel();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.tcFornecedores = new System.Windows.Forms.TabControl();
            this.tpFornecedor = new System.Windows.Forms.TabPage();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionTimeoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mySqlConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpDados = new System.Windows.Forms.TabPage();
            this.txtIe = new System.Windows.Forms.TextBox();
            this.rdoInativo = new System.Windows.Forms.RadioButton();
            this.rdoAtivo = new System.Windows.Forms.RadioButton();
            this.lnlNumEnd = new System.Windows.Forms.Label();
            this.mtxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblIE = new System.Windows.Forms.Label();
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.lblIdForn = new System.Windows.Forms.Label();
            this.txtBairroFornecedor = new System.Windows.Forms.TextBox();
            this.txtNumEndFornecedor = new System.Windows.Forms.TextBox();
            this.txtEndFornecedor = new System.Windows.Forms.TextBox();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNomeForn = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddFornecedor = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditFornecedor = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.pnlFornecedor.SuspendLayout();
            this.tcFornecedores.SuspendLayout();
            this.tpFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlConnectionBindingSource)).BeginInit();
            this.tpDados.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFornecedor
            // 
            this.pnlFornecedor.Controls.Add(this.txtPesquisa);
            this.pnlFornecedor.Controls.Add(this.tcFornecedores);
            this.pnlFornecedor.Controls.Add(this.toolStrip1);
            this.pnlFornecedor.Controls.Add(this.lblPesquisa);
            this.pnlFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFornecedor.Location = new System.Drawing.Point(0, 0);
            this.pnlFornecedor.Name = "pnlFornecedor";
            this.pnlFornecedor.Size = new System.Drawing.Size(983, 590);
            this.pnlFornecedor.TabIndex = 0;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(76, 32);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(257, 20);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TabStop = false;
            // 
            // tcFornecedores
            // 
            this.tcFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcFornecedores.Controls.Add(this.tpFornecedor);
            this.tcFornecedores.Controls.Add(this.tpDados);
            this.tcFornecedores.Location = new System.Drawing.Point(-1, 58);
            this.tcFornecedores.Multiline = true;
            this.tcFornecedores.Name = "tcFornecedores";
            this.tcFornecedores.SelectedIndex = 0;
            this.tcFornecedores.Size = new System.Drawing.Size(984, 532);
            this.tcFornecedores.TabIndex = 0;
            this.tcFornecedores.TabStop = false;
            // 
            // tpFornecedor
            // 
            this.tpFornecedor.Controls.Add(this.dgvFornecedor);
            this.tpFornecedor.Location = new System.Drawing.Point(4, 22);
            this.tpFornecedor.Name = "tpFornecedor";
            this.tpFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.tpFornecedor.Size = new System.Drawing.Size(976, 506);
            this.tpFornecedor.TabIndex = 0;
            this.tpFornecedor.Text = "Fornecedor";
            this.tpFornecedor.UseVisualStyleBackColor = true;
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToDeleteRows = false;
            this.dgvFornecedor.AllowUserToOrderColumns = true;
            this.dgvFornecedor.AutoGenerateColumns = false;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column8,
            this.dataSourceDataGridViewTextBoxColumn,
            this.connectionTimeoutDataGridViewTextBoxColumn,
            this.databaseDataGridViewTextBoxColumn,
            this.connectionStringDataGridViewTextBoxColumn});
            this.dgvFornecedor.DataSource = this.mySqlConnectionBindingSource;
            this.dgvFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFornecedor.Location = new System.Drawing.Point(3, 3);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            this.dgvFornecedor.RowHeadersWidth = 12;
            this.dgvFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedor.Size = new System.Drawing.Size(970, 500);
            this.dgvFornecedor.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nome";
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ie";
            this.Column3.HeaderText = "IE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "cnpj";
            this.Column4.HeaderText = "CNPJ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "endereco";
            this.Column5.HeaderText = "Endereço";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "numEndereco";
            this.Column6.HeaderText = "Nº";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "bairro";
            this.Column7.HeaderText = "Bairro";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "DtRegistro";
            this.Column9.HeaderText = "Dt Registro";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Ativo";
            this.Column8.HeaderText = "Ativo";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
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
            // mySqlConnectionBindingSource
            // 
            this.mySqlConnectionBindingSource.DataSource = typeof(MySql.Data.MySqlClient.MySqlConnection);
            // 
            // tpDados
            // 
            this.tpDados.Controls.Add(this.txtIe);
            this.tpDados.Controls.Add(this.rdoInativo);
            this.tpDados.Controls.Add(this.rdoAtivo);
            this.tpDados.Controls.Add(this.lnlNumEnd);
            this.tpDados.Controls.Add(this.mtxCNPJ);
            this.tpDados.Controls.Add(this.lblCNPJ);
            this.tpDados.Controls.Add(this.lblIE);
            this.tpDados.Controls.Add(this.txtIdFornecedor);
            this.tpDados.Controls.Add(this.lblIdForn);
            this.tpDados.Controls.Add(this.txtBairroFornecedor);
            this.tpDados.Controls.Add(this.txtNumEndFornecedor);
            this.tpDados.Controls.Add(this.txtEndFornecedor);
            this.tpDados.Controls.Add(this.txtNomeFornecedor);
            this.tpDados.Controls.Add(this.lblBairro);
            this.tpDados.Controls.Add(this.lblEndereco);
            this.tpDados.Controls.Add(this.lblNomeForn);
            this.tpDados.Location = new System.Drawing.Point(4, 22);
            this.tpDados.Name = "tpDados";
            this.tpDados.Padding = new System.Windows.Forms.Padding(3);
            this.tpDados.Size = new System.Drawing.Size(976, 506);
            this.tpDados.TabIndex = 3;
            this.tpDados.Text = "Dados";
            this.tpDados.UseVisualStyleBackColor = true;
            // 
            // txtIe
            // 
            this.txtIe.Font = new System.Drawing.Font("Arial", 12F);
            this.txtIe.Location = new System.Drawing.Point(455, 91);
            this.txtIe.Name = "txtIe";
            this.txtIe.Size = new System.Drawing.Size(114, 26);
            this.txtIe.TabIndex = 2;
            // 
            // rdoInativo
            // 
            this.rdoInativo.AutoSize = true;
            this.rdoInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoInativo.Location = new System.Drawing.Point(275, 37);
            this.rdoInativo.Name = "rdoInativo";
            this.rdoInativo.Size = new System.Drawing.Size(67, 21);
            this.rdoInativo.TabIndex = 14;
            this.rdoInativo.Text = "Inativo";
            this.rdoInativo.UseVisualStyleBackColor = true;
            // 
            // rdoAtivo
            // 
            this.rdoAtivo.AutoSize = true;
            this.rdoAtivo.Checked = true;
            this.rdoAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoAtivo.Location = new System.Drawing.Point(212, 37);
            this.rdoAtivo.Name = "rdoAtivo";
            this.rdoAtivo.Size = new System.Drawing.Size(57, 21);
            this.rdoAtivo.TabIndex = 15;
            this.rdoAtivo.TabStop = true;
            this.rdoAtivo.Text = "Ativo";
            this.rdoAtivo.UseVisualStyleBackColor = true;
            // 
            // lnlNumEnd
            // 
            this.lnlNumEnd.AutoSize = true;
            this.lnlNumEnd.Font = new System.Drawing.Font("Arial", 12F);
            this.lnlNumEnd.Location = new System.Drawing.Point(345, 129);
            this.lnlNumEnd.Name = "lnlNumEnd";
            this.lnlNumEnd.Size = new System.Drawing.Size(28, 18);
            this.lnlNumEnd.TabIndex = 11;
            this.lnlNumEnd.Text = "Nº:";
            // 
            // mtxCNPJ
            // 
            this.mtxCNPJ.Font = new System.Drawing.Font("Arial", 12F);
            this.mtxCNPJ.Location = new System.Drawing.Point(574, 91);
            this.mtxCNPJ.Mask = "000,000,000-00";
            this.mtxCNPJ.Name = "mtxCNPJ";
            this.mtxCNPJ.Size = new System.Drawing.Size(130, 26);
            this.mtxCNPJ.TabIndex = 3;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCNPJ.Location = new System.Drawing.Point(571, 70);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(54, 18);
            this.lblCNPJ.TabIndex = 9;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // lblIE
            // 
            this.lblIE.AutoSize = true;
            this.lblIE.Font = new System.Drawing.Font("Arial", 12F);
            this.lblIE.Location = new System.Drawing.Point(452, 70);
            this.lblIE.Name = "lblIE";
            this.lblIE.Size = new System.Drawing.Size(26, 18);
            this.lblIE.TabIndex = 7;
            this.lblIE.Text = "IE:";
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtIdFornecedor.Enabled = false;
            this.txtIdFornecedor.Font = new System.Drawing.Font("Arial", 12F);
            this.txtIdFornecedor.Location = new System.Drawing.Point(11, 34);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(77, 26);
            this.txtIdFornecedor.TabIndex = 0;
            this.txtIdFornecedor.TabStop = false;
            // 
            // lblIdForn
            // 
            this.lblIdForn.AutoSize = true;
            this.lblIdForn.Font = new System.Drawing.Font("Arial", 12F);
            this.lblIdForn.Location = new System.Drawing.Point(8, 13);
            this.lblIdForn.Name = "lblIdForn";
            this.lblIdForn.Size = new System.Drawing.Size(64, 18);
            this.lblIdForn.TabIndex = 6;
            this.lblIdForn.Text = "Código:";
            // 
            // txtBairroFornecedor
            // 
            this.txtBairroFornecedor.Font = new System.Drawing.Font("Arial", 12F);
            this.txtBairroFornecedor.Location = new System.Drawing.Point(403, 150);
            this.txtBairroFornecedor.Name = "txtBairroFornecedor";
            this.txtBairroFornecedor.Size = new System.Drawing.Size(301, 26);
            this.txtBairroFornecedor.TabIndex = 6;
            // 
            // txtNumEndFornecedor
            // 
            this.txtNumEndFornecedor.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNumEndFornecedor.Location = new System.Drawing.Point(345, 150);
            this.txtNumEndFornecedor.Name = "txtNumEndFornecedor";
            this.txtNumEndFornecedor.Size = new System.Drawing.Size(52, 26);
            this.txtNumEndFornecedor.TabIndex = 5;
            // 
            // txtEndFornecedor
            // 
            this.txtEndFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndFornecedor.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEndFornecedor.Location = new System.Drawing.Point(11, 150);
            this.txtEndFornecedor.Name = "txtEndFornecedor";
            this.txtEndFornecedor.Size = new System.Drawing.Size(331, 26);
            this.txtEndFornecedor.TabIndex = 4;
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFornecedor.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNomeFornecedor.Location = new System.Drawing.Point(11, 91);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(331, 26);
            this.txtNomeFornecedor.TabIndex = 1;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Arial", 12F);
            this.lblBairro.Location = new System.Drawing.Point(400, 129);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(55, 18);
            this.lblBairro.TabIndex = 3;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEndereco.Location = new System.Drawing.Point(8, 129);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(80, 18);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblNomeForn
            // 
            this.lblNomeForn.AutoSize = true;
            this.lblNomeForn.Font = new System.Drawing.Font("Arial", 12F);
            this.lblNomeForn.Location = new System.Drawing.Point(8, 70);
            this.lblNomeForn.Name = "lblNomeForn";
            this.lblNomeForn.Size = new System.Drawing.Size(54, 18);
            this.lblNomeForn.TabIndex = 0;
            this.lblNomeForn.Text = "Nome:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddFornecedor,
            this.tsbtnEditFornecedor,
            this.tsbtnSalvar,
            this.tsbtnCancelar,
            this.toolStripSeparator,
            this.tsbtnImprimir,
            this.toolStripSeparator1,
            this.tsbtnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(983, 29);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "tsFornecedor";
            // 
            // tsbtnAddFornecedor
            // 
            this.tsbtnAddFornecedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddFornecedor.Image")));
            this.tsbtnAddFornecedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddFornecedor.Name = "tsbtnAddFornecedor";
            this.tsbtnAddFornecedor.Size = new System.Drawing.Size(26, 26);
            this.tsbtnAddFornecedor.Text = "Novo";
            this.tsbtnAddFornecedor.Click += new System.EventHandler(this.tsbtnAddFornecedor_Click);
            // 
            // tsbtnEditFornecedor
            // 
            this.tsbtnEditFornecedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEditFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditFornecedor.Image")));
            this.tsbtnEditFornecedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditFornecedor.Name = "tsbtnEditFornecedor";
            this.tsbtnEditFornecedor.Size = new System.Drawing.Size(26, 26);
            this.tsbtnEditFornecedor.Text = "Editar";
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
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(12, 35);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisa.TabIndex = 17;
            this.lblPesquisa.Text = "Pesquisar:";
            // 
            // FrmFornecedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.pnlFornecedor);
            this.KeyPreview = true;
            this.Name = "FrmFornecedor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFornecedor_KeyDown);
            this.pnlFornecedor.ResumeLayout(false);
            this.pnlFornecedor.PerformLayout();
            this.tcFornecedores.ResumeLayout(false);
            this.tpFornecedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlConnectionBindingSource)).EndInit();
            this.tpDados.ResumeLayout(false);
            this.tpDados.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFornecedor;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TabControl tcFornecedores;
        private System.Windows.Forms.TabPage tpFornecedor;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.TabPage tpDados;
        private System.Windows.Forms.Label lnlNumEnd;
        private System.Windows.Forms.MaskedTextBox mtxCNPJ;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblIE;
        private System.Windows.Forms.TextBox txtIdFornecedor;
        private System.Windows.Forms.Label lblIdForn;
        private System.Windows.Forms.TextBox txtBairroFornecedor;
        private System.Windows.Forms.TextBox txtNumEndFornecedor;
        private System.Windows.Forms.TextBox txtEndFornecedor;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNomeForn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAddFornecedor;
        private System.Windows.Forms.ToolStripButton tsbtnEditFornecedor;
        private System.Windows.Forms.ToolStripButton tsbtnSalvar;
        private System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.RadioButton rdoInativo;
        private System.Windows.Forms.RadioButton rdoAtivo;
        private System.Windows.Forms.TextBox txtIe;
        private System.Windows.Forms.BindingSource mySqlConnectionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionTimeoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionStringDataGridViewTextBoxColumn;
    }
}