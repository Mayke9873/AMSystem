﻿namespace Projeto_Novo
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
            this.txtValVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionTimeoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSourceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionTimeoutDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionStringDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlConnectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Arial", 11F);
            this.txtDesconto.Location = new System.Drawing.Point(733, 196);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(86, 24);
            this.txtDesconto.TabIndex = 17;
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
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.dataSourceDataGridViewTextBoxColumn1,
            this.connectionTimeoutDataGridViewTextBoxColumn1,
            this.databaseDataGridViewTextBoxColumn1,
            this.connectionStringDataGridViewTextBoxColumn1});
            this.dgvProVenda.DataSource = this.mySqlConnectionBindingSource;
            this.dgvProVenda.Location = new System.Drawing.Point(12, 226);
            this.dgvProVenda.Name = "dgvProVenda";
            this.dgvProVenda.RowHeadersWidth = 12;
            this.dgvProVenda.Size = new System.Drawing.Size(959, 301);
            this.dgvProVenda.TabIndex = 0;
            this.dgvProVenda.TabStop = false;
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
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Font = new System.Drawing.Font("Arial", 11F);
            this.txtIdCliente.Location = new System.Drawing.Point(12, 126);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(86, 24);
            this.txtIdCliente.TabIndex = 7;
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
            // 
            // txtIdVendedor
            // 
            this.txtIdVendedor.Font = new System.Drawing.Font("Arial", 11F);
            this.txtIdVendedor.Location = new System.Drawing.Point(12, 78);
            this.txtIdVendedor.Name = "txtIdVendedor";
            this.txtIdVendedor.Size = new System.Drawing.Size(86, 24);
            this.txtIdVendedor.TabIndex = 4;
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
            this.txtValorTotal.Leave += new System.EventHandler(this.txtValorTotal_Leave);
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
            this.btnConfirmar.Size = new System.Drawing.Size(96, 32);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "F1 - Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
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
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "F2 - Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.dgvProdutos.Location = new System.Drawing.Point(12, 220);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersWidth = 12;
            this.dgvProdutos.Size = new System.Drawing.Size(623, 231);
            this.dgvProdutos.TabIndex = 23;
            this.dgvProdutos.TabStop = false;
            this.dgvProdutos.Visible = false;
            this.dgvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellDoubleClick);
            // 
            // txtValVenda
            // 
            this.txtValVenda.BackColor = System.Drawing.Color.Gainsboro;
            this.txtValVenda.Enabled = false;
            this.txtValVenda.Font = new System.Drawing.Font("Arial", 11F);
            this.txtValVenda.Location = new System.Drawing.Point(807, 30);
            this.txtValVenda.Multiline = true;
            this.txtValVenda.Name = "txtValVenda";
            this.txtValVenda.Size = new System.Drawing.Size(104, 45);
            this.txtValVenda.TabIndex = 24;
            this.txtValVenda.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(804, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "R$ Total";
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
            this.Column2.Width = 230;
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
            // Column7
            // 
            this.Column7.DataPropertyName = "idprod";
            this.Column7.HeaderText = "Código";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "descricao";
            this.Column8.HeaderText = "Descrição";
            this.Column8.Name = "Column8";
            this.Column8.Width = 230;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "quantidade";
            this.Column9.HeaderText = "Qtd.";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "valor";
            this.Column10.HeaderText = "R$ Unit.";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "desconto";
            this.Column11.HeaderText = "Desc.";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "total";
            this.Column12.HeaderText = "R$ Total";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
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
            // FrmVenda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValVenda);
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
        private System.Windows.Forms.TextBox txtValVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
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
    }
}