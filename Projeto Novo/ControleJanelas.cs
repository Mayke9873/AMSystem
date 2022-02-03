using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Novo
{
    internal class ControleJanelas
    {
        private ControleJanelas() {  }

        private static FrmPrincipal InstancePricinpal;

        public static FrmPrincipal CriarInstaceMDI()
        {
            if (InstancePricinpal == null)
            {
                InstancePricinpal = new FrmPrincipal();
                return InstancePricinpal;
            }
            return InstancePricinpal;
        }
    }
}