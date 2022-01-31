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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFornecedor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddFornecedor = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditFornecedor = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tpFornecedor = new System.Windows.Forms.TabPage();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.tpFornecedores = new System.Windows.Forms.TabControl();
            this.tpDados = new System.Windows.Forms.TabPage();
            this.lnlNumEnd = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
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
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tpFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.tpFornecedores.SuspendLayout();
            this.tpDados.SuspendLayout();
            this.SuspendLayout();
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
            this.tsbtnSair,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(983, 29);
            this.toolStrip1.TabIndex = 3;
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
            // tsbtnSair
            // 
            this.tsbtnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSair.Image")));
            this.tsbtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSair.Name = "tsbtnSair";
            this.tsbtnSair.Size = new System.Drawing.Size(26, 26);
            this.tsbtnSair.Text = "Sair";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
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
            this.dgvClientes.Size = new System.Drawing.Size(970, 526);
            this.dgvClientes.TabIndex = 0;
            // 
            // tpFornecedor
            // 
            this.tpFornecedor.Controls.Add(this.dgvFornecedor);
            this.tpFornecedor.Controls.Add(this.dgvClientes);
            this.tpFornecedor.Location = new System.Drawing.Point(4, 22);
            this.tpFornecedor.Name = "tpFornecedor";
            this.tpFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.tpFornecedor.Size = new System.Drawing.Size(976, 532);
            this.tpFornecedor.TabIndex = 0;
            this.tpFornecedor.Text = "Fornecedor";
            this.tpFornecedor.UseVisualStyleBackColor = true;
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToOrderColumns = true;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFornecedor.Location = new System.Drawing.Point(3, 3);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.Size = new System.Drawing.Size(970, 526);
            this.dgvFornecedor.TabIndex = 2;
            // 
            // tpFornecedores
            // 
            this.tpFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpFornecedores.Controls.Add(this.tpFornecedor);
            this.tpFornecedores.Controls.Add(this.tpDados);
            this.tpFornecedores.Location = new System.Drawing.Point(-1, 32);
            this.tpFornecedores.Multiline = true;
            this.tpFornecedores.Name = "tpFornecedores";
            this.tpFornecedores.SelectedIndex = 0;
            this.tpFornecedores.Size = new System.Drawing.Size(984, 558);
            this.tpFornecedores.TabIndex = 2;
            // 
            // tpDados
            // 
            this.tpDados.Controls.Add(this.lnlNumEnd);
            this.tpDados.Controls.Add(this.maskedTextBox2);
            this.tpDados.Controls.Add(this.label2);
            this.tpDados.Controls.Add(this.maskedTextBox1);
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
            this.tpDados.Size = new System.Drawing.Size(976, 532);
            this.tpDados.TabIndex = 3;
            this.tpDados.Text = "Dados";
            this.tpDados.UseVisualStyleBackColor = true;
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
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Arial", 12F);
            this.maskedTextBox2.Location = new System.Drawing.Point(468, 91);
            this.maskedTextBox2.Mask = "000,000,000-00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(130, 26);
            this.maskedTextBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(465, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "CNPJ:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.maskedTextBox1.Location = new System.Drawing.Point(348, 91);
            this.maskedTextBox1.Mask = "00,000,000-0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(114, 26);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(345, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "IE:";
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
            this.txtBairroFuncionario.TabIndex = 5;
            // 
            // txtNumEndFuncionario
            // 
            this.txtNumEndFuncionario.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNumEndFuncionario.Location = new System.Drawing.Point(345, 150);
            this.txtNumEndFuncionario.Name = "txtNumEndFuncionario";
            this.txtNumEndFuncionario.Size = new System.Drawing.Size(52, 26);
            this.txtNumEndFuncionario.TabIndex = 4;
            // 
            // txtEndFuncionario
            // 
            this.txtEndFuncionario.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEndFuncionario.Location = new System.Drawing.Point(11, 150);
            this.txtEndFuncionario.Name = "txtEndFuncionario";
            this.txtEndFuncionario.Size = new System.Drawing.Size(331, 26);
            this.txtEndFuncionario.TabIndex = 3;
            // 
            // mtxDtNascFuncionario
            // 
            this.mtxDtNascFuncionario.Font = new System.Drawing.Font("Arial", 12F);
            this.mtxDtNascFuncionario.Location = new System.Drawing.Point(604, 91);
            this.mtxDtNascFuncionario.Mask = "00/00/0000";
            this.mtxDtNascFuncionario.Name = "mtxDtNascFuncionario";
            this.mtxDtNascFuncionario.Size = new System.Drawing.Size(100, 26);
            this.mtxDtNascFuncionario.TabIndex = 2;
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
            // FrmFornecedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tpFornecedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmFornecedor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tpFornecedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.tpFornecedores.ResumeLayout(false);
            this.tpDados.ResumeLayout(false);
            this.tpDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TabPage tpFornecedor;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.TabControl tpFornecedores;
        private System.Windows.Forms.ToolStripButton tsbtnAddFornecedor;
        private System.Windows.Forms.ToolStripButton tsbtnEditFornecedor;
        private System.Windows.Forms.ToolStripButton tsbtnSalvar;
        private System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.TabPage tpDados;
        private System.Windows.Forms.Label lnlNumEnd;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
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
    }
}