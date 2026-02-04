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
        public frmFuncionarios(int idEmpresa)
        {
            InitializeComponent();
            this.idEmpresa = idEmpresa;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            bool senha = false;

            if (UsSenha.Text == ConfirmarSenha.Text) senha = true;


            if (senha && UsNome.Text != "" && UsTelefone.MaskFull && UsEmail.Text != "")
            {

                using (var conn = Banco.AbrirConexao())
                {
                    // 1 - cria usuario
                    string insertUsuario =
                    "INSERT INTO usuarios (nome, email, cpf, telefone, senha) " +
                    $"VALUES ('{UsNome.Text}', '{UsEmail.Text}', '{UsCpf.Text}', '{UsTelefone.Text}', '{ConfirmarSenha.Text}')";

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
    }
}

