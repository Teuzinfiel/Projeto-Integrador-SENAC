using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegradorSENAC.Logins;

namespace ProjetoIntegradorSENAC.Empresa
{
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            dtgEmpresas.ColumnCount = 1;
            dtgEmpresas.Columns[0].Name = "Nome da Empresa";
            dtgEmpresas.Rows.Add("SENAC - Projeto integrador");
            dtgEmpresas.Rows.Add("SENAI - Projeto integrador");
            dtgEmpresas.Rows.Add("CARONE - Projeto integrador");
            dtgEmpresas.Rows.Add("SEMPRE TEM - Projeto integrador");
            dtgEmpresas.ClearSelection();
        }

        private void dtgEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainPrincipal mainPrincipal = new MainPrincipal();
            mainPrincipal.Show();
            this.Hide();
        }

        // evento de hover no data grid de empresa
        private void dtgEmpresas_CellMouseEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // pra nao contar com cabecalho
            {
                dtgEmpresas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(70, 70, 90);
            }
        }

        private void dtgEmpresas_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dtgEmpresas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 50);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loginUsuario loginUsuario = new loginUsuario();
            loginUsuario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadEmpresa cadEmpresa = new cadEmpresa();
            cadEmpresa.Show();
            this.Hide();
        }
    }
}
