namespace Projeto_Novo
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.tcClientes = new System.Windows.Forms.TabControl();
            this.tpCliente = new System.Windows.Forms.TabPage();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tpDados = new System.Windows.Forms.TabPage();
            this.grpTpCliente = new System.Windows.Forms.GroupBox();
            this.rdoJuridica = new System.Windows.Forms.RadioButton();
            this.rdoFisica = new System.Windows.Forms.RadioButton();
            this.rdoCliInativo = new System.Windows.Forms.RadioButton();
            this.rdoCliAtivo = new System.Windows.Forms.RadioButton();
            this.mtxCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mtxRG = new System.Windows.Forms.MaskedTextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.lnlNumEnd = new System.Windows.Forms.Label();
            this.txtIdCli = new System.Windows.Forms.TextBox();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.txtBairroCli = new System.Windows.Forms.TextBox();
            this.txtNumEndCli = new System.Windows.Forms.TextBox();
            this.txtEnderecoCli = new System.Windows.Forms.TextBox();
            this.mtxDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddCliente = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditCliente = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.pnlCliente.SuspendLayout();
            this.tcClientes.SuspendLayout();
            this.tpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tpDados.SuspendLayout();
            this.grpTpCliente.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCliente
            // 
            this.pnlCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCliente.Controls.Add(this.txtPesquisa);
            this.pnlCliente.Controls.Add(this.tcClientes);
            this.pnlCliente.Controls.Add(this.toolStrip1);
            this.pnlCliente.Controls.Add(this.lblPesquisa);
            this.pnlCliente.Location = new System.Drawing.Point(0, 0);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(983, 590);
            this.pnlCliente.TabIndex = 0;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(76, 32);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(257, 20);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TabStop = false;
            // 
            // tcClientes
            // 
            this.tcClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcClientes.Controls.Add(this.tpCliente);
            this.tcClientes.Controls.Add(this.tpDados);
            this.tcClientes.Location = new System.Drawing.Point(-1, 58);
            this.tcClientes.Multiline = true;
            this.tcClientes.Name = "tcClientes";
            this.tcClientes.SelectedIndex = 0;
            this.tcClientes.Size = new System.Drawing.Size(984, 532);
            this.tcClientes.TabIndex = 0;
            this.tcClientes.TabStop = false;
            // 
            // tpCliente
            // 
            this.tpCliente.Controls.Add(this.dgvCliente);
            this.tpCliente.Controls.Add(this.dgvClientes);
            this.tpCliente.Location = new System.Drawing.Point(4, 22);
            this.tpCliente.Name = "tpCliente";
            this.tpCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tpCliente.Size = new System.Drawing.Size(976, 506);
            this.tpCliente.TabIndex = 0;
            this.tpCliente.Text = "Cliente";
            this.tpCliente.UseVisualStyleBackColor = true;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(3, 3);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(970, 500);
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
            this.dgvClientes.Size = new System.Drawing.Size(970, 500);
            this.dgvClientes.TabIndex = 0;
            // 
            // tpDados
            // 
            this.tpDados.Controls.Add(this.grpTpCliente);
            this.tpDados.Controls.Add(this.rdoCliInativo);
            this.tpDados.Controls.Add(this.rdoCliAtivo);
            this.tpDados.Controls.Add(this.mtxCpfCnpj);
            this.tpDados.Controls.Add(this.lblCPF);
            this.tpDados.Controls.Add(this.mtxRG);
            this.tpDados.Controls.Add(this.lblRG);
            this.tpDados.Controls.Add(this.lnlNumEnd);
            this.tpDados.Controls.Add(this.txtIdCli);
            this.tpDados.Controls.Add(this.lblIdCli);
            this.tpDados.Controls.Add(this.txtBairroCli);
            this.tpDados.Controls.Add(this.txtNumEndCli);
            this.tpDados.Controls.Add(this.txtEnderecoCli);
            this.tpDados.Controls.Add(this.mtxDtNasc);
            this.tpDados.Controls.Add(this.txtNomeCli);
            this.tpDados.Controls.Add(this.lblBairro);
            this.tpDados.Controls.Add(this.lblEndereco);
            this.tpDados.Controls.Add(this.lblDtNasc);
            this.tpDados.Controls.Add(this.lblNomeCli);
            this.tpDados.Location = new System.Drawing.Point(4, 22);
            this.tpDados.Name = "tpDados";
            this.tpDados.Padding = new System.Windows.Forms.Padding(3);
            this.tpDados.Size = new System.Drawing.Size(976, 506);
            this.tpDados.TabIndex = 1;
            this.tpDados.Text = "Dados";
            this.tpDados.UseVisualStyleBackColor = true;
            // 
            // grpTpCliente
            // 
            this.grpTpCliente.Controls.Add(this.rdoJuridica);
            this.grpTpCliente.Controls.Add(this.rdoFisica);
            this.grpTpCliente.Location = new System.Drawing.Point(780, 13);
            this.grpTpCliente.Name = "grpTpCliente";
            this.grpTpCliente.Size = new System.Drawing.Size(150, 53);
            this.grpTpCliente.TabIndex = 21;
            this.grpTpCliente.TabStop = false;
            this.grpTpCliente.Text = "Tipo cliente";
            // 
            // rdoJuridica
            // 
            this.rdoJuridica.AutoSize = true;
            this.rdoJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoJuridica.Location = new System.Drawing.Point(71, 19);
            this.rdoJuridica.Name = "rdoJuridica";
            this.rdoJuridica.Size = new System.Drawing.Size(75, 21);
            this.rdoJuridica.TabIndex = 19;
            this.rdoJuridica.Text = "Jurídica";
            this.rdoJuridica.UseVisualStyleBackColor = true;
            // 
            // rdoFisica
            // 
            this.rdoFisica.AutoSize = true;
            this.rdoFisica.Checked = true;
            this.rdoFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoFisica.Location = new System.Drawing.Point(6, 19);
            this.rdoFisica.Name = "rdoFisica";
            this.rdoFisica.Size = new System.Drawing.Size(62, 21);
            this.rdoFisica.TabIndex = 20;
            this.rdoFisica.TabStop = true;
            this.rdoFisica.Text = "Fisíca";
            this.rdoFisica.UseVisualStyleBackColor = true;
            // 
            // rdoCliInativo
            // 
            this.rdoCliInativo.AutoSize = true;
            this.rdoCliInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoCliInativo.Location = new System.Drawing.Point(275, 37);
            this.rdoCliInativo.Name = "rdoCliInativo";
            this.rdoCliInativo.Size = new System.Drawing.Size(67, 21);
            this.rdoCliInativo.TabIndex = 17;
            this.rdoCliInativo.Text = "Inativo";
            this.rdoCliInativo.UseVisualStyleBackColor = true;
            // 
            // rdoCliAtivo
            // 
            this.rdoCliAtivo.AutoSize = true;
            this.rdoCliAtivo.Checked = true;
            this.rdoCliAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoCliAtivo.Location = new System.Drawing.Point(212, 37);
            this.rdoCliAtivo.Name = "rdoCliAtivo";
            this.rdoCliAtivo.Size = new System.Drawing.Size(57, 21);
            this.rdoCliAtivo.TabIndex = 18;
            this.rdoCliAtivo.TabStop = true;
            this.rdoCliAtivo.Text = "Ativo";
            this.rdoCliAtivo.UseVisualStyleBackColor = true;
            // 
            // mtxCpfCnpj
            // 
            this.mtxCpfCnpj.Font = new System.Drawing.Font("Arial", 12F);
            this.mtxCpfCnpj.Location = new System.Drawing.Point(468, 91);
            this.mtxCpfCnpj.Mask = "###,###,###-##";
            this.mtxCpfCnpj.Name = "mtxCpfCnpj";
            this.mtxCpfCnpj.Size = new System.Drawing.Size(130, 26);
            this.mtxCpfCnpj.TabIndex = 3;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCPF.Location = new System.Drawing.Point(465, 70);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(45, 18);
            this.lblCPF.TabIndex = 16;
            this.lblCPF.Text = "CPF:";
            // 
            // mtxRG
            // 
            this.mtxRG.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtxRG.Font = new System.Drawing.Font("Arial", 12F);
            this.mtxRG.Location = new System.Drawing.Point(348, 91);
            this.mtxRG.Mask = "##,###,###-#";
            this.mtxRG.Name = "mtxRG";
            this.mtxRG.Size = new System.Drawing.Size(114, 26);
            this.mtxRG.TabIndex = 2;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Arial", 12F);
            this.lblRG.Location = new System.Drawing.Point(345, 70);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(35, 18);
            this.lblRG.TabIndex = 15;
            this.lblRG.Text = "RG:";
            // 
            // lnlNumEnd
            // 
            this.lnlNumEnd.AutoSize = true;
            this.lnlNumEnd.Font = new System.Drawing.Font("Arial", 12F);
            this.lnlNumEnd.Location = new System.Drawing.Point(342, 129);
            this.lnlNumEnd.Name = "lnlNumEnd";
            this.lnlNumEnd.Size = new System.Drawing.Size(28, 18);
            this.lnlNumEnd.TabIndex = 12;
            this.lnlNumEnd.Text = "Nº:";
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
            this.txtIdCli.TabStop = false;
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
            // txtBairroCli
            // 
            this.txtBairroCli.Font = new System.Drawing.Font("Arial", 12F);
            this.txtBairroCli.Location = new System.Drawing.Point(403, 150);
            this.txtBairroCli.Name = "txtBairroCli";
            this.txtBairroCli.Size = new System.Drawing.Size(301, 26);
            this.txtBairroCli.TabIndex = 7;
            // 
            // txtNumEndCli
            // 
            this.txtNumEndCli.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNumEndCli.Location = new System.Drawing.Point(345, 150);
            this.txtNumEndCli.Name = "txtNumEndCli";
            this.txtNumEndCli.Size = new System.Drawing.Size(52, 26);
            this.txtNumEndCli.TabIndex = 6;
            // 
            // txtEnderecoCli
            // 
            this.txtEnderecoCli.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEnderecoCli.Location = new System.Drawing.Point(11, 150);
            this.txtEnderecoCli.Name = "txtEnderecoCli";
            this.txtEnderecoCli.Size = new System.Drawing.Size(331, 26);
            this.txtEnderecoCli.TabIndex = 5;
            // 
            // mtxDtNasc
            // 
            this.mtxDtNasc.Font = new System.Drawing.Font("Arial", 12F);
            this.mtxDtNasc.Location = new System.Drawing.Point(604, 91);
            this.mtxDtNasc.Mask = "00/00/0000";
            this.mtxDtNasc.Name = "mtxDtNasc";
            this.mtxDtNasc.Size = new System.Drawing.Size(100, 26);
            this.mtxDtNasc.TabIndex = 4;
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNomeCli.Location = new System.Drawing.Point(11, 91);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(331, 26);
            this.txtNomeCli.TabIndex = 1;
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddCliente,
            this.tsbtnEditCliente,
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
            // tsbtnAddCliente
            // 
            this.tsbtnAddCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddCliente.Image")));
            this.tsbtnAddCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddCliente.Name = "tsbtnAddCliente";
            this.tsbtnAddCliente.Size = new System.Drawing.Size(26, 26);
            this.tsbtnAddCliente.Text = "Novo";
            this.tsbtnAddCliente.Click += new System.EventHandler(this.tsbtnAddCliente_Click);
            // 
            // tsbtnEditCliente
            // 
            this.tsbtnEditCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEditCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditCliente.Image")));
            this.tsbtnEditCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditCliente.Name = "tsbtnEditCliente";
            this.tsbtnEditCliente.Size = new System.Drawing.Size(26, 26);
            this.tsbtnEditCliente.Text = "Editar";
            // 
            // tsbtnSalvar
            // 
            this.tsbtnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSalvar.Enabled = false;
            this.tsbtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSalvar.Image")));
            this.tsbtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSalvar.Name = "tsbtnSalvar";
            this.tsbtnSalvar.Size = new System.Drawing.Size(26, 26);
            this.tsbtnSalvar.Text = "Salvar";
            this.tsbtnSalvar.Click += new System.EventHandler(this.tsbtnSalvar_Click);
            // 
            // tsbtnCancelar
            // 
            this.tsbtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCancelar.Enabled = false;
            this.tsbtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancelar.Image")));
            this.tsbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancelar.Name = "tsbtnCancelar";
            this.tsbtnCancelar.Size = new System.Drawing.Size(26, 26);
            this.tsbtnCancelar.Text = "Cancelar";
            this.tsbtnCancelar.Click += new System.EventHandler(this.tsbtnCancelar_Click);
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
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(12, 35);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisa.TabIndex = 17;
            this.lblPesquisa.Text = "Pesquisar:";
            // 
            // FrmCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(983, 590);
            this.Controls.Add(this.pnlCliente);
            this.KeyPreview = true;
            this.Name = "FrmCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCliente_KeyDown);
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.tcClientes.ResumeLayout(false);
            this.tpCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tpDados.ResumeLayout(false);
            this.tpDados.PerformLayout();
            this.grpTpCliente.ResumeLayout(false);
            this.grpTpCliente.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TabControl tcClientes;
        private System.Windows.Forms.TabPage tpCliente;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TabPage tpDados;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAddCliente;
        private System.Windows.Forms.ToolStripButton tsbtnEditCliente;
        private System.Windows.Forms.ToolStripButton tsbtnSalvar;
        private System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtIdCli;
        private System.Windows.Forms.Label lblIdCli;
        private System.Windows.Forms.TextBox txtBairroCli;
        private System.Windows.Forms.TextBox txtNumEndCli;
        private System.Windows.Forms.TextBox txtEnderecoCli;
        private System.Windows.Forms.MaskedTextBox mtxDtNasc;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.Label lnlNumEnd;
        private System.Windows.Forms.MaskedTextBox mtxCpfCnpj;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mtxRG;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.RadioButton rdoCliInativo;
        private System.Windows.Forms.RadioButton rdoCliAtivo;
        private System.Windows.Forms.GroupBox grpTpCliente;
        private System.Windows.Forms.RadioButton rdoJuridica;
        private System.Windows.Forms.RadioButton rdoFisica;
    }
}