using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC
{
    public partial class frmChat : Form
    {

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        private string MANUS_API_KEY = "sk-FX-TGtu1lCvFMv-12qe5GjMKK-WaF4rzSxKKIvZTQIqHpcQeIvIqHs05KVbQpHYSNGCiXxGWDMEaYRQNd_Al9dcpYScA";
        private string _taskIdAtual = null;
        private bool _chatIniciado = false;
        private List<string> _historico = new List<string>();
        public frmChat()
        {
            InitializeComponent();
            btnSair.Click += (s, e) => this.Close();
            btnMinimizar.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
            panelTop.MouseDown += PanelTop_MouseDown;

            btnEnviar.Click += BtnEnviar_Click;
        }

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private async void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMensagem.Text))
                return;

            string textoUsuario = txtMensagem.Text.Trim();
            txtMensagem.Clear();

            await EnviarPergunta(textoUsuario);
        }

        private void AdicionarMensagem(string texto, bool ehUsuario)
        {
            // Container que ocupa toda largura
            Panel container = new Panel();
            container.Width = flowChat.ClientSize.Width - 25;
            container.AutoSize = true;

            FlowLayoutPanel alinhador = new FlowLayoutPanel();
            alinhador.FlowDirection = ehUsuario ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;
            alinhador.Dock = DockStyle.Fill;
            alinhador.AutoSize = true;
            alinhador.WrapContents = false;

            Panel bubble = new Panel();
            bubble.AutoSize = true;
            bubble.MaximumSize = new Size(220, 0);
            bubble.Padding = new Padding(10);
            bubble.Margin = new Padding(5);

            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.MaximumSize = new Size(200, 0);
            lbl.Text = texto;
            lbl.ForeColor = Color.White;
            lbl.Font = new Font("Microsoft Sans Serif", 10F);

            bubble.Controls.Add(lbl);

            if (ehUsuario)
                bubble.BackColor = SystemColors.Highlight;
            else
                bubble.BackColor = Color.FromArgb(70, 70, 80);

            alinhador.Controls.Add(bubble);
            container.Controls.Add(alinhador);
            flowChat.Controls.Add(container);

            flowChat.ScrollControlIntoView(container);
        }

        private void frmChat_Load(object sender, EventArgs e)
        {
            Button btnCaixa = new Button();
            btnCaixa.Text = "Dúvidas sobre o Caixa";
            btnCaixa.Width = 200;
            btnCaixa.Height = 40;
            btnCaixa.BackColor = Color.FromArgb(0, 150, 255);
            btnCaixa.ForeColor = Color.White;

            btnCaixa.Click += async (s, ev) =>
            {
                btnCaixa.Enabled = false;

                AdicionarMensagem("Carregando manual do Caixa...", false);

                await IniciarChatCaixa();
            };

            flowChat.Controls.Add(btnCaixa);
        }

        private string GerarManualCaixa()
        {
            return @"
Você está respondendo dúvidas sobre um sistema de CAIXA comercial.

FUNCIONAMENTO DO CAIXA:

- Produtos são carregados da tabela produtos.
- Estoque é controlado pela tabela movimentacoes_estoque.
- Ao adicionar item:
    • Verifica estoque
    • Incrementa quantidade
    • Aplica desconto percentual (0-99)
- A venda mantém:
    • Lista de itens
    • Total bruto
    • Descontos
    • Forma de pagamento

FINALIZAÇÃO DA VENDA:
- Salva na tabela vendas
- Salva itens em items_venda
- Dá baixa no estoque (tipo = saida)
- Gera código_consumidor (GUID)

FORMAS DE PAGAMENTO:
- Pix
- Dinheiro
- Crédito
- Débito

DEVOLUÇÃO:
- Busca venda pelo codigo_consumidor
- Devolve estoque (tipo = entrada)
- Remove itens_venda
- Remove venda

IMPRESSÃO:
- Gera comprovante com:
    • Código
    • Data
    • Forma pagamento
    • Itens
    • Total
    • Descontos

Responda sempre de forma clara e didática para usuários do sistema.
";
        }

        private async Task IniciarChatCaixa()
        {
            string manual = GerarManualCaixa();

            _historico.Clear();
            _historico.Add("SISTEMA:\n" + manual);

            string resposta = await EnviarParaManus(String.Join("\n\n", _historico));

            AdicionarMensagem(resposta, false);

            _historico.Add("ASSISTENTE:\n" + resposta);

            _chatIniciado = true;
        }
        private async Task<string> EnviarParaManus(string prompt)
        {
            string taskId = await CreateTask(prompt);
            return await WaitForTask(taskId);
        }

        private async Task EnviarPergunta(string pergunta)
        {
            if (!_chatIniciado)
                return;

            AdicionarMensagem(pergunta, true);

            _historico.Add("USUARIO:\n" + pergunta);

            string promptCompleto = String.Join("\n\n", _historico);

            string resposta = await EnviarParaManus(promptCompleto);

            AdicionarMensagem(resposta, false);

            _historico.Add("ASSISTENTE:\n" + resposta);
        }

        private async Task<string> CreateTask(string prompt)
        {
            string url = "https://api.manus.ai/v1/tasks";

            var payload = new { prompt };
            string json = JsonSerializer.Serialize(payload);

            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("API_KEY", MANUS_API_KEY);

            using var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);
            string responseBody = await response.Content.ReadAsStringAsync();

            using JsonDocument doc = JsonDocument.Parse(responseBody);
            return doc.RootElement.GetProperty("task_id").GetString();
        }

        private async Task<string> WaitForTask(string taskId)
        {
            string url = $"https://api.manus.ai/v1/tasks/{taskId}";

            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("API_KEY", MANUS_API_KEY);

            while (true)
            {
                var response = await client.GetAsync(url);
                string body = await response.Content.ReadAsStringAsync();

                using JsonDocument doc = JsonDocument.Parse(body);
                var root = doc.RootElement;

                string status = root.GetProperty("status").GetString();

                if (status == "completed")
                {
                    string ultimaResposta = null;

                    if (root.TryGetProperty("output", out JsonElement outputArray)
                        && outputArray.ValueKind == JsonValueKind.Array)
                    {
                        foreach (var item in outputArray.EnumerateArray())
                        {
                            if (!item.TryGetProperty("role", out JsonElement roleElement))
                                continue;

                            if (roleElement.GetString() != "assistant")
                                continue;

                            if (!item.TryGetProperty("content", out JsonElement contentArray))
                                continue;

                            if (contentArray.ValueKind != JsonValueKind.Array)
                                continue;

                            foreach (var content in contentArray.EnumerateArray())
                            {
                                if (content.TryGetProperty("text", out JsonElement textElement) &&
                                    textElement.ValueKind == JsonValueKind.String)
                                {
                                    // 🔥 Guarda sempre a última
                                    ultimaResposta = textElement.GetString();
                                }
                            }
                        }
                    }

                    return ultimaResposta ?? "Sem resposta.";
                }

                if (status == "failed")
                    return "Erro ao processar.";

                await Task.Delay(3000);
            }
        }
    }
}
