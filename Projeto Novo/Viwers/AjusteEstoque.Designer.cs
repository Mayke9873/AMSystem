namespace Projeto_Novo
{
    partial class FrmAjusteEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjusteEstoque));
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.lblIdProduto = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.rdoSaida = new System.Windows.Forms.RadioButton();
            this.rdoEntrada = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionTimeoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPasswordExpiredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mySqlConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtxQtd = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlConnectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Arial", 12F);
            this.lblQtd.Location = new System.Drawing.Point(460, 70);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(37, 18);
            this.lblQtd.TabIndex = 35;
            this.lblQtd.Text = "Qtd:";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtIdProduto.Font = new System.Drawing.Font("Arial", 12F);
            this.txtIdProduto.Location = new System.Drawing.Point(12, 91);
            this.txtIdProduto.MaxLength = 30;
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(77, 26);
            this.txtIdProduto.TabIndex = 1;
            this.txtIdProduto.Leave += new System.EventHandler(this.txtIdProduto_Leave);
            // 
            // lblIdProduto
            // 
            this.lblIdProduto.AutoSize = true;
            this.lblIdProduto.Font = new System.Drawing.Font("Arial", 12F);
            this.lblIdProduto.Location = new System.Drawing.Point(9, 70);
            this.lblIdProduto.Name = "lblIdProduto";
            this.lblIdProduto.Size = new System.Drawing.Size(64, 18);
            this.lblIdProduto.TabIndex = 32;
            this.lblIdProduto.Text = "Código:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(92, 91);
            this.txtDescricao.MaxLength = 255;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(364, 26);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDescricao.Location = new System.Drawing.Point(89, 70);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(84, 18);
            this.lblDescricao.TabIndex = 29;
            this.lblDescricao.Text = "Descrição:";
            // 
            // rdoSaida
            // 
            this.rdoSaida.AutoSize = true;
            this.rdoSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoSaida.Location = new System.Drawing.Point(306, 139);
            this.rdoSaida.Name = "rdoSaida";
            this.rdoSaida.Size = new System.Drawing.Size(62, 21);
            this.rdoSaida.TabIndex = 5;
            this.rdoSaida.TabStop = true;
            this.rdoSaida.Text = "Saida";
            this.rdoSaida.UseVisualStyleBackColor = true;
            // 
            // rdoEntrada
            // 
            this.rdoEntrada.AutoSize = true;
            this.rdoEntrada.Checked = true;
            this.rdoEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoEntrada.Location = new System.Drawing.Point(186, 139);
            this.rdoEntrada.Name = "rdoEntrada";
            this.rdoEntrada.Size = new System.Drawing.Size(76, 21);
            this.rdoEntrada.TabIndex = 4;
            this.rdoEntrada.TabStop = true;
            this.rdoEntrada.Text = "Entrada";
            this.rdoEntrada.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F);
            this.label1.Location = new System.Drawing.Point(181, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ajuste de Estoque";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial", 9F);
            this.btnSair.Location = new System.Drawing.Point(278, 194);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(96, 32);
            this.btnSair.TabIndex = 38;
            this.btnSair.Text = "Esc - Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnConfirmar.Location = new System.Drawing.Point(180, 194);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(96, 32);
            this.btnConfirmar.TabIndex = 37;
            this.btnConfirmar.Text = "F3 - Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
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
            this.qtd,
            this.dataSourceDataGridViewTextBoxColumn,
            this.connectionTimeoutDataGridViewTextBoxColumn,
            this.databaseDataGridViewTextBoxColumn,
            this.connectionStringDataGridViewTextBoxColumn,
            this.isPasswordExpiredDataGridViewCheckBoxColumn});
            this.dgvProduto.DataSource = this.mySqlConnectionBindingSource;
            this.dgvProduto.Location = new System.Drawing.Point(488, 181);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersWidth = 20;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(444, 150);
            this.dgvProduto.TabIndex = 39;
            this.dgvProduto.Visible = false;
            this.dgvProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 80;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 270;
            // 
            // qtd
            // 
            this.qtd.DataPropertyName = "estoque";
            this.qtd.HeaderText = "Qtd.";
            this.qtd.Name = "qtd";
            this.qtd.ReadOnly = true;
            this.qtd.Width = 70;
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
            // isPasswordExpiredDataGridViewCheckBoxColumn
            // 
            this.isPasswordExpiredDataGridViewCheckBoxColumn.DataPropertyName = "IsPasswordExpired";
            this.isPasswordExpiredDataGridViewCheckBoxColumn.HeaderText = "IsPasswordExpired";
            this.isPasswordExpiredDataGridViewCheckBoxColumn.Name = "isPasswordExpiredDataGridViewCheckBoxColumn";
            this.isPasswordExpiredDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isPasswordExpiredDataGridViewCheckBoxColumn.Visible = false;
            // 
            // mySqlConnectionBindingSource
            // 
            this.mySqlConnectionBindingSource.DataSource = typeof(MySql.Data.MySqlClient.MySqlConnection);
            // 
            // mtxQtd
            // 
            this.mtxQtd.Font = new System.Drawing.Font("Arial", 12F);
            this.mtxQtd.HidePromptOnLeave = true;
            this.mtxQtd.Location = new System.Drawing.Point(463, 91);
            this.mtxQtd.Name = "mtxQtd";
            this.mtxQtd.Size = new System.Drawing.Size(77, 26);
            this.mtxQtd.TabIndex = 3;
            this.mtxQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmAjusteEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 238);
            this.Controls.Add(this.mtxQtd);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.lblIdProduto);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.rdoSaida);
            this.Controls.Add(this.rdoEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmAjusteEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuste Estoque";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAjusteEstoque_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlConnectionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label lblIdProduto;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RadioButton rdoSaida;
        private System.Windows.Forms.RadioButton rdoEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionTimeoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPasswordExpiredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource mySqlConnectionBindingSource;
        private System.Windows.Forms.MaskedTextBox mtxQtd;
    }
}