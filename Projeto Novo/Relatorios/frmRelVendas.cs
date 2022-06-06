using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Projeto_Novo.Relatorios
{
    public partial class frmRelVendas : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd;

        public frmRelVendas()
        {
            InitializeComponent();
        }

        private void frmRelVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projeto_dbDataSet.venda'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaTableAdapter.Fill(this.projeto_dbDataSet.venda);
            this.rpvVendas.RefreshReport();
        }
    }
}
