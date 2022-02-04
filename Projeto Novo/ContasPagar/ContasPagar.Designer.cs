namespace Projeto_Novo
{
    partial class FrmContasPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContasPagar));
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.tsC_Receber = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddC_Pagar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditC_Pagar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.pnlContasReceber = new System.Windows.Forms.Panel();
            this.dgvFornPagar = new System.Windows.Forms.DataGridView();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.tsC_Receber.SuspendLayout();
            this.pnlContasReceber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornPagar)).BeginInit();
            this.SuspendLayout();
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
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(12, 35);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(64, 13);
            this.lblPesquisa.TabIndex = 11;
            this.lblPesquisa.Text = "Fornecedor:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(76, 32);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(257, 20);
            this.txtPesquisa.TabIndex = 10;
            // 
            // tsC_Receber
            // 
            this.tsC_Receber.BackColor = System.Drawing.SystemColors.Control;
            this.tsC_Receber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsC_Receber.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsC_Receber.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.tsC_Receber.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddC_Pagar,
            this.tsbtnEditC_Pagar,
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
            // tsbtnAddC_Pagar
            // 
            this.tsbtnAddC_Pagar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddC_Pagar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddC_Pagar.Image")));
            this.tsbtnAddC_Pagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddC_Pagar.Name = "tsbtnAddC_Pagar";
            this.tsbtnAddC_Pagar.Size = new System.Drawing.Size(26, 26);
            this.tsbtnAddC_Pagar.Text = "Novo";
            // 
            // tsbtnEditC_Pagar
            // 
            this.tsbtnEditC_Pagar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEditC_Pagar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditC_Pagar.Image")));
            this.tsbtnEditC_Pagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditC_Pagar.Name = "tsbtnEditC_Pagar";
            this.tsbtnEditC_Pagar.Size = new System.Drawing.Size(26, 26);
            this.tsbtnEditC_Pagar.Text = "Editar";
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
            // pnlContasReceber
            // 
            this.pnlContasReceber.Controls.Add(this.dgvFornPagar);
            this.pnlContasReceber.Controls.Add(this.maskedTextBox2);
            this.pnlContasReceber.Controls.Add(this.lblPeriodo);
            this.pnlContasReceber.Controls.Add(this.maskedTextBox1);
            this.pnlContasReceber.Controls.Add(this.lblPesquisa);
            this.pnlContasReceber.Controls.Add(this.txtPesquisa);
            this.pnlContasReceber.Controls.Add(this.tsC_Receber);
            this.pnlContasReceber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContasReceber.Location = new System.Drawing.Point(0, 0);
            this.pnlContasReceber.Name = "pnlContasReceber";
            this.pnlContasReceber.Size = new System.Drawing.Size(983, 590);
            this.pnlContasReceber.TabIndex = 2;
            // 
            // dgvFornPagar
            // 
            this.dgvFornPagar.AllowUserToOrderColumns = true;
            this.dgvFornPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFornPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornPagar.Location = new System.Drawing.Point(3, 58);
            this.dgvFornPagar.Name = "dgvFornPagar";
            this.dgvFornPagar.Size = new System.Drawing.Size(977, 529);
            this.dgvFornPagar.TabIndex = 16;
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
            // FrmContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.pnlContasReceber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmContasPagar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ContasPagar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmContasPagar_KeyDown);
            this.tsC_Receber.ResumeLayout(false);
            this.tsC_Receber.PerformLayout();
            this.pnlContasReceber.ResumeLayout(false);
            this.pnlContasReceber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornPagar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ToolStrip tsC_Receber;
        private System.Windows.Forms.ToolStripButton tsbtnAddC_Pagar;
        private System.Windows.Forms.ToolStripButton tsbtnEditC_Pagar;
        private System.Windows.Forms.ToolStripButton tsbtnSalvar;
        private System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.Panel pnlContasReceber;
        private System.Windows.Forms.DataGridView dgvFornPagar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}