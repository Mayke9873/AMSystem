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
    public partial class FrmConsVendas : Form
    {
        public FrmConsVendas()
        {
            InitializeComponent();
        }
        private void FrmConsVendas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    this.SelectNextControl(ActiveControl, !e.Shift, true, true, true);
                    break;

                case Keys.Escape:
                    tsbtnSair_Click(sender, e);
                    break;
            }
        }
        private void tsbtnAddVenda_Click(object sender, EventArgs e)
        {
            FrmVenda venda = new FrmVenda();
            venda.MdiParent = JanelaPai.Instance();

            if (Application.OpenForms.OfType<FrmVenda>().Count() > 0)
            {
                MessageBox.Show("Tela já está aberta, por favor verifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            venda.Show();
        }

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
