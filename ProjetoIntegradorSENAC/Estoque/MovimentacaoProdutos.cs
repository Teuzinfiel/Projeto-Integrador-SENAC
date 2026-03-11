using MySql.Data.MySqlClient;
using ProjetoIntegradorSENAC.Classes;
using ProjetoIntegradorSENAC.Empresa;
using ProjetoIntegradorSENAC.personalizado;
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
                string sql = $@"
SELECT 
    me.tipo AS Tipo,
    me.quantidade AS Quantidade,
    me.quantidade_final AS 'Qtd Final',
    me.motivo AS Motivo,
    me.observacao AS Observação,
    me.data AS Data,
    COALESCE(u.nome, '--') AS Funcionario
FROM movimentacoes_estoque me
LEFT JOIN funcionarios f ON f.id = me.funcionario_id
LEFT JOIN usuarios u ON u.id = f.usuarios_id
WHERE me.comercio_id = {_comercioId}"; 

                // 🔎 FILTRO MOTIVO
                if (cbTipoFiltro.Text != "TODOS")
                {
                    sql += " AND me.motivo = @motivo ";
                }

                // 🔎 FILTRO TEXTO (observacao ou outro campo)
                if (!string.IsNullOrWhiteSpace(txtPesquisar.Text))
                {
                    sql += " AND me.observacao LIKE @textoFiltro ";
                }

                // 🔎 FILTRO DATA (pega o dia inteiro)
                sql += " AND me.data >= @dataInicio AND me.data < DATE_ADD(@dataFim, INTERVAL 1 DAY) ";

                // 🔎 ORDER
                sql += " ORDER BY me.data DESC";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    if (cbTipoFiltro.Text != "TODOS")
                        cmd.Parameters.AddWithValue("@motivo", cbTipoFiltro.Text);

                    if (!string.IsNullOrWhiteSpace(txtPesquisar.Text))
                        cmd.Parameters.AddWithValue("@textoFiltro", "%" + txtPesquisar.Text + "%");

                    // pega início do dia e fim do dia
                    DateTime dataInicio = dtpDe.Value.Date;
                    DateTime dataFim = dtpAte.Value.Date.AddDays(1).AddSeconds(-1);
                    cmd.Parameters.AddWithValue("@dataInicio", dataInicio);
                    cmd.Parameters.AddWithValue("@dataFim", dataFim);

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dtgMovimentacoes.DataSource = dt;

                        // Formatação
                        dtgMovimentacoes.Columns["Quantidade"].DefaultCellStyle.Format = "#,0.##";
                        dtgMovimentacoes.Columns["Qtd Final"].DefaultCellStyle.Format = "#,0.##";
                        dtgMovimentacoes.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    }
                }
            }
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
                var opa = new caixaMensagem("A data inicial não pode ser maior que a data final.", "Falha ❌");
                opa.ShowDialog();
                return;
            }

            CarregarMovimentacoes();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dtgMovimentacoes.DataSource == null)
            {
                var opa = new caixaMensagem("Não há dados para imprimir.", "Falha ❌");
                opa.ShowDialog();
                return;
            }

            DataTable dt = (DataTable)dtgMovimentacoes.DataSource;
            frmPreviewMovimentacoes frm = new frmPreviewMovimentacoes(dt);
            frm.ShowDialog();
        }
    }
}