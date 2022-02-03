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
    public partial class FrmReceber : Form
    {
        public FrmReceber()
        {
            InitializeComponent();
        }

        private void FrmReceber_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.SelectNextControl(ActiveControl, !e.Shift, true, true, true);
                    break;

                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.F1:
                    btnNovo_Click(sender, e);
                    break;

                case Keys .F2:
                    btnReceber_Click(sender, e);
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

        private void btnReceber_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Receber");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Excluir");
        }
    }
}
