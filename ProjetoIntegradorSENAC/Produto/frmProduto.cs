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

        // Flags para erros

        private bool erroNome = true;
        private bool erroDescricao = true;
        private bool erroMarca = true;
        private bool erroPreco = true;
        private bool erroCategoria = true;
        private bool erroUnidade = true;

        // Construtor
        public frmProduto(int idUsuario, int idComercio)
        {
            InitializeComponent();
            CmbUnidade.SelectedIndex = -1;
            this.idUsuario = idUsuario;
            this.idComercio = idComercio;
        }


        // Evento de carregamento do formulário, Carrega produtos e cadegorias, no datagrid e no comboBox, atraves das funcoes
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


        //Botao de cadastro de produtos
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

            try
            {
                using (var conn = Banco.AbrirConexao())
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1️⃣ Inserir produto
                        string insertProduto = $@"
                INSERT INTO produtos 
                (comercio_id, nome, descricao, status, marca, codigo_barra, unidade_medida, categoria_id, preco)
                VALUES
                ({idComercio},
                '{PrNome.Text}',
                '{PrDescricao.Text}',
                'ativo',
                '{PrMarca.Text}',
                '{codigoBarra}',
                '{unidade}',
                {CmbCategoria.SelectedValue},
                {preco});
                
                SELECT LAST_INSERT_ID();";

                        MySqlCommand cmdProduto = new MySqlCommand(insertProduto, conn, trans);
                        int novoProdutoId = Convert.ToInt32(cmdProduto.ExecuteScalar());

                        // 2️⃣ Criar estoque com 0
                        string insertEstoque = $@"
                INSERT INTO estoque (produto_id, quantidade_atual)
                VALUES ({novoProdutoId}, 0);";

                        MySqlCommand cmdEstoque = new MySqlCommand(insertEstoque, conn, trans);
                        cmdEstoque.ExecuteNonQuery();

                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }

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


        // Verificações de campos obrigatórios
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


        //funcao que valida os campos obrigatórios e os asterescos
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

        //funcao que carrega os produtos no datagrid

        private void CarregarProdutos()
        {
            try
            {
                string query = $@"
                SELECT  
                    p.id,
                    p.nome AS Produto,
                    p.marca AS Marca,
                    p.descricao AS Descricao,
                    p.codigo_barra AS CodigoBarra,
                    p.unidade_medida AS Medida,
                    c.nome AS Categoria,
                    p.preco AS Preco,
                    p.status AS Status
                FROM produtos p
                LEFT JOIN categorias c ON c.id = p.categoria_id
                WHERE p.comercio_id = {idComercio}";

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

        //funcao que carrega as categorias no datagrid

        private void CarregarCategorias()
        {
            string sql = $@" SELECT id, nome FROM categorias WHERE comercio_id = {idComercio} ORDER BY nome";
            dtgCategoria.DataSource = Banco.Pesquisar(sql);
            dtgCategoria.Columns["id"].Visible = false;
        }



        //Funcao que carrega as categorias no comboBox


        private void CarregarCategoriasCb()
        {
            string sql = $@"
            SELECT id, nome
            FROM categorias
            WHERE comercio_id = {idComercio}
            ORDER BY nome";

            DataTable dt = Banco.Pesquisar(sql);

            CmbCategoria.DataSource = dt;
            CmbCategoria.DisplayMember = "nome";
            CmbCategoria.ValueMember = "id";
            CmbCategoria.SelectedIndex = -1;
        }

        // Funcao que limpa os campos de categoria
        private void LimparCategoria()
        {
            txtCategoria.Clear();
            idCategoriaSelecionada = 0;
            btnCadCategoria.Text = "Cadastrar categoria";
            dtgCategoria.ClearSelection();
        }


        private int idCategoriaSelecionada = 0;

        // Botao de cadastro e atualizacao de categorias

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
                    string insert = $@"  INSERT INTO categorias (comercio_id, nome)  VALUES ({idComercio}, '{nome}')";
                    Banco.Inserir(insert);
                    MessageBox.Show("Categoria cadastrada!");
                }
                else
                {
                    // ATUALIZAR
                    string update = $@"  UPDATE categorias SET nome = '{nome}'  WHERE id = {idCategoriaSelecionada}  AND comercio_id = {idComercio}";
                    Banco.Inserir(update);
                    MessageBox.Show("Categoria atualizada!");
                }
                // Atualiza produtos associados à categoria atualizada
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

        // Botao de exclusao de categorias
        private void btnExcluirCat_Click(object sender, EventArgs e)
        {
            if (idCategoriaSelecionada == 0)
            {
                MessageBox.Show("Selecione uma categoria.");
                return;
            }

            if (MessageBox.Show(  "Ao excluir esta categoria, os produtos ficarão como 'Categoria excluída'.\nDeseja continuar?",   "Confirmação",
                MessageBoxButtons.YesNo,  MessageBoxIcon.Warning) == DialogResult.No) return;

            try
            {
                //  Atualiza produtos
                string updateProdutos = $@" 
                UPDATE produtos 
                SET categoria_id = NULL
                WHERE categoria_id = {idCategoriaSelecionada}
                AND comercio_id = {idComercio}; ";

                //  Exclui categoria
                string delete = $@" DELETE FROM categorias WHERE id = {idCategoriaSelecionada}  AND comercio_id = {idComercio}; ";

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

        // Evento de clique na celula do datagrid de categorias

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

        // Evento de clique na celula do datagrid de produtos
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

            //  alterna botões
            btnDesativarProd.Visible = status == "ativo";
            btnAtivarProd.Visible = status == "desativo";

            btnExcluirProd.Visible = true;
            btnAttProd.Visible = true;
        }

        // Botao de atualizacao de produtos
        private void btnAttProd_Click(object sender, EventArgs e)
        {
            if (idProdutoSelecionado == 0)
            {
                MessageBox.Show("Selecione um produto na lista.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNomeProd.Text) ||  string.IsNullOrWhiteSpace(txtPrecoProd.Text) ||
                cmbMedida.SelectedIndex == -1 || cmbCatAtt.SelectedIndex == -1)
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
categoria_id = {cmbCatAtt.SelectedValue}
WHERE id = {idProdutoSelecionado};";

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

            if (MessageBox.Show(  "Deseja desativar este produto?",  "Confirmação",  MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            string sql = $@"  UPDATE produtos SET status = 'desativo' WHERE id = {idProdutoSelecionado}; ";

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
        // Botao de exclusao de produtos

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

            try
            {
                using (var conn = Banco.AbrirConexao())
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1️⃣ Excluir movimentações
                        string deleteMov = $@"
                DELETE FROM movimentacoes_estoque 
                WHERE produto_id = {idProdutoSelecionado};";

                        new MySqlCommand(deleteMov, conn, trans).ExecuteNonQuery();

                        // 2️⃣ Excluir estoque
                        string deleteEstoque = $@"
                DELETE FROM estoque 
                WHERE produto_id = {idProdutoSelecionado};";

                        new MySqlCommand(deleteEstoque, conn, trans).ExecuteNonQuery();

                        // 3️⃣ Excluir produto
                        string deleteProduto = $@"
                DELETE FROM produtos 
                WHERE id = {idProdutoSelecionado};";

                        new MySqlCommand(deleteProduto, conn, trans).ExecuteNonQuery();

                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }

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

        // Carrega categorias no comboBox de edição de produtos
        private void CarregarCategoriasCbAtt()
        {
                    string sql = $@"
            SELECT id, nome
            FROM categorias
            WHERE comercio_id = {idComercio}
            ORDER BY nome";

                    DataTable dt = Banco.Pesquisar(sql);

                    cmbCatAtt.DataSource = dt;
                    cmbCatAtt.DisplayMember = "nome";
                    cmbCatAtt.ValueMember = "id";
                    cmbCatAtt.SelectedIndex = -1;
        }

        // Reseta botões de edição de produtos

        private void ResetarBotoesProduto()
        {
            btnAtivarProd.Visible = false;
            btnDesativarProd.Visible = false;
            btnExcluirProd.Visible = false;
            btnAttProd.Visible = false;
        }
        // Limpa campos de edição de produtos
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

        // Botao de ativacao de produtos
        private void btnAtivarProd_Click(object sender, EventArgs e)
        {
            if (idProdutoSelecionado == 0)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }

            if (MessageBox.Show( "Deseja ativar este produto novamente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)  return;
            string sql = $@" UPDATE produtos SET status = 'ativo' WHERE id = {idProdutoSelecionado};";

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
