using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorSENAC.Classes
{
    internal class EfeitoClickBotaocs
    {
        public static void ResetarBotoes(Button btnCaixa, Button btnDashboard, Button btnEstoque, Button btnFuncionario, Button btnLog,Button btnProduto,Button btnMovimentacao)
        {
            btnCaixa.BackColor = Color.Transparent;
            btnDashboard.BackColor = Color.Transparent;
            btnEstoque.BackColor = Color.Transparent;
            btnFuncionario.BackColor = Color.Transparent;
            btnLog.BackColor = Color.Transparent;
            btnProduto.BackColor = Color.Transparent;
            btnMovimentacao.BackColor = Color.Transparent;

        }
    }
}
