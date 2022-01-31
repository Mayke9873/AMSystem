namespace Projeto_Novo
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.txtIdCli = new System.Windows.Forms.TextBox();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.txtEnderecoCli = new System.Windows.Forms.TextBox();
            this.txtDescProd = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.lblDescProd = new System.Windows.Forms.Label();
            this.tpDadosProd = new System.Windows.Forms.TabPage();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tpProduto = new System.Windows.Forms.TabPage();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tpProdutos = new System.Windows.Forms.TabControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdoProdAtivo = new System.Windows.Forms.RadioButton();
            this.rdoProdInativo = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tsbtnAddProduto = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditProduto = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.tpDadosProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tpProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tpProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdCli
            // 
            this.txtIdCli.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtIdCli.Enabled = false;
            this.txtIdCli.Font = new System.Drawing.Font("Arial", 12F);
            this.txtIdCli.Location = new System.Drawing.Point(11, 34);
            this.txtIdCli.Name = "txtIdCli";
            this.txtIdCli.Size = new System.Drawing.Size(77, 26);
            this.txtIdCli.TabIndex = 0;
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
            // txtEnderecoCli
            // 
            this.txtEnderecoCli.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEnderecoCli.Location = new System.Drawing.Point(139, 157);
            this.txtEnderecoCli.Name = "txtEnderecoCli";
            this.txtEnderecoCli.Size = new System.Drawing.Size(90, 26);
            this.txtEnderecoCli.TabIndex = 4;
            // 
            // txtDescProd
            // 
            this.txtDescProd.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDescProd.Location = new System.Drawing.Point(11, 91);
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.Size = new System.Drawing.Size(339, 26);
            this.txtDescProd.TabIndex = 1;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEndereco.Location = new System.Drawing.Point(136, 136);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(93, 18);
            this.lblEndereco.TabIndex = 0;
            this.lblEndereco.Text = "R$ Compra:";
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Font = new System.Drawing.Font("Arial", 12F);
            this.lblUnidade.Location = new System.Drawing.Point(353, 70);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(31, 18);
            this.lblUnidade.TabIndex = 0;
            this.lblUnidade.Text = "Un.";
            // 
            // lblDescProd
            // 
            this.lblDescProd.AutoSize = true;
            this.lblDescProd.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDescProd.Location = new System.Drawing.Point(8, 70);
            this.lblDescProd.Name = "lblDescProd";
            this.lblDescProd.Size = new System.Drawing.Size(84, 18);
            this.lblDescProd.TabIndex = 0;
            this.lblDescProd.Text = "Descrição:";
            // 
            // tpDadosProd
            // 
            this.tpDadosProd.Controls.Add(this.textBox4);
            this.tpDadosProd.Controls.Add(this.lblEstoque);
            this.tpDadosProd.Controls.Add(this.textBox3);
            this.tpDadosProd.Controls.Add(this.label2);
            this.tpDadosProd.Controls.Add(this.textBox2);
            this.tpDadosProd.Controls.Add(this.label1);
            this.tpDadosProd.Controls.Add(this.rdoProdInativo);
            this.tpDadosProd.Controls.Add(this.rdoProdAtivo);
            this.tpDadosProd.Controls.Add(this.textBox1);
            this.tpDadosProd.Controls.Add(this.txtIdCli);
            this.tpDadosProd.Controls.Add(this.lblIdCli);
            this.tpDadosProd.Controls.Add(this.txtEnderecoCli);
            this.tpDadosProd.Controls.Add(this.txtDescProd);
            this.tpDadosProd.Controls.Add(this.lblEndereco);
            this.tpDadosProd.Controls.Add(this.lblUnidade);
            this.tpDadosProd.Controls.Add(this.lblDescProd);
            this.tpDadosProd.Location = new System.Drawing.Point(4, 22);
            this.tpDadosProd.Name = "tpDadosProd";
            this.tpDadosProd.Padding = new System.Windows.Forms.Padding(3);
            this.tpDadosProd.Size = new System.Drawing.Size(976, 532);
            this.tpDadosProd.TabIndex = 1;
            this.tpDadosProd.Text = "Dados";
            this.tpDadosProd.UseVisualStyleBackColor = true;
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
            // tpProduto
            // 
            this.tpProduto.Controls.Add(this.dgvProduto);
            this.tpProduto.Controls.Add(this.dgvClientes);
            this.tpProduto.Location = new System.Drawing.Point(4, 22);
            this.tpProduto.Name = "tpProduto";
            this.tpProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tpProduto.Size = new System.Drawing.Size(976, 532);
            this.tpProduto.TabIndex = 0;
            this.tpProduto.Text = "Produtos";
            this.tpProduto.UseVisualStyleBackColor = true;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToOrderColumns = true;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduto.Location = new System.Drawing.Point(3, 3);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(970, 526);
            this.dgvProduto.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddProduto,
            this.tsbtnEditProduto,
            this.tsbtnSalvar,
            this.tsbtnCancelar,
            this.toolStripSeparator,
            this.tsbtnImprimir,
            this.toolStripSeparator1,
            this.tsbtnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(983, 29);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tpProdutos
            // 
            this.tpProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpProdutos.Controls.Add(this.tpProduto);
            this.tpProdutos.Controls.Add(this.tpDadosProd);
            this.tpProdutos.Location = new System.Drawing.Point(-1, 32);
            this.tpProdutos.Multiline = true;
            this.tpProdutos.Name = "tpProdutos";
            this.tpProdutos.SelectedIndex = 0;
            this.tpProdutos.Size = new System.Drawing.Size(984, 558);
            this.tpProdutos.TabIndex = 0;
            this.tpProdutos.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox1.Location = new System.Drawing.Point(356, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 26);
            this.textBox1.TabIndex = 2;
            // 
            // rdoProdAtivo
            // 
            this.rdoProdAtivo.AutoSize = true;
            this.rdoProdAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoProdAtivo.Location = new System.Drawing.Point(291, 36);
            this.rdoProdAtivo.Name = "rdoProdAtivo";
            this.rdoProdAtivo.Size = new System.Drawing.Size(57, 21);
            this.rdoProdAtivo.TabIndex = 0;
            this.rdoProdAtivo.Text = "Ativo";
            this.rdoProdAtivo.UseVisualStyleBackColor = true;
            // 
            // rdoProdInativo
            // 
            this.rdoProdInativo.AutoSize = true;
            this.rdoProdInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoProdInativo.Location = new System.Drawing.Point(354, 36);
            this.rdoProdInativo.Name = "rdoProdInativo";
            this.rdoProdInativo.Size = new System.Drawing.Size(67, 21);
            this.rdoProdInativo.TabIndex = 0;
            this.rdoProdInativo.Text = "Inativo";
            this.rdoProdInativo.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox2.Location = new System.Drawing.Point(235, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 26);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(232, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lucro (%):";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox3.Location = new System.Drawing.Point(331, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 26);
            this.textBox3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(328, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "R$ Venda:";
            // 
            // tsbtnAddProduto
            // 
            this.tsbtnAddProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddProduto.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddProduto.Image")));
            this.tsbtnAddProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddProduto.Name = "tsbtnAddProduto";
            this.tsbtnAddProduto.Size = new System.Drawing.Size(26, 26);
            this.tsbtnAddProduto.Text = "Novo";
            // 
            // tsbtnEditProduto
            // 
            this.tsbtnEditProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEditProduto.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditProduto.Image")));
            this.tsbtnEditProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditProduto.Name = "tsbtnEditProduto";
            this.tsbtnEditProduto.Size = new System.Drawing.Size(26, 26);
            this.tsbtnEditProduto.Text = "Editar";
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
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox4.Location = new System.Drawing.Point(11, 157);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(90, 26);
            this.textBox4.TabIndex = 3;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEstoque.Location = new System.Drawing.Point(8, 136);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(70, 18);
            this.lblEstoque.TabIndex = 0;
            this.lblEstoque.Text = "Estoque:";
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tpProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProduto_KeyDown);
            this.tpDadosProd.ResumeLayout(false);
            this.tpDadosProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tpProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tpProdutos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdCli;
        private System.Windows.Forms.Label lblIdCli;
        private System.Windows.Forms.TextBox txtEnderecoCli;
        private System.Windows.Forms.TextBox txtDescProd;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.Label lblDescProd;
        private System.Windows.Forms.TabPage tpDadosProd;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TabPage tpProduto;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl tpProdutos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoProdInativo;
        private System.Windows.Forms.RadioButton rdoProdAtivo;
        private System.Windows.Forms.ToolStripButton tsbtnAddProduto;
        private System.Windows.Forms.ToolStripButton tsbtnEditProduto;
        private System.Windows.Forms.ToolStripButton tsbtnSalvar;
        private System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblEstoque;
    }
}