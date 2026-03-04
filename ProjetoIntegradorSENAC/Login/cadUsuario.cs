using ProjetoIntegradorSENAC.Classes;
using ProjetoIntegradorSENAC.Logins;
using ProjetoIntegradorSENAC.Main;
using ProjetoIntegradorSENAC.personalizado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Usuario
{
    public partial class cadUsuario : Form
    {

        bool erroNome = true;
        bool erroEmail = true;
        bool erroCpf = true;
        bool erroTelefone = true;
        bool[] erroSenha = { true, true };

        caixaInformacao? info;
        mainFrm main;

        public cadUsuario(mainFrm mainFrm)
        {
            InitializeComponent();
            main = mainFrm;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            bool senhaVal = false;

            if (UsSenha.Text == ConfirmarSenha.Text)
                senhaVal = true;

            if (senhaVal && !erroNome && !erroCpf && !erroEmail && !erroTelefone && !erroSenha[0] && !erroSenha[1])
            {
                // 🔎 Verifica se já existe email, cpf ou telefone
                string select = "SELECT * FROM usuarios WHERE " +
                                $"email = '{UsEmail.Text.ToLower()}' OR " +
                                $"cpf = '{UsCpf.Text}' OR " +
                                $"telefone = '{UsTelefone.Text}'";

                DataTable dt = Banco.Pesquisar(select);

                if (dt.Rows.Count > 0)
                {
                    string mensagem = "";

                    if (dt.Rows[0]["email"].ToString() == UsEmail.Text)
                        mensagem += "Email já cadastrado!\n";

                    if (dt.Rows[0]["cpf"].ToString() == UsCpf.Text)
                        mensagem += "CPF já cadastrado!\n";

                    if (dt.Rows[0]["telefone"].ToString() == UsTelefone.Text)
                        mensagem += "Telefone já cadastrado!\n";

                    MessageBox.Show(mensagem);
                    return;
                }

                // 🔐 Criptografa senha
                string senha = Funcoes.CriptoSenha(ConfirmarSenha.Text);

                string insert = "INSERT INTO usuarios (nome, email, cpf, telefone, senha) " +
                                $"VALUES ('{UsNome.Text}', '{UsEmail.Text.ToLower()}', '{UsCpf.Text}', '{UsTelefone.Text}', '{senha}')";

                Banco.Inserir(insert);

                MessageBox.Show("Conta criada com sucesso!!");
                Funcoes.Limpar(this);
                main.AbrirFormNoPanel(new loginUsuario(main));
            }
            else
            {
                if (!senhaVal)
                    MessageBox.Show("As senhas não correspondem");
                else
                    MessageBox.Show("Preencha todos os campos corretamente");
            }
        }

        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {

            if (chkMostrarSenha.Checked)
            {
                ConfirmarSenha.UseSystemPasswordChar = false; // Mostra a senha
                UsSenha.UseSystemPasswordChar = false;
            }
            else
            {
                ConfirmarSenha.UseSystemPasswordChar = true;  // Esconde a senha
                UsSenha.UseSystemPasswordChar = true;
            }

        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Funcoes.Limpar(this);
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            main.AbrirFormNoPanel (new loginUsuario(main));

        }

        private void UsNome_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.CampoVazio(UsNome))
            {
                erroNome = true;
                astNome.Visible = true;
                lbNome.ForeColor = Color.DarkRed;
            }
            else
            {
                erroNome = false;
                astNome.Visible = false;
                lbNome.ForeColor = Color.White;
            }
        }

        private void UsEmail_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isEmail(UsEmail.Text))
            {
                erroEmail = false;
                astEmail.Visible = false;
                lbEmail.ForeColor = Color.White;
            }
            else
            {
                erroEmail = true;
                astEmail.Visible = true;
                lbEmail.ForeColor = Color.DarkRed;
            }
        }

        private void UsTelefone_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isTelefone(UsTelefone.Text))
            {
                erroTelefone = false;
                astTelefone.Visible = false;
                lbTelefone.ForeColor = Color.White;
            }
            else
            {
                erroTelefone = true;
                astTelefone.Visible = true;
                lbTelefone.ForeColor = Color.DarkRed;
            }
        }

        private void UsCpf_TextChanged(object sender, EventArgs e)
        {

            if (Funcoes.isCpf(UsCpf.Text))
            {
                erroCpf = false;
                astCpf.Visible = false;
                lbCpf.ForeColor = Color.White;
            }
            else
            {
                erroCpf = true;
                astCpf.Visible = true;
                lbCpf.ForeColor = Color.DarkRed;
            }

        }

        private void UsSenha_TextChanged(object sender, EventArgs e)
        {

            if (Funcoes.isSenha(UsSenha.Text))
            {
                erroSenha[0] = false;
                astSenha.Visible = false;
                lbSenha.ForeColor = Color.White;
            }
            else
            {
                erroSenha[0] = true;
                astSenha.Visible = true;
                lbSenha.ForeColor = Color.DarkRed;
            }
        }

        private void ConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isSenha(UsSenha.Text))
            {
                erroSenha[1] = false;
                astConfirmar.Visible = false;
                lbConfirmar.ForeColor = Color.White;
            }
            else
            {
                erroSenha[1] = true;
                astConfirmar.Visible = true;
                lbConfirmar.ForeColor = Color.DarkRed;
            }
        }

        private void picSenha_MouseHover(object sender, EventArgs e)
        {
            if (info == null || info.IsDisposed)
            {
                Point pos = Cursor.Position;

                info = new caixaInformacao();

                info.StartPosition = FormStartPosition.Manual;
                info.FormBorderStyle = FormBorderStyle.None;
                info.ShowInTaskbar = false;

                info.Location = new Point(pos.X + 10, pos.Y + 10);

                main.AbrirFormNoPanel(info);
            }
        }

        private void picSenha_MouseLeave(object sender, EventArgs e)
        {
            if (info != null && !info.IsDisposed)
            {
                info.Close();
            }
        }
    }
}
