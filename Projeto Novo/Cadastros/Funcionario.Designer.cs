namespace Projeto_Novo
{
    partial class FrmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionario));
            this.pnlFuncionario = new System.Windows.Forms.Panel();
            this.rdoInativo = new System.Windows.Forms.RadioButton();
            this.rdoAtivo = new System.Windows.Forms.RadioButton();
            this.rdoTodos = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.tcFuncionarios = new System.Windows.Forms.TabControl();
            this.tpFuncionario = new System.Windows.Forms.TabPage();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionTimeoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mySqlConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpDados = new System.Windows.Forms.TabPage();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.gpUsuario = new System.Windows.Forms.GroupBox();
            this.cbGpUsu = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lnlNumEnd = new System.Windows.Forms.Label();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxRG = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdFuncionario = new System.Windows.Forms.TextBox();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumEnd = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.mtxDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddFuncionario = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditFuncionario = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.pnlFuncionario.SuspendLayout();
            this.tcFuncionarios.SuspendLayout();
            this.tpFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlConnectionBindingSource)).BeginInit();
            this.tpDados.SuspendLayout();
            this.gpUsuario.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFuncionario
            // 
            this.pnlFuncionario.Controls.Add(this.rdoInativo);
            this.pnlFuncionario.Controls.Add(this.rdoAtivo);
            this.pnlFuncionario.Controls.Add(this.rdoTodos);
            this.pnlFuncionario.Controls.Add(this.txtPesquisa);
            this.pnlFuncionario.Controls.Add(this.tcFuncionarios);
            this.pnlFuncionario.Controls.Add(this.lblPesquisa);
            this.pnlFuncionario.Controls.Add(this.toolStrip1);
            this.pnlFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFuncionario.Location = new System.Drawing.Point(0, 0);
            this.pnlFuncionario.Name = "pnlFuncionario";
            this.pnlFuncionario.Size = new System.Drawing.Size(983, 590);
            this.pnlFuncionario.TabIndex = 0;
            // 
            // rdoInativo
            // 
            this.rdoInativo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoInativo.AutoSize = true;
            this.rdoInativo.Location = new System.Drawing.Point(558, 33);
            this.rdoInativo.Name = "rdoInativo";
            this.rdoInativo.Size = new System.Drawing.Size(57, 17);
            this.rdoInativo.TabIndex = 23;
            this.rdoInativo.Text = "Inativo";
            this.rdoInativo.UseVisualStyleBackColor = true;
            this.rdoInativo.CheckedChanged += new System.EventHandler(this.rdoInativo_CheckedChanged);
            // 
            // rdoAtivo
            // 
            this.rdoAtivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoAtivo.AutoSize = true;
            this.rdoAtivo.Checked = true;
            this.rdoAtivo.Location = new System.Drawing.Point(489, 33);
            this.rdoAtivo.Name = "rdoAtivo";
            this.rdoAtivo.Size = new System.Drawing.Size(49, 17);
            this.rdoAtivo.TabIndex = 22;
            this.rdoAtivo.TabStop = true;
            this.rdoAtivo.Text = "Ativo";
            this.rdoAtivo.UseVisualStyleBackColor = true;
            this.rdoAtivo.CheckedChanged += new System.EventHandler(this.rdoAtivo_CheckedChanged);
            // 
            // rdoTodos
            // 
            this.rdoTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoTodos.AutoSize = true;
            this.rdoTodos.Location = new System.Drawing.Point(416, 33);
            this.rdoTodos.Name = "rdoTodos";
            this.rdoTodos.Size = new System.Drawing.Size(55, 17);
            this.rdoTodos.TabIndex = 21;
            this.rdoTodos.TabStop = true;
            this.rdoTodos.Text = "Todos";
            this.rdoTodos.UseVisualStyleBackColor = true;
            this.rdoTodos.CheckedChanged += new System.EventHandler(this.rdoTodos_CheckedChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(76, 32);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(257, 20);
            this.txtPesquisa.TabIndex = 16;
            this.txtPesquisa.TabStop = false;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // tcFuncionarios
            // 
            this.tcFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcFuncionarios.Controls.Add(this.tpFuncionario);
            this.tcFuncionarios.Controls.Add(this.tpDados);
            this.tcFuncionarios.Location = new System.Drawing.Point(-1, 58);
            this.tcFuncionarios.Multiline = true;
            this.tcFuncionarios.Name = "tcFuncionarios";
            this.tcFuncionarios.SelectedIndex = 0;
            this.tcFuncionarios.Size = new System.Drawing.Size(984, 532);
            this.tcFuncionarios.TabIndex = 0;
            this.tcFuncionarios.TabStop = false;
            // 
            // tpFuncionario
            // 
            this.tpFuncionario.Controls.Add(this.dgvFuncionario);
            this.tpFuncionario.Location = new System.Drawing.Point(4, 22);
            this.tpFuncionario.Name = "tpFuncionario";
            this.tpFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tpFuncionario.Size = new System.Drawing.Size(976, 506);
            this.tpFuncionario.TabIndex = 0;
            this.tpFuncionario.Text = "Funcionário";
            this.tpFuncionario.UseVisualStyleBackColor = true;
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            this.dgvFuncionario.AllowUserToOrderColumns = true;
            this.dgvFuncionario.AllowUserToResizeRows = false;
            this.dgvFuncionario.AutoGenerateColumns = false;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.dataSourceDataGridViewTextBoxColumn,
            this.connectionTimeoutDataGridViewTextBoxColumn,
            this.databaseDataGridViewTextBoxColumn,
            this.connectionStringDataGridViewTextBoxColumn});
            this.dgvFuncionario.DataSource = this.mySqlConnectionBindingSource;
            this.dgvFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFuncionario.Location = new System.Drawing.Point(3, 3);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            this.dgvFuncionario.RowHeadersWidth = 12;
            this.dgvFuncionario.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionario.Size = new System.Drawing.Size(970, 500);
            this.dgvFuncionario.TabIndex = 2;
            this.dgvFuncionario.TabStop = false;
            this.dgvFuncionario.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nome";
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "rg";
            this.Column3.HeaderText = "RG";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "cpf";
            this.Column4.HeaderText = "CPF";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "dtNasc";
            this.Column5.HeaderText = "Nascimento";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "endereco";
            this.Column6.HeaderText = "Endereço";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "numEndereco";
            this.Column7.HeaderText = "Nº";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "bairro";
            this.Column8.HeaderText = "Bairro";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "dtRegistro";
            this.Column9.HeaderText = "Dt Registro";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "ativo";
            this.Column10.HeaderText = "Ativo";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
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
            this.tpDados.Controls.Add(this.chkAtivo);
            this.tpDados.Controls.Add(this.gpUsuario);
            this.tpDados.Controls.Add(this.lnlNumEnd);
            this.tpDados.Controls.Add(this.mtxCPF);
            this.tpDados.Controls.Add(this.label2);
            this.tpDados.Controls.Add(this.mtxRG);
            this.tpDados.Controls.Add(this.label1);
            this.tpDados.Controls.Add(this.txtIdFuncionario);
            this.tpDados.Controls.Add(this.lblIdCli);
            this.tpDados.Controls.Add(this.txtBairro);
            this.tpDados.Controls.Add(this.txtNumEnd);
            this.tpDados.Controls.Add(this.txtEnd);
            this.tpDados.Controls.Add(this.mtxDtNasc);
            this.tpDados.Controls.Add(this.txtNome);
            this.tpDados.Controls.Add(this.lblBairro);
            this.tpDados.Controls.Add(this.lblEndereco);
            this.tpDados.Controls.Add(this.lblDtNasc);
            this.tpDados.Controls.Add(this.lblNomeCli);
            this.tpDados.Location = new System.Drawing.Point(4, 22);
            this.tpDados.Name = "tpDados";
            this.tpDados.Padding = new System.Windows.Forms.Padding(3);
            this.tpDados.Size = new System.Drawing.Size(976, 506);
            this.tpDados.TabIndex = 2;
            this.tpDados.Text = "Dados";
            this.tpDados.UseVisualStyleBackColor = true;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkAtivo.Location = new System.Drawing.Point(283, 37);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(58, 21);
            this.chkAtivo.TabIndex = 24;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // gpUsuario
            // 
            this.gpUsuario.Controls.Add(this.cbGpUsu);
            this.gpUsuario.Controls.Add(this.lblCargo);
            this.gpUsuario.Controls.Add(this.txtLogin);
            this.gpUsuario.Controls.Add(this.lblUsuario);
            this.gpUsuario.Controls.Add(this.txtSenha);
            this.gpUsuario.Controls.Add(this.lblSenha);
            this.gpUsuario.Enabled = false;
            this.gpUsuario.Font = new System.Drawing.Font("Arial", 12F);
            this.gpUsuario.Location = new System.Drawing.Point(12, 201);
            this.gpUsuario.Name = "gpUsuario";
            this.gpUsuario.Size = new System.Drawing.Size(450, 140);
            this.gpUsuario.TabIndex = 14;
            this.gpUsuario.TabStop = false;
            this.gpUsuario.Text = "Usuário";
            // 
            // cbGpUsu
            // 
            this.cbGpUsu.Font = new System.Drawing.Font("Arial", 12F);
            this.cbGpUsu.FormattingEnabled = true;
            this.cbGpUsu.Location = new System.Drawing.Point(200, 48);
            this.cbGpUsu.Name = "cbGpUsu";
            this.cbGpUsu.Size = new System.Drawing.Size(240, 26);
            this.cbGpUsu.TabIndex = 10;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCargo.Location = new System.Drawing.Point(197, 27);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(132, 18);
            this.lblCargo.TabIndex = 9;
            this.lblCargo.Text = "Grupo de usuario:";
            // 
            // txtLogin
            // 
            this.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogin.Font = new System.Drawing.Font("Arial", 12F);
            this.txtLogin.Location = new System.Drawing.Point(12, 48);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(150, 26);
            this.txtLogin.TabIndex = 8;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F);
            this.lblUsuario.Location = new System.Drawing.Point(9, 27);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(66, 18);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSenha.Location = new System.Drawing.Point(12, 98);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(150, 26);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSenha.Location = new System.Drawing.Point(9, 77);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 18);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha:";
            // 
            // lnlNumEnd
            // 
            this.lnlNumEnd.AutoSize = true;
            this.lnlNumEnd.Font = new System.Drawing.Font("Arial", 12F);
            this.lnlNumEnd.Location = new System.Drawing.Point(342, 129);
            this.lnlNumEnd.Name = "lnlNumEnd";
            this.lnlNumEnd.Size = new System.Drawing.Size(28, 18);
            this.lnlNumEnd.TabIndex = 11;
            this.lnlNumEnd.Text = "Nº:";
            // 
            // mtxCPF
            // 
            this.mtxCPF.Enabled = false;
            this.mtxCPF.Font = new System.Drawing.Font("Arial", 12F);
            this.mtxCPF.Location = new System.Drawing.Point(468, 91);
            this.mtxCPF.Mask = "000,000,000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(130, 26);
            this.mtxCPF.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(465, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "CPF:";
            // 
            // mtxRG
            // 
            this.mtxRG.Enabled = false;
            this.mtxRG.Font = new System.Drawing.Font("Arial", 12F);
            this.mtxRG.Location = new System.Drawing.Point(348, 91);
            this.mtxRG.Mask = "00,000,000-0";
            this.mtxRG.Name = "mtxRG";
            this.mtxRG.Size = new System.Drawing.Size(114, 26);
            this.mtxRG.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(345, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "RG:";
            // 
            // txtIdFuncionario
            // 
            this.txtIdFuncionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtIdFuncionario.Enabled = false;
            this.txtIdFuncionario.Font = new System.Drawing.Font("Arial", 12F);
            this.txtIdFuncionario.Location = new System.Drawing.Point(11, 34);
            this.txtIdFuncionario.Name = "txtIdFuncionario";
            this.txtIdFuncionario.Size = new System.Drawing.Size(77, 26);
            this.txtIdFuncionario.TabIndex = 0;
            this.txtIdFuncionario.TabStop = false;
            // 
            // lblIdCli
            // 
            this.lblIdCli.AutoSize = true;
            this.lblIdCli.Font = new System.Drawing.Font("Arial", 12F);
            this.lblIdCli.Location = new System.Drawing.Point(8, 13);
            this.lblIdCli.Name = "lblIdCli";
            this.lblIdCli.Size = new System.Drawing.Size(64, 18);
            this.lblIdCli.TabIndex = 6;
            this.lblIdCli.Text = "Código:";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Enabled = false;
            this.txtBairro.Font = new System.Drawing.Font("Arial", 12F);
            this.txtBairro.Location = new System.Drawing.Point(403, 150);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(301, 26);
            this.txtBairro.TabIndex = 7;
            // 
            // txtNumEnd
            // 
            this.txtNumEnd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumEnd.Enabled = false;
            this.txtNumEnd.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNumEnd.Location = new System.Drawing.Point(345, 150);
            this.txtNumEnd.Name = "txtNumEnd";
            this.txtNumEnd.Size = new System.Drawing.Size(52, 26);
            this.txtNumEnd.TabIndex = 6;
            // 
            // txtEnd
            // 
            this.txtEnd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnd.Enabled = false;
            this.txtEnd.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEnd.Location = new System.Drawing.Point(11, 150);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(331, 26);
            this.txtEnd.TabIndex = 5;
            // 
            // mtxDtNasc
            // 
            this.mtxDtNasc.Enabled = false;
            this.mtxDtNasc.Font = new System.Drawing.Font("Arial", 12F);
            this.mtxDtNasc.Location = new System.Drawing.Point(604, 91);
            this.mtxDtNasc.Mask = "00/00/0000";
            this.mtxDtNasc.Name = "mtxDtNasc";
            this.mtxDtNasc.Size = new System.Drawing.Size(100, 26);
            this.mtxDtNasc.TabIndex = 4;
            this.mtxDtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNome.Location = new System.Drawing.Point(11, 91);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(331, 26);
            this.txtNome.TabIndex = 1;
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
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDtNasc.Location = new System.Drawing.Point(601, 70);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(68, 18);
            this.lblDtNasc.TabIndex = 1;
            this.lblDtNasc.Text = "Dt Nasc:";
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Font = new System.Drawing.Font("Arial", 12F);
            this.lblNomeCli.Location = new System.Drawing.Point(8, 70);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(54, 18);
            this.lblNomeCli.TabIndex = 0;
            this.lblNomeCli.Text = "Nome:";
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddFuncionario,
            this.tsbtnEditFuncionario,
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
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAddFuncionario
            // 
            this.tsbtnAddFuncionario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddFuncionario.Image")));
            this.tsbtnAddFuncionario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddFuncionario.Name = "tsbtnAddFuncionario";
            this.tsbtnAddFuncionario.Size = new System.Drawing.Size(26, 26);
            this.tsbtnAddFuncionario.Text = "Novo";
            this.tsbtnAddFuncionario.Click += new System.EventHandler(this.tsbtnAddFuncionario_Click);
            // 
            // tsbtnEditFuncionario
            // 
            this.tsbtnEditFuncionario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEditFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditFuncionario.Image")));
            this.tsbtnEditFuncionario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditFuncionario.Name = "tsbtnEditFuncionario";
            this.tsbtnEditFuncionario.Size = new System.Drawing.Size(26, 26);
            this.tsbtnEditFuncionario.Text = "Editar";
            this.tsbtnEditFuncionario.Click += new System.EventHandler(this.tsbtnEditFuncionario_Click);
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
            // FrmFuncionario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.pnlFuncionario);
            this.KeyPreview = true;
            this.Name = "FrmFuncionario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Funcionario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFuncionario_KeyDown);
            this.pnlFuncionario.ResumeLayout(false);
            this.pnlFuncionario.PerformLayout();
            this.tcFuncionarios.ResumeLayout(false);
            this.tpFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlConnectionBindingSource)).EndInit();
            this.tpDados.ResumeLayout(false);
            this.tpDados.PerformLayout();
            this.gpUsuario.ResumeLayout(false);
            this.gpUsuario.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFuncionario;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TabControl tcFuncionarios;
        private System.Windows.Forms.TabPage tpFuncionario;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.TabPage tpDados;
        private System.Windows.Forms.Label lnlNumEnd;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdFuncionario;
        private System.Windows.Forms.Label lblIdCli;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumEnd;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.MaskedTextBox mtxDtNasc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAddFuncionario;
        private System.Windows.Forms.ToolStripButton tsbtnEditFuncionario;
        private System.Windows.Forms.ToolStripButton tsbtnSalvar;
        private System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.MaskedTextBox mtxRG;
        private System.Windows.Forms.BindingSource mySqlConnectionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionTimeoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gpUsuario;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.ComboBox cbGpUsu;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.RadioButton rdoInativo;
        private System.Windows.Forms.RadioButton rdoAtivo;
        private System.Windows.Forms.RadioButton rdoTodos;
        private System.Windows.Forms.CheckBox chkAtivo;
    }
}