using MySql.Data.MySqlClient;
using ProjetoIntegradorSENAC.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Usuarios
{
    public partial class frmFuncionarios : Form
    {
        int idEmpresa;

        bool erroNome = true;
        bool erroEmail = true;
        bool erroCpf = true;
        bool erroTelefone = true;
        bool[] erroSenha = { true, true };

        public frmFuncionarios(int idEmpresa)
        {
            InitializeComponent();
            this.idEmpresa = idEmpresa;
        }

        private void CarregarFucionarios()
        {
            string query = $@"SELECT u.id, u.senha, u.nome, u.email, u.cpf, u.telefone
                              FROM funcionarios f
                              JOIN usuarios u ON f.usuarios_id = u.id
                              WHERE f.comercio_id = {idEmpresa} and f.cargo != 'dono'";

            DataTable dtFuncionarios = Banco.Pesquisar(query);
            dtgFuncionarios.DataSource = dtFuncionarios;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            bool senhaVal = false;

            if (UsSenha.Text == ConfirmarSenha.Text) senhaVal = true;


            if (senhaVal && !erroNome && !erroCpf && !erroEmail && !erroTelefone && !erroSenha[0] && !erroSenha[1])
            {

                using (var conn = Banco.AbrirConexao())
                {
                    // 1 - cria usuario
                    string senha = Funcoes.CriptoSenha(ConfirmarSenha.Text);

                    string insertUsuario =
                    "INSERT INTO usuarios (nome, email, cpf, telefone, senha) " +
                    $"VALUES ('{UsNome.Text}', '{UsEmail.Text}', '{UsCpf.Text}', '{UsTelefone.Text}', '{senha}')";

                    using (var cmd1 = new MySqlCommand(insertUsuario, conn))
                        cmd1.ExecuteNonQuery();

                    // 2 - pega id criado
                    using (var cmd2 = new MySqlCommand("SELECT LAST_INSERT_ID()", conn))
                    {
                        int idUsuarioNovo =
                            Convert.ToInt32(cmd2.ExecuteScalar());

                        // 3 - cria funcionario
                        string insertFuncionario =
                        $@"INSERT INTO funcionarios (usuarios_id, comercio_id, cargo)
                          VALUES ({idUsuarioNovo},{idEmpresa}, 'funcionario')";

                        using (var cmd3 = new MySqlCommand(insertFuncionario, conn))
                            cmd3.ExecuteNonQuery();
                    }
                    MessageBox.Show("Conta criada com sucesso!!");
                    Funcoes.Limpar(this);
                }

            }
            else
            {
                if (!senhaVal) MessageBox.Show("As senhas não correspondem");
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

        private void dtgFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            DataGridViewRow row = dtgFuncionarios.Rows[e.RowIndex];



           
        }

        private void dtgFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            CarregarFucionarios();
        }
    }
}

