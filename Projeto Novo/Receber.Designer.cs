﻿namespace Projeto_Novo
{
    partial class FrmReceber
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
            this.pnlReceber = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnReceber = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvReceber = new System.Windows.Forms.DataGridView();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.pnlReceber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReceber
            // 
            this.pnlReceber.Controls.Add(this.btnExcluir);
            this.pnlReceber.Controls.Add(this.btnReceber);
            this.pnlReceber.Controls.Add(this.btnNovo);
            this.pnlReceber.Controls.Add(this.dgvReceber);
            this.pnlReceber.Controls.Add(this.maskedTextBox2);
            this.pnlReceber.Controls.Add(this.lblPeriodo);
            this.pnlReceber.Controls.Add(this.maskedTextBox1);
            this.pnlReceber.Controls.Add(this.lblPesquisa);
            this.pnlReceber.Controls.Add(this.txtPesquisa);
            this.pnlReceber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReceber.Location = new System.Drawing.Point(0, 0);
            this.pnlReceber.Name = "pnlReceber";
            this.pnlReceber.Size = new System.Drawing.Size(1084, 661);
            this.pnlReceber.TabIndex = 2;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 9F);
            this.btnExcluir.Location = new System.Drawing.Point(201, 621);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(96, 32);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "F3 - Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnReceber
            // 
            this.btnReceber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReceber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceber.Font = new System.Drawing.Font("Arial", 9F);
            this.btnReceber.Location = new System.Drawing.Point(102, 621);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(96, 32);
            this.btnReceber.TabIndex = 18;
            this.btnReceber.Text = "F2 - Receber";
            this.btnReceber.UseVisualStyleBackColor = true;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Arial", 9F);
            this.btnNovo.Location = new System.Drawing.Point(3, 621);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(96, 32);
            this.btnNovo.TabIndex = 17;
            this.btnNovo.Text = "F1 - Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgvReceber
            // 
            this.dgvReceber.AllowUserToOrderColumns = true;
            this.dgvReceber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceber.Location = new System.Drawing.Point(3, 43);
            this.dgvReceber.Name = "dgvReceber";
            this.dgvReceber.Size = new System.Drawing.Size(1078, 571);
            this.dgvReceber.TabIndex = 16;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox2.Location = new System.Drawing.Point(653, 13);
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
            this.lblPeriodo.Location = new System.Drawing.Point(518, 16);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(48, 13);
            this.lblPeriodo.TabIndex = 14;
            this.lblPeriodo.Text = "Período:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.Location = new System.Drawing.Point(572, 13);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBox1.TabIndex = 12;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(12, 16);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(42, 13);
            this.lblPesquisa.TabIndex = 11;
            this.lblPesquisa.Text = "Cliente:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(74, 13);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(358, 20);
            this.txtPesquisa.TabIndex = 10;
            // 
            // FrmReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.pnlReceber);
            this.KeyPreview = true;
            this.Name = "FrmReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Receber";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmReceber_KeyDown);
            this.pnlReceber.ResumeLayout(false);
            this.pnlReceber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReceber;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnReceber;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvReceber;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
    }
}