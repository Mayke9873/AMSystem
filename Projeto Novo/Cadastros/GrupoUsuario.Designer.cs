namespace Projeto_Novo
{
    partial class FrmGrupoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrupoUsuario));
            this.pnlGrupoUsu = new System.Windows.Forms.Panel();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.tsGrupoUsu = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddGrupoUSu = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditGrupoUsu = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.tpGrupoUsuarios = new System.Windows.Forms.TabControl();
            this.tpGrupoUsuario = new System.Windows.Forms.TabPage();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tpDadosUsu = new System.Windows.Forms.TabPage();
            this.txtDescTipoUsu = new System.Windows.Forms.TextBox();
            this.rdoInativo = new System.Windows.Forms.RadioButton();
            this.rdoAtivo = new System.Windows.Forms.RadioButton();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.lblDescTipoUsu = new System.Windows.Forms.Label();
            this.tbPemissoes = new System.Windows.Forms.TabPage();
            this.dgvPermUsu = new System.Windows.Forms.DataGridView();
            this.pnlGrupoUsu.SuspendLayout();
            this.tsGrupoUsu.SuspendLayout();
            this.tpGrupoUsuarios.SuspendLayout();
            this.tpGrupoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tpDadosUsu.SuspendLayout();
            this.tbPemissoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGrupoUsu
            // 
            this.pnlGrupoUsu.Controls.Add(this.lblPesquisa);
            this.pnlGrupoUsu.Controls.Add(this.txtPesquisa);
            this.pnlGrupoUsu.Controls.Add(this.tsGrupoUsu);
            this.pnlGrupoUsu.Controls.Add(this.tpGrupoUsuarios);
            this.pnlGrupoUsu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrupoUsu.Location = new System.Drawing.Point(0, 0);
            this.pnlGrupoUsu.Name = "pnlGrupoUsu";
            this.pnlGrupoUsu.Size = new System.Drawing.Size(983, 590);
            this.pnlGrupoUsu.TabIndex = 0;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(12, 35);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisa.TabIndex = 13;
            this.lblPesquisa.Text = "Pesquisar:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(74, 32);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(257, 20);
            this.txtPesquisa.TabIndex = 12;
            this.txtPesquisa.TabStop = false;
            // 
            // tsGrupoUsu
            // 
            this.tsGrupoUsu.BackColor = System.Drawing.SystemColors.Control;
            this.tsGrupoUsu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsGrupoUsu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsGrupoUsu.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.tsGrupoUsu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddGrupoUSu,
            this.tsbtnEditGrupoUsu,
            this.tsbtnSalvar,
            this.tsbtnCancelar,
            this.toolStripSeparator,
            this.tsbtnImprimir,
            this.toolStripSeparator1,
            this.tsbtnSair});
            this.tsGrupoUsu.Location = new System.Drawing.Point(0, 0);
            this.tsGrupoUsu.Name = "tsGrupoUsu";
            this.tsGrupoUsu.Size = new System.Drawing.Size(983, 29);
            this.tsGrupoUsu.TabIndex = 11;
            this.tsGrupoUsu.Text = "Grupo Usuario";
            // 
            // tsbtnAddGrupoUSu
            // 
            this.tsbtnAddGrupoUSu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddGrupoUSu.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddGrupoUSu.Image")));
            this.tsbtnAddGrupoUSu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddGrupoUSu.Name = "tsbtnAddGrupoUSu";
            this.tsbtnAddGrupoUSu.Size = new System.Drawing.Size(26, 26);
            this.tsbtnAddGrupoUSu.Text = "Novo";
            // 
            // tsbtnEditGrupoUsu
            // 
            this.tsbtnEditGrupoUsu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEditGrupoUsu.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditGrupoUsu.Image")));
            this.tsbtnEditGrupoUsu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditGrupoUsu.Name = "tsbtnEditGrupoUsu";
            this.tsbtnEditGrupoUsu.Size = new System.Drawing.Size(26, 26);
            this.tsbtnEditGrupoUsu.Text = "Editar";
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
            // tpGrupoUsuarios
            // 
            this.tpGrupoUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpGrupoUsuarios.Controls.Add(this.tpGrupoUsuario);
            this.tpGrupoUsuarios.Controls.Add(this.tpDadosUsu);
            this.tpGrupoUsuarios.Controls.Add(this.tbPemissoes);
            this.tpGrupoUsuarios.Location = new System.Drawing.Point(-1, 58);
            this.tpGrupoUsuarios.Multiline = true;
            this.tpGrupoUsuarios.Name = "tpGrupoUsuarios";
            this.tpGrupoUsuarios.SelectedIndex = 0;
            this.tpGrupoUsuarios.Size = new System.Drawing.Size(984, 532);
            this.tpGrupoUsuarios.TabIndex = 10;
            this.tpGrupoUsuarios.TabStop = false;
            // 
            // tpGrupoUsuario
            // 
            this.tpGrupoUsuario.Controls.Add(this.dgvUsuarios);
            this.tpGrupoUsuario.Controls.Add(this.dgvClientes);
            this.tpGrupoUsuario.Location = new System.Drawing.Point(4, 22);
            this.tpGrupoUsuario.Name = "tpGrupoUsuario";
            this.tpGrupoUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tpGrupoUsuario.Size = new System.Drawing.Size(976, 506);
            this.tpGrupoUsuario.TabIndex = 0;
            this.tpGrupoUsuario.Text = "Tipo Usuario";
            this.tpGrupoUsuario.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 3);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(970, 500);
            this.dgvUsuarios.TabIndex = 2;
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
            // tpDadosUsu
            // 
            this.tpDadosUsu.Controls.Add(this.txtDescTipoUsu);
            this.tpDadosUsu.Controls.Add(this.rdoInativo);
            this.tpDadosUsu.Controls.Add(this.rdoAtivo);
            this.tpDadosUsu.Controls.Add(this.txtIdUsuario);
            this.tpDadosUsu.Controls.Add(this.lblIdCli);
            this.tpDadosUsu.Controls.Add(this.lblDescTipoUsu);
            this.tpDadosUsu.Location = new System.Drawing.Point(4, 22);
            this.tpDadosUsu.Name = "tpDadosUsu";
            this.tpDadosUsu.Padding = new System.Windows.Forms.Padding(3);
            this.tpDadosUsu.Size = new System.Drawing.Size(976, 506);
            this.tpDadosUsu.TabIndex = 1;
            this.tpDadosUsu.Text = "Dados";
            this.tpDadosUsu.UseVisualStyleBackColor = true;
            // 
            // txtDescTipoUsu
            // 
            this.txtDescTipoUsu.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDescTipoUsu.Location = new System.Drawing.Point(11, 91);
            this.txtDescTipoUsu.Name = "txtDescTipoUsu";
            this.txtDescTipoUsu.Size = new System.Drawing.Size(356, 26);
            this.txtDescTipoUsu.TabIndex = 1;
            // 
            // rdoInativo
            // 
            this.rdoInativo.AutoSize = true;
            this.rdoInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoInativo.Location = new System.Drawing.Point(300, 37);
            this.rdoInativo.Name = "rdoInativo";
            this.rdoInativo.Size = new System.Drawing.Size(67, 21);
            this.rdoInativo.TabIndex = 0;
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
            this.rdoAtivo.TabIndex = 0;
            this.rdoAtivo.Text = "Ativo";
            this.rdoAtivo.UseVisualStyleBackColor = true;
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
            this.txtIdUsuario.TabStop = false;
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
            // lblDescTipoUsu
            // 
            this.lblDescTipoUsu.AutoSize = true;
            this.lblDescTipoUsu.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDescTipoUsu.Location = new System.Drawing.Point(8, 70);
            this.lblDescTipoUsu.Name = "lblDescTipoUsu";
            this.lblDescTipoUsu.Size = new System.Drawing.Size(84, 18);
            this.lblDescTipoUsu.TabIndex = 0;
            this.lblDescTipoUsu.Text = "Descrição:";
            // 
            // tbPemissoes
            // 
            this.tbPemissoes.Controls.Add(this.dgvPermUsu);
            this.tbPemissoes.Location = new System.Drawing.Point(4, 22);
            this.tbPemissoes.Name = "tbPemissoes";
            this.tbPemissoes.Padding = new System.Windows.Forms.Padding(3);
            this.tbPemissoes.Size = new System.Drawing.Size(976, 506);
            this.tbPemissoes.TabIndex = 2;
            this.tbPemissoes.Text = "Permissões";
            this.tbPemissoes.UseVisualStyleBackColor = true;
            // 
            // dgvPermUsu
            // 
            this.dgvPermUsu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPermUsu.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvPermUsu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPermUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermUsu.Location = new System.Drawing.Point(0, 0);
            this.dgvPermUsu.Name = "dgvPermUsu";
            this.dgvPermUsu.Size = new System.Drawing.Size(660, 530);
            this.dgvPermUsu.TabIndex = 0;
            // 
            // FrmGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.pnlGrupoUsu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmGrupoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GrupoUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGrupoUsuario_KeyDown);
            this.pnlGrupoUsu.ResumeLayout(false);
            this.pnlGrupoUsu.PerformLayout();
            this.tsGrupoUsu.ResumeLayout(false);
            this.tsGrupoUsu.PerformLayout();
            this.tpGrupoUsuarios.ResumeLayout(false);
            this.tpGrupoUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tpDadosUsu.ResumeLayout(false);
            this.tpDadosUsu.PerformLayout();
            this.tbPemissoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermUsu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrupoUsu;
        private System.Windows.Forms.ToolStrip tsGrupoUsu;
        private System.Windows.Forms.ToolStripButton tsbtnAddGrupoUSu;
        private System.Windows.Forms.ToolStripButton tsbtnEditGrupoUsu;
        private System.Windows.Forms.ToolStripButton tsbtnSalvar;
        private System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.TabControl tpGrupoUsuarios;
        private System.Windows.Forms.TabPage tpGrupoUsuario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TabPage tpDadosUsu;
        private System.Windows.Forms.TextBox txtDescTipoUsu;
        private System.Windows.Forms.RadioButton rdoInativo;
        private System.Windows.Forms.RadioButton rdoAtivo;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label lblIdCli;
        private System.Windows.Forms.Label lblDescTipoUsu;
        private System.Windows.Forms.TabPage tbPemissoes;
        private System.Windows.Forms.DataGridView dgvPermUsu;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
    }
}