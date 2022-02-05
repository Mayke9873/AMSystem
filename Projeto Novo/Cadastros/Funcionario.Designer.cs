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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionario));
            this.pnlFuncionario = new System.Windows.Forms.Panel();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.tpFornecedores = new System.Windows.Forms.TabControl();
            this.tpFuncionario = new System.Windows.Forms.TabPage();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tpDados = new System.Windows.Forms.TabPage();
            this.rdoInativo = new System.Windows.Forms.RadioButton();
            this.rdoAtivo = new System.Windows.Forms.RadioButton();
            this.lnlNumEnd = new System.Windows.Forms.Label();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxRG = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdFuncionario = new System.Windows.Forms.TextBox();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.txtBairroFuncionario = new System.Windows.Forms.TextBox();
            this.txtNumEndFuncionario = new System.Windows.Forms.TextBox();
            this.txtEndFuncionario = new System.Windows.Forms.TextBox();
            this.mtxDtNascFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
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
            this.tpFornecedores.SuspendLayout();
            this.tpFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tpDados.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFuncionario
            // 
            this.pnlFuncionario.Controls.Add(this.txtPesquisa);
            this.pnlFuncionario.Controls.Add(this.tpFornecedores);
            this.pnlFuncionario.Controls.Add(this.lblPesquisa);
            this.pnlFuncionario.Controls.Add(this.toolStrip1);
            this.pnlFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFuncionario.Location = new System.Drawing.Point(0, 0);
            this.pnlFuncionario.Name = "pnlFuncionario";
            this.pnlFuncionario.Size = new System.Drawing.Size(983, 590);
            this.pnlFuncionario.TabIndex = 0;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(74, 32);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(257, 20);
            this.txtPesquisa.TabIndex = 16;
            this.txtPesquisa.TabStop = false;
            // 
            // tpFornecedores
            // 
            this.tpFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpFornecedores.Controls.Add(this.tpFuncionario);
            this.tpFornecedores.Controls.Add(this.tpDados);
            this.tpFornecedores.Location = new System.Drawing.Point(-1, 58);
            this.tpFornecedores.Multiline = true;
            this.tpFornecedores.Name = "tpFornecedores";
            this.tpFornecedores.SelectedIndex = 0;
            this.tpFornecedores.Size = new System.Drawing.Size(984, 532);
            this.tpFornecedores.TabIndex = 0;
            this.tpFornecedores.TabStop = false;
            // 
            // tpFuncionario
            // 
            this.tpFuncionario.Controls.Add(this.dgvFuncionario);
            this.tpFuncionario.Controls.Add(this.dgvClientes);
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
            this.dgvFuncionario.AllowUserToOrderColumns = true;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFuncionario.Location = new System.Drawing.Point(3, 3);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.Size = new System.Drawing.Size(970, 500);
            this.dgvFuncionario.TabIndex = 2;
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
            // tpDados
            // 
            this.tpDados.Controls.Add(this.rdoInativo);
            this.tpDados.Controls.Add(this.rdoAtivo);
            this.tpDados.Controls.Add(this.lnlNumEnd);
            this.tpDados.Controls.Add(this.mtxCPF);
            this.tpDados.Controls.Add(this.label2);
            this.tpDados.Controls.Add(this.mtxRG);
            this.tpDados.Controls.Add(this.label1);
            this.tpDados.Controls.Add(this.txtIdFuncionario);
            this.tpDados.Controls.Add(this.lblIdCli);
            this.tpDados.Controls.Add(this.txtBairroFuncionario);
            this.tpDados.Controls.Add(this.txtNumEndFuncionario);
            this.tpDados.Controls.Add(this.txtEndFuncionario);
            this.tpDados.Controls.Add(this.mtxDtNascFuncionario);
            this.tpDados.Controls.Add(this.txtNomeFuncionario);
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
            // rdoInativo
            // 
            this.rdoInativo.AutoSize = true;
            this.rdoInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoInativo.Location = new System.Drawing.Point(275, 37);
            this.rdoInativo.Name = "rdoInativo";
            this.rdoInativo.Size = new System.Drawing.Size(67, 21);
            this.rdoInativo.TabIndex = 12;
            this.rdoInativo.Text = "Inativo";
            this.rdoInativo.UseVisualStyleBackColor = true;
            // 
            // rdoAtivo
            // 
            this.rdoAtivo.AutoSize = true;
            this.rdoAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoAtivo.Location = new System.Drawing.Point(212, 37);
            this.rdoAtivo.Name = "rdoAtivo";
            this.rdoAtivo.Size = new System.Drawing.Size(57, 21);
            this.rdoAtivo.TabIndex = 13;
            this.rdoAtivo.Text = "Ativo";
            this.rdoAtivo.UseVisualStyleBackColor = true;
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
            // txtBairroFuncionario
            // 
            this.txtBairroFuncionario.Font = new System.Drawing.Font("Arial", 12F);
            this.txtBairroFuncionario.Location = new System.Drawing.Point(403, 150);
            this.txtBairroFuncionario.Name = "txtBairroFuncionario";
            this.txtBairroFuncionario.Size = new System.Drawing.Size(301, 26);
            this.txtBairroFuncionario.TabIndex = 7;
            // 
            // txtNumEndFuncionario
            // 
            this.txtNumEndFuncionario.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNumEndFuncionario.Location = new System.Drawing.Point(345, 150);
            this.txtNumEndFuncionario.Name = "txtNumEndFuncionario";
            this.txtNumEndFuncionario.Size = new System.Drawing.Size(52, 26);
            this.txtNumEndFuncionario.TabIndex = 6;
            // 
            // txtEndFuncionario
            // 
            this.txtEndFuncionario.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEndFuncionario.Location = new System.Drawing.Point(11, 150);
            this.txtEndFuncionario.Name = "txtEndFuncionario";
            this.txtEndFuncionario.Size = new System.Drawing.Size(331, 26);
            this.txtEndFuncionario.TabIndex = 5;
            // 
            // mtxDtNascFuncionario
            // 
            this.mtxDtNascFuncionario.Font = new System.Drawing.Font("Arial", 12F);
            this.mtxDtNascFuncionario.Location = new System.Drawing.Point(604, 91);
            this.mtxDtNascFuncionario.Mask = "00/00/0000";
            this.mtxDtNascFuncionario.Name = "mtxDtNascFuncionario";
            this.mtxDtNascFuncionario.Size = new System.Drawing.Size(100, 26);
            this.mtxDtNascFuncionario.TabIndex = 4;
            this.mtxDtNascFuncionario.ValidatingType = typeof(System.DateTime);
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNomeFuncionario.Location = new System.Drawing.Point(11, 91);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(331, 26);
            this.txtNomeFuncionario.TabIndex = 1;
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
            // 
            // tsbtnEditFuncionario
            // 
            this.tsbtnEditFuncionario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEditFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditFuncionario.Image")));
            this.tsbtnEditFuncionario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditFuncionario.Name = "tsbtnEditFuncionario";
            this.tsbtnEditFuncionario.Size = new System.Drawing.Size(26, 26);
            this.tsbtnEditFuncionario.Text = "Editar";
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
            // tsbtnCancelar
            // 
            this.tsbtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancelar.Image")));
            this.tsbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancelar.Name = "tsbtnCancelar";
            this.tsbtnCancelar.Size = new System.Drawing.Size(26, 26);
            this.tsbtnCancelar.Text = "Cancelar";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.pnlFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmFuncionario";
            this.Text = "Funcionario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFuncionario_KeyDown);
            this.pnlFuncionario.ResumeLayout(false);
            this.pnlFuncionario.PerformLayout();
            this.tpFornecedores.ResumeLayout(false);
            this.tpFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tpDados.ResumeLayout(false);
            this.tpDados.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFuncionario;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TabControl tpFornecedores;
        private System.Windows.Forms.TabPage tpFuncionario;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TabPage tpDados;
        private System.Windows.Forms.Label lnlNumEnd;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdFuncionario;
        private System.Windows.Forms.Label lblIdCli;
        private System.Windows.Forms.TextBox txtBairroFuncionario;
        private System.Windows.Forms.TextBox txtNumEndFuncionario;
        private System.Windows.Forms.TextBox txtEndFuncionario;
        private System.Windows.Forms.MaskedTextBox mtxDtNascFuncionario;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
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
        private System.Windows.Forms.RadioButton rdoInativo;
        private System.Windows.Forms.RadioButton rdoAtivo;
        private System.Windows.Forms.MaskedTextBox mtxRG;
    }
}