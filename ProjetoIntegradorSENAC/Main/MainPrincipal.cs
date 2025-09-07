using ProjetoIntegradorSENAC.Caixa;
using ProjetoIntegradorSENAC.Dashboard;
using ProjetoIntegradorSENAC.Empresa;
using ProjetoIntegradorSENAC.Estoque;
using ProjetoIntegradorSENAC.Log;
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
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new dashboard());
            labelCategorias.Text = "Dashboard";
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new frmProduto());
            labelCategorias.Text = "Produtos";
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new estoque());
            labelCategorias.Text = "Estoque";
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new frmUsuarios());
            labelCategorias.Text = "Funcionários";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new log());
            labelCategorias.Text = "Log";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmEmpresa frmEmpresa = new frmEmpresa();
            frmEmpresa.Show();
            this.Hide();
        }
    }
}
