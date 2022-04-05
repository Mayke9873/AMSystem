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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
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

                case Keys.F2:
                    tsbtnCReceber_Click(sender, e);
                    break;
            }
        }

        private void tsmiSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            cliente.MdiParent = this;

            if (Application.OpenForms.OfType<FrmCliente>().Count() > 0)
            {
                MessageBox.Show("Tela já está aberta, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            cliente.Show();
        }

        private void tsmiFornecedor_Click(object sender, EventArgs e)
        {
            FrmFornecedor fornecedor = new FrmFornecedor();
            fornecedor.MdiParent = this;

            if (Application.OpenForms.OfType<FrmFornecedor>().Count() > 0)
            {
                MessageBox.Show("Tela já está aberta, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            fornecedor.Show();
        }

        private void tsbtnPedido_Click(object sender, EventArgs e)
        {
            FrmVenda vendas = new FrmVenda();
            vendas.MdiParent = this;

            
            if (Application.OpenForms.OfType<FrmVenda>().Count() > 0)
            {
                vendas.Activate();
                MessageBox.Show("Tela já está aberta, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            vendas.Show();
        }
        private void tsmiPedido_Click(object sender, EventArgs e)
        {
            tsbtnPedido_Click(sender, e);
        }

        private void tsmiProdutos_Click(object sender, EventArgs e)
        {
            FrmProduto produtos = new FrmProduto();
            produtos.MdiParent = this;            
            
            if (Application.OpenForms.OfType <FrmProduto>().Count() > 0)
            {
                MessageBox.Show("Tela já está aberta, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            produtos.Show();
        }

        private void tsmiFuncionario_Click(object sender, EventArgs e)
        {
            FrmFuncionario funcionario = new FrmFuncionario();
            funcionario.MdiParent = this;            
            
            if (Application.OpenForms.OfType<FrmFuncionario>().Count() > 0)
            {
                MessageBox.Show("Tela já está aberta, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            funcionario.Show();
        }

        private void tsmiGrupoUsu_Click(object sender, EventArgs e)
        {
            FrmGrupoUsuario grupoUsuario = new FrmGrupoUsuario();
            grupoUsuario.MdiParent = this;            
            
            if (Application.OpenForms.OfType <FrmGrupoUsuario> ().Count() > 0)
            {
                MessageBox.Show("Tela já está aberta, por favor verifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            grupoUsuario.Show();
        }

        private void tsmiGrupoProd_Click(object sender, EventArgs e)
        {
            FrmGrupoProdutos grupoProdutos = new FrmGrupoProdutos();
            grupoProdutos.MdiParent = this;            
            
            if (Application.OpenForms.OfType <FrmGrupoProdutos> ().Count() > 0)
            {
                MessageBox.Show("Tela já está aberta, por favor verifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            grupoProdutos.Show();
        }

        private void tsmiConsPedido_Click(object sender, EventArgs e)
        {
            FrmConsVendas consVendas = new FrmConsVendas();
            consVendas.MdiParent = this;            
            
            if (Application.OpenForms.OfType <FrmConsVendas> ().Count() > 0)
            {
                MessageBox.Show("Tela já está aberta, por favor verifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            consVendas.Show();
        }

        private void tsmiAbreCaixa_Click(object sender, EventArgs e)
        {
            FrmAberturaCaixa aberturaCaixa = new FrmAberturaCaixa();
            aberturaCaixa.ShowDialog();
        }

        private void tsmiFechaCaixa_Click(object sender, EventArgs e)
        {
            FrmFechamentoCaixa fechamentoCaixa = new FrmFechamentoCaixa();
            fechamentoCaixa.ShowDialog();
        }

        private void tsbtnCReceber_Click(object sender, EventArgs e)
        {
            FrmContaReceber contaReceber = new FrmContaReceber();
            contaReceber.MdiParent = this;            

            if (Application.OpenForms.OfType<FrmContaReceber>().Count() > 0)
            {
                MessageBox.Show("Tela já está aberta, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            contaReceber.Show();
        }

        private void tmsiContaReceber_Click(object sender, EventArgs e)
        {
            tsbtnCReceber_Click(sender, e);
        }

        private void tsmiContaPagar_Click(object sender, EventArgs e)
        {
            FrmContasPagar contaPagar = new FrmContasPagar();
            contaPagar.MdiParent = this;            

            if (Application.OpenForms.OfType<FrmContasPagar>().Count() > 0)
            {
                MessageBox.Show("Tela já está aberta, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            contaPagar.Show();
        }

        private void tsmiMovCaixa_Click(object sender, EventArgs e)
        {
            Caixa.FrmMovCaixa movCaixa = new Caixa.FrmMovCaixa();
            movCaixa.MdiParent = this;            

            if (Application.OpenForms.OfType<Caixa.FrmMovCaixa>().Count() > 0)
            {
                MessageBox.Show("Tela já está aberta, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            movCaixa.Show();
        }

        private void tsmiContas_Click(object sender, EventArgs e)
        {
            Cadastros.FrmContas contas = new Cadastros.FrmContas();
            contas.MdiParent = this;            

            if (Application.OpenForms.OfType<Cadastros.FrmContas>().Count() > 0)
            {
                MessageBox.Show("Tela já está aberta, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            contas.Show();
        }

        private void mstiCompras_Click(object sender, EventArgs e)
        {
            FrmConsCompras consCompras = new FrmConsCompras();
            consCompras.MdiParent = this;            

            if (Application.OpenForms.OfType<FrmConsCompras>().Count() > 0)
            {
                MessageBox.Show("Tela já está aberta, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            consCompras.Show();
        }
    }
}