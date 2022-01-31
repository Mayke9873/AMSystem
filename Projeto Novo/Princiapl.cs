using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

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

                case Keys.Alt | Keys.F4:
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

            if (Application.OpenForms.OfType<FrmCliente>().Count() > 0)
            {
                MessageBox.Show("Tela de Produtos já está aberta, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                cliente.Show();
                return;
            }
        }

        private void tsmiFornecedor_Click(object sender, EventArgs e)
        {
            FrmFornecedor fornecedor = new FrmFornecedor();
            fornecedor.TopLevel = false;
            pnlPrincipal.Controls.Add(fornecedor);

            if (Application.OpenForms.OfType<FrmFornecedor>().Count() > 0)
            {
                MessageBox.Show("Tela de Produtos já está aberta, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                fornecedor.Show();
                return;
            }
        }

        private void tsbtnPedido_Click(object sender, EventArgs e)
        {
            FrmVenda vendas= new FrmVenda();
            vendas.TopLevel = false;
            pnlPrincipal.Controls.Add(vendas);

            if (Application.OpenForms.OfType <FrmVenda>().Count()>0)
            {
                MessageBox.Show("Tela de Vendas já está aberta, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                vendas.Show();
                return;
            }
        }
        private void tsmiPedido_Click(object sender, EventArgs e)
        {
            tsbtnPedido_Click(sender, e);
        }

        private void tsmiProdutos_Click(object sender, EventArgs e)
        {
            FrmProduto produtos = new FrmProduto();
            produtos.TopLevel = false;
            pnlPrincipal.Controls.Add(produtos);
            if (Application.OpenForms.OfType<FrmProduto>().Count() > 0)
            {
                MessageBox.Show("Tela de Produtos já está aberta, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                produtos.Show();
                return;
            }
        }

        private void tsmiFuncionario_Click(object sender, EventArgs e)
        {
            FrmFuncionario funcionario = new FrmFuncionario();
            funcionario.TopLevel = false;
            pnlPrincipal.Controls.Add(funcionario);
            if (Application.OpenForms.OfType<FrmFuncionario>().Count() > 0)
            {
                MessageBox.Show("Tela de Produtos já está aberta, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                funcionario.Show();
                return;
            }
        }
    }
}
