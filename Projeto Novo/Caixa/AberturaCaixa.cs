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
    public partial class FrmAberturaCaixa : Form
    {
        public FrmAberturaCaixa()
        {
            InitializeComponent();
        }

        private void FrmAberturaCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    //Retira som do envento.
                    e.SuppressKeyPress = true;

                    //Se enter = Pula para o proximo campo.
                    this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                    break;

                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            if (txtSenhaUsu.Text == "")
            {
                MessageBox.Show("Senha não informada, por favor verifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenhaUsu.Focus();
                return;
            }

            if (txtValorAbertura.Text == "")
            {
                txtValorAbertura.Text = "0";
            }

            MessageBox.Show("Caixa aberto com: " + txtValorAbertura.Text + "R$", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
