using MySql.Data.MySqlClient;
using ProjetoIntegradorSENAC.Classes;
using ProjetoIntegradorSENAC.LogInf;
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

namespace ProjetoIntegradorSENAC.Usuarios
{
    public partial class frmFuncionarios : Form
    {
        int idEmpresa;
        int idFuncionario;
        int idUser;
        string senhaAntiga;

        bool erroNome = true;
        bool erroEmail = true;
        bool erroCpf = true;
        bool erroTelefone = true;
        bool[] erroSenha = { true, true };

        bool erroNomeEd = true;
        bool erroEmailEd = true;
        bool erroCpfEd = true;
        bool erroTelefoneEd = true;
        bool[] erroSenhaEd = { true, true };



        caixaInformacao info;

        public frmFuncionarios(int idEmpresa, int idUser)
        {
            InitializeComponent();
            this.idEmpresa = idEmpresa;
            this.idUser = idUser;
        }

        private void CarregarFucionarios()
        {
            string query = $@"SELECT u.id, u.senha, u.nome, u.email, u.cpf, u.telefone
                              FROM funcionarios f
                              JOIN usuarios u ON f.usuarios_id = u.id
                              WHERE f.comercio_id = {idEmpresa} and f.cargo != 'dono'";

            DataTable dtFuncionarios = Banco.Pesquisar(query);
            dtgFuncionarios.DataSource = null;
            dtgFuncionarios.DataSource = dtFuncionarios;

            dtgFuncionarios.Columns["id"].Visible = false;
            dtgFuncionarios.Columns["senha"].Visible = false;

            astNome.Visible = false;
            lbNome.ForeColor = Color.White;
            astEmail.Visible = false;
            lbEmail.ForeColor = Color.White;
            astEmail.Visible = false;
            lbEmail.ForeColor = Color.White;
            astCpf.Visible = false;
            lbCpf.ForeColor = Color.White;
            astSenha.Visible = false;
            lbSenha.ForeColor = Color.White;
            astConfirmar.Visible = false;
            lbConfirmar.ForeColor = Color.White;
            astNomeEd.Visible = false;
            lbNomeEd.ForeColor = Color.White;
            astSenhaEd.Visible = false;
            lbSenhaEd.ForeColor = Color.White;
            astSenhaEd.Visible = false;
            lbSenhaEd.ForeColor = Color.White;
            astEmailEd.Visible = false;
            lbEmailEd.ForeColor = Color.White;
            astTelefoneEd.Visible = false;
            lbTelefoneEd.ForeColor = Color.White;
            astCpfEd.Visible = false;
            lbCpfEd.ForeColor = Color.White;


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
                    LogService.CriarLog(this.idEmpresa, this.idUser, "Cadastrou funcionario");
                    Funcoes.Limpar(this);

                    CarregarFucionarios();
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

            idFuncionario = Convert.ToInt32(row.Cells["id"].Value);
            senhaAntiga = row.Cells["senha"].Value.ToString();
            EdNome.Text = row.Cells["nome"].Value.ToString();
            EdEmail.Text = row.Cells["email"].Value.ToString();
            EdCpf.Text = row.Cells["cpf"].Value.ToString();
            EdTelefone.Text = row.Cells["telefone"].Value.ToString();

        }

        private void dtgFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            CarregarFucionarios();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (Funcoes.CriptoSenha(EdSenha.Text) != senhaAntiga)
            {
                caixaMensagem erro = new caixaMensagem("A senha atual não correponde", "Tente novamente");
                erro.Show();
                return;
            }

