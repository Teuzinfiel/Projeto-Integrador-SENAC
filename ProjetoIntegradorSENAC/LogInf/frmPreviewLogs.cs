using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.LogInf
{
    public partial class frmPreviewLogs : Form
    {
        private DataTable dados;
        private PrintDocument print;

        public frmPreviewLogs(DataTable tabela)
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
            Font titulo = new Font("Franklin Gothic Medium", 22);
            Font cabecalho = new Font("Segoe UI", 12, FontStyle.Bold);
            Font texto = new Font("Segoe UI", 11);

            int y = 20;

            e.Graphics.DrawString("RELATÓRIO DE LOGS DO SISTEMA", titulo, Brushes.Black, 20, y);
            y += 50;

            // Cabeçalho
            e.Graphics.DrawString("Código", cabecalho, Brushes.Black, 20, y);
            e.Graphics.DrawString("Usuário", cabecalho, Brushes.Black, 100, y);
            e.Graphics.DrawString("Descrição", cabecalho, Brushes.Black, 260, y);
            e.Graphics.DrawString("Data/Hora", cabecalho, Brushes.Black, 650, y);

            y += 30;

            foreach (DataRow row in dados.Rows)
            {
                e.Graphics.DrawString(row["id"].ToString(), texto, Brushes.Black, 20, y);
                e.Graphics.DrawString(row["Usuario"].ToString(), texto, Brushes.Black, 100, y);
                e.Graphics.DrawString(row["Descricao"].ToString(), texto, Brushes.Black, 260, y);
                e.Graphics.DrawString(row["Data"].ToString(), texto, Brushes.Black, 650, y);

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