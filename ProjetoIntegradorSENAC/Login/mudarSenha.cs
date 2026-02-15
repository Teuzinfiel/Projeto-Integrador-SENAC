using MySql.Data.MySqlClient;
using ProjetoIntegradorSENAC.Classes;
using ProjetoIntegradorSENAC.Dashboard;
using ProjetoIntegradorSENAC.Logins;
using ProjetoIntegradorSENAC.personalizado;
using ProjetoIntegradorSENAC.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetoIntegradorSENAC
{
    public partial class mudarSenha : Form
    {
        private string Email;
        private int Codigo;
        public mudarSenha(int codigo, string email)
        {
            InitializeComponent();
            Email = email;
            Codigo = codigo;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        bool novaSenhaboo = false, confirmarSenhaboo = false;
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarSenha.Checked)
            {
                txtNovaSenha.UseSystemPasswordChar = false; // Mostra a senha
                txtConfirmarSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtNovaSenha.UseSystemPasswordChar = true; // Esconde a senha
                txtConfirmarSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtNovaSenha_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isSenha(txtNovaSenha.Text) == false)
            {
                lbNovaSenha.ForeColor = Color.DarkRed;
                novaSenhaboo = false;
            }
            else
            {
                lbNovaSenha.ForeColor = Color.FromArgb(180, 180, 190);
                novaSenhaboo = true;
            }
        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isSenha(txtConfirmarSenha.Text) == false)
            {
                lbConfirmarSenha.ForeColor = Color.DarkRed;
                confirmarSenhaboo = false;
            }
            else
            {
                lbConfirmarSenha.ForeColor = Color.FromArgb(180, 180, 190);
                confirmarSenhaboo = true;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (novaSenhaboo == true && confirmarSenhaboo == true)
            {
                string query = @"UPDATE usuarios SET
                senha = @senha
                WHERE email = @email";
                Dictionary<string, string> parametros = new Dictionary<string, string>()
                {
                    {"@senha", Funcoes.CriptoSenha(txtConfirmarSenha.Text)},
                    {"@email", Email}
                };
                func_dashboard.Update(query, parametros);
                loginUsuario usuario = new loginUsuario();
                usuario.Show();


                caixaMensagem mensagem = new caixaMensagem("Senha alterada com sucesso", "Sucesso ✔");
                mensagem.Show();
                this.Hide();
            }
        }

        private void btnVoltarParaLogin_Click(object sender, EventArgs e)
        {
            loginUsuario usuario = new loginUsuario();
            usuario.Show();
            this.Hide();
        }

        private void mudarSenha_Load(object sender, EventArgs e)
        {
            Funcoes.AtivarMovimentoPanel(this, panelTop);
        }
    }
}
