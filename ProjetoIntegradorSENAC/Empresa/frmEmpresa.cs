using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Empresa
{
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();

            dtgEmpresas.ColumnCount = 1;
            dtgEmpresas.Columns[0].Name = "Nome da Empresa";
            dtgEmpresas.Rows.Add("SENAC - Projeto integrador");
            dtgEmpresas.Rows.Add("SENAI - Projeto integrador");
            dtgEmpresas.Rows.Add("CARONE - Projeto integrador");
            dtgEmpresas.Rows.Add("SEMPRE TEM - Projeto integrador");
        }

        private void dtgEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainPrincipal mainPrincipal = new MainPrincipal();
            mainPrincipal.Show();
            this.Hide();
        }
    }
}
