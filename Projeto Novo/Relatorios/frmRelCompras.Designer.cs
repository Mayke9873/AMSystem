namespace Projeto_Novo.Relatorios
{
    partial class frmRelCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelCompras));
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetodbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeto_dbDataSet = new Projeto_Novo.projeto_dbDataSet();
            this.rpvCompras = new Microsoft.Reporting.WinForms.ReportViewer();
            this.compraTableAdapter = new Projeto_Novo.projeto_dbDataSetTableAdapters.compraTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetodbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataMember = "compra";
            this.compraBindingSource.DataSource = this.projetodbDataSetBindingSource;
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
            // rpvCompras
            // 
            this.rpvCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Compra_DataSet";
            reportDataSource1.Value = this.compraBindingSource;
            this.rpvCompras.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvCompras.LocalReport.ReportEmbeddedResource = "Projeto_Novo.Relatorios.Compras.rdlc";
            this.rpvCompras.Location = new System.Drawing.Point(0, 0);
            this.rpvCompras.Name = "rpvCompras";
            this.rpvCompras.ServerReport.BearerToken = null;
            this.rpvCompras.ShowBackButton = false;
            this.rpvCompras.ShowFindControls = false;
            this.rpvCompras.ShowRefreshButton = false;
            this.rpvCompras.ShowStopButton = false;
            this.rpvCompras.Size = new System.Drawing.Size(714, 749);
            this.rpvCompras.TabIndex = 0;
            // 
            // compraTableAdapter
            // 
            this.compraTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "até";
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
            this.chkTodos.TabIndex = 7;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = false;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // dtpFinal
            // 
            this.dtpFinal.Enabled = false;
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(507, 3);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(79, 20);
            this.dtpFinal.TabIndex = 6;
            this.dtpFinal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFinal_KeyDown);
            this.dtpFinal.Validated += new System.EventHandler(this.dtpFinal_Validated);
            // 
            // dtpInicial
            // 
            this.dtpInicial.Enabled = false;
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(398, 3);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(79, 20);
            this.dtpInicial.TabIndex = 5;
            this.dtpInicial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpInicial_KeyDown);
            // 
            // frmRelCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicial);
            this.Controls.Add(this.rpvCompras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelCompras";
            this.Load += new System.EventHandler(this.frmRelCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetodbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvCompras;
        private projeto_dbDataSet projeto_dbDataSet;
        private System.Windows.Forms.BindingSource projetodbDataSetBindingSource;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private projeto_dbDataSetTableAdapters.compraTableAdapter compraTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicial;
    }
}