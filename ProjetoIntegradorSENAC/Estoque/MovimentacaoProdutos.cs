using MySql.Data.MySqlClient;
using ProjetoIntegradorSENAC.Classes;
using ProjetoIntegradorSENAC.Empresa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoIntegradorSENAC.Estoque
{
    public partial class MovimentacaoProdutos : Form
    {
        private int _comercioId;

        public MovimentacaoProdutos(int comercioId)
        {
            InitializeComponent();
            _comercioId = comercioId;
        }

           private void MovimentacaoProdutos_Load(object sender, EventArgs e)
        {
            cbTipoFiltro.Items.Clear();
            cbTipoFiltro.Items.Add("TODOS");
            cbTipoFiltro.Items.Add("DEVOLUCAO_CLIENTE");
            cbTipoFiltro.Items.Add("AJUSTE_POSITIVO");
            cbTipoFiltro.Items.Add("AJUSTE_NEGATIVO");
            cbTipoFiltro.Items.Add("OUTROS");
            cbTipoFiltro.SelectedIndex = 0;

            dtpDe.Value = DateTime.Now.AddMonths(-1);
            dtpAte.Value = DateTime.Now;

            CarregarMovimentacoes();
        }


        private void CarregarMovimentacoes()
        {
            using (var conn = Banco.AbrirConexao())
            {
                string sql = @"
            SELECT 
                p.nome AS Produto,
                m.tipo AS Tipo,
                m.quantidade AS Quantidade,
                m.quantidade_final AS 'Qtd Final',
                m.motivo AS Motivo,
                m.observacao AS Observacao,
                m.data AS Data,
                u.nome AS Funcionario
            FROM movimentacoes_estoque m
            INNER JOIN produtos p ON p.id = m.produto_id
            LEFT JOIN funcionarios f ON f.id = m.funcionario_id
            LEFT JOIN usuarios u ON u.id = f.usuarios_id
            WHERE m.comercio_id = @comercioId
        ";

                // 🔎 FILTRO NOME PRODUTO
                if (!string.IsNullOrWhiteSpace(txtPesquisar.Text))
                {
                    sql += " AND p.nome LIKE @nomeProduto ";
                }

                // 🔎 FILTRO MOTIVO (CORRETO AGORA)
                if (cbTipoFiltro.Text != "TODOS")
                {
                    sql += " AND m.motivo = @motivo ";
                }

                // 🔎 FILTRO DATA
                sql += " AND DATE(m.data) BETWEEN @dataInicio AND @dataFim ";

                sql += " ORDER BY m.data DESC";

                var cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@comercioId", _comercioId);

                if (!string.IsNullOrWhiteSpace(txtPesquisar.Text))
                    cmd.Parameters.AddWithValue("@nomeProduto", "%" + txtPesquisar.Text + "%");

                if (cbTipoFiltro.Text != "TODOS")
                    cmd.Parameters.AddWithValue("@motivo", cbTipoFiltro.Text);

                cmd.Parameters.AddWithValue("@dataInicio", dtpDe.Value.Date);
                cmd.Parameters.AddWithValue("@dataFim", dtpAte.Value.Date);

                using (var da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgMovimentacoes.DataSource = dt;

                    dtgMovimentacoes.Columns["Quantidade"].DefaultCellStyle.Format = "#,0.##";
                    dtgMovimentacoes.Columns["Qtd Final"].DefaultCellStyle.Format = "#,0.##";
                }
            }
        }



        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TextChanged_1(object sender, EventArgs e)
        {
            CarregarMovimentacoes();
        }

        private void cbTipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarMovimentacoes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtpDe.Value.Date > dtpAte.Value.Date)
            {
                MessageBox.Show("A data inicial não pode ser maior que a data final.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            CarregarMovimentacoes();
        }
    }
}