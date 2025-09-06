using ProjetoIntegradorSENAC.Caixa;
using ProjetoIntegradorSENAC.Dashboard;
using ProjetoIntegradorSENAC.Estoque;
using ProjetoIntegradorSENAC.Log;
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
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new caixa());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new dashboard());
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new frmProduto());
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new estoque());
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new frmUsuarios());
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new log());
        }
    }
}
