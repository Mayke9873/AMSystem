using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Novo
{
    public partial class FrmPrinciapl : Form
    {
        public FrmPrinciapl()
        {
            InitializeComponent();
        }
        private void fmrPrinciapl_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    tsbtnPedido_Click(sender, e);
                    break;

                case Keys.Escape:
                    tsmiSair_Click(sender, e);
                    break;
            }
        }

        private void tsmiSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            tsmiSair_Click((object)sender, e);
        }

        private void tsmiClientes_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.TopLevel = false;
            pnlPrincipal.Controls.Add(cliente);
            cliente.Show();
        }

        private void tsmiFornecedor_Click(object sender, EventArgs e)
        {
            FrmFornecedor fornecedor = new FrmFornecedor();
            fornecedor.TopLevel = false;
            pnlPrincipal.Controls.Add(fornecedor);
            fornecedor.Show();
        }

        private void tsbtnPedido_Click(object sender, EventArgs e)
        {
            FrmVendas vendas= new FrmVendas();
            vendas.TopLevel = false;
            pnlPrincipal.Controls.Add(vendas);
            vendas.Show();
        }
    }
}
