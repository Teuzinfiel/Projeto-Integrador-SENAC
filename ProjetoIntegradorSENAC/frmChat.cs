using iText.Layout.Properties;
using ProjetoIntegradorSENAC.Classes;
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
        private int idEmpresa;
        private int idFuncionario;

        public frmChat(int idEmpresa, int idFunc)
        {
            InitializeComponent();
            btnSair.Click += (s, e) => this.Close();
            btnMinimizar.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
            panelTop.MouseDown += PanelTop_MouseDown;

            btnEnviar.Click += BtnEnviar_Click;
            this.idFuncionario = idFunc;
            this.idEmpresa = idEmpresa;
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

        private async void frmChat_Load(object sender, EventArgs e)
        {
            AdicionarMensagem("Carregando informações do sistema...", false);
            await IniciarChatSistemaCompleto();
        }
        private bool IAQuerSQL(string resposta)
        {
            return resposta.TrimStart().StartsWith("SQL_QUERY:");
        }

        private string ExtrairSQL(string resposta)
        {
            return resposta.Replace("SQL_QUERY:", "").Trim();
        }

        private string DataTableParaTexto(DataTable dt)
        {
            if (dt.Rows.Count == 0)
                return "RESULTADO: Nenhum registro encontrado.";

            StringBuilder sb = new StringBuilder();

            foreach (DataColumn col in dt.Columns)
                sb.Append(col.ColumnName + " | ");

            sb.AppendLine();
            sb.AppendLine("-----------------------------------");

            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                    sb.Append(item.ToString() + " | ");

                sb.AppendLine();
            }

            return sb.ToString();
        }

        private string GerarManualSistemaCompleto()
        {
            return @"
Você é um assistente técnico interno do sistema Erpex.
Você responde dúvidas sobre TODO o funcionamento do sistema.

========================================
BANCO DE DADOS
========================================

========================================
EMPRESA ATUAL
========================================

comercio_id = {{comercio_id}}

NUNCA acessar dados de outra empresa.

========================================
BANCO DE DADOS DO SISTEMA ERP
========================================

TABELAS:

usuarios
- id
- nome
- telefone
- email
- cpf

funcionarios
- id
- usuarios_id
- comercio_id
- cargo

produtos
- id
- comercio_id
- nome
- descricao
- marca
- codigo_barra
- unidade_medida
- categoria_id
- preco
- custo

estoque
- produto_id
- quantidade_atual

vendas
- id
- funcionario_id
- comercio_id
- data_venda
- total
- descontos
- forma_pagamento_id
- lucro

items_venda
- id
- produtos_id
- quantidade
- preco_unitario
- lucro
- vendas_id

forma_pagamento
- id
- nome

movimentacoes_estoque
- id
- produto_id
- funcionario_id
- comercio_id
- tipo
- quantidade
- quantidade_final
- motivo
- data

contas_receber
- id
- comercio_id
- pagador_tipo
- pagador_id
- descricao
- valor
- data_vencimento
- status

parcelas
- id
- tipo
- titulo_id
- numero_parcela
- valor
- data_vencimento
- status

pagamentos
- id
- parcela_id
- movimentacao_id
- valor_pago
- data_pagamento

movimentacoes_financeiras
- id
- conta_financeira_id
- tipo
- valor
- data_movimento
- origem_tipo
- origem_id
- descricao

logs
- id
- comercio_id
- usuario_id
- descricao
- data

========================================
FLUXO DO SISTEMA
========================================

USUÁRIOS:
- Cadastro com nome, senha, telefone, email e cpf.

EMPRESA:
- Dono cadastra comércio.
- Comércio pode ser CPF ou CNPJ.
- Dono vira automaticamente funcionário com cargo 'dono'.

FUNCIONÁRIOS:
- Vinculados a usuário e comércio.

PRODUTOS:
- Ligados ao comércio.
- Possuem categoria, preço, código de barra.
- Estoque controlado por movimentacoes_estoque.
- Tabela estoque mantém quantidade atual.

========================================
CAIXA
========================================

Ao abrir:
- Carrega produtos do comércio.
- Busca estoque pela última movimentação.

Ao adicionar item:
- Verifica estoque.
- Incrementa quantidade.
- Aplica desconto percentual (0 a 99).
- Atualiza painel visual.

Finalização da venda:
- Salva em vendas.
- Salva em items_venda.
- Registra movimentação tipo 'saida'.
- Atualiza tabela estoque.
- Gera codigo_consumidor (GUID).
- Permite impressão.

Devolução:
- Busca venda pelo codigo_consumidor.
- Reverte estoque (tipo 'entrada').
- Exclui items_venda.
- Exclui venda.

Formas de pagamento:
- Pix
- Dinheiro
- Crédito
- Débito

========================================
IMPRESSÃO
========================================

Comprovante contém:
- Código consumidor
- Data
- Forma pagamento
- Lista de itens
- Total
- Descontos

========================================
DASHBOARD
========================================

Permite:
- Gráfico de vendas
- Gráfico de produtos
- Comparação de períodos
- Exportação Excel
- Ranking de produtos
- Faturamento mensal

========================================

========================================
ACESSO AO BANCO DE DADOS
========================================

Se precisar consultar dados do banco:

Responda APENAS com:

SQL_QUERY: SELECT ...

REGRAS:

1 Apenas SELECT
2 Nunca INSERT
3 Nunca UPDATE
4 Nunca DELETE
5 Sempre filtrar por comercio_id = {comercio_id}
6 Nunca acessar dados de outra empresa
7 Nunca acessar dados de outro funcionario

Após receber o RESULTADO_SQL você deve gerar a resposta final para o usuário.

REGRAS DE RESPOSTA:

- Nunca faça perguntas.
- Nunca peça confirmação.
- Nunca aguarde resposta do usuário.
- Sempre gere a resposta final completa, sem criar efeitos visuais com caracteres... Apenas texto.
-Nunca exponha dados da estrutura do banco de dados, apenas oque ele precisa para a requisição.
-Escreva Totalmente em portugues.
Responda sempre de forma didática e técnica.
Explique fluxos internos quando necessário. E responda no maximo em 30 segundos
";
        }

        private async Task IniciarChatSistemaCompleto()
        {
            string manual = GerarManualSistemaCompleto()
    .Replace("{comercio_id}", idEmpresa.ToString());

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

            // 🔥 SE IA PEDIR SQL
            if (IAQuerSQL(resposta))
            {
                string sql = ExtrairSQL(resposta);

                try
                {
                    DataTable dados = Banco.Pesquisar(sql);

                    string resultado = DataTableParaTexto(dados);

                    _historico.Add("SISTEMA_RESULTADO_SQL:\n" + resultado);

                    string promptFinal = String.Join("\n\n", _historico);

                    string respostaFinal = await EnviarParaManus(promptFinal);

                    AdicionarMensagem(respostaFinal, false);

                    _historico.Add("ASSISTENTE:\n" + respostaFinal);
                }
                catch (Exception ex)
                {
                    AdicionarMensagem("Erro ao consultar banco. Tente Novamente", false);
                }
            }
            else
            {
                AdicionarMensagem(resposta, false);

                _historico.Add("ASSISTENTE:\n" + resposta);
            }
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

            int tentativas = 0;
            int maxTentativas = 10; // 10 x 3 segundos = 30 segundos

            while (tentativas < maxTentativas)
            {
                tentativas++;

                var response = await client.GetAsync(url);
                string body = await response.Content.ReadAsStringAsync();

                using JsonDocument doc = JsonDocument.Parse(body);
                var root = doc.RootElement;

                string status = root.GetProperty("status").GetString()?? "WOLF";

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
                                if (content.TryGetProperty("text", out JsonElement textElement))
                                {
                                    ultimaResposta = textElement.GetString();
                                }
                            }
                        }
                    }

                    return ultimaResposta ?? "Sem resposta.";
                }

                if (status == "WOLF")
                    return "Tente novamente";

                if (status == "failed")
                    return "Erro ao processar.";

                await Task.Delay(3000);
            }

            return "Tempo limite atingido tente novamente:";
        }
    }
}