            if (!erroNomeEd && !erroCpfEd && !erroEmailEd && !erroTelefoneEd && !erroSenhaEd[0] && !erroSenhaEd[1])
            {

                string senha = Funcoes.CriptoSenha(EdRedefinir.Text);

                string update = $@"UPDATE usuarios u
                            JOIN funcionarios f ON u.id = f.usuarios_id
                            SET u.nome = '{EdNome.Text}', u.email = '{EdEmail.Text}', u.cpf = '{EdCpf.Text}', 
                            u.telefone = '{EdTelefone.Text}', u.senha = '{senha}' 
                            WHERE u.id = {idFuncionario}";

                Banco.Inserir(update);

                caixaMensagem parabens = new caixaMensagem("Os dados do funcionário foram atualizados com êxito!", "Sucesso!");
                LogService.CriarLog(this.idEmpresa, this.idUser, "Atualizou Funcionario");
                parabens.Show();

                CarregarFucionarios();
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

                info.Show();
            }
        }

        private void picSenha_MouseLeave(object sender, EventArgs e)
        {
            if (info != null && !info.IsDisposed)
            {
                info.Close();
            }
        }

        private void EdNome_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.CampoVazio(EdNome))
            {
                erroNomeEd = true;
                astNomeEd.Visible = true;
                lbNomeEd.ForeColor = Color.DarkRed;
            }
            else
            {
                erroNomeEd = false;
                astNomeEd.Visible = false;
                lbNomeEd.ForeColor = Color.White;
            }
        }


        private void EdRedefinir_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isSenha(EdRedefinir.Text))
            {
                erroSenhaEd[1] = false;
                astRedefinir.Visible = false;
                lbRedefinir.ForeColor = Color.White;
            }
            else
            {
                erroSenhaEd[1] = true;
                astRedefinir.Visible = true;
                lbRedefinir.ForeColor = Color.DarkRed;
            }
        }

        private void EdSenha_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isSenha(EdSenha.Text))
            {
                erroSenhaEd[0] = false;
                astSenhaEd.Visible = false;
                lbSenhaEd.ForeColor = Color.White;
            }
            else
            {
                erroSenhaEd[0] = true;
                astSenhaEd.Visible = true;
                lbSenhaEd.ForeColor = Color.DarkRed;
            }
        }

        private void EdEmail_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isEmail(EdEmail.Text))
            {
                erroEmailEd = false;
                astEmailEd.Visible = false;
                lbEmailEd.ForeColor = Color.White;
            }
            else
            {
                erroEmailEd = true;
                astEmailEd.Visible = true;
                lbEmailEd.ForeColor = Color.DarkRed;
            }
        }

        private void EdTelefone_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isTelefone(EdTelefone.Text))
            {
                erroTelefoneEd = false;
                astTelefoneEd.Visible = false;
                lbTelefoneEd.ForeColor = Color.White;
            }
            else
            {
                erroTelefoneEd = true;
                astTelefoneEd.Visible = true;
                lbTelefoneEd.ForeColor = Color.DarkRed;
            }
        }

        private void EdCpf_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isCpf(EdCpf.Text))
            {
                erroCpfEd = false;
                astCpfEd.Visible = false;
                lbCpfEd.ForeColor = Color.White;
            }
            else
            {
                erroCpfEd = true;
                astCpfEd.Visible = true;
                lbCpfEd.ForeColor = Color.DarkRed;
            }
        }

        private void EdMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (EdMostrar.Checked)
            {
                EdRedefinir.UseSystemPasswordChar = false; // Mostra a senha
                EdSenha.UseSystemPasswordChar = false;
            }
            else
            {
                EdRedefinir.UseSystemPasswordChar = true;  // Esconde a senha
                EdSenha.UseSystemPasswordChar = true;
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var opcao = new caixaDecisao("Tem certeza que deseja excluir este funcionário?", "Confirmação");
            opcao.ShowDialog();

            if (opcao.decisao)
            {

              string excluir = $@"DELETE u FROM usuarios u
                         JOIN funcionarios f ON u.id = f.usuarios_id
                         WHERE u.id = {idFuncionario}";

                Banco.Excluir(excluir);

                caixaMensagem deletou = new caixaMensagem("Funcionário excluído com êxito!", "Sucesso!");
                LogService.CriarLog(this.idEmpresa, this.idUser, "Excluiu Funcionario");
                deletou.Show();

                CarregarFucionarios();
            }
        }
    }
}

