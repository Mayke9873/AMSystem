namespace Projeto_Novo
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.tpUsuarios = new System.Windows.Forms.TabControl();
            this.tpUsuario = new System.Windows.Forms.TabPage();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tpDadosUsu = new System.Windows.Forms.TabPage();
            this.cmbFuncUsuario = new System.Windows.Forms.ComboBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.rdoUsuInativo = new System.Windows.Forms.RadioButton();
            this.rdoUsuAtivo = new System.Windows.Forms.RadioButton();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblDescFunc = new System.Windows.Forms.Label();
            this.tsUsuario = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddUsuario = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditUsuario = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.pnlUsuarios.SuspendLayout();
            this.tpUsuarios.SuspendLayout();
            this.tpUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tpDadosUsu.SuspendLayout();
            this.tsUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.Controls.Add(this.lblPesquisa);
            this.pnlUsuarios.Controls.Add(this.txtPesquisa);
            this.pnlUsuarios.Controls.Add(this.tpUsuarios);
            this.pnlUsuarios.Controls.Add(this.tsUsuario);
            this.pnlUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUsuarios.Location = new System.Drawing.Point(0, 0);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(983, 590);
            this.pnlUsuarios.TabIndex = 0;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(12, 35);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisa.TabIndex = 15;
            this.lblPesquisa.Text = "Pesquisar:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(74, 32);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(257, 20);
            this.txtPesquisa.TabIndex = 14;
            this.txtPesquisa.TabStop = false;
            // 
            // tpUsuarios
            // 
            this.tpUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpUsuarios.Controls.Add(this.tpUsuario);
            this.tpUsuarios.Controls.Add(this.tpDadosUsu);
            this.tpUsuarios.Location = new System.Drawing.Point(-1, 58);
            this.tpUsuarios.Multiline = true;
            this.tpUsuarios.Name = "tpUsuarios";
            this.tpUsuarios.SelectedIndex = 0;
            this.tpUsuarios.Size = new System.Drawing.Size(984, 532);
            this.tpUsuarios.TabIndex = 8;
            this.tpUsuarios.TabStop = false;
            // 
            // tpUsuario
            // 
            this.tpUsuario.Controls.Add(this.dgvUsuarios);
            this.tpUsuario.Controls.Add(this.dgvClientes);
            this.tpUsuario.Location = new System.Drawing.Point(4, 22);
            this.tpUsuario.Name = "tpUsuario";
            this.tpUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsuario.Size = new System.Drawing.Size(976, 506);
            this.tpUsuario.TabIndex = 0;
            this.tpUsuario.Text = "Usuarios";
            this.tpUsuario.UseVisualStyleBackColor = true;
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
            this.tpDadosUsu.Controls.Add(this.cmbFuncUsuario);
            this.tpDadosUsu.Controls.Add(this.txtLogin);
            this.tpDadosUsu.Controls.Add(this.lblUsuario);
            this.tpDadosUsu.Controls.Add(this.rdoUsuInativo);
            this.tpDadosUsu.Controls.Add(this.rdoUsuAtivo);
            this.tpDadosUsu.Controls.Add(this.txtIdUsuario);
            this.tpDadosUsu.Controls.Add(this.lblIdCli);
            this.tpDadosUsu.Controls.Add(this.txtSenha);
            this.tpDadosUsu.Controls.Add(this.lblSenha);
            this.tpDadosUsu.Controls.Add(this.lblDescFunc);
            this.tpDadosUsu.Location = new System.Drawing.Point(4, 22);
            this.tpDadosUsu.Name = "tpDadosUsu";
            this.tpDadosUsu.Padding = new System.Windows.Forms.Padding(3);
            this.tpDadosUsu.Size = new System.Drawing.Size(976, 506);
            this.tpDadosUsu.TabIndex = 1;
            this.tpDadosUsu.Text = "Dados";
            this.tpDadosUsu.UseVisualStyleBackColor = true;
            // 
            // cmbFuncUsuario
            // 
            this.cmbFuncUsuario.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbFuncUsuario.FormattingEnabled = true;
            this.cmbFuncUsuario.Location = new System.Drawing.Point(11, 91);
            this.cmbFuncUsuario.Name = "cmbFuncUsuario";
            this.cmbFuncUsuario.Size = new System.Drawing.Size(356, 26);
            this.cmbFuncUsuario.TabIndex = 2;
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Arial", 12F);
            this.txtLogin.Location = new System.Drawing.Point(11, 150);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(175, 26);
            this.txtLogin.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F);
            this.lblUsuario.Location = new System.Drawing.Point(8, 129);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(66, 18);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
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
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSenha.Location = new System.Drawing.Point(192, 150);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(175, 26);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSenha.Location = new System.Drawing.Point(189, 129);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 18);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha:";
            // 
            // lblDescFunc
            // 
            this.lblDescFunc.AutoSize = true;
            this.lblDescFunc.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDescFunc.Location = new System.Drawing.Point(8, 70);
            this.lblDescFunc.Name = "lblDescFunc";
            this.lblDescFunc.Size = new System.Drawing.Size(94, 18);
            this.lblDescFunc.TabIndex = 0;
            this.lblDescFunc.Text = "Funcionário:";
            // 
            // tsUsuario
            // 
            this.tsUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.tsUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsUsuario.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsUsuario.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.tsUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddUsuario,
            this.tsbtnEditUsuario,
            this.tsbtnSalvar,
            this.tsbtnCancelar,
            this.toolStripSeparator,
            this.tsbtnImprimir,
            this.toolStripSeparator1,
            this.tsbtnSair});
            this.tsUsuario.Location = new System.Drawing.Point(0, 0);
            this.tsUsuario.Name = "tsUsuario";
            this.tsUsuario.Size = new System.Drawing.Size(983, 29);
            this.tsUsuario.TabIndex = 9;
            this.tsUsuario.Text = "toolStrip1";
            // 
            // tsbtnAddUsuario
            // 
            this.tsbtnAddUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddUsuario.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddUsuario.Image")));
            this.tsbtnAddUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddUsuario.Name = "tsbtnAddUsuario";
            this.tsbtnAddUsuario.Size = new System.Drawing.Size(26, 26);
            this.tsbtnAddUsuario.Text = "Novo";
            // 
            // tsbtnEditUsuario
            // 
            this.tsbtnEditUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEditUsuario.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditUsuario.Image")));
            this.tsbtnEditUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditUsuario.Name = "tsbtnEditUsuario";
            this.tsbtnEditUsuario.Size = new System.Drawing.Size(26, 26);
            this.tsbtnEditUsuario.Text = "Editar";
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
            // FrmUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.pnlUsuarios);
            this.KeyPreview = true;
            this.Name = "FrmUsuario";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmUsuario_KeyDown);
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlUsuarios.PerformLayout();
            this.tpUsuarios.ResumeLayout(false);
            this.tpUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tpDadosUsu.ResumeLayout(false);
            this.tpDadosUsu.PerformLayout();
            this.tsUsuario.ResumeLayout(false);
            this.tsUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.TabControl tpUsuarios;
        private System.Windows.Forms.TabPage tpUsuario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TabPage tpDadosUsu;
        private System.Windows.Forms.ComboBox cmbFuncUsuario;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.RadioButton rdoUsuInativo;
        private System.Windows.Forms.RadioButton rdoUsuAtivo;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label lblIdCli;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblDescFunc;
        private System.Windows.Forms.ToolStrip tsUsuario;
        private System.Windows.Forms.ToolStripButton tsbtnAddUsuario;
        private System.Windows.Forms.ToolStripButton tsbtnEditUsuario;
        private System.Windows.Forms.ToolStripButton tsbtnSalvar;
        private System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
    }
}