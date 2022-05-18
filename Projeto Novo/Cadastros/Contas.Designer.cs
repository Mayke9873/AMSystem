namespace Projeto_Novo.Cadastros
{
    partial class FrmContas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContas));
            this.pnlContas = new System.Windows.Forms.Panel();
            this.rdoInativo = new System.Windows.Forms.RadioButton();
            this.rdoAtivo = new System.Windows.Forms.RadioButton();
            this.rdoTodos = new System.Windows.Forms.RadioButton();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.tcContas = new System.Windows.Forms.TabControl();
            this.tpConta = new System.Windows.Forms.TabPage();
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionTimeoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mySqlConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tpDadosConta = new System.Windows.Forms.TabPage();
            this.chkBanco = new System.Windows.Forms.CheckBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.lblDescGrupoProd = new System.Windows.Forms.Label();
            this.tsGrupoProduto = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddConta = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditConta = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.pnlContas.SuspendLayout();
            this.tcContas.SuspendLayout();
            this.tpConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlConnectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tpDadosConta.SuspendLayout();
            this.tsGrupoProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContas
            // 
            this.pnlContas.Controls.Add(this.rdoInativo);
            this.pnlContas.Controls.Add(this.rdoAtivo);
            this.pnlContas.Controls.Add(this.rdoTodos);
            this.pnlContas.Controls.Add(this.lblPesquisa);
            this.pnlContas.Controls.Add(this.txtPesquisa);
            this.pnlContas.Controls.Add(this.tcContas);
            this.pnlContas.Controls.Add(this.tsGrupoProduto);
            this.pnlContas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContas.Location = new System.Drawing.Point(0, 0);
            this.pnlContas.Name = "pnlContas";
            this.pnlContas.Size = new System.Drawing.Size(983, 590);
            this.pnlContas.TabIndex = 1;
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
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(12, 35);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisa.TabIndex = 11;
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
            this.txtPesquisa.TabIndex = 10;
            this.txtPesquisa.TabStop = false;
            // 
            // tcContas
            // 
            this.tcContas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcContas.Controls.Add(this.tpConta);
            this.tcContas.Controls.Add(this.tpDadosConta);
            this.tcContas.Location = new System.Drawing.Point(-1, 58);
            this.tcContas.Multiline = true;
            this.tcContas.Name = "tcContas";
            this.tcContas.SelectedIndex = 0;
            this.tcContas.Size = new System.Drawing.Size(984, 532);
            this.tcContas.TabIndex = 8;
            this.tcContas.TabStop = false;
            // 
            // tpConta
            // 
            this.tpConta.Controls.Add(this.dgvContas);
            this.tpConta.Controls.Add(this.dgvClientes);
            this.tpConta.Location = new System.Drawing.Point(4, 22);
            this.tpConta.Name = "tpConta";
            this.tpConta.Padding = new System.Windows.Forms.Padding(3);
            this.tpConta.Size = new System.Drawing.Size(976, 506);
            this.tpConta.TabIndex = 0;
            this.tpConta.Text = "Contas";
            this.tpConta.UseVisualStyleBackColor = true;
            // 
            // dgvContas
            // 
            this.dgvContas.AllowUserToAddRows = false;
            this.dgvContas.AllowUserToDeleteRows = false;
            this.dgvContas.AllowUserToOrderColumns = true;
            this.dgvContas.AutoGenerateColumns = false;
            this.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.dataSourceDataGridViewTextBoxColumn,
            this.connectionTimeoutDataGridViewTextBoxColumn,
            this.databaseDataGridViewTextBoxColumn,
            this.connectionStringDataGridViewTextBoxColumn});
            this.dgvContas.DataSource = this.mySqlConnectionBindingSource;
            this.dgvContas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContas.Location = new System.Drawing.Point(3, 3);
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.ReadOnly = true;
            this.dgvContas.RowHeadersWidth = 12;
            this.dgvContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContas.Size = new System.Drawing.Size(970, 500);
            this.dgvContas.TabIndex = 2;
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
            // Column4
            // 
            this.Column4.DataPropertyName = "banco";
            this.Column4.HeaderText = "Banco";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
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
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(3, 3);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(970, 500);
            this.dgvClientes.TabIndex = 0;
            // 
            // tpDadosConta
            // 
            this.tpDadosConta.Controls.Add(this.chkAtivo);
            this.tpDadosConta.Controls.Add(this.chkBanco);
            this.tpDadosConta.Controls.Add(this.txtDescricao);
            this.tpDadosConta.Controls.Add(this.txtIdUsuario);
            this.tpDadosConta.Controls.Add(this.lblIdCli);
            this.tpDadosConta.Controls.Add(this.lblDescGrupoProd);
            this.tpDadosConta.Location = new System.Drawing.Point(4, 22);
            this.tpDadosConta.Name = "tpDadosConta";
            this.tpDadosConta.Padding = new System.Windows.Forms.Padding(3);
            this.tpDadosConta.Size = new System.Drawing.Size(976, 506);
            this.tpDadosConta.TabIndex = 1;
            this.tpDadosConta.Text = "Dados";
            this.tpDadosConta.UseVisualStyleBackColor = true;
            // 
            // chkBanco
            // 
            this.chkBanco.AutoSize = true;
            this.chkBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkBanco.Location = new System.Drawing.Point(12, 139);
            this.chkBanco.Name = "chkBanco";
            this.chkBanco.Size = new System.Drawing.Size(124, 21);
            this.chkBanco.TabIndex = 5;
            this.chkBanco.Text = "Conta Bancária";
            this.chkBanco.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(11, 91);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(356, 26);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtIdUsuario.Enabled = false;
            this.txtIdUsuario.Font = new System.Drawing.Font("Arial", 12F);
            this.txtIdUsuario.Location = new System.Drawing.Point(11, 34);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(77, 26);
            this.txtIdUsuario.TabIndex = 0;
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
            // lblDescGrupoProd
            // 
            this.lblDescGrupoProd.AutoSize = true;
            this.lblDescGrupoProd.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDescGrupoProd.Location = new System.Drawing.Point(8, 70);
            this.lblDescGrupoProd.Name = "lblDescGrupoProd";
            this.lblDescGrupoProd.Size = new System.Drawing.Size(84, 18);
            this.lblDescGrupoProd.TabIndex = 0;
            this.lblDescGrupoProd.Text = "Descrição:";
            // 
            // tsGrupoProduto
            // 
            this.tsGrupoProduto.BackColor = System.Drawing.SystemColors.Control;
            this.tsGrupoProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsGrupoProduto.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsGrupoProduto.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.tsGrupoProduto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddConta,
            this.tsbtnEditConta,
            this.tsbtnSalvar,
            this.tsbtnCancelar,
            this.toolStripSeparator,
            this.tsbtnImprimir,
            this.toolStripSeparator1,
            this.tsbtnSair});
            this.tsGrupoProduto.Location = new System.Drawing.Point(0, 0);
            this.tsGrupoProduto.Name = "tsGrupoProduto";
            this.tsGrupoProduto.Size = new System.Drawing.Size(983, 29);
            this.tsGrupoProduto.TabIndex = 9;
            this.tsGrupoProduto.Text = "toolStrip1";
            // 
            // tsbtnAddConta
            // 
            this.tsbtnAddConta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddConta.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddConta.Image")));
            this.tsbtnAddConta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddConta.Name = "tsbtnAddConta";
            this.tsbtnAddConta.Size = new System.Drawing.Size(26, 26);
            this.tsbtnAddConta.Text = "Novo";
            this.tsbtnAddConta.Click += new System.EventHandler(this.tsbtnAddConta_Click);
            // 
            // tsbtnEditConta
            // 
            this.tsbtnEditConta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEditConta.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditConta.Image")));
            this.tsbtnEditConta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditConta.Name = "tsbtnEditConta";
            this.tsbtnEditConta.Size = new System.Drawing.Size(26, 26);
            this.tsbtnEditConta.Text = "Editar";
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
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkAtivo.Location = new System.Drawing.Point(309, 37);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(58, 21);
            this.chkAtivo.TabIndex = 23;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // FrmContas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.pnlContas);
            this.KeyPreview = true;
            this.Name = "FrmContas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmContas_KeyDown);
            this.pnlContas.ResumeLayout(false);
            this.pnlContas.PerformLayout();
            this.tcContas.ResumeLayout(false);
            this.tpConta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlConnectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tpDadosConta.ResumeLayout(false);
            this.tpDadosConta.PerformLayout();
            this.tsGrupoProduto.ResumeLayout(false);
            this.tsGrupoProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContas;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TabControl tcContas;
        private System.Windows.Forms.TabPage tpConta;
        private System.Windows.Forms.DataGridView dgvContas;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TabPage tpDadosConta;
        private System.Windows.Forms.CheckBox chkBanco;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label lblIdCli;
        private System.Windows.Forms.Label lblDescGrupoProd;
        private System.Windows.Forms.ToolStrip tsGrupoProduto;
        private System.Windows.Forms.ToolStripButton tsbtnAddConta;
        private System.Windows.Forms.ToolStripButton tsbtnEditConta;
        private System.Windows.Forms.ToolStripButton tsbtnSalvar;
        private System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.BindingSource mySqlConnectionBindingSource;
        private System.Windows.Forms.RadioButton rdoInativo;
        private System.Windows.Forms.RadioButton rdoAtivo;
        private System.Windows.Forms.RadioButton rdoTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionTimeoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox chkAtivo;
    }
}