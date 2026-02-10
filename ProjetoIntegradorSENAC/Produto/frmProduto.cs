using MySql.Data.MySqlClient;
using ProjetoIntegradorSENAC.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Produto
{
    public partial class frmProduto : Form
    {
        public int idUsuario;
        public int idComercio;

        private bool erroNome = true;
        private bool erroDescricao = true;
        private bool erroMarca = true;
        private bool erroPreco = true;
        private bool erroCategoria = true;
        private bool erroUnidade = true;

        public frmProduto(int idUsuario, int idComercio)
        {
            InitializeComponent();
            CmbUnidade.SelectedIndex = -1;
            this.idUsuario = idUsuario;
            this.idComercio = idComercio;
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            CmbUnidade.SelectedIndex = -1;
            erroUnidade = true;
            CarregarProdutos();
            CarregarCategoriasCb();
            CarregarCategorias();
            CarregarCategoriasCbAtt();
            ResetarBotoesProduto();
        }



        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (!CamposValidos())
            {
                MessageBox.Show(
                    "Preencha corretamente todos os campos obrigatórios!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            string codigoBarra = string.IsNullOrWhiteSpace(PrCodigoBarra.Text)
            ? GerarCodigoBarra()
            : PrCodigoBarra.Text;

            string unidade = CmbUnidade.SelectedItem.ToString() == "Grama"
                ? "gramas"
                : "unidade";

            string preco = PrPreco.Text.Replace(",", ".");

            string insert = $@"
                INSERT INTO produtos
                (comercio_id, nome, descricao, status, marca,
                 codigo_barra, unidade_medida, categoria, preco)
                VALUES
                ({idComercio},
                 '{PrNome.Text}',
                 '{PrDescricao.Text}',
                 'ativo',
                 '{PrMarca.Text}',
                 '{codigoBarra}',
                 '{unidade}',
                 '{CmbCategoria.Text}',
                 {preco})";

            try
            {
                Banco.Inserir(insert);

                MessageBox.Show("Produto cadastrado com sucesso!");

                Funcoes.Limpar(this);
                CarregarProdutos();
                CarregarCategoriasCb();
                CarregarCategorias();
                if (dtgProdutos.Columns["ID"] != null)
                    dtgProdutos.Columns["ID"].Visible = false;


                CmbUnidade.SelectedIndex = -1;

                erroNome = true;
                erroDescricao = true;
                erroMarca = true;
                erroPreco = true;
                erroCategoria = true;
                erroUnidade = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto:\n" + ex.Message);
            }
        }


        private void PrNome_TextChanged(object sender, EventArgs e)
        {
            erroNome = Funcoes.CampoVazio(PrNome);
            astNome.Visible = erroNome;
            lbNome.ForeColor = erroNome ? Color.DarkRed : Color.White;
        }

        private void PrDescricao_TextChanged(object sender, EventArgs e)
        {
            erroDescricao = Funcoes.CampoVazio(PrDescricao);
            astDesc.Visible = erroDescricao;
            lbDescricao.ForeColor = erroDescricao ? Color.DarkRed : Color.White;
        }

        private void PrMarca_TextChanged(object sender, EventArgs e)
        {
            erroMarca = Funcoes.CampoVazio(PrMarca);

            astMarca.Visible = erroMarca;
            lbMarca.ForeColor = erroMarca ? Color.DarkRed : Color.White;
        }

        private void PrPreco_TextChanged(object sender, EventArgs e)
        {
            erroPreco = Funcoes.CampoVazio(PrPreco);

            astPreco.Visible = erroPreco;
            lbPreco.ForeColor = erroPreco ? Color.DarkRed : Color.White;
        }

        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            erroCategoria = Funcoes.CampoVazio(CmbCategoria);

            astCategoria.Visible = erroCategoria;
            lbCategoria.ForeColor = erroCategoria ? Color.DarkRed : Color.White;
        }

        private void CmbUnidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            erroUnidade = Funcoes.CampoVazio(CmbUnidade);

            astUnidade.Visible = erroUnidade;
            lbUnidade.ForeColor = erroUnidade ? Color.DarkRed : Color.White;

            if (!erroUnidade)
            {
                if (CmbUnidade.SelectedItem.ToString() == "Grama")
                    lbPreco.Text = "Preço por Kg";
                else
                    lbPreco.Text = "Preço por unidade";
            }
        }
        private string GerarCodigoBarra()
        {
            Random r = new Random();
            return r.Next(100000000, 999999999).ToString();


        }

        private bool CamposValidos()
        {
            erroNome = Funcoes.CampoVazio(PrNome);
            erroDescricao = Funcoes.CampoVazio(PrDescricao);
            erroMarca = Funcoes.CampoVazio(PrMarca);
            erroPreco = Funcoes.CampoVazio(PrPreco);
            erroCategoria = Funcoes.CampoVazio(CmbCategoria);
            erroUnidade = Funcoes.CampoVazio(CmbUnidade);

            astNome.Visible = erroNome;
            lbNome.ForeColor = erroNome ? Color.DarkRed : Color.White;

            astDesc.Visible = erroDescricao;
            lbDescricao.ForeColor = erroDescricao ? Color.DarkRed : Color.White;

            astMarca.Visible = erroMarca;
            lbMarca.ForeColor = erroMarca ? Color.DarkRed : Color.White;

            astPreco.Visible = erroPreco;
            lbPreco.ForeColor = erroPreco ? Color.DarkRed : Color.White;

            astCategoria.Visible = erroCategoria;
            lbCategoria.ForeColor = erroCategoria ? Color.DarkRed : Color.White;

            astUnidade.Visible = erroUnidade;
            lbUnidade.ForeColor = erroUnidade ? Color.DarkRed : Color.White;

            return !erroNome &&
                   !erroDescricao &&
                   !erroMarca &&
                   !erroPreco &&
                   !erroCategoria &&
                   !erroUnidade;
        }

        // data grid de produtos

        private void CarregarProdutos()
        {
            try
            {
                string query = $@"
            SELECT 
                id,
                nome AS Produto,
                marca AS Marca,
                descricao AS Descricao,
                codigo_barra AS CodigoBarra,
                unidade_medida AS Medida,
                categoria AS Categoria,
                preco AS Preco,
                status AS Status
            FROM produtos
            WHERE comercio_id = {idComercio}";

                DataTable dt = Banco.Pesquisar(query);

                dtgProdutos.DataSource = dt;
                dtgProdutos.Columns["id"].Visible = false;
                dtgProdutos.ClearSelection();
                dtgProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos:\n" + ex.Message);
            }
        }

        //carrega no grid
        private void CarregarCategorias()
        {
            string sql = $@"
        SELECT id, nome
        FROM categorias
        WHERE comercio_id = {idComercio}
        ORDER BY nome";

            dtgCategoria.DataSource = Banco.Pesquisar(sql);

            dtgCategoria.Columns["id"].Visible = false;
        }
        //carrega no combo box
        private void CarregarCategoriasCb()
        {
            string sql = $@"
        SELECT nome
        FROM categorias
        WHERE comercio_id = {idComercio}
        ORDER BY nome";

            DataTable dt = Banco.Pesquisar(sql);

            CmbCategoria.DataSource = dt;
            CmbCategoria.DisplayMember = "nome";
            CmbCategoria.SelectedIndex = -1;
        }
        private void LimparCategoria()
        {
            txtCategoria.Clear();
            idCategoriaSelecionada = 0;
            btnCadCategoria.Text = "Cadastrar categoria";
            dtgCategoria.ClearSelection();
        }



        private int idCategoriaSelecionada = 0;

        private void btnCadCategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("Informe o nome da categoria.");
                return;
            }

            string nome = txtCategoria.Text.Trim();

            try
            {
                if (idCategoriaSelecionada == 0)
                {
                    // CADASTRAR
                    string insert = $@"
                INSERT INTO categorias (comercio_id, nome)
                VALUES ({idComercio}, '{nome}')";

                    Banco.Inserir(insert);

                    MessageBox.Show("Categoria cadastrada!");
                }
                else
                {
                    // ATUALIZAR
                    string update = $@"
                UPDATE categorias
                   SET nome = '{nome}'
                 WHERE id = {idCategoriaSelecionada}
                   AND comercio_id = {idComercio}";

                    Banco.Inserir(update);

                    MessageBox.Show("Categoria atualizada!");
                }

                LimparCategoria();
                CarregarCategorias();
                CarregarCategoriasCbAtt();
                CarregarCategoriasCb();
        
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message);
            }
        }

        private void btnExcluirCat_Click(object sender, EventArgs e)
        {
            if (idCategoriaSelecionada == 0)
            {
                MessageBox.Show("Selecione uma categoria.");
                return;
            }

            if (MessageBox.Show(
                "Ao excluir esta categoria, os produtos ficarão como 'Categoria excluída'.\nDeseja continuar?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
                return;

            try
            {
                // 1️⃣ Atualiza produtos
                string updateProdutos = $@"
            UPDATE produtos
            SET categoria = 'Categoria excluída'
            WHERE categoria = '{txtCategoria.Text}'
              AND comercio_id = {idComercio};
        ";

                Banco.Inserir(updateProdutos);

                // 2️⃣ Exclui categoria
                string delete = $@"
            DELETE FROM categorias
            WHERE id = {idCategoriaSelecionada}
              AND comercio_id = {idComercio};
        ";

                Banco.Excluir(delete);

                MessageBox.Show("Categoria excluída. Produtos atualizados.");

                LimparCategoria();
                CarregarCategorias();
                CarregarCategoriasCb();
                CarregarCategoriasCbAtt();
                CarregarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message);
            }
        }

        private void dtgCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idCategoriaSelecionada =
                    Convert.ToInt32(dtgCategoria.Rows[e.RowIndex].Cells["id"].Value);

                txtCategoria.Text =
                    dtgCategoria.Rows[e.RowIndex].Cells["nome"].Value.ToString();

                btnCadCategoria.Text = "Atualizar";
            }
        }



        private int idProdutoSelecionado = 0;

        private void dtgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dtgProdutos.Rows[e.RowIndex];

            idProdutoSelecionado = Convert.ToInt32(row.Cells["id"].Value);

            txtNomeProd.Text = row.Cells["Produto"].Value.ToString();
            txtMarcaProd.Text = row.Cells["Marca"].Value.ToString();
            PrDescricaoAtt.Text = row.Cells["Descricao"].Value.ToString();
            txtCodBarra.Text = row.Cells["CodigoBarra"].Value.ToString();

            cmbMedida.Text = row.Cells["Medida"].Value.ToString();
            cmbCatAtt.Text = row.Cells["Categoria"].Value.ToString();

            txtPrecoProd.Text = row.Cells["Preco"].Value.ToString();

            string status = row.Cells["Status"].Value.ToString().ToLower();

            // UX: alterna botões
            btnDesativarProd.Visible = status == "ativo";
            btnAtivarProd.Visible = status == "desativo";

            btnExcluirProd.Visible = true;
            btnAttProd.Visible = true;
        }

        private void btnAttProd_Click(object sender, EventArgs e)
        {
            if (idProdutoSelecionado == 0)
            {
                MessageBox.Show("Selecione um produto na lista.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNomeProd.Text) ||
                string.IsNullOrWhiteSpace(txtPrecoProd.Text) ||
                cmbMedida.SelectedIndex == -1 ||
                cmbCatAtt.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha os campos obrigatórios.");
                return;
            }

            string unidade = cmbMedida.Text == "Grama" ? "gramas" : "unidade";

            string sql = $@"
                        UPDATE produtos
                        SET
                            nome = '{txtNomeProd.Text}',
                            marca = '{txtMarcaProd.Text}',
                            descricao = '{PrDescricaoAtt.Text}',
                            unidade_medida = '{unidade}',
                            preco = {txtPrecoProd.Text.Replace(",", ".")},
                            codigo_barra = '{txtCodBarra.Text}',
                            categoria = '{cmbCatAtt.Text}'
                        WHERE id = {idProdutoSelecionado};
                    ";

            try
            {
                Banco.Inserir(sql);

                MessageBox.Show("Produto atualizado!");
                LimparEdicaoProduto();
                CarregarProdutos();
                ResetarBotoesProduto();
                dtgProdutos.ClearSelection();
                idProdutoSelecionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message);
            }
        }

        private void btnDesativarProd_Click(object sender, EventArgs e)
        {
            if (idProdutoSelecionado == 0)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }

            if (MessageBox.Show(
                "Deseja desativar este produto?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
                return;

            string sql = $@"
        UPDATE produtos
        SET status = 'desativo'
        WHERE id = {idProdutoSelecionado};
    ";

            try
            {
                Banco.Inserir(sql);
                ResetarBotoesProduto();
                MessageBox.Show("Produto desativado!");
                LimparEdicaoProduto();
                CarregarProdutos();
                idProdutoSelecionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message);
            }
        }

        private void btnExcluirProd_Click(object sender, EventArgs e)
        {
            if (idProdutoSelecionado == 0)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }

            if (MessageBox.Show(
                "Excluir este produto definitivamente?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error) == DialogResult.No)
                return;

            string sql = $"DELETE FROM produtos WHERE id = {idProdutoSelecionado}";

            try
            {
                Banco.Inserir(sql);

                MessageBox.Show("Produto excluído!");
                LimparEdicaoProduto();
                CarregarProdutos();
                ResetarBotoesProduto();
                idProdutoSelecionado = 0;
                btnAtivarProd.Visible = false;
                btnDesativarProd.Visible = false;
                btnExcluirProd.Visible = false;
                btnAttProd.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message);
            }
        }


        private void CarregarCategoriasCbAtt()
        {
               string sql = $@"
                SELECT nome
                FROM categorias
                WHERE comercio_id = {idComercio}
                ORDER BY nome";

                    DataTable dt = Banco.Pesquisar(sql);

                    cmbCatAtt.DataSource = dt;
                    cmbCatAtt.DisplayMember = "nome";
                    cmbCatAtt.SelectedIndex = -1;
        }

        private void ResetarBotoesProduto()
        {
            btnAtivarProd.Visible = false;
            btnDesativarProd.Visible = false;
            btnExcluirProd.Visible = false;
            btnAttProd.Visible = false;
        }

        private void LimparEdicaoProduto()
        {
            txtNomeProd.Clear();
            txtMarcaProd.Clear();
            txtPrecoProd.Clear();
            txtCodBarra.Clear();
            PrDescricaoAtt.Clear();

            cmbMedida.SelectedIndex = -1;
            cmbCatAtt.SelectedIndex = -1;

            idProdutoSelecionado = 0;
        }

        private void btnAtivarProd_Click(object sender, EventArgs e)
        {
            if (idProdutoSelecionado == 0)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }

            if (MessageBox.Show(
                "Deseja ativar este produto novamente?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                return;

            string sql = $@"
        UPDATE produtos
        SET status = 'ativo'
        WHERE id = {idProdutoSelecionado};
    ";

            try
            {
                Banco.Inserir(sql);

                MessageBox.Show("Produto ativado!");
                ResetarBotoesProduto();
                LimparEdicaoProduto();
                CarregarProdutos();
                idProdutoSelecionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message);
            }
        }
    }
}
