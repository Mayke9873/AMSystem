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
    public partial class FrmFechamentoCaixa : Form
    {
        public FrmFechamentoCaixa()
        {
            InitializeComponent();
        }

        private void FrmFechamentoCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //Se enter = Pula para o proximo campo.
                case Keys.Enter:
                    this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                    break;

                case Keys.Escape:
                    this.Close();
                    break;
            }
        }
    }
}
