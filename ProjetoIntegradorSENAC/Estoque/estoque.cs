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
    public partial class estoque : Form
    {
        int idEmpresa;
        public estoque(int idEmpresa)
        {
            InitializeComponent();
            this.idEmpresa = idEmpresa;
        }

        private void estoque_Load_1(object sender, EventArgs e)
        {
            string query = $"SELECT \r\n    p.id AS produto_id,\r\n    p.nome AS nome_produto,\r\n    p.marca,\r\n    p.codigo_barra,\r\n    p.unidade_medida,\r\n    p.categoria,\r\n\r\n    m.quantidade AS quantidade_movimentada,\r\n    m.quantidade_final,\r\n    m.tipo,\r\n    m.data_movimentacao,\r\n\tf.id,\r\n    u.nome AS funcionario_responsavel\r\n\r\nFROM movimentacoes_estoque m\r\nLEFT JOIN produtos p\r\n    ON p.id = m.produto_id\r\nLEFT JOIN funcionarios f\r\n    ON f.id = m.funcionario_id\r\nLEFT JOIN usuarios u\r\n    ON u.id = f.usuarios_id\r\n\r\nORDER BY m.data_movimentacao DESC limit 50;";
            var produtos = Banco.Pesquisar(query);
            dtgProdutos.DataSource = produtos;
            // Impedir que o grid autoajuste de forma bagunçada
            dtgProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dtgProdutos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dtgProdutos.AllowUserToResizeRows = false;

            // Opção: ajusta automaticamente largura mínima
            dtgProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Esconder colunas que não precisam aparecer no grid
            if (dtgProdutos.Columns.Contains("produto_id"))
                dtgProdutos.Columns["produto_id"].Visible = false;

            if (dtgProdutos.Columns.Contains("id"))   // id do funcionario
                dtgProdutos.Columns["id"].Visible = false;

            // Alterar textos das colunas para ficar mais bonitinho
            dtgProdutos.Columns["nome_produto"].HeaderText = "Produto";
            dtgProdutos.Columns["marca"].HeaderText = "Marca";
            dtgProdutos.Columns["codigo_barra"].HeaderText = "Código";
            dtgProdutos.Columns["unidade_medida"].HeaderText = "Unidade";
            dtgProdutos.Columns["categoria"].HeaderText = "Categoria";
            dtgProdutos.Columns["quantidade_movimentada"].HeaderText = "Movimentado";
            dtgProdutos.Columns["quantidade_final"].HeaderText = "Saldo";
            dtgProdutos.Columns["tipo"].HeaderText = "Tipo";
            dtgProdutos.Columns["data_movimentacao"].HeaderText = "Data";
            dtgProdutos.Columns["funcionario_responsavel"].HeaderText = "Funcionário";

            // Travar edição pelo usuário
            dtgProdutos.ReadOnly = true;

            // Ajustar layout geral
            dtgProdutos.RowHeadersVisible = false; // tira aquela primeira coluna cinza
            dtgProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProdutos.MultiSelect = false;

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

     
    }
}

