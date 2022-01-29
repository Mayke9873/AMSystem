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
    public partial class fmrPrinciapl : Form
    {
        public fmrPrinciapl()
        {
            InitializeComponent();
        }

        private void tsmiSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tsmiClientes_Click(object sender, EventArgs e)
        {
            fmrCliente cliente = new fmrCliente();
            cliente.TopLevel = false;
            pnlPrincipal.Controls.Add(cliente);
            cliente.Show();
        }
    }
}
