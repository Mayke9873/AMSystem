namespace Projeto_Novo
{
    partial class fmrCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrCliente));
            this.tpClientes = new System.Windows.Forms.TabControl();
            this.tpCliente = new System.Windows.Forms.TabPage();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tpDados = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imprimirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.recortarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copiarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tpClientes.SuspendLayout();
            this.tpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tpDados.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpClientes
            // 
            this.tpClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpClientes.Controls.Add(this.tpCliente);
            this.tpClientes.Controls.Add(this.tpDados);
            this.tpClientes.Location = new System.Drawing.Point(0, 32);
            this.tpClientes.Multiline = true;
            this.tpClientes.Name = "tpClientes";
            this.tpClientes.SelectedIndex = 0;
            this.tpClientes.Size = new System.Drawing.Size(984, 558);
            this.tpClientes.TabIndex = 0;
            // 
            // tpCliente
            // 
            this.tpCliente.Controls.Add(this.dgvCliente);
            this.tpCliente.Controls.Add(this.dgvClientes);
            this.tpCliente.Location = new System.Drawing.Point(4, 22);
            this.tpCliente.Name = "tpCliente";
            this.tpCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tpCliente.Size = new System.Drawing.Size(976, 536);
            this.tpCliente.TabIndex = 0;
            this.tpCliente.Text = "Cliente";
            this.tpCliente.UseVisualStyleBackColor = true;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToOrderColumns = true;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCliente.Location = new System.Drawing.Point(3, 3);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(970, 530);
            this.dgvCliente.TabIndex = 2;
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
            this.dgvClientes.Size = new System.Drawing.Size(970, 530);
            this.dgvClientes.TabIndex = 0;
            // 
            // tpDados
            // 
            this.tpDados.Controls.Add(this.textBox4);
            this.tpDados.Controls.Add(this.textBox3);
            this.tpDados.Controls.Add(this.textBox2);
            this.tpDados.Controls.Add(this.maskedTextBox1);
            this.tpDados.Controls.Add(this.textBox1);
            this.tpDados.Controls.Add(this.label4);
            this.tpDados.Controls.Add(this.label3);
            this.tpDados.Controls.Add(this.label2);
            this.tpDados.Controls.Add(this.label1);
            this.tpDados.Location = new System.Drawing.Point(4, 22);
            this.tpDados.Name = "tpDados";
            this.tpDados.Padding = new System.Windows.Forms.Padding(3);
            this.tpDados.Size = new System.Drawing.Size(976, 532);
            this.tpDados.TabIndex = 1;
            this.tpDados.Text = "Dados";
            this.tpDados.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripButton,
            this.abrirToolStripButton,
            this.salvarToolStripButton,
            this.imprimirToolStripButton,
            this.toolStripSeparator,
            this.recortarToolStripButton,
            this.copiarToolStripButton,
            this.colarToolStripButton,
            this.toolStripSeparator1,
            this.ajudaToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(983, 29);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // novoToolStripButton
            // 
            this.novoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripButton.Image")));
            this.novoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripButton.Name = "novoToolStripButton";
            this.novoToolStripButton.Size = new System.Drawing.Size(26, 26);
            this.novoToolStripButton.Text = "&Novo";
            // 
            // abrirToolStripButton
            // 
            this.abrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripButton.Image")));
            this.abrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton.Name = "abrirToolStripButton";
            this.abrirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.abrirToolStripButton.Text = "&Abrir";
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvarToolStripButton.Text = "&Salvar";
            // 
            // imprimirToolStripButton
            // 
            this.imprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripButton.Image")));
            this.imprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripButton.Name = "imprimirToolStripButton";
            this.imprimirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.imprimirToolStripButton.Text = "&Imprimir";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // recortarToolStripButton
            // 
            this.recortarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.recortarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("recortarToolStripButton.Image")));
            this.recortarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.recortarToolStripButton.Name = "recortarToolStripButton";
            this.recortarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.recortarToolStripButton.Text = "Recor&tar";
            // 
            // copiarToolStripButton
            // 
            this.copiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripButton.Image")));
            this.copiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripButton.Name = "copiarToolStripButton";
            this.copiarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copiarToolStripButton.Text = "&Copiar";
            // 
            // colarToolStripButton
            // 
            this.colarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("colarToolStripButton.Image")));
            this.colarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colarToolStripButton.Name = "colarToolStripButton";
            this.colarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.colarToolStripButton.Text = "C&olar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ajudaToolStripButton
            // 
            this.ajudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ajudaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripButton.Image")));
            this.ajudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ajudaToolStripButton.Name = "ajudaToolStripButton";
            this.ajudaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ajudaToolStripButton.Text = "&Ajuda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(359, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dt Nasc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(8, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(359, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bairro:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox1.Location = new System.Drawing.Point(11, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 26);
            this.textBox1.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.maskedTextBox1.Location = new System.Drawing.Point(362, 44);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox2.Location = new System.Drawing.Point(11, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(285, 26);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox3.Location = new System.Drawing.Point(298, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(52, 26);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox4.Location = new System.Drawing.Point(362, 114);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(285, 26);
            this.textBox4.TabIndex = 8;
            // 
            // fmrCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tpClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tpClientes.ResumeLayout(false);
            this.tpCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tpDados.ResumeLayout(false);
            this.tpDados.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tpClientes;
        private System.Windows.Forms.TabPage tpCliente;
        private System.Windows.Forms.TabPage tpDados;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton novoToolStripButton;
        private System.Windows.Forms.ToolStripButton abrirToolStripButton;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripButton imprimirToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton recortarToolStripButton;
        private System.Windows.Forms.ToolStripButton copiarToolStripButton;
        private System.Windows.Forms.ToolStripButton colarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ajudaToolStripButton;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}