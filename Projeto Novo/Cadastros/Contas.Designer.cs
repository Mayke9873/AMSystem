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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContas));
            this.pnlContas = new System.Windows.Forms.Panel();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.tpContas = new System.Windows.Forms.TabControl();
            this.tpConta = new System.Windows.Forms.TabPage();
            this.dgvGrupoProd = new System.Windows.Forms.DataGridView();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tpDadosConta = new System.Windows.Forms.TabPage();
            this.chkBanco = new System.Windows.Forms.CheckBox();
            this.rdoInativo = new System.Windows.Forms.RadioButton();
            this.rdoAtivo = new System.Windows.Forms.RadioButton();
            this.txtDescGrupoProd = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.lblDescGrupoProd = new System.Windows.Forms.Label();
            this.tsGrupoProduto = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnAddConta = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditConta = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.pnlContas.SuspendLayout();
            this.tpContas.SuspendLayout();
            this.tpConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tpDadosConta.SuspendLayout();
            this.tsGrupoProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContas
            // 
            this.pnlContas.Controls.Add(this.lblPesquisa);
            this.pnlContas.Controls.Add(this.txtPesquisa);
            this.pnlContas.Controls.Add(this.tpContas);
            this.pnlContas.Controls.Add(this.tsGrupoProduto);
            this.pnlContas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContas.Location = new System.Drawing.Point(0, 0);
            this.pnlContas.Name = "pnlContas";
            this.pnlContas.Size = new System.Drawing.Size(983, 590);
            this.pnlContas.TabIndex = 1;
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
            this.txtPesquisa.Location = new System.Drawing.Point(76, 32);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(257, 20);
            this.txtPesquisa.TabIndex = 10;
            this.txtPesquisa.TabStop = false;
            // 
            // tpContas
            // 
            this.tpContas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpContas.Controls.Add(this.tpConta);
            this.tpContas.Controls.Add(this.tpDadosConta);
            this.tpContas.Location = new System.Drawing.Point(-1, 58);
            this.tpContas.Multiline = true;
            this.tpContas.Name = "tpContas";
            this.tpContas.SelectedIndex = 0;
            this.tpContas.Size = new System.Drawing.Size(984, 532);
            this.tpContas.TabIndex = 8;
            this.tpContas.TabStop = false;
            // 
            // tpConta
            // 
            this.tpConta.Controls.Add(this.dgvGrupoProd);
            this.tpConta.Controls.Add(this.dgvClientes);
            this.tpConta.Location = new System.Drawing.Point(4, 22);
            this.tpConta.Name = "tpConta";
            this.tpConta.Padding = new System.Windows.Forms.Padding(3);
            this.tpConta.Size = new System.Drawing.Size(976, 506);
            this.tpConta.TabIndex = 0;
            this.tpConta.Text = "Contas";
            this.tpConta.UseVisualStyleBackColor = true;
            // 
            // dgvGrupoProd
            // 
            this.dgvGrupoProd.AllowUserToOrderColumns = true;
            this.dgvGrupoProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupoProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrupoProd.Location = new System.Drawing.Point(3, 3);
            this.dgvGrupoProd.Name = "dgvGrupoProd";
            this.dgvGrupoProd.Size = new System.Drawing.Size(970, 500);
            this.dgvGrupoProd.TabIndex = 2;
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
            this.tpDadosConta.Controls.Add(this.chkBanco);
            this.tpDadosConta.Controls.Add(this.rdoInativo);
            this.tpDadosConta.Controls.Add(this.rdoAtivo);
            this.tpDadosConta.Controls.Add(this.txtDescGrupoProd);
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
            this.rdoAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoAtivo.Location = new System.Drawing.Point(237, 37);
            this.rdoAtivo.Name = "rdoAtivo";
            this.rdoAtivo.Size = new System.Drawing.Size(57, 21);
            this.rdoAtivo.TabIndex = 4;
            this.rdoAtivo.Text = "Ativo";
            this.rdoAtivo.UseVisualStyleBackColor = true;
            // 
            // txtDescGrupoProd
            // 
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
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbtnAddConta
            // 
            this.tsbtnAddConta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddConta.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddConta.Image")));
            this.tsbtnAddConta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddConta.Name = "tsbtnAddConta";
            this.tsbtnAddConta.Size = new System.Drawing.Size(26, 26);
            this.tsbtnAddConta.Text = "Novo";
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
            this.tsbtnSair.Click += new System.EventHandler(this.tsbtnSair_Click);
            // 
            // FrmContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.pnlContas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmContas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmContas_KeyDown);
            this.pnlContas.ResumeLayout(false);
            this.pnlContas.PerformLayout();
            this.tpContas.ResumeLayout(false);
            this.tpConta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoProd)).EndInit();
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
        private System.Windows.Forms.TabControl tpContas;
        private System.Windows.Forms.TabPage tpConta;
        private System.Windows.Forms.DataGridView dgvGrupoProd;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TabPage tpDadosConta;
        private System.Windows.Forms.CheckBox chkBanco;
        private System.Windows.Forms.RadioButton rdoInativo;
        private System.Windows.Forms.RadioButton rdoAtivo;
        private System.Windows.Forms.TextBox txtDescGrupoProd;
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
    }
}