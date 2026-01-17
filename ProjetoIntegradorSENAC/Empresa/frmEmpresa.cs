using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ProjetoIntegradorSENAC.Classes;
using ProjetoIntegradorSENAC.Configurações;
using ProjetoIntegradorSENAC.Logins;

namespace ProjetoIntegradorSENAC.Empresa
{
    public partial class frmEmpresa : Form
    {
        public int idUsuario;

        public frmEmpresa(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            try
            {
                string query = $@"
                            SELECT 
                                comercios.id AS id_comercio,
                                usuarios.id AS id_dono,
                                usuarios.nome AS dono,
                                comercios.nome AS comercio,
                                comercios.nome_fantasia AS fantasia,
                                comercios.documentacao
                            FROM comercios
                            JOIN usuarios ON usuarios.id = comercios.dono_id
                            WHERE comercios.dono_id = {idUsuario}  ";
                DataTable dt = Banco.Pesquisar(query);

                dtgEmpresas.DataSource = dt;
                dtgEmpresas.Columns["id_comercio"].Visible = false;
                dtgEmpresas.Columns["id_dono"].Visible = false;
                dtgEmpresas.Columns["dono"].HeaderText = "Gerente";
                dtgEmpresas.Columns["comercio"].HeaderText = "Comércio";
                dtgEmpresas.Columns["fantasia"].HeaderText = "Nome Fantasia";
                dtgEmpresas.Columns["documentacao"].HeaderText = "Documentacao";
            }
              
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar empresas: " + ex.Message);
            }
            dtgEmpresas.ClearSelection();

            string nomeUsuario = "";

            string queryUser = $"SELECT nome FROM usuarios WHERE id = {idUsuario}";
            DataTable dtUser = Banco.Pesquisar(queryUser);
            if (dtUser.Rows.Count > 0)
            {
                nomeUsuario = dtUser.Rows[0]["nome"].ToString();
                label4.Text = ($"Bem - vindo, { nomeUsuario}");
            }

        }

        private void dtgEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idComercio = Convert.ToInt32(dtgEmpresas.Rows[e.RowIndex].Cells["id_comercio"].Value);
            int idDono = Convert.ToInt32(dtgEmpresas.Rows[e.RowIndex].Cells["id_dono"].Value);

            MainPrincipal main = new MainPrincipal(idComercio, idDono, this.idUsuario);
            main.Show();
            this.Hide();
        }

        private void dtgEmpresas_CellMouseEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dtgEmpresas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(70, 70, 90);
        }

        private void dtgEmpresas_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dtgEmpresas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 50);
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
            cadEmpresa cad = new cadEmpresa(this.idUsuario);
            cad.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            configEmpresa cfg = new configEmpresa(this.idUsuario);
            cfg.Show();
            this.Hide();
        }
    }
}
