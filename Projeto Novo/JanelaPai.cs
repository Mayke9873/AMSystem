using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Novo
{
    public class JanelaPai
    {
        private JanelaPai() { }

        private static FrmPrincipal newInstance;
        public static FrmPrincipal Instance()
        {
            if (newInstance == null)
            {
                newInstance = new FrmPrincipal();
                return newInstance;
            }

            return newInstance;
        }


    }
}
