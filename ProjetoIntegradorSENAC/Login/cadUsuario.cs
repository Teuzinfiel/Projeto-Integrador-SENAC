using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegradorSENAC.Classes;
using ProjetoIntegradorSENAC.Logins;

namespace ProjetoIntegradorSENAC.Usuario
{
    public partial class cadUsuario : Form
    {

        bool erroNome = true;
        bool erroEmail = true;
        bool erroCpf = true;

        public cadUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            bool senha = false;

            if (UsSenha.Text == ConfirmarSenha.Text) senha = true;


            if (senha && UsNome.Text != "" && UsTelefone.MaskFull && UsEmail.Text != "")
            {

                string insert = "insert into usuarios (nome, email, cpf, telefone, senha)" +
                    $" value ('{UsNome.Text}', '{UsEmail.Text}', '{UsCpf.Text}', '{UsTelefone.Text}', '{ConfirmarSenha.Text}')";

                Banco.Inserir(insert);

                MessageBox.Show("Conta criada com sucesso!!");
                Funcoes.Limpar(this);
                loginUsuario loginUsuario = new loginUsuario();
                loginUsuario.Show();
                this.Close();
            }
            else
            {
                if (!senha) MessageBox.Show("As senhas não correspondem");
                else MessageBox.Show("Preencha todos os campos corretamente");
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

        private void UsCpf_TextChanged(object sender, EventArgs e)
        {
            if (UsCpf.MaskFull)
            {

                if (!Funcoes.isCpf(UsCpf.Text))
                {
                    MessageBox.Show("tá errado isso ae");
                    UsCpf.Text = "";
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Funcoes.Limpar(this);
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            loginUsuario loginUsuario = new loginUsuario();
            loginUsuario.Show();
            this.Close();
        }

        private void UsNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {








        }
    }
}
