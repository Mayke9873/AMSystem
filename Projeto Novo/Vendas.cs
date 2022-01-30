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
    public partial class FrmVendas : Form
    {
        public FrmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    btnSair_Click(sender, e);
                    break;

                case Keys.F2:
                    btnCancelar_Click(sender, e);
                    break;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Length != 0 || txtCliente.Text.Length != 0 || txtIdProduto.Text.Length != 0 && txtProduto.Text.Length != 0)
            {
                if (MessageBox.Show("Deseja cancelar venda?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                if (MessageBox.Show("Sair sair da venda?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar venda?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtIdVenda.Clear();
                txtCliente.Clear();
                txtIdCliente.Clear();
                txtIdProduto.Clear();
                txtProduto.Clear();
                txtQtd.Clear();
                txtValorUnit.Clear();
                txtValorTotal.Clear();
                txtDesconto.Clear();
            }
        }
    }
}
