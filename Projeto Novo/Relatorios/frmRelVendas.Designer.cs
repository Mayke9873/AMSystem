namespace Projeto_Novo.Relatorios
{
    partial class frmRelVendas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelVendas));
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetodbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeto_dbDataSet = new Projeto_Novo.projeto_dbDataSet();
            this.rpvVendas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vendaTableAdapter = new Projeto_Novo.projeto_dbDataSetTableAdapters.vendaTableAdapter();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetodbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "venda";
            this.vendaBindingSource.DataSource = this.projetodbDataSetBindingSource;
            // 
            // projetodbDataSetBindingSource
            // 
            this.projetodbDataSetBindingSource.DataSource = this.projeto_dbDataSet;
            this.projetodbDataSetBindingSource.Position = 0;
            // 
            // projeto_dbDataSet
            // 
            this.projeto_dbDataSet.DataSetName = "projeto_dbDataSet";
            this.projeto_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvVendas
            // 
            this.rpvVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvVendas.IsDocumentMapWidthFixed = true;
            reportDataSource1.Name = "Venda_DataSet";
            reportDataSource1.Value = this.vendaBindingSource;
            this.rpvVendas.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvVendas.LocalReport.ReportEmbeddedResource = "Projeto_Novo.Relatorios.Vendas.rdlc";
            this.rpvVendas.Location = new System.Drawing.Point(0, 0);
            this.rpvVendas.Name = "rpvVendas";
            this.rpvVendas.ServerReport.BearerToken = null;
            this.rpvVendas.ShowBackButton = false;
            this.rpvVendas.ShowFindControls = false;
            this.rpvVendas.ShowRefreshButton = false;
            this.rpvVendas.ShowStopButton = false;
            this.rpvVendas.Size = new System.Drawing.Size(684, 551);
            this.rpvVendas.TabIndex = 0;
            this.rpvVendas.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // dtpInicial
            // 
            this.dtpInicial.Enabled = false;
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(398, 3);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(79, 20);
            this.dtpInicial.TabIndex = 1;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Enabled = false;
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(507, 3);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(79, 20);
            this.dtpFinal.TabIndex = 2;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.BackColor = System.Drawing.Color.Transparent;
            this.chkTodos.Checked = true;
            this.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTodos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkTodos.Location = new System.Drawing.Point(591, 5);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(56, 17);
            this.chkTodos.TabIndex = 3;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = false;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "até";
            // 
            // tbnFiltrar
            // 
            this.tbnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("tbnFiltrar.Image")));
            this.tbnFiltrar.Location = new System.Drawing.Point(644, 2);
            this.tbnFiltrar.Name = "tbnFiltrar";
            this.tbnFiltrar.Size = new System.Drawing.Size(31, 23);
            this.tbnFiltrar.TabIndex = 5;
            this.tbnFiltrar.UseVisualStyleBackColor = true;
            this.tbnFiltrar.Click += new System.EventHandler(this.tbnFiltrar_Click);
            // 
            // frmRelVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 551);
            this.Controls.Add(this.tbnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicial);
            this.Controls.Add(this.rpvVendas);
            this.Name = "frmRelVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Vendas";
            this.Load += new System.EventHandler(this.frmRelVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetodbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvVendas;
        private System.Windows.Forms.BindingSource projetodbDataSetBindingSource;
        private projeto_dbDataSet projeto_dbDataSet;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private projeto_dbDataSetTableAdapters.vendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tbnFiltrar;
    }
}