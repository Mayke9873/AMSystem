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
    public partial class FrmConsCompras : Form
    {
        public FrmConsCompras()
        {
            InitializeComponent();
        }
        private void FrmConsCompras_KeyDown(object sender, KeyEventArgs e)
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

        private void tsbtnAddCompra_Click(object sender, EventArgs e)
        {
            FrmCompra compra = new FrmCompra();
            compra.ShowDialog();
        }

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
