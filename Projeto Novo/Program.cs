using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Novo
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin login = new FrmLogin();

            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(ControleJanelas.CriarInstaceMDI());
            }
        }
    }
}
