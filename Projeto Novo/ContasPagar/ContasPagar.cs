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
    public partial class FrmContasPagar : Form
    {
        public FrmContasPagar()
        {
            InitializeComponent();
        }
        private void FrmContasPagar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                    break;

                case Keys.Escape:
                    tsbtnSair_Click(sender, e);
                    break;
            }
        }
        private void tsbtnEditC_Pagar_Click(object sender, EventArgs e)
        {
            ContasPagar.FrmPagar pagar = new ContasPagar.FrmPagar();
            pagar.ShowDialog();
        }

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
