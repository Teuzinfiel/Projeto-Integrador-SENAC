using ProjetoIntegradorSENAC.Caixa;
using ProjetoIntegradorSENAC.Classes;
using ProjetoIntegradorSENAC.Configurações;
using ProjetoIntegradorSENAC.Dashboard;
using ProjetoIntegradorSENAC.Empresa;
using ProjetoIntegradorSENAC.Estoque;
using ProjetoIntegradorSENAC.LogInf;
using ProjetoIntegradorSENAC.Logins;
using ProjetoIntegradorSENAC.Produto;
using ProjetoIntegradorSENAC.Usuarios;


namespace ProjetoIntegradorSENAC
{
    public partial class MainEmpresa : Form
    {
        public int idEmpresa;
        public int idDono;
        public int idUsuario;
        public string nomeEmpresa;
        public MainEmpresa(int idEmpresa, int idDono, int idUsuario, string nomeEmpresa)
        {
            InitializeComponent();
            this.idEmpresa = idEmpresa;
            this.idDono = idDono;
            this.idUsuario = idUsuario;
            nomeEmpresa = nomeEmpresa;
            label3.Text = nomeEmpresa;
            LogService.CriarLog(this.idEmpresa, this.idUsuario, "Entrou na " + nomeEmpresa);
        }

        public void DestacarMovimentacoes()
        {
            EfeitoClickBotaocs.ResetarBotoes(
                btnCaixa,
                btnDashboard,
                btnEstoque,
                btnFuncionario,
                btnLog,
                btnProdutos,
                btnMovimentacao
            );

            btnMovimentacao.BackColor = Color.FromArgb(45, 45, 60);
            labelCategorias.Text = "Movimentações";
        }

        public void AbrirFormNoPanel(Form formFilho)
        {
            // tira qualquer container que tiver aberto se outro for clicado
            panelContainer.Controls.Clear();
            formFilho.TopLevel = false; // faz com que o form dependa do container pai
            formFilho.FormBorderStyle = FormBorderStyle.None; // tira a borda
            formFilho.Dock = DockStyle.Fill; // preenche todo o espaço do container
            panelContainer.Controls.Add(formFilho);  // add o form que abriu
            panelContainer.Tag = formFilho;
            formFilho.Show();
        }

        private void MainEmpresa_Load(object sender, EventArgs e)
        {
            if (idUsuario != idDono) btnFuncionario.ImageIndex = 9;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {

            AbrirFormNoPanel(new caixa(this.idEmpresa, this.idUsuario));
            labelCategorias.Text = "Caixa";
            EfeitoClickBotaocs.ResetarBotoes(btnCaixa, btnDashboard, btnEstoque, btnFuncionario, btnLog, btnProdutos, btnMovimentacao);
            btnCaixa.BackColor = Color.FromArgb(45, 45, 60);
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {

            AbrirFormNoPanel(new dashboard(this, this.idEmpresa, false));
            labelCategorias.Text = "Dashboard";
            EfeitoClickBotaocs.ResetarBotoes(btnCaixa, btnDashboard, btnEstoque, btnFuncionario, btnLog, btnProdutos, btnMovimentacao);
            btnDashboard.BackColor = Color.FromArgb(45, 45, 60);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {

            AbrirFormNoPanel(new frmProduto(idUsuario, idEmpresa));
            labelCategorias.Text = "Produtos";
            EfeitoClickBotaocs.ResetarBotoes(btnCaixa, btnDashboard, btnEstoque, btnFuncionario, btnLog, btnProdutos, btnMovimentacao);
            btnProdutos.BackColor = Color.FromArgb(45, 45, 60);
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {

            AbrirFormNoPanel(new estoque(this, this.idEmpresa, this.idUsuario));
            labelCategorias.Text = "Estoque";
            EfeitoClickBotaocs.ResetarBotoes(btnCaixa, btnDashboard, btnEstoque, btnFuncionario, btnLog, btnProdutos, btnMovimentacao);
            btnEstoque.BackColor = Color.FromArgb(45, 45, 60);
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {

            if (idUsuario == idDono)
            {
                AbrirFormNoPanel(new frmFuncionarios(this.idEmpresa, this.idUsuario));

                labelCategorias.Text = "Funcionários";
                EfeitoClickBotaocs.ResetarBotoes(btnCaixa, btnDashboard, btnEstoque, btnFuncionario, btnLog, btnProdutos, btnMovimentacao);
                btnFuncionario.BackColor = Color.FromArgb(45, 45, 60);
            }
            else
            {
                MessageBox.Show("Apenas o dono da empresa pode acessar a tela de funcionários.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {

            AbrirFormNoPanel(new logInf(this.idEmpresa));
            labelCategorias.Text = "Log";
            EfeitoClickBotaocs.ResetarBotoes(btnCaixa, btnDashboard, btnEstoque, btnFuncionario, btnLog, btnProdutos, btnMovimentacao);
            btnLog.BackColor = Color.FromArgb(45, 45, 60);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmEmpresa frm = new frmEmpresa(this.idUsuario, null);
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // AbrirFormNoPanel(new configEmpresa(this.idEmpresa, this.idDono, this.idUsuario));
            labelCategorias.Text = "Configurações";
            EfeitoClickBotaocs.ResetarBotoes(btnCaixa, btnDashboard, btnEstoque, btnFuncionario, btnLog, btnProdutos, btnMovimentacao);
            frmChat frmChat = new frmChat();
            frmChat.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new MovimentacaoProdutos(this.idEmpresa));
            labelCategorias.Text = "Movimentações";
            EfeitoClickBotaocs.ResetarBotoes(btnCaixa, btnDashboard, btnEstoque, btnFuncionario, btnLog, btnProdutos, btnMovimentacao);
            btnMovimentacao.BackColor = Color.FromArgb(45, 45, 60);
        }
    }
}
