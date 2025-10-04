using ProjetoIntegradorSENAC.Caixa;
using ProjetoIntegradorSENAC.Classes;
using ProjetoIntegradorSENAC.Dashboard;
using ProjetoIntegradorSENAC.Empresa;
using ProjetoIntegradorSENAC.Estoque;
using ProjetoIntegradorSENAC.LogInf;
using ProjetoIntegradorSENAC.Logins;
using ProjetoIntegradorSENAC.Produto;
using ProjetoIntegradorSENAC.Usuarios;


namespace ProjetoIntegradorSENAC
{
    public partial class MainPrincipal : Form
    {
        public MainPrincipal()
        {
            InitializeComponent();
        }
        private void AbrirFormNoPanel(Form formFilho)
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
            AbrirFormNoPanel(new caixa());
            labelCategorias.Text = "Caixa";
            EfeitoClickBotaocs.ResetarBotoes(btnCaixa, btnDashboard, btnEstoque, btnFuncionario, btnLog, btnProdutos);
            btnCaixa.BackColor = Color.FromArgb(45, 45, 60);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new dashboard());
            labelCategorias.Text = "Dashboard";
            EfeitoClickBotaocs.ResetarBotoes(btnCaixa, btnDashboard, btnEstoque, btnFuncionario, btnLog, btnProdutos);
            btnDashboard.BackColor = Color.FromArgb(45, 45, 60);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new frmProduto());
            labelCategorias.Text = "Produtos";
            EfeitoClickBotaocs.ResetarBotoes(btnCaixa, btnDashboard, btnEstoque, btnFuncionario, btnLog, btnProdutos);
            btnProdutos.BackColor = Color.FromArgb(45, 45, 60);
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new estoque());
            labelCategorias.Text = "Estoque";
            EfeitoClickBotaocs.ResetarBotoes(btnCaixa, btnDashboard, btnEstoque, btnFuncionario, btnLog, btnProdutos);
            btnEstoque.BackColor = Color.FromArgb(45, 45, 60);
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new frmUsuarios());
            labelCategorias.Text = "Funcionários";
            EfeitoClickBotaocs.ResetarBotoes(btnCaixa, btnDashboard, btnEstoque, btnFuncionario, btnLog, btnProdutos);
            btnFuncionario.BackColor = Color.FromArgb(45, 45, 60);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new logInf());
            labelCategorias.Text = "Log";
            EfeitoClickBotaocs.ResetarBotoes(btnCaixa, btnDashboard, btnEstoque, btnFuncionario, btnLog, btnProdutos);
            btnLog.BackColor = Color.FromArgb(45, 45, 60);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmEmpresa frmEmpresa = new frmEmpresa();
            frmEmpresa.Show();
            this.Hide();
        }
    }
}
