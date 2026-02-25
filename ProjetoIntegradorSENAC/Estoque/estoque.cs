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
        private MainPrincipal _main;
        private int idEmpresa;

        public estoque(MainPrincipal main, int idEmpresa)
        {
            InitializeComponent();
            _main = main;
            this.idEmpresa = idEmpresa;
            dtgProdutos.DefaultCellStyle.SelectionBackColor = dtgProdutos.DefaultCellStyle.BackColor;
            dtgProdutos.DefaultCellStyle.SelectionForeColor = dtgProdutos.DefaultCellStyle.ForeColor;
            dtgProdutos.RowsDefaultCellStyle.SelectionBackColor = dtgProdutos.RowsDefaultCellStyle.BackColor;
            dtgProdutos.RowsDefaultCellStyle.SelectionForeColor = dtgProdutos.RowsDefaultCellStyle.ForeColor;
            dtgProdutos.AlternatingRowsDefaultCellStyle.SelectionBackColor =
            dtgProdutos.AlternatingRowsDefaultCellStyle.BackColor;
            dtgProdutos.TabStop = false;
            dtgProdutos.ClearSelection();
        }
        private int _produtoId;

   
        private void CarregarProdutos()
        {
                    string sql = @"
            SELECT 
                p.id,
                p.codigo_barra,
                p.nome,
                p.status,
                IFNULL(e.quantidade_atual,0) AS quantidade
            FROM produtos p
            LEFT JOIN estoque e ON e.produto_id = p.id
            WHERE p.comercio_id = " + idEmpresa;

                    DataTable dt = Banco.Pesquisar(sql);

                    dt.Columns.Add("Situacao");

                    foreach (DataRow row in dt.Rows)
                    {
                        decimal qtd = Convert.ToDecimal(row["quantidade"]);
                        row["Situacao"] = ObterSituacao(qtd);
                    }

                    dtgProdutos.DataSource = dt;


                    dtgProdutos.Columns["Situacao"].DefaultCellStyle.BackColor = Color.Empty;
                    dtgProdutos.Columns["Situacao"].DefaultCellStyle.ForeColor = Color.Empty;

                    dtgProdutos.Columns["codigo_barra"].HeaderText = "Código de Barras";
                    dtgProdutos.Columns["quantidade"].HeaderText = "Quantidade";
                    dtgProdutos.Columns["id"].Visible = false;

                    dtgProdutos.ClearSelection();
        }


      

        private string ObterSituacao(decimal quantidade)
        {
            if (quantidade == 0)
                return "Sem Estoque";

            if (quantidade <= 12)
                return "Estoque Baixo";

            if (quantidade <= 25)
                return "Atenção";

            return "Normal";
        }


        private void estoque_Load_1(object sender, EventArgs e)
        {

            CarregarProdutos();
            // Travar edição pelo usuário
            dtgProdutos.ReadOnly = true;
            // Ajustar layout geral
            dtgProdutos.RowHeadersVisible = false; // tira aquela primeira coluna cinza
            dtgProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProdutos.MultiSelect = false;
            dtgProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProdutos.RowTemplate.Height = 32;
            dtgProdutos.EnableHeadersVisualStyles = false;
            dtgProdutos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 45);
            dtgProdutos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgProdutos.BackgroundColor = Color.FromArgb(20, 20, 35);
            dtgProdutos.BorderStyle = BorderStyle.None;
            comboBox1.Items.Add("Todas");
            comboBox1.Items.Add("Normal");
            comboBox1.Items.Add("Atenção");
            comboBox1.Items.Add("Estoque Baixo");
            comboBox1.Items.Add("Sem Estoque");
            comboBox1.SelectedIndex = 0;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void dtgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idProduto = Convert.ToInt32(dtgProdutos.Rows[e.RowIndex].Cells["id"].Value);

                _main.AbrirFormNoPanel(new frmControleEstoque(_main, idProduto));


                CarregarProdutos(); // Atualiza quando voltar
            }
        }

        private void dtgProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgProdutos.Columns[e.ColumnIndex].Name == "Situacao")
            {
                string situacao = e.Value?.ToString();

                if (situacao == "Normal")
                {
                    e.CellStyle.BackColor = Color.FromArgb(0, 120, 215); // Azul moderno
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (situacao == "Atenção")
                {
                    e.CellStyle.BackColor = Color.FromArgb(255, 140, 0); // Laranja forte
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (situacao == "Estoque Baixo")
                {
                    e.CellStyle.BackColor = Color.FromArgb(200, 0, 0); // Vermelho
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (situacao == "Sem Estoque")
                {
                    e.CellStyle.BackColor = Color.FromArgb(120, 0, 0); // Vermelho escuro
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dtgProdutos.DataSource;


            if (comboBox1.Text == "Todas")
            {
                dt.DefaultView.RowFilter = "";
            }
            else
            {
                dt.DefaultView.RowFilter = $"Situacao = '{comboBox1.Text}'";
            }
        }

        private bool ordemAsc = true;
        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dtgProdutos.DataSource;

            if (ordemAsc)
                dt.DefaultView.Sort = "nome ASC";
            else
                dt.DefaultView.Sort = "nome DESC";

            ordemAsc = !ordemAsc;
        }


    }
}

