﻿namespace Projeto_Novo
{
    partial class FrmContaReceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContaReceber));
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditC_Receber = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAddC_Receber = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsC_Receber = new System.Windows.Forms.ToolStrip();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.tpDadosReceber = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnReceber = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvCliAReceber = new System.Windows.Forms.DataGridView();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tpContaReceber = new System.Windows.Forms.TabPage();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.tpContasAReceber = new System.Windows.Forms.TabControl();
            this.pnlContasReceber = new System.Windows.Forms.Panel();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.tsC_Receber.SuspendLayout();
            this.tpDadosReceber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliAReceber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tpContaReceber.SuspendLayout();
            this.tpContasAReceber.SuspendLayout();
            this.pnlContasReceber.SuspendLayout();
            this.SuspendLayout();
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
            // tsbtnCancelar
            // 
            this.tsbtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancelar.Image")));
            this.tsbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancelar.Name = "tsbtnCancelar";
            this.tsbtnCancelar.Size = new System.Drawing.Size(26, 26);
            this.tsbtnCancelar.Text = "Cancelar";
            // 
            // tsbtnSalvar
            // 
            this.tsbtnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSalvar.Image")));
            this.tsbtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSalvar.Name = "tsbtnSalvar";
            this.tsbtnSalvar.Size = new System.Drawing.Size(26, 26);
            this.tsbtnSalvar.Text = "Salvar";
            // 
            // tsbtnEditC_Receber
            // 
            this.tsbtnEditC_Receber.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEditC_Receber.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditC_Receber.Image")));
            this.tsbtnEditC_Receber.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditC_Receber.Name = "tsbtnEditC_Receber";
            this.tsbtnEditC_Receber.Size = new System.Drawing.Size(26, 26);
            this.tsbtnEditC_Receber.Text = "Editar";
            // 
            // tsbtnAddC_Receber
            // 
            this.tsbtnAddC_Receber.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddC_Receber.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddC_Receber.Image")));
            this.tsbtnAddC_Receber.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddC_Receber.Name = "tsbtnAddC_Receber";
            this.tsbtnAddC_Receber.Size = new System.Drawing.Size(26, 26);
            this.tsbtnAddC_Receber.Text = "Novo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 29);
            // 
            // tsC_Receber
            // 
            this.tsC_Receber.BackColor = System.Drawing.SystemColors.Control;
            this.tsC_Receber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsC_Receber.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsC_Receber.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.tsC_Receber.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddC_Receber,
            this.tsbtnEditC_Receber,
            this.tsbtnSalvar,
            this.tsbtnCancelar,
            this.toolStripSeparator,
            this.tsbtnImprimir,
            this.toolStripSeparator1,
            this.tsbtnSair});
            this.tsC_Receber.Location = new System.Drawing.Point(0, 0);
            this.tsC_Receber.Name = "tsC_Receber";
            this.tsC_Receber.Size = new System.Drawing.Size(983, 29);
            this.tsC_Receber.TabIndex = 9;
            this.tsC_Receber.Text = "Contas a Receber";
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
            // tpDadosReceber
            // 
            this.tpDadosReceber.Controls.Add(this.btnExcluir);
            this.tpDadosReceber.Controls.Add(this.btnReceber);
            this.tpDadosReceber.Controls.Add(this.btnNovo);
            this.tpDadosReceber.Controls.Add(this.dataGridView1);
            this.tpDadosReceber.Location = new System.Drawing.Point(4, 22);
            this.tpDadosReceber.Name = "tpDadosReceber";
            this.tpDadosReceber.Padding = new System.Windows.Forms.Padding(3);
            this.tpDadosReceber.Size = new System.Drawing.Size(976, 506);
            this.tpDadosReceber.TabIndex = 1;
            this.tpDadosReceber.Text = "Dados";
            this.tpDadosReceber.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 9F);
            this.btnExcluir.Location = new System.Drawing.Point(201, 466);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(96, 32);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "F3 - Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnReceber
            // 
            this.btnReceber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReceber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceber.Font = new System.Drawing.Font("Arial", 9F);
            this.btnReceber.Location = new System.Drawing.Point(102, 466);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(96, 32);
            this.btnReceber.TabIndex = 2;
            this.btnReceber.Text = "F2 - Receber";
            this.btnReceber.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Arial", 9F);
            this.btnNovo.Location = new System.Drawing.Point(3, 466);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(96, 32);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "F1 - Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(970, 457);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgvCliAReceber
            // 
            this.dgvCliAReceber.AllowUserToOrderColumns = true;
            this.dgvCliAReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliAReceber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCliAReceber.Location = new System.Drawing.Point(3, 3);
            this.dgvCliAReceber.Name = "dgvCliAReceber";
            this.dgvCliAReceber.Size = new System.Drawing.Size(970, 500);
            this.dgvCliAReceber.TabIndex = 2;
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
            // tpContaReceber
            // 
            this.tpContaReceber.Controls.Add(this.dgvCliAReceber);
            this.tpContaReceber.Controls.Add(this.dgvClientes);
            this.tpContaReceber.Location = new System.Drawing.Point(4, 22);
            this.tpContaReceber.Name = "tpContaReceber";
            this.tpContaReceber.Padding = new System.Windows.Forms.Padding(3);
            this.tpContaReceber.Size = new System.Drawing.Size(976, 506);
            this.tpContaReceber.TabIndex = 0;
            this.tpContaReceber.Text = "Contas a Receber";
            this.tpContaReceber.UseVisualStyleBackColor = true;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(12, 35);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(42, 13);
            this.lblPesquisa.TabIndex = 11;
            this.lblPesquisa.Text = "Cliente:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(74, 32);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(257, 20);
            this.txtPesquisa.TabIndex = 10;
            // 
            // tpContasAReceber
            // 
            this.tpContasAReceber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpContasAReceber.Controls.Add(this.tpContaReceber);
            this.tpContasAReceber.Controls.Add(this.tpDadosReceber);
            this.tpContasAReceber.Location = new System.Drawing.Point(-1, 58);
            this.tpContasAReceber.Multiline = true;
            this.tpContasAReceber.Name = "tpContasAReceber";
            this.tpContasAReceber.SelectedIndex = 0;
            this.tpContasAReceber.Size = new System.Drawing.Size(984, 532);
            this.tpContasAReceber.TabIndex = 8;
            this.tpContasAReceber.TabStop = false;
            // 
            // pnlContasReceber
            // 
            this.pnlContasReceber.Controls.Add(this.maskedTextBox2);
            this.pnlContasReceber.Controls.Add(this.lblPeriodo);
            this.pnlContasReceber.Controls.Add(this.maskedTextBox1);
            this.pnlContasReceber.Controls.Add(this.lblPesquisa);
            this.pnlContasReceber.Controls.Add(this.txtPesquisa);
            this.pnlContasReceber.Controls.Add(this.tpContasAReceber);
            this.pnlContasReceber.Controls.Add(this.tsC_Receber);
            this.pnlContasReceber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContasReceber.Location = new System.Drawing.Point(0, 0);
            this.pnlContasReceber.Name = "pnlContasReceber";
            this.pnlContasReceber.Size = new System.Drawing.Size(983, 590);
            this.pnlContasReceber.TabIndex = 1;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox2.Location = new System.Drawing.Point(552, 32);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBox2.TabIndex = 15;
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(417, 35);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(48, 13);
            this.lblPeriodo.TabIndex = 14;
            this.lblPeriodo.Text = "Período:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.Location = new System.Drawing.Point(471, 32);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBox1.TabIndex = 12;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // FrmContaReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.pnlContasReceber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmContaReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contas a Receber";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmContaReceber_KeyDown);
            this.tsC_Receber.ResumeLayout(false);
            this.tsC_Receber.PerformLayout();
            this.tpDadosReceber.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliAReceber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tpContaReceber.ResumeLayout(false);
            this.tpContasAReceber.ResumeLayout(false);
            this.pnlContasReceber.ResumeLayout(false);
            this.pnlContasReceber.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStripButton tsbtnSalvar;
        private System.Windows.Forms.ToolStripButton tsbtnEditC_Receber;
        private System.Windows.Forms.ToolStripButton tsbtnAddC_Receber;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStrip tsC_Receber;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.TabPage tpDadosReceber;
        private System.Windows.Forms.DataGridView dgvCliAReceber;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TabPage tpContaReceber;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TabControl tpContasAReceber;
        private System.Windows.Forms.Panel pnlContasReceber;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnReceber;
    }
}