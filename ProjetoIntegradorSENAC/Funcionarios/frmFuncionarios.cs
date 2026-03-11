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

        bool erroNome = true;
        bool erroEmail = true;
        bool erroCpf = true;
        bool erroTelefone = true;
        bool[] erroSenha = { true, true };

        bool erroNomeEd = true;
        bool erroEmailEd = true;
        bool erroCpfEd = true;
        bool erroTelefoneEd = true;

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

            
            lbNome.ForeColor = Color.White;
           
            lbEmail.ForeColor = Color.White;
          
            lbEmail.ForeColor = Color.White;
          
            lbCpf.ForeColor = Color.White;
         
            lbSenha.ForeColor = Color.White;
           
            lbConfirmar.ForeColor = Color.White;
           
            lbNomeEd.ForeColor = Color.White;
           
            lbEmailEd.ForeColor = Color.White;
            
            lbTelefoneEd.ForeColor = Color.White;
            
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

                        var opa1 = new caixaMensagem(mensagem, "Falha ❌");
                        opa1.ShowDialog();
                        return;
                    }
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
                    var opa = new caixaMensagem("Conta criada com sucesso!", "Sucesso ✔");
                    opa.ShowDialog();
                    LogService.CriarLog(this.idEmpresa, this.idUser, "Cadastrou funcionario");
                    Funcoes.Limpar(this);

                    CarregarFucionarios();
                }

            }
            else
            {
                if (!senhaVal)
                {
                    var opa = new caixaMensagem("As senhas não correspondem", "Falha ❌");
                    opa.ShowDialog();
                }
                else
                {
                    var opa = new caixaMensagem("Preencha todos os campos corretamente", "Falha ❌");
                    opa.ShowDialog();
                }
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
                
                lbNome.ForeColor = Color.DarkRed;
            }
            else
            {
                erroNome = false;
                
                lbNome.ForeColor = Color.White;

            }
        }

        private void UsEmail_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isEmail(UsEmail.Text))
            {
                erroEmail = false;
              
                lbEmail.ForeColor = Color.White;
            }
            else
            {
                erroEmail = true;
               
                lbEmail.ForeColor = Color.DarkRed;
            }
        }

        private void UsTelefone_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isTelefone(UsTelefone.Text))
            {
                erroTelefone = false;
               
                lbTelefone.ForeColor = Color.White;
            }
            else
            {
                erroTelefone = true;
              
                lbTelefone.ForeColor = Color.DarkRed;
            }
        }

        private void UsCpf_TextChanged(object sender, EventArgs e)
        {

            if (Funcoes.isCpf(UsCpf.Text))
            {
                erroCpf = false;
              
                lbCpf.ForeColor = Color.White;
            }
            else
            {
                erroCpf = true;
               
                lbCpf.ForeColor = Color.DarkRed;
            }

        }

        private void UsSenha_TextChanged(object sender, EventArgs e)
        {

            if (Funcoes.isSenha(UsSenha.Text))
            {
                erroSenha[0] = false;
              
                lbSenha.ForeColor = Color.White;
            }
            else
            {
                erroSenha[0] = true;
               
                lbSenha.ForeColor = Color.DarkRed;
            }
        }

        private void ConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isSenha(UsSenha.Text))
            {
                erroSenha[1] = false;
                
                lbConfirmar.ForeColor = Color.White;
            }
            else
            {
                erroSenha[1] = true;
              
                lbConfirmar.ForeColor = Color.DarkRed;
            }
        }

        private void dtgFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            DataGridViewRow row = dtgFuncionarios.Rows[e.RowIndex];

            idFuncionario = Convert.ToInt32(row.Cells["id"].Value);
            EdNome.Text = row.Cells["nome"].Value.ToString();
            EdEmail.Text = row.Cells["email"].Value.ToString();
            EdCpf.Text = row.Cells["cpf"].Value.ToString();
            EdTelefone.Text = row.Cells["telefone"].Value.ToString();

        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            CarregarFucionarios();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!erroNomeEd && !erroCpfEd && !erroEmailEd && !erroTelefoneEd)
            {
                string select = "SELECT * FROM usuarios WHERE " +
                $"(email = '{EdEmail.Text.ToLower()}' OR " +
                $"cpf = '{EdCpf.Text}' OR " +
                $"telefone = '{EdTelefone.Text}') " +
                $"AND id != {idFuncionario}";

                DataTable dt = Banco.Pesquisar(select);

                if (dt.Rows.Count > 0)
                {
                    string mensagem = "";

                    if (dt.Rows[0]["email"].ToString() == EdEmail.Text)
                        mensagem += "Email já cadastrado!\n";

                    if (dt.Rows[0]["cpf"].ToString() == EdCpf.Text)
                        mensagem += "CPF já cadastrado!\n";

                    if (dt.Rows[0]["telefone"].ToString() == EdTelefone.Text)
                        mensagem += "Telefone já cadastrado!\n";

                    var opa = new caixaMensagem(mensagem, "Falha ❌");
                    opa.ShowDialog(); 
                    return;
                }
                string update = $@"UPDATE usuarios u
                            JOIN funcionarios f ON u.id = f.usuarios_id
                            SET u.nome = '{EdNome.Text}', u.email = '{EdEmail.Text}', u.cpf = '{EdCpf.Text}', 
                            u.telefone = '{EdTelefone.Text}'
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
                
                lbNomeEd.ForeColor = Color.DarkRed;
            }
            else
            {
                erroNomeEd = false;
               
                lbNomeEd.ForeColor = Color.White;
            }
        }

        private void EdEmail_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isEmail(EdEmail.Text))
            {
                erroEmailEd = false;
          
                lbEmailEd.ForeColor = Color.White;
            }
            else
            {
                erroEmailEd = true;
                
                lbEmailEd.ForeColor = Color.DarkRed;
            }
        }

        private void EdTelefone_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isTelefone(EdTelefone.Text))
            {
                erroTelefoneEd = false;
                
                lbTelefoneEd.ForeColor = Color.White;
            }
            else
            {
                erroTelefoneEd = true;
              
                lbTelefoneEd.ForeColor = Color.DarkRed;
            }
        }

        private void EdCpf_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isCpf(EdCpf.Text))
            {
                erroCpfEd = false;
               
                lbCpfEd.ForeColor = Color.White;
            }
            else
            {
                erroCpfEd = true;
                
                lbCpfEd.ForeColor = Color.DarkRed;
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

