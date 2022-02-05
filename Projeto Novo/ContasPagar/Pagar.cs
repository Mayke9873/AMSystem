using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Novo.ContasPagar
{
    public partial class FrmPagar : Form
    {
        public FrmPagar()
        {
            InitializeComponent();
        }

        private void FrmPagar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.Enter:
                    break;

                case Keys.F1:
                    btnNovo_Click(sender, e);
                    break;

                case Keys.F2:
                    btnPagar_Click(sender, e);
                    break;

                case Keys.F3:
                    btnExcluir_Click(sender, e);
                    break;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Novo");
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pagar");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Excluir");
        }
    }
}
