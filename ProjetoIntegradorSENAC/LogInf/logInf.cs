using ProjetoIntegradorSENAC.Classes;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.LogInf
{
    public partial class logInf : Form
    {
        int idEmpresa;

        public logInf(int idEmpresa)
        {
            InitializeComponent();
            this.idEmpresa = idEmpresa;

            // Eventos
            txtPesquisar.TextChanged += (_, __) => CarregarLogs();
            dtInicio.ValueChanged += (_, __) => CarregarLogs();
            dtFim.ValueChanged += (_, __) => CarregarLogs();
            btnExportar.Click += BtnExportar_Click;

            CarregarLogs();
        }
        private void BtnExportar_Click(object sender, EventArgs e)
        {
            if (dgvLogs.DataSource == null)
            {
                MessageBox.Show("Não há dados para exportar.");
                return;
            }

            DataTable dt = (DataTable)dgvLogs.DataSource;

            frmPreviewLogs frm = new frmPreviewLogs(dt);
            frm.ShowDialog();
        }

        private void CarregarLogs()
        {
            string filtro = txtPesquisar.Text.Trim();

            StringBuilder sql = new StringBuilder();
            sql.Append(@"
                SELECT 
                    l.id,
                    u.nome AS Usuario,
                    l.descricao AS Descricao,
                    DATE_FORMAT(l.data, '%d/%m/%Y %H:%i') AS Data
                FROM logs l
                INNER JOIN usuarios u ON u.id = l.usuario_id
                WHERE l.comercio_id = " + idEmpresa + @"
            ");

            if (!string.IsNullOrEmpty(filtro))
            {
                sql.Append($@"
                    AND (
                        u.nome LIKE '%{filtro}%'
                        OR l.descricao LIKE '%{filtro}%'
                    )
                ");
            }

            sql.Append($@"
                AND l.data BETWEEN 
                    '{dtInicio.Value:yyyy-MM-dd} 00:00:00'
                AND '{dtFim.Value:yyyy-MM-dd} 23:59:59'
            ");

            sql.Append(" ORDER BY l.data DESC ");

            DataTable dt = Banco.Pesquisar(sql.ToString());
            dgvLogs.DataSource = dt;

            EstilizarGrid();
        }

        private void EstilizarGrid()
        {
            dgvLogs.RowHeadersVisible = false;
            dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLogs.MultiSelect = false;
            dgvLogs.AllowUserToResizeRows = false;

            dgvLogs.Columns["id"].HeaderText = "Código";
            dgvLogs.Columns["Usuario"].HeaderText = "Usuário";
            dgvLogs.Columns["Descricao"].HeaderText = "Descrição";
            dgvLogs.Columns["Data"].HeaderText = "Data/Hora";
        }
    }
}