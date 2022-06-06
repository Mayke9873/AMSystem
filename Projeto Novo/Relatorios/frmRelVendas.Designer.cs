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
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetodbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeto_dbDataSet = new Projeto_Novo.projeto_dbDataSet();
            this.rpvVendas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vendaTableAdapter = new Projeto_Novo.projeto_dbDataSetTableAdapters.vendaTableAdapter();
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
            reportDataSource1.Name = "Venda_DataSet";
            reportDataSource1.Value = this.vendaBindingSource;
            this.rpvVendas.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvVendas.LocalReport.ReportEmbeddedResource = "Projeto_Novo.Relatorios.Vendas.rdlc";
            this.rpvVendas.Location = new System.Drawing.Point(0, 0);
            this.rpvVendas.Name = "rpvVendas";
            this.rpvVendas.ServerReport.BearerToken = null;
            this.rpvVendas.Size = new System.Drawing.Size(684, 551);
            this.rpvVendas.TabIndex = 0;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 551);
            this.Controls.Add(this.rpvVendas);
            this.Name = "frmRelVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Vendas";
            this.Load += new System.EventHandler(this.frmRelVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetodbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvVendas;
        private System.Windows.Forms.BindingSource projetodbDataSetBindingSource;
        private projeto_dbDataSet projeto_dbDataSet;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private projeto_dbDataSetTableAdapters.vendaTableAdapter vendaTableAdapter;
    }
}