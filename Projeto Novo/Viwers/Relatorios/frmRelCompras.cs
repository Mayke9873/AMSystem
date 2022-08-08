using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Novo.Relatorios
{
    public partial class frmRelCompras : Form
    {
        public frmRelCompras()
        {
            InitializeComponent();
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                dtpFinal.Enabled = false;
                dtpInicial.Enabled = false;
            }
            else
            {
                dtpFinal.Enabled = true;
                dtpInicial.Enabled = true;
            }
            this.GeraRelatrio();
        }

        private void GeraRelatrio()
        {
            // TODO: esta linha de código carrega dados na tabela 'projeto_dbDataSet.venda'. Você pode movê-la ou removê-la conforme necessário.

            if (chkTodos.Checked)
            {
                this.compraTableAdapter.Fill(this.projeto_dbDataSet.compra);
                this.rpvCompras.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DtInicial", (string)null));
                this.rpvCompras.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DtFinal", (string)null));
                this.rpvCompras.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Periodo", "Todos."));
                this.rpvCompras.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("de", (string)null));
                this.rpvCompras.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.rpvCompras.RefreshReport();
            }
            else
            {
                this.compraTableAdapter.Fill(this.projeto_dbDataSet.compra);
                this.rpvCompras.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DtInicial", dtpInicial.Text));
                this.rpvCompras.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DtFinal", dtpFinal.Text));
                this.rpvCompras.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Periodo", (string)null));
                this.rpvCompras.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("de", "até"));
                this.rpvCompras.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.rpvCompras.RefreshReport();
            }
        }

        private void frmRelCompras_Load(object sender, EventArgs e)
        {
            // Volta 3 meses no filtro data inicial
            DateTime data = DateTime.Parse(dtpInicial.Text).AddMonths(-3);
            dtpInicial.Text = data.ToString();

            this.GeraRelatrio();
        }

        private void dtpInicial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpFinal.Focus();
            }
        }

        private void dtpFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpInicial.Focus();
            }
        }

        private void dtpFinal_Validated(object sender, EventArgs e)
        {
            this.GeraRelatrio();
        }
    }
}
