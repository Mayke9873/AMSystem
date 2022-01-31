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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }
        private void FrmFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)

        }

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
