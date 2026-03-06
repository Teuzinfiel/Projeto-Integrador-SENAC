using ProjetoIntegradorSENAC.Caixa;
using ProjetoIntegradorSENAC.Classes;
using ProjetoIntegradorSENAC.Configurações;
using ProjetoIntegradorSENAC.Dashboard;
using ProjetoIntegradorSENAC.Empresa;
using ProjetoIntegradorSENAC.Estoque;
using ProjetoIntegradorSENAC.LogInf;
using ProjetoIntegradorSENAC.Logins;
using ProjetoIntegradorSENAC.Main;
using ProjetoIntegradorSENAC.Produto;
using ProjetoIntegradorSENAC.Usuarios;
using System.Data;


namespace ProjetoIntegradorSENAC
{
    public partial class MainEmpresa : Form
    {
        public int idEmpresa;
        public int idDono;
        public int idUsuario;
        public string nomeEmpresa;
        mainFrm main;
        public MainEmpresa(int idEmpresa, int idDono, int idUsuario, string nomeEmpresa, mainFrm mainFrm)
        {
            InitializeComponent();
            this.idEmpresa = idEmpresa;
            this.idDono = idDono;
            this.idUsuario = idUsuario;
            this.nomeEmpresa = nomeEmpresa;

            if (nomeEmpresa.Length < 20)
            {
                txtNomeEmpresa.Text = nomeEmpresa;
            }
            else
            {
                txtNomeEmpresa.Text = nomeEmpresa.Substring(0, 20) + "...";
            }
            
            main = mainFrm;

           
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

      

        private void btnCaixa_Click(object sender, EventArgs e)
        {

            AbrirFormNoPanel(new caixa(this.idEmpresa, this.idUsuario));
            labelCategorias.Text = "Caixa";
            EfeitoClickBotaocs.ResetarBotoes(btnCaixa, btnDashboard, btnEstoque, btnFuncionario, btnLog, btnProdutos, btnMovimentacao);
            btnCaixa.BackColor = Color.FromArgb(45, 45, 60);
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {

            AbrirFormNoPanel(new dashboardVenda(this, this.idEmpresa));
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
            if (idDono == idUsuario)
            {
                main.AbrirFormNoPanel(new frmEmpresa(this.idUsuario, main));
            }
            else
            {
                main.AbrirFormNoPanel(new loginUsuario(main));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // AbrirFormNoPanel(new configEmpresa(this.idEmpresa, this.idDono, this.idUsuario));
            labelCategorias.Text = "Configurações";
            EfeitoClickBotaocs.ResetarBotoes(btnCaixa, btnDashboard, btnEstoque, btnFuncionario, btnLog, btnProdutos, btnMovimentacao);
            frmChat frmChat = new frmChat(idEmpresa, idUsuario);
            frmChat.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new MovimentacaoProdutos(this.idEmpresa));
            labelCategorias.Text = "Movimentações";
            EfeitoClickBotaocs.ResetarBotoes(btnCaixa, btnDashboard, btnEstoque, btnFuncionario, btnLog, btnProdutos, btnMovimentacao);
            btnMovimentacao.BackColor = Color.FromArgb(45, 45, 60);
        }

        private void MainEmpresa_Load(object sender, EventArgs e)
        {
            if (idUsuario != idDono)
            {
                btnFuncionario.ImageIndex = 9;             
                btnFuncionario.ForeColor = Color.FromArgb(100, 100, 100);
            }
            try
            {
                string sql = $"SELECT nome FROM usuarios WHERE id = {idUsuario} LIMIT 1";
                DataTable dt = Banco.Pesquisar(sql);

                if (dt.Rows.Count > 0)
                {
                    string nomeUsuario = dt.Rows[0]["nome"].ToString();
                    txtNomeUser.Text = "Bem-vindo, " + nomeUsuario;
                }
                else
                {
                    txtNomeUser.Text = "Bem-vindo, usuário";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar nome do usuário:\n" + ex.Message);
                txtNomeUser.Text = "Bem-vindo";
            }
        }
    }
}
