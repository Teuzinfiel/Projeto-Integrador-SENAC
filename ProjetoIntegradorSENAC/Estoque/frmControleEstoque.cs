using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Utilities;
using ProjetoIntegradorSENAC.Classes;
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
    public partial class frmControleEstoque : Form
    {
        private int _produtoId;
        private int _comercioId = 1;
        private MainPrincipal _main;
        public frmControleEstoque(MainPrincipal main, int produtoId)
        {
            InitializeComponent();
            _main = main;
            _produtoId = produtoId;
        }

        private void frmControleEstoque_Load(object sender, EventArgs e)
        {
            if (txtStatusPd.Text.ToLower() == "inativo")
            {
                btnEnviarEntrada.Enabled = false;
                btnEnviarSaida.Enabled = false;

                MessageBox.Show("Produto inativo. Movimentações bloqueadas.");
            }
            GarantirEstoqueExiste();
            CarregarProduto();
            CarregarMovimentacoes();
        }


        private bool ValidarEntrada()
        {
            bool valido = true;

            // Reset visual
            astQtdEntrada.Visible = false;
            astTpEntrada.Visible = false;
            astDescEntrada.Visible = false;

            label13.ForeColor = Color.White;
            label14.ForeColor = Color.White;
            label15.ForeColor = Color.White;

            // QUANTIDADE
            if (!decimal.TryParse(mkQuantidadeEntrada.Text, out decimal qtd) || qtd <= 0)
            {
                astQtdEntrada.Visible = true;
                label13.ForeColor = Color.DarkRed;
                valido = false;
            }

            // TIPO
            if (string.IsNullOrWhiteSpace(cbTipoEntrada.Text))
            {
                astTpEntrada.Visible = true;
                label14.ForeColor = Color.DarkRed;
                valido = false;
            }

            // OBSERVAÇÃO
            if (string.IsNullOrWhiteSpace(txtDescEntrada.Text))
            {
                astDescEntrada.Visible = true;
                label15.ForeColor = Color.DarkRed;
                valido = false;
            }

            return valido;
        }

        private bool ValidarSaida()
        {
            bool valido = true;

            // Reset visual
            astQtdSaida.Visible = false;
            astTpSaida.Visible = false;
            astDescSaida.Visible = false;

            label22.ForeColor = Color.White;
            label21.ForeColor = Color.White;
            label18.ForeColor = Color.White;

            // QUANTIDADE
            if (!decimal.TryParse(mkQuantidadeSaida.Text, out decimal qtd) || qtd <= 0)
            {
                astQtdSaida.Visible = true;
                label22.ForeColor = Color.DarkRed;
                valido = false;
            }

            // TIPO
            if (string.IsNullOrWhiteSpace(cbTipoSaida.Text))
            {
                astTpSaida.Visible = true;
                label21.ForeColor = Color.DarkRed;
                valido = false;
            }

            // OBSERVAÇÃO
            if (string.IsNullOrWhiteSpace(txtDescSaida.Text))
            {
                astDescSaida.Visible = true;
                label18.ForeColor = Color.DarkRed;
                valido = false;
            }

            return valido;
        }


        // ================================
        // GARANTE QUE EXISTE LINHA NO ESTOQUE
        // ================================
        private void GarantirEstoqueExiste()
        {
            using (var conn = Banco.AbrirConexao())
            {
                string sql = @"
                    INSERT INTO estoque (produto_id, quantidade_atual)
                    VALUES (@produtoId, 0)
                    ON DUPLICATE KEY UPDATE produto_id = produto_id";

                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@produtoId", MySqlDbType.Int32).Value = _produtoId;
                cmd.ExecuteNonQuery();
            }
        }

        // ================================
        // CARREGAR PRODUTO
        // ================================
        private void CarregarProduto()
        {
            string sql = @"
                SELECT 
                    p.nome,
                    c.nome AS categoria,
                    p.unidade_medida,
                    p.status,
                    IFNULL(e.quantidade_atual,0) AS saldo
                FROM produtos p
                LEFT JOIN categorias c ON c.id = p.categoria_id
                LEFT JOIN estoque e ON e.produto_id = p.id
                WHERE p.id = @produtoId";

            using (var conn = Banco.AbrirConexao())
            {
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@produtoId", MySqlDbType.Int32).Value = _produtoId;

                using (var da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        txtNomePd.Text = dt.Rows[0]["nome"].ToString();
                        txtCatPd.Text = dt.Rows[0]["categoria"].ToString();
                        txtUnidadePd.Text = dt.Rows[0]["unidade_medida"].ToString();
                        txtStatusPd.Text = dt.Rows[0]["status"].ToString();
                        TxtSaldoPd.Text = Convert.ToDecimal(dt.Rows[0]["saldo"]).ToString("#,0.##");
                    }
                }
            }
        }

        // ================================
        // CARREGAR MOVIMENTAÇÕES
        // ================================
        private void CarregarMovimentacoes()
        {
            string sql = @"
                    SELECT 
                        tipo AS Tipo,
                        quantidade AS Quantidade,
                        quantidade_final AS 'Qtd Final',
                        motivo AS Motivo,
                        observacao AS Observação,
                        data AS Data
                    FROM movimentacoes_estoque
                    WHERE produto_id = @produtoId
                    ORDER BY data DESC";

            using (var conn = Banco.AbrirConexao())
            {
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@produtoId", MySqlDbType.Int32).Value = _produtoId;

                using (var da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dtgProdutos.DataSource = dt;

                    // Formatação numérica
                    dtgProdutos.Columns["Quantidade"].DefaultCellStyle.Format = "#,0.##";
                    dtgProdutos.Columns["Qtd Final"].DefaultCellStyle.Format = "#,0.##";
                }
            }
        }

        // ================================
        // ENTRADA
        // ================================
        private void btnEnviarEntrada_Click(object sender, EventArgs e)
        {
            if (!ValidarEntrada())
            {
                MessageBox.Show("Preencha corretamente os campos obrigatórios.");
                return;
            }

            // AGORA você pega a quantidade
            decimal quantidade = Convert.ToDecimal(mkQuantidadeEntrada.Text);

            using (var conn = Banco.AbrirConexao())
            using (var trans = conn.BeginTransaction())
            {
                try
                {
                    decimal saldoAnterior = 0;

                    var cmdSaldo = new MySqlCommand(
                        "SELECT quantidade_atual FROM estoque WHERE produto_id = @produtoId",
                        conn, trans);

                    cmdSaldo.Parameters.Add("@produtoId", MySqlDbType.Int32).Value = _produtoId;

                    var result = cmdSaldo.ExecuteScalar();
                    if (result != null)
                        saldoAnterior = Convert.ToDecimal(result);

                    decimal saldoNovo = saldoAnterior + quantidade;

                    var cmdUpdate = new MySqlCommand(
                        "UPDATE estoque SET quantidade_atual = @saldo WHERE produto_id = @produtoId",
                        conn, trans);

                    cmdUpdate.Parameters.Add("@saldo", MySqlDbType.Decimal).Value = saldoNovo;
                    cmdUpdate.Parameters.Add("@produtoId", MySqlDbType.Int32).Value = _produtoId;
                    cmdUpdate.ExecuteNonQuery();

                    var cmdInsert = new MySqlCommand(@"
                        INSERT INTO movimentacoes_estoque
                        (produto_id, tipo, quantidade, quantidade_final, motivo, observacao, comercio_id)
                        VALUES
                        (@produtoId, 'entrada', @quantidade, @saldoFinal, @motivo, @obs, @comercioId)",
                        conn, trans);

                    cmdInsert.Parameters.Add("@produtoId", MySqlDbType.Int32).Value = _produtoId;
                    cmdInsert.Parameters.Add("@quantidade", MySqlDbType.Decimal).Value = quantidade;
                    cmdInsert.Parameters.Add("@saldoFinal", MySqlDbType.Decimal).Value = saldoNovo;
                    cmdInsert.Parameters.Add("@motivo", MySqlDbType.VarChar).Value = cbTipoEntrada.Text;
                    cmdInsert.Parameters.Add("@obs", MySqlDbType.VarChar).Value = txtDescEntrada.Text;
                    cmdInsert.Parameters.Add("@comercioId", MySqlDbType.Int32).Value = _comercioId;

                    cmdInsert.ExecuteNonQuery();

                    trans.Commit();

                    TxtSaldoPd.Text = saldoNovo.ToString("#,0.##");
                    CarregarMovimentacoes();

                    mkQuantidadeEntrada.Clear();
                    txtDescEntrada.Clear();
                    cbTipoEntrada.SelectedIndex = -1;

                    MessageBox.Show("Entrada registrada com sucesso!");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        // ================================
        // SAÍDA
        // ================================
        private void btnEnviarSaida_Click(object sender, EventArgs e)
        {
            if (!ValidarSaida())
            {
                MessageBox.Show("Preencha corretamente os campos obrigatórios.");
                return;
            }

            decimal quantidade = Convert.ToDecimal(mkQuantidadeSaida.Text);

            using (var conn = Banco.AbrirConexao())
            using (var trans = conn.BeginTransaction())
            {
                try
                {
                    decimal saldoAnterior = 0;

                    var cmdSaldo = new MySqlCommand(
                        "SELECT quantidade_atual FROM estoque WHERE produto_id = @produtoId",
                        conn, trans);

                    cmdSaldo.Parameters.Add("@produtoId", MySqlDbType.Int32).Value = _produtoId;

                    var result = cmdSaldo.ExecuteScalar();
                    if (result != null)
                        saldoAnterior = Convert.ToDecimal(result);

                    if (quantidade > saldoAnterior)
                    {
                        MessageBox.Show("Estoque insuficiente.");
                        return;
                    }

                    decimal saldoNovo = saldoAnterior - quantidade;

                    var cmdUpdate = new MySqlCommand(
                        "UPDATE estoque SET quantidade_atual = @saldo WHERE produto_id = @produtoId",
                        conn, trans);

                    cmdUpdate.Parameters.Add("@saldo", MySqlDbType.Decimal).Value = saldoNovo;
                    cmdUpdate.Parameters.Add("@produtoId", MySqlDbType.Int32).Value = _produtoId;
                    cmdUpdate.ExecuteNonQuery();

                    var cmdInsert = new MySqlCommand(@"
                        INSERT INTO movimentacoes_estoque
                        (produto_id, tipo, quantidade, quantidade_final, motivo, observacao, comercio_id)
                        VALUES
                        (@produtoId, 'saida', @quantidade, @saldoFinal, @motivo, @obs, @comercioId)",
                        conn, trans);

                    cmdInsert.Parameters.Add("@produtoId", MySqlDbType.Int32).Value = _produtoId;
                    cmdInsert.Parameters.Add("@quantidade", MySqlDbType.Decimal).Value = quantidade;
                    cmdInsert.Parameters.Add("@saldoFinal", MySqlDbType.Decimal).Value = saldoNovo;
                    cmdInsert.Parameters.Add("@motivo", MySqlDbType.VarChar).Value = cbTipoSaida.Text;
                    cmdInsert.Parameters.Add("@obs", MySqlDbType.VarChar).Value = txtDescSaida.Text;
                    cmdInsert.Parameters.Add("@comercioId", MySqlDbType.Int32).Value = _comercioId;

                    cmdInsert.ExecuteNonQuery();

                    trans.Commit();

                    TxtSaldoPd.Text = saldoNovo.ToString("#,0.##");
                    CarregarMovimentacoes();

                    mkQuantidadeSaida.Clear();
                    txtDescSaida.Clear();
                    cbTipoSaida.SelectedIndex = -1;

                    MessageBox.Show("Saída registrada com sucesso!");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        // ================================
        // TEXT CHANGED (PREVIEW SALDO)
        // ================================
        private decimal ObterSaldoAtual()
        {
            decimal.TryParse(TxtSaldoPd.Text, out decimal saldo);
            return saldo;
        }

        private void mkQuantidadeEntrada_TextChanged(object sender, EventArgs e)
        {
            decimal saldoAtual = ObterSaldoAtual();

            if (decimal.TryParse(mkQuantidadeEntrada.Text, out decimal qtdEntrada))
            {
                lbSaldoAposEntrada.Text = (saldoAtual + qtdEntrada).ToString("#,0.##");
                lbSaldoAposEntrada.ForeColor = Color.Green;
            }
            else
            {
                lbSaldoAposEntrada.Text = saldoAtual.ToString("#,0.##");
                lbSaldoAposEntrada.ForeColor = Color.Black;
            }
        }

        private void mkQuantidadeSaida_TextChanged(object sender, EventArgs e)
        {
            decimal saldoAtual = ObterSaldoAtual();

            if (decimal.TryParse(mkQuantidadeSaida.Text, out decimal qtdSaida))
            {
                decimal saldoFinal = saldoAtual - qtdSaida;

                if (saldoFinal < 0)
                {
                    lbSaldoAposSaida.Text = "Estoque insuficiente";
                    lbSaldoAposSaida.ForeColor = Color.Red;
                }
                else
                {
                    lbSaldoAposSaida.Text = saldoFinal.ToString("#,0.##");
                    lbSaldoAposSaida.ForeColor = Color.Black;
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            _main.AbrirFormNoPanel(new estoque(_main, _main.idEmpresa));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _main.AbrirFormNoPanel(
               new MovimentacaoProdutos(_main.idEmpresa) );

            _main.DestacarMovimentacoes();
        }
    }
}


