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
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                    break;

                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            if (txtSenhaUsu.Text == "")
            {
                MessageBox.Show("Senha não informada, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtRetirada.Text == "")
            {
                txtRetirada.Text = "0";
            }

            MessageBox.Show("Realizado retirada de: " + txtRetirada.Text + "R$", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
