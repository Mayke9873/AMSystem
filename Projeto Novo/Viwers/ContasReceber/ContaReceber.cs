﻿using System;
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
    public partial class FrmContaReceber : Form
    {
        public FrmContaReceber()
        {
            InitializeComponent();
        }
        private void FrmContaReceber_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                    break;

                case Keys.Escape:
                    tsbtnSair_Click(sender, e);
                    break;
            }
        }

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnEditC_Receber_Click(object sender, EventArgs e)
        {
            FrmReceber receber = new FrmReceber();
            receber.MdiParent = JanelaPai.Instance();

            if (Application.OpenForms.OfType<FrmReceber>().Count() > 0)
            {
                MessageBox.Show("Tela já está aberta, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            receber.Show();
        }
    }
}
