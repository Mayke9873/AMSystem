﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Novo.Relatorios
{
    public partial class frmRelVendas : Form
    {
        public frmRelVendas()
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
        }

        private void GeraRelatrio()
        {
            // TODO: esta linha de código carrega dados na tabela 'projeto_dbDataSet.venda'. Você pode movê-la ou removê-la conforme necessário.

            if (chkTodos.Checked)
            {
                this.vendaTableAdapter.Fill(this.projeto_dbDataSet.venda);
                this.rpvVendas.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DtInicial", (string)null));
                this.rpvVendas.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DtFinal", (string)null));
                this.rpvVendas.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.rpvVendas.RefreshReport();
            }
            else
            {
                this.vendaTableAdapter.Fill(this.projeto_dbDataSet.venda);
                this.rpvVendas.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DtInicial", dtpInicial.Text));
                this.rpvVendas.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DtFinal", dtpFinal.Text));
                this.rpvVendas.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.rpvVendas.RefreshReport();
            }
        }

        private void frmRelVendas_Load(object sender, EventArgs e)
        {
            this.GeraRelatrio();
        }

        private void tbnFiltrar_Click(object sender, EventArgs e)
        {
            this.GeraRelatrio();
        }
    }
}
