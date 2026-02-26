using MySql.Data.MySqlClient;
using ProjetoIntegradorSENAC.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Caixa
{
    public partial class frmImprimirVenda : Form
    {
        private readonly int _vendaId;

        private string _codigoConsumidor;
        private string _formaPagamento;
        private decimal _total;
        private decimal _descontos;
        private DateTime _dataVenda;

        private List<(string Produto, decimal Quantidade, decimal PrecoUnitario, decimal Total)> _itens
            = new List<(string, decimal, decimal, decimal)>();

        #region Arrastar janela pelo painel (user32.dll)

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void panelTopo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        #endregion

        #region Construtor

        public frmImprimirVenda(int vendaId)
        {
            InitializeComponent();
            _vendaId = vendaId;
            EstilizarTela();
            CarregarVenda();
        }

        #endregion

        #region Estilo da Tela

        private void EstilizarTela()
        {
            btnImprimir.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 130, 220);
            btnPreview.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 110, 200);

            lblSub.Text = "Revise os dados antes de imprimir";
        }

        #endregion

        #region Carregar Venda do Banco

        private void CarregarVenda()
        {
            using (MySqlConnection conn = Banco.AbrirConexao())
            {
                string sqlVenda = @"
                    SELECT codigo_consumidor, forma_pagamento, total, descontos, data_venda
                    FROM vendas
                    WHERE id = @id
                    LIMIT 1;
                ";

                using (MySqlCommand cmd = new MySqlCommand(sqlVenda, conn))
                {
                    cmd.Parameters.AddWithValue("@id", _vendaId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            throw new Exception("Venda não encontrada.");

                        _codigoConsumidor = reader.GetString("codigo_consumidor");
                        _formaPagamento = reader.GetString("forma_pagamento");
                        _total = reader.GetDecimal("total");
                        _descontos = reader.IsDBNull(reader.GetOrdinal("descontos")) ? 0 : reader.GetDecimal("descontos");
                        _dataVenda = reader.GetDateTime("data_venda");
                    }
                }

                string sqlItens = @"
                    SELECT p.nome, iv.quantidade, iv.preco_unitario
                    FROM items_venda iv
                    INNER JOIN produtos p ON p.id = iv.produtos_id
                    WHERE iv.vendas_id = @venda;
                ";

                using (MySqlCommand cmd = new MySqlCommand(sqlItens, conn))
                {
                    cmd.Parameters.AddWithValue("@venda", _vendaId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nome = reader.GetString("nome");
                            decimal qtd = reader.GetDecimal("quantidade");
                            decimal preco = reader.GetDecimal("preco_unitario");
                            decimal totalItem = qtd * preco;

                            _itens.Add((nome, qtd, preco, totalItem));
                        }
                    }
                }
            }
        }

        #endregion

        #region Eventos dos Botões
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument1.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao imprimir: " + ex.Message);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            using (PrintPreviewDialog preview = new PrintPreviewDialog())
            {
                preview.Document = printDocument1;
                preview.WindowState = FormWindowState.Maximized;
                preview.ShowDialog();
            }
        }

        #endregion

        #region Lógica de Impressão

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font titulo = new Font("Franklin Gothic Medium", 14, FontStyle.Bold);
            Font normal = new Font("Segoe UI", 9);
            Font bold = new Font("Segoe UI", 9, FontStyle.Bold);

            float y = 10;

            e.Graphics.DrawString("COMPROVANTE DE VENDA", titulo, Brushes.Black, 10, y);
            y += 30;

            e.Graphics.DrawString($"CÓDIGO: {_codigoConsumidor}", bold, Brushes.Black, 10, y);
            y += 20;

            e.Graphics.DrawString($"Data: {_dataVenda:dd/MM/yyyy HH:mm}", normal, Brushes.Black, 10, y);
            y += 20;

            e.Graphics.DrawString($"Pagamento: {_formaPagamento}", normal, Brushes.Black, 10, y);
            y += 25;

            e.Graphics.DrawLine(Pens.Black, 10, y, 280, y);
            y += 10;

            foreach (var item in _itens)
            {
                e.Graphics.DrawString(item.Produto, normal, Brushes.Black, 10, y);
                y += 15;

                e.Graphics.DrawString(
                    $"{item.Quantidade} x {item.PrecoUnitario:C2} = {item.Total:C2}",
                    normal, Brushes.Black, 20, y
                );
                y += 20;
            }

            e.Graphics.DrawLine(Pens.Black, 10, y, 280, y);
            y += 15;

            e.Graphics.DrawString($"Descontos: {_descontos:C2}", normal, Brushes.Black, 10, y);
            y += 15;

            e.Graphics.DrawString($"TOTAL: {_total:C2}", bold, Brushes.Black, 10, y);
            y += 25;

            e.Graphics.DrawString("Obrigado pela preferência!", normal, Brushes.Black, 10, y);
        }

        #endregion
    }
}