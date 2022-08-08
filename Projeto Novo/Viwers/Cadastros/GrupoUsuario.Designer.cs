namespace Projeto_Novo
{
    partial class FrmGrupoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrupoUsuario));
            this.pnlGrupoUsu = new System.Windows.Forms.Panel();
            this.rdoInativo = new System.Windows.Forms.RadioButton();
            this.rdoAtivo = new System.Windows.Forms.RadioButton();
            this.rdoTodos = new System.Windows.Forms.RadioButton();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.tsGrupoUsu = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddGrupoUSu = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditGrupoUsu = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.tcGrupoUsuarios = new System.Windows.Forms.TabControl();
            this.tpGrupoUsuario = new System.Windows.Forms.TabPage();
            this.dgvGpUsuarios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionTimeoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mySqlConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpDadosUsu = new System.Windows.Forms.TabPage();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtDescTipoUsu = new System.Windows.Forms.TextBox();
            this.txtIdGpUsuario = new System.Windows.Forms.TextBox();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.lblDescTipoUsu = new System.Windows.Forms.Label();
            this.tbPemissoes = new System.Windows.Forms.TabPage();
            this.dgvPermUsu = new System.Windows.Forms.DataGridView();
            this.pnlGrupoUsu.SuspendLayout();
            this.tsGrupoUsu.SuspendLayout();
            this.tcGrupoUsuarios.SuspendLayout();
            this.tpGrupoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGpUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlConnectionBindingSource)).BeginInit();
            this.tpDadosUsu.SuspendLayout();
            this.tbPemissoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGrupoUsu
            // 
            this.pnlGrupoUsu.Controls.Add(this.rdoInativo);
            this.pnlGrupoUsu.Controls.Add(this.rdoAtivo);
            this.pnlGrupoUsu.Controls.Add(this.rdoTodos);
            this.pnlGrupoUsu.Controls.Add(this.lblPesquisa);
            this.pnlGrupoUsu.Controls.Add(this.txtPesquisa);
            this.pnlGrupoUsu.Controls.Add(this.tsGrupoUsu);
            this.pnlGrupoUsu.Controls.Add(this.tcGrupoUsuarios);
            this.pnlGrupoUsu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrupoUsu.Location = new System.Drawing.Point(0, 0);
            this.pnlGrupoUsu.Name = "pnlGrupoUsu";
            this.pnlGrupoUsu.Size = new System.Drawing.Size(983, 590);
            this.pnlGrupoUsu.TabIndex = 0;
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
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(76, 32);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(257, 20);
            this.txtPesquisa.TabIndex = 12;
            this.txtPesquisa.TabStop = false;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // tsGrupoUsu
            // 
            this.tsGrupoUsu.BackColor = System.Drawing.SystemColors.Control;
            this.tsGrupoUsu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsGrupoUsu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsGrupoUsu.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.tsGrupoUsu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddGrupoUSu,
            this.tsbtnEditGrupoUsu,
            this.tsbtnSalvar,
            this.tsbtnCancelar,
            this.toolStripSeparator,
            this.tsbtnImprimir,
            this.toolStripSeparator1,
            this.tsbtnSair});
            this.tsGrupoUsu.Location = new System.Drawing.Point(0, 0);
            this.tsGrupoUsu.Name = "tsGrupoUsu";
            this.tsGrupoUsu.Size = new System.Drawing.Size(983, 29);
            this.tsGrupoUsu.TabIndex = 11;
            this.tsGrupoUsu.Text = "Grupo Usuario";
            // 
            // tsbtnAddGrupoUSu
            // 
            this.tsbtnAddGrupoUSu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddGrupoUSu.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddGrupoUSu.Image")));
            this.tsbtnAddGrupoUSu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddGrupoUSu.Name = "tsbtnAddGrupoUSu";
            this.tsbtnAddGrupoUSu.Size = new System.Drawing.Size(26, 26);
            this.tsbtnAddGrupoUSu.Text = "Novo";
            this.tsbtnAddGrupoUSu.Click += new System.EventHandler(this.tsbtnAddGrupoUSu_Click);
            // 
            // tsbtnEditGrupoUsu
            // 
            this.tsbtnEditGrupoUsu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEditGrupoUsu.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditGrupoUsu.Image")));
            this.tsbtnEditGrupoUsu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditGrupoUsu.Name = "tsbtnEditGrupoUsu";
            this.tsbtnEditGrupoUsu.Size = new System.Drawing.Size(26, 26);
            this.tsbtnEditGrupoUsu.Text = "Editar";
            this.tsbtnEditGrupoUsu.Click += new System.EventHandler(this.tsbtnEditGrupoUsu_Click);
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
            // tcGrupoUsuarios
            // 
            this.tcGrupoUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcGrupoUsuarios.Controls.Add(this.tpGrupoUsuario);
            this.tcGrupoUsuarios.Controls.Add(this.tpDadosUsu);
            this.tcGrupoUsuarios.Controls.Add(this.tbPemissoes);
            this.tcGrupoUsuarios.Location = new System.Drawing.Point(-1, 58);
            this.tcGrupoUsuarios.Multiline = true;
            this.tcGrupoUsuarios.Name = "tcGrupoUsuarios";
            this.tcGrupoUsuarios.SelectedIndex = 0;
            this.tcGrupoUsuarios.Size = new System.Drawing.Size(984, 532);
            this.tcGrupoUsuarios.TabIndex = 10;
            this.tcGrupoUsuarios.TabStop = false;
            // 
            // tpGrupoUsuario
            // 
            this.tpGrupoUsuario.Controls.Add(this.dgvGpUsuarios);
            this.tpGrupoUsuario.Location = new System.Drawing.Point(4, 22);
            this.tpGrupoUsuario.Name = "tpGrupoUsuario";
            this.tpGrupoUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tpGrupoUsuario.Size = new System.Drawing.Size(976, 506);
            this.tpGrupoUsuario.TabIndex = 0;
            this.tpGrupoUsuario.Text = "Tipo Usuario";
            this.tpGrupoUsuario.UseVisualStyleBackColor = true;
            // 
            // dgvGpUsuarios
            // 
            this.dgvGpUsuarios.AllowUserToAddRows = false;
            this.dgvGpUsuarios.AllowUserToDeleteRows = false;
            this.dgvGpUsuarios.AllowUserToOrderColumns = true;
            this.dgvGpUsuarios.AutoGenerateColumns = false;
            this.dgvGpUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvGpUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGpUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.dataSourceDataGridViewTextBoxColumn,
            this.connectionTimeoutDataGridViewTextBoxColumn,
            this.databaseDataGridViewTextBoxColumn,
            this.connectionStringDataGridViewTextBoxColumn});
            this.dgvGpUsuarios.DataSource = this.mySqlConnectionBindingSource;
            this.dgvGpUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGpUsuarios.Location = new System.Drawing.Point(3, 3);
            this.dgvGpUsuarios.Name = "dgvGpUsuarios";
            this.dgvGpUsuarios.ReadOnly = true;
            this.dgvGpUsuarios.RowHeadersWidth = 12;
            this.dgvGpUsuarios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGpUsuarios.Size = new System.Drawing.Size(970, 500);
            this.dgvGpUsuarios.TabIndex = 2;
            this.dgvGpUsuarios.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGpUsuarios_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "descricao";
            this.Column2.HeaderText = "Descrição";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ativo";
            this.Column3.HeaderText = "Ativo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
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
            // tpDadosUsu
            // 
            this.tpDadosUsu.Controls.Add(this.chkAtivo);
            this.tpDadosUsu.Controls.Add(this.txtDescTipoUsu);
            this.tpDadosUsu.Controls.Add(this.txtIdGpUsuario);
            this.tpDadosUsu.Controls.Add(this.lblIdCli);
            this.tpDadosUsu.Controls.Add(this.lblDescTipoUsu);
            this.tpDadosUsu.Location = new System.Drawing.Point(4, 22);
            this.tpDadosUsu.Name = "tpDadosUsu";
            this.tpDadosUsu.Padding = new System.Windows.Forms.Padding(3);
            this.tpDadosUsu.Size = new System.Drawing.Size(976, 506);
            this.tpDadosUsu.TabIndex = 1;
            this.tpDadosUsu.Text = "Dados";
            this.tpDadosUsu.UseVisualStyleBackColor = true;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkAtivo.Location = new System.Drawing.Point(309, 37);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(58, 21);
            this.chkAtivo.TabIndex = 2;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtDescTipoUsu
            // 
            this.txtDescTipoUsu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescTipoUsu.Enabled = false;
            this.txtDescTipoUsu.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDescTipoUsu.Location = new System.Drawing.Point(11, 91);
            this.txtDescTipoUsu.Name = "txtDescTipoUsu";
            this.txtDescTipoUsu.Size = new System.Drawing.Size(356, 26);
            this.txtDescTipoUsu.TabIndex = 1;
            // 
            // txtIdGpUsuario
            // 
            this.txtIdGpUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtIdGpUsuario.Enabled = false;
            this.txtIdGpUsuario.Font = new System.Drawing.Font("Arial", 12F);
            this.txtIdGpUsuario.Location = new System.Drawing.Point(11, 34);
            this.txtIdGpUsuario.Name = "txtIdGpUsuario";
            this.txtIdGpUsuario.Size = new System.Drawing.Size(77, 26);
            this.txtIdGpUsuario.TabIndex = 0;
            this.txtIdGpUsuario.TabStop = false;
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
            // lblDescTipoUsu
            // 
            this.lblDescTipoUsu.AutoSize = true;
            this.lblDescTipoUsu.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDescTipoUsu.Location = new System.Drawing.Point(8, 70);
            this.lblDescTipoUsu.Name = "lblDescTipoUsu";
            this.lblDescTipoUsu.Size = new System.Drawing.Size(84, 18);
            this.lblDescTipoUsu.TabIndex = 0;
            this.lblDescTipoUsu.Text = "Descrição:";
            // 
            // tbPemissoes
            // 
            this.tbPemissoes.Controls.Add(this.dgvPermUsu);
            this.tbPemissoes.Location = new System.Drawing.Point(4, 22);
            this.tbPemissoes.Name = "tbPemissoes";
            this.tbPemissoes.Padding = new System.Windows.Forms.Padding(3);
            this.tbPemissoes.Size = new System.Drawing.Size(976, 506);
            this.tbPemissoes.TabIndex = 2;
            this.tbPemissoes.Text = "Permissões";
            this.tbPemissoes.UseVisualStyleBackColor = true;
            // 
            // dgvPermUsu
            // 
            this.dgvPermUsu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPermUsu.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvPermUsu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPermUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermUsu.Location = new System.Drawing.Point(0, 0);
            this.dgvPermUsu.Name = "dgvPermUsu";
            this.dgvPermUsu.Size = new System.Drawing.Size(660, 530);
            this.dgvPermUsu.TabIndex = 0;
            // 
            // FrmGrupoUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.pnlGrupoUsu);
            this.KeyPreview = true;
            this.Name = "FrmGrupoUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Grupo de Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGrupoUsuario_KeyDown);
            this.pnlGrupoUsu.ResumeLayout(false);
            this.pnlGrupoUsu.PerformLayout();
            this.tsGrupoUsu.ResumeLayout(false);
            this.tsGrupoUsu.PerformLayout();
            this.tcGrupoUsuarios.ResumeLayout(false);
            this.tpGrupoUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGpUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlConnectionBindingSource)).EndInit();
            this.tpDadosUsu.ResumeLayout(false);
            this.tpDadosUsu.PerformLayout();
            this.tbPemissoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermUsu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrupoUsu;
        private System.Windows.Forms.ToolStrip tsGrupoUsu;
        private System.Windows.Forms.ToolStripButton tsbtnAddGrupoUSu;
        private System.Windows.Forms.ToolStripButton tsbtnEditGrupoUsu;
        private System.Windows.Forms.ToolStripButton tsbtnSalvar;
        private System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.TabControl tcGrupoUsuarios;
        private System.Windows.Forms.TabPage tpGrupoUsuario;
        private System.Windows.Forms.DataGridView dgvGpUsuarios;
        private System.Windows.Forms.TabPage tpDadosUsu;
        private System.Windows.Forms.TextBox txtDescTipoUsu;
        private System.Windows.Forms.TextBox txtIdGpUsuario;
        private System.Windows.Forms.Label lblIdCli;
        private System.Windows.Forms.Label lblDescTipoUsu;
        private System.Windows.Forms.TabPage tbPemissoes;
        private System.Windows.Forms.DataGridView dgvPermUsu;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.BindingSource mySqlConnectionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionTimeoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton rdoInativo;
        private System.Windows.Forms.RadioButton rdoAtivo;
        private System.Windows.Forms.RadioButton rdoTodos;
        private System.Windows.Forms.CheckBox chkAtivo;
    }
}