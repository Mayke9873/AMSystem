namespace Projeto_Novo
{
    partial class FrmGrupoProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrupoProdutos));
            this.tsGrupoProduto = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddGrupoProd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditGrupoProd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.tcGrupoProdutos = new System.Windows.Forms.TabControl();
            this.tpGrupoProdudo = new System.Windows.Forms.TabPage();
            this.dgvGrupoProd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionTimeoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mySqlConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpDadosGrupoProd = new System.Windows.Forms.TabPage();
            this.rdoInativo = new System.Windows.Forms.RadioButton();
            this.rdoAtivo = new System.Windows.Forms.RadioButton();
            this.txtDescGrupoProd = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.lblDescGrupoProd = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.pnlGrupoProdutos = new System.Windows.Forms.Panel();
            this.tsGrupoProduto.SuspendLayout();
            this.tcGrupoProdutos.SuspendLayout();
            this.tpGrupoProdudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlConnectionBindingSource)).BeginInit();
            this.tpDadosGrupoProd.SuspendLayout();
            this.pnlGrupoProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsGrupoProduto
            // 
            this.tsGrupoProduto.BackColor = System.Drawing.SystemColors.Control;
            this.tsGrupoProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsGrupoProduto.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsGrupoProduto.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.tsGrupoProduto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddGrupoProd,
            this.tsbtnEditGrupoProd,
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
            // tsbtnAddGrupoProd
            // 
            this.tsbtnAddGrupoProd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddGrupoProd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddGrupoProd.Image")));
            this.tsbtnAddGrupoProd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddGrupoProd.Name = "tsbtnAddGrupoProd";
            this.tsbtnAddGrupoProd.Size = new System.Drawing.Size(26, 26);
            this.tsbtnAddGrupoProd.Text = "Novo";
            this.tsbtnAddGrupoProd.Click += new System.EventHandler(this.tsbtnAddGrupoProd_Click);
            // 
            // tsbtnEditGrupoProd
            // 
            this.tsbtnEditGrupoProd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEditGrupoProd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditGrupoProd.Image")));
            this.tsbtnEditGrupoProd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditGrupoProd.Name = "tsbtnEditGrupoProd";
            this.tsbtnEditGrupoProd.Size = new System.Drawing.Size(26, 26);
            this.tsbtnEditGrupoProd.Text = "Editar";
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
            // tcGrupoProdutos
            // 
            this.tcGrupoProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcGrupoProdutos.Controls.Add(this.tpGrupoProdudo);
            this.tcGrupoProdutos.Controls.Add(this.tpDadosGrupoProd);
            this.tcGrupoProdutos.Location = new System.Drawing.Point(-1, 58);
            this.tcGrupoProdutos.Multiline = true;
            this.tcGrupoProdutos.Name = "tcGrupoProdutos";
            this.tcGrupoProdutos.SelectedIndex = 0;
            this.tcGrupoProdutos.Size = new System.Drawing.Size(984, 532);
            this.tcGrupoProdutos.TabIndex = 8;
            this.tcGrupoProdutos.TabStop = false;
            // 
            // tpGrupoProdudo
            // 
            this.tpGrupoProdudo.Controls.Add(this.dgvGrupoProd);
            this.tpGrupoProdudo.Location = new System.Drawing.Point(4, 22);
            this.tpGrupoProdudo.Name = "tpGrupoProdudo";
            this.tpGrupoProdudo.Padding = new System.Windows.Forms.Padding(3);
            this.tpGrupoProdudo.Size = new System.Drawing.Size(976, 506);
            this.tpGrupoProdudo.TabIndex = 0;
            this.tpGrupoProdudo.Text = "Grupo Produto";
            this.tpGrupoProdudo.UseVisualStyleBackColor = true;
            // 
            // dgvGrupoProd
            // 
            this.dgvGrupoProd.AllowUserToAddRows = false;
            this.dgvGrupoProd.AllowUserToDeleteRows = false;
            this.dgvGrupoProd.AllowUserToOrderColumns = true;
            this.dgvGrupoProd.AutoGenerateColumns = false;
            this.dgvGrupoProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvGrupoProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupoProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.dataSourceDataGridViewTextBoxColumn,
            this.connectionTimeoutDataGridViewTextBoxColumn,
            this.databaseDataGridViewTextBoxColumn,
            this.connectionStringDataGridViewTextBoxColumn});
            this.dgvGrupoProd.DataSource = this.mySqlConnectionBindingSource;
            this.dgvGrupoProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrupoProd.Location = new System.Drawing.Point(3, 3);
            this.dgvGrupoProd.Name = "dgvGrupoProd";
            this.dgvGrupoProd.ReadOnly = true;
            this.dgvGrupoProd.RowHeadersWidth = 12;
            this.dgvGrupoProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupoProd.Size = new System.Drawing.Size(970, 500);
            this.dgvGrupoProd.TabIndex = 2;
            this.dgvGrupoProd.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.FillWeight = 13.26861F;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "descricao";
            this.Column2.FillWeight = 129.9598F;
            this.Column2.HeaderText = "Descrição";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ativo";
            this.Column3.FillWeight = 156.7715F;
            this.Column3.HeaderText = "Ativo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
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
            // tpDadosGrupoProd
            // 
            this.tpDadosGrupoProd.Controls.Add(this.rdoInativo);
            this.tpDadosGrupoProd.Controls.Add(this.rdoAtivo);
            this.tpDadosGrupoProd.Controls.Add(this.txtDescGrupoProd);
            this.tpDadosGrupoProd.Controls.Add(this.txtIdUsuario);
            this.tpDadosGrupoProd.Controls.Add(this.lblIdCli);
            this.tpDadosGrupoProd.Controls.Add(this.lblDescGrupoProd);
            this.tpDadosGrupoProd.Location = new System.Drawing.Point(4, 22);
            this.tpDadosGrupoProd.Name = "tpDadosGrupoProd";
            this.tpDadosGrupoProd.Padding = new System.Windows.Forms.Padding(3);
            this.tpDadosGrupoProd.Size = new System.Drawing.Size(976, 506);
            this.tpDadosGrupoProd.TabIndex = 1;
            this.tpDadosGrupoProd.Text = "Dados";
            this.tpDadosGrupoProd.UseVisualStyleBackColor = true;
            // 
            // rdoInativo
            // 
            this.rdoInativo.AutoSize = true;
            this.rdoInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoInativo.Location = new System.Drawing.Point(300, 37);
            this.rdoInativo.Name = "rdoInativo";
            this.rdoInativo.Size = new System.Drawing.Size(67, 21);
            this.rdoInativo.TabIndex = 3;
            this.rdoInativo.Text = "Inativo";
            this.rdoInativo.UseVisualStyleBackColor = true;
            // 
            // rdoAtivo
            // 
            this.rdoAtivo.AutoSize = true;
            this.rdoAtivo.Checked = true;
            this.rdoAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoAtivo.Location = new System.Drawing.Point(237, 37);
            this.rdoAtivo.Name = "rdoAtivo";
            this.rdoAtivo.Size = new System.Drawing.Size(57, 21);
            this.rdoAtivo.TabIndex = 4;
            this.rdoAtivo.TabStop = true;
            this.rdoAtivo.Text = "Ativo";
            this.rdoAtivo.UseVisualStyleBackColor = true;
            // 
            // txtDescGrupoProd
            // 
            this.txtDescGrupoProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescGrupoProd.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDescGrupoProd.Location = new System.Drawing.Point(11, 91);
            this.txtDescGrupoProd.Name = "txtDescGrupoProd";
            this.txtDescGrupoProd.Size = new System.Drawing.Size(356, 26);
            this.txtDescGrupoProd.TabIndex = 2;
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
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(76, 32);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(257, 20);
            this.txtPesquisa.TabIndex = 10;
            this.txtPesquisa.TabStop = false;
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
            // pnlGrupoProdutos
            // 
            this.pnlGrupoProdutos.Controls.Add(this.lblPesquisa);
            this.pnlGrupoProdutos.Controls.Add(this.txtPesquisa);
            this.pnlGrupoProdutos.Controls.Add(this.tcGrupoProdutos);
            this.pnlGrupoProdutos.Controls.Add(this.tsGrupoProduto);
            this.pnlGrupoProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrupoProdutos.Location = new System.Drawing.Point(0, 0);
            this.pnlGrupoProdutos.Name = "pnlGrupoProdutos";
            this.pnlGrupoProdutos.Size = new System.Drawing.Size(983, 590);
            this.pnlGrupoProdutos.TabIndex = 0;
            // 
            // FrmGrupoProdutos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.pnlGrupoProdutos);
            this.KeyPreview = true;
            this.Name = "FrmGrupoProdutos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Grupo de Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGrupoProdutos_KeyDown);
            this.tsGrupoProduto.ResumeLayout(false);
            this.tsGrupoProduto.PerformLayout();
            this.tcGrupoProdutos.ResumeLayout(false);
            this.tpGrupoProdudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlConnectionBindingSource)).EndInit();
            this.tpDadosGrupoProd.ResumeLayout(false);
            this.tpDadosGrupoProd.PerformLayout();
            this.pnlGrupoProdutos.ResumeLayout(false);
            this.pnlGrupoProdutos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsGrupoProduto;
        private System.Windows.Forms.ToolStripButton tsbtnAddGrupoProd;
        private System.Windows.Forms.ToolStripButton tsbtnEditGrupoProd;
        private System.Windows.Forms.ToolStripButton tsbtnSalvar;
        private System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.TabControl tcGrupoProdutos;
        private System.Windows.Forms.TabPage tpGrupoProdudo;
        private System.Windows.Forms.TabPage tpDadosGrupoProd;
        private System.Windows.Forms.TextBox txtDescGrupoProd;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label lblIdCli;
        private System.Windows.Forms.Label lblDescGrupoProd;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Panel pnlGrupoProdutos;
        private System.Windows.Forms.RadioButton rdoInativo;
        private System.Windows.Forms.RadioButton rdoAtivo;
        private System.Windows.Forms.BindingSource mySqlConnectionBindingSource;
        private System.Windows.Forms.DataGridView dgvGrupoProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionTimeoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionStringDataGridViewTextBoxColumn;
    }
}