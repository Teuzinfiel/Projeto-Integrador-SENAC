using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Estoque
{
    public partial class frmPreviewMovimentacoes : Form
    {
        private DataTable dados;
        private PrintDocument print;

        public frmPreviewMovimentacoes(DataTable tabela)
        {
            InitializeComponent();
            dados = tabela;

            print = new PrintDocument();
            print.PrintPage += Print_PrintPage;

            preview.Document = print;

            btnImprimir.Click += (_, __) => print.Print();
            btnFechar.Click += (_, __) => this.Close();
        }

        private void Print_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font titulo = new Font("Franklin Gothic Medium", 20);
            Font cabecalho = new Font("Segoe UI", 11, FontStyle.Bold);
            Font texto = new Font("Segoe UI", 10);

            int y = 20;
            e.Graphics.DrawString("RELATÓRIO DE MOVIMENTAÇÕES DE ESTOQUE", titulo, Brushes.Black, 20, y);
            y += 40;

            // Cabeçalho
            int x = 20;
            e.Graphics.DrawString("Produto", cabecalho, Brushes.Black, x, y);
            x += 180;
            e.Graphics.DrawString("Tipo", cabecalho, Brushes.Black, x, y);
            x += 100;
            e.Graphics.DrawString("Qtd", cabecalho, Brushes.Black, x, y);
            x += 60;
            e.Graphics.DrawString("Qtd Final", cabecalho, Brushes.Black, x, y);
            x += 80;
            e.Graphics.DrawString("Motivo", cabecalho, Brushes.Black, x, y);
            x += 120;
            e.Graphics.DrawString("Observação", cabecalho, Brushes.Black, x, y);
            x += 180;
            e.Graphics.DrawString("Data", cabecalho, Brushes.Black, x, y);
            x += 100;
            e.Graphics.DrawString("Funcionário", cabecalho, Brushes.Black, x, y);

            y += 25;

            // Linhas
            foreach (DataRow row in dados.Rows)
            {
                x = 20;
                e.Graphics.DrawString(row["Produto"].ToString(), texto, Brushes.Black, x, y);
                x += 180;
                e.Graphics.DrawString(row["Tipo"].ToString(), texto, Brushes.Black, x, y);
                x += 100;
                e.Graphics.DrawString(row["Quantidade"].ToString(), texto, Brushes.Black, x, y);
                x += 60;
                e.Graphics.DrawString(row["Qtd Final"].ToString(), texto, Brushes.Black, x, y);
                x += 80;
                e.Graphics.DrawString(row["Motivo"].ToString(), texto, Brushes.Black, x, y);
                x += 120;
                e.Graphics.DrawString(row["Observacao"].ToString(), texto, Brushes.Black, x, y);
                x += 180;
                e.Graphics.DrawString(Convert.ToDateTime(row["Data"]).ToString("dd/MM/yyyy HH:mm"), texto, Brushes.Black, x, y);
                x += 100;
                e.Graphics.DrawString(row["Funcionario"].ToString(), texto, Brushes.Black, x, y);

                y += 25;

                if (y > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }
    }
}