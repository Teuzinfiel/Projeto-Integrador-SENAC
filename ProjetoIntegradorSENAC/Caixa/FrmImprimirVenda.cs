using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using ProjetoIntegradorSENAC.Classes;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Caixa
{
    public partial class frmImprimirVenda : Form
    {
        private string _codigo;
        private Venda _venda;

        public frmImprimirVenda(string codigo, Venda venda)
        {
            InitializeComponent();
            _codigo = codigo;
            _venda = venda;
        }

        private void frmImprimirVenda_Load(object sender, EventArgs e)
        {
            GerarPdf();
        }

        private void GerarPdf()

        {
            PdfFont fontBold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            string pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string caminho = Path.Combine(pasta, $"Cupom_{_codigo}.pdf");

            using (PdfWriter writer = new PdfWriter(caminho))
            using (PdfDocument pdf = new PdfDocument(writer))
            using (Document document = new Document(pdf))
            {
                PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                document.Add(new Paragraph("========= CUPOM =========")
                    .SetFont(fontBold)
                    .SetTextAlignment(TextAlignment.CENTER));

                document.Add(new Paragraph("\nCódigo: " + _codigo));
                document.Add(new Paragraph("Data: " + DateTime.Now));
                document.Add(new Paragraph("Forma Pagamento: " + _venda.FormaPagamento));

                document.Add(new Paragraph("\nItens:\n"));

                foreach (var item in _venda.Itens)
                {
                    document.Add(new Paragraph(
                        $"{item.NomeProduto} - {item.Quantidade}x - {item.Total:C2}"
                    ));
                }

                document.Add(new Paragraph("\n------------------------"));
                document.Add(new Paragraph("Descontos: " + _venda.Descontos.ToString("C2")));
                document.Add(new Paragraph("TOTAL: " + _venda.TotalBruto.ToString("C2"))
                    .SetFont(fontBold));
            }

            // Abre automaticamente o PDF
            Process.Start(new ProcessStartInfo()
            {
                FileName = caminho,
                UseShellExecute = true
            });
        }
    }
}
