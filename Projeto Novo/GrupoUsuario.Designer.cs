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
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditGrupoUsu = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAddGrupoUSu = new System.Windows.Forms.ToolStripButton();
            this.rdoUsuInativo = new System.Windows.Forms.RadioButton();
            this.rdoUsuAtivo = new System.Windows.Forms.RadioButton();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.tsGrupoUsu = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.tpDadosUsu = new System.Windows.Forms.TabPage();
            this.lblDescTipoUsu = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tpGrupoUsuario = new System.Windows.Forms.TabPage();
            this.tpGrupoUsuarios = new System.Windows.Forms.TabControl();
            this.tbPemissoes = new System.Windows.Forms.TabPage();
            this.dgvPermUsu = new System.Windows.Forms.DataGridView();
            this.txtDescTipoUsu = new System.Windows.Forms.TextBox();
            this.tsGrupoUsu.SuspendLayout();
            this.tpDadosUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tpGrupoUsuario.SuspendLayout();
            this.tpGrupoUsuarios.SuspendLayout();
            this.tbPemissoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermUsu)).BeginInit();
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
            // tsbtnEditGrupoUsu
            // 
            this.tsbtnEditGrupoUsu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEditGrupoUsu.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditGrupoUsu.Image")));
            this.tsbtnEditGrupoUsu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditGrupoUsu.Name = "tsbtnEditGrupoUsu";
            this.tsbtnEditGrupoUsu.Size = new System.Drawing.Size(26, 26);
            this.tsbtnEditGrupoUsu.Text = "Editar";
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
            // rdoUsuInativo
            // 
            this.rdoUsuInativo.AutoSize = true;
            this.rdoUsuInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoUsuInativo.Location = new System.Drawing.Point(300, 37);
            this.rdoUsuInativo.Name = "rdoUsuInativo";
            this.rdoUsuInativo.Size = new System.Drawing.Size(67, 21);
            this.rdoUsuInativo.TabIndex = 0;
            this.rdoUsuInativo.Text = "Inativo";
            this.rdoUsuInativo.UseVisualStyleBackColor = true;
            // 
            // rdoUsuAtivo
            // 
            this.rdoUsuAtivo.AutoSize = true;
            this.rdoUsuAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoUsuAtivo.Location = new System.Drawing.Point(237, 37);
            this.rdoUsuAtivo.Name = "rdoUsuAtivo";
            this.rdoUsuAtivo.Size = new System.Drawing.Size(57, 21);
            this.rdoUsuAtivo.TabIndex = 0;
            this.rdoUsuAtivo.Text = "Ativo";
            this.rdoUsuAtivo.UseVisualStyleBackColor = true;
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
            this.tsGrupoUsu.TabIndex = 7;
            this.tsGrupoUsu.Text = "Grupo Usuario";
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
            // tpDadosUsu
            // 
            this.tpDadosUsu.Controls.Add(this.txtDescTipoUsu);
            this.tpDadosUsu.Controls.Add(this.rdoUsuInativo);
            this.tpDadosUsu.Controls.Add(this.rdoUsuAtivo);
            this.tpDadosUsu.Controls.Add(this.txtIdUsuario);
            this.tpDadosUsu.Controls.Add(this.lblIdCli);
            this.tpDadosUsu.Controls.Add(this.lblDescTipoUsu);
            this.tpDadosUsu.Location = new System.Drawing.Point(4, 22);
            this.tpDadosUsu.Name = "tpDadosUsu";
            this.tpDadosUsu.Padding = new System.Windows.Forms.Padding(3);
            this.tpDadosUsu.Size = new System.Drawing.Size(976, 532);
            this.tpDadosUsu.TabIndex = 1;
            this.tpDadosUsu.Text = "Dados";
            this.tpDadosUsu.UseVisualStyleBackColor = true;
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
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 3);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(970, 526);
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
            this.dgvClientes.Size = new System.Drawing.Size(970, 526);
            this.dgvClientes.TabIndex = 0;
            // 
            // tpGrupoUsuario
            // 
            this.tpGrupoUsuario.Controls.Add(this.dgvUsuarios);
            this.tpGrupoUsuario.Controls.Add(this.dgvClientes);
            this.tpGrupoUsuario.Location = new System.Drawing.Point(4, 22);
            this.tpGrupoUsuario.Name = "tpGrupoUsuario";
            this.tpGrupoUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tpGrupoUsuario.Size = new System.Drawing.Size(976, 532);
            this.tpGrupoUsuario.TabIndex = 0;
            this.tpGrupoUsuario.Text = "Tipo Usuario";
            this.tpGrupoUsuario.UseVisualStyleBackColor = true;
            // 
            // tpGrupoUsuarios
            // 
            this.tpGrupoUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpGrupoUsuarios.Controls.Add(this.tpGrupoUsuario);
            this.tpGrupoUsuarios.Controls.Add(this.tpDadosUsu);
            this.tpGrupoUsuarios.Controls.Add(this.tbPemissoes);
            this.tpGrupoUsuarios.Location = new System.Drawing.Point(-1, 32);
            this.tpGrupoUsuarios.Multiline = true;
            this.tpGrupoUsuarios.Name = "tpGrupoUsuarios";
            this.tpGrupoUsuarios.SelectedIndex = 0;
            this.tpGrupoUsuarios.Size = new System.Drawing.Size(984, 558);
            this.tpGrupoUsuarios.TabIndex = 6;
            this.tpGrupoUsuarios.TabStop = false;
            // 
            // tbPemissoes
            // 
            this.tbPemissoes.Controls.Add(this.dgvPermUsu);
            this.tbPemissoes.Location = new System.Drawing.Point(4, 22);
            this.tbPemissoes.Name = "tbPemissoes";
            this.tbPemissoes.Padding = new System.Windows.Forms.Padding(3);
            this.tbPemissoes.Size = new System.Drawing.Size(976, 532);
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
            // txtDescTipoUsu
            // 
            this.txtDescTipoUsu.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDescTipoUsu.Location = new System.Drawing.Point(11, 91);
            this.txtDescTipoUsu.Name = "txtDescTipoUsu";
            this.txtDescTipoUsu.Size = new System.Drawing.Size(356, 26);
            this.txtDescTipoUsu.TabIndex = 1;
            // 
            // FrmGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.tsGrupoUsu);
            this.Controls.Add(this.tpGrupoUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmGrupoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GrupoUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGrupoUsuario_KeyDown);
            this.tsGrupoUsu.ResumeLayout(false);
            this.tsGrupoUsu.PerformLayout();
            this.tpDadosUsu.ResumeLayout(false);
            this.tpDadosUsu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tpGrupoUsuario.ResumeLayout(false);
            this.tpGrupoUsuarios.ResumeLayout(false);
            this.tbPemissoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermUsu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStripButton tsbtnSalvar;
        private System.Windows.Forms.ToolStripButton tsbtnEditGrupoUsu;
        private System.Windows.Forms.ToolStripButton tsbtnAddGrupoUSu;
        private System.Windows.Forms.RadioButton rdoUsuInativo;
        private System.Windows.Forms.RadioButton rdoUsuAtivo;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.ToolStrip tsGrupoUsu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lblIdCli;
        private System.Windows.Forms.TabPage tpDadosUsu;
        private System.Windows.Forms.Label lblDescTipoUsu;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TabPage tpGrupoUsuario;
        private System.Windows.Forms.TabControl tpGrupoUsuarios;
        private System.Windows.Forms.TabPage tbPemissoes;
        private System.Windows.Forms.DataGridView dgvPermUsu;
        private System.Windows.Forms.TextBox txtDescTipoUsu;
    }
}