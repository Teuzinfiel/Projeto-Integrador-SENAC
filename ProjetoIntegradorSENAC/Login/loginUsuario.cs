using Microsoft.VisualBasic.ApplicationServices;
using ProjetoIntegradorSENAC.Caixa;
using ProjetoIntegradorSENAC.Classes;
using ProjetoIntegradorSENAC.Empresa;
using ProjetoIntegradorSENAC.Main;
using ProjetoIntegradorSENAC.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoIntegradorSENAC.Logins
{
    public partial class loginUsuario : Form
    {
        mainFrm main;
        private GoogleAuth googleAuth;


        public loginUsuario(mainFrm mainFrm)
        {
            InitializeComponent();
            this.main = mainFrm;
            googleAuth = new GoogleAuth(Properties.Resources.tokenPublicGoogle,
                                        Properties.Resources.tokenSecurityGoogle);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //  Busca usuário
            string queryUser = $@"
            SELECT id, senha 
            FROM usuarios 
            WHERE email = '{txtEmail.Text.ToLower()}'";

            DataTable user = Banco.Pesquisar(queryUser);

            if (user.Rows.Count == 0)
            {
                MessageBox.Show("Usuário não encontrado!");
                return;
            }

            string passwordBD = user.Rows[0]["senha"].ToString();
            int idUser = Convert.ToInt32(user.Rows[0]["id"]);

            //  Confere senha
            if (Funcoes.CriptoSenha(txtSenha.Text) != passwordBD)
            {
                MessageBox.Show("Senha incorreta!");
                return;
            }

            //  Verifica se é DONO
            string queryDono = $@"
            SELECT id 
            FROM comercios 
            WHERE dono_id = {idUser}";

            bool isDono = Banco.Pesquisar(queryDono).Rows.Count > 0;

            //  Verifica se é FUNCIONÁRIO
            string queryFunc = $@"
            SELECT id, comercio_id 
            FROM funcionarios 
            WHERE usuarios_id = {idUser}";

            DataTable func = Banco.Pesquisar(queryFunc);
            bool ehFuncionario = func.Rows.Count > 0;

            if (isDono)
            {
                //  dono escolhe empresa depois
                main.AbrirFormNoPanel(new frmEmpresa(idUser, main));

            }
            else if (ehFuncionario)
            {
                int idEmpresa = Convert.ToInt32(func.Rows[0]["comercio_id"]);

                //  Busca dados da empresa
                string queryEmpresa = $@"
                SELECT nome_fantasia, dono_id
                FROM comercios
                WHERE id = {idEmpresa}";

                DataTable emp = Banco.Pesquisar(queryEmpresa);

                string nomeEmpresa = emp.Rows[0]["nome_fantasia"].ToString();
                int idDono = Convert.ToInt32(emp.Rows[0]["dono_id"]);

                //  entra direto na main

                main.AbrirFormNoPanel(new MainEmpresa(idEmpresa, idDono, idUser, nomeEmpresa, main));


            }
            else
            {
                main.AbrirFormNoPanel(new frmEmpresa(idUser, main));

            }

        }

        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false; // Mostra a senha
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;  // Esconde a senha
            }
        }

        private void CriarConta_Click(object sender, EventArgs e)
        {
            main.AbrirFormNoPanel(new cadUsuario(main));
        }

        private void recuperarConta_Click(object sender, EventArgs e)
        {
            recuperarEmail frmEmail = new recuperarEmail();
            frmEmail.ShowDialog();

        }

        private void loginUsuario_Load(object sender, EventArgs e)
        {

        }

        private async void label12_Click(object sender, EventArgs e)
        {
            string email = await googleAuth.LoginAsync();
            //  Busca usuário
            string queryUser = $@"
            SELECT id
            FROM usuarios 
            WHERE email = '{email.ToLower()}'";

            DataTable user = Banco.Pesquisar(queryUser);

            if (user.Rows.Count == 0)
            {
                MessageBox.Show("Usuário não encontrado!");
                return;
            }


            int idUser = Convert.ToInt32(user.Rows[0]["id"]);

            //  Verifica se é DONO
            string queryDono = $@"
            SELECT id 
            FROM comercios 
            WHERE dono_id = {idUser}";

            bool isDono = Banco.Pesquisar(queryDono).Rows.Count > 0;

            //  Verifica se é FUNCIONÁRIO
            string queryFunc = $@"
            SELECT id, comercio_id 
            FROM funcionarios 
            WHERE usuarios_id = {idUser}";

            DataTable func = Banco.Pesquisar(queryFunc);
            bool ehFuncionario = func.Rows.Count > 0;

            if (isDono)
            {
                //  dono escolhe empresa depois
                main.AbrirFormNoPanel(new frmEmpresa(idUser, main));

            }
            else if (ehFuncionario)
            {
                int idEmpresa = Convert.ToInt32(func.Rows[0]["comercio_id"]);

                //  Busca dados da empresa
                string queryEmpresa = $@"
                SELECT nome_fantasia, dono_id
                FROM comercios
                WHERE id = {idEmpresa}";

                DataTable emp = Banco.Pesquisar(queryEmpresa);

                string nomeEmpresa = emp.Rows[0]["nome_fantasia"].ToString();
                int idDono = Convert.ToInt32(emp.Rows[0]["dono_id"]);

                //  entra direto na main

                main.AbrirFormNoPanel(new MainEmpresa(idEmpresa, idDono, idUser, nomeEmpresa, main));


            }
            else
            {
                main.AbrirFormNoPanel(new frmEmpresa(idUser, main));

            }
        }

        private async void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void pictureBox2_Click(object sender, EventArgs e)
        {

            string email = await googleAuth.LoginAsync();
            //  Busca usuário
            string queryUser = $@"
            SELECT id
            FROM usuarios 
            WHERE email = '{email.ToLower()}'";

            DataTable user = Banco.Pesquisar(queryUser);

            if (user.Rows.Count == 0)
            {
                MessageBox.Show("Usuário não encontrado!");
                return;
            }


            int idUser = Convert.ToInt32(user.Rows[0]["id"]);

            //  Verifica se é DONO
            string queryDono = $@"
            SELECT id 
            FROM comercios 
            WHERE dono_id = {idUser}";

            bool isDono = Banco.Pesquisar(queryDono).Rows.Count > 0;

            //  Verifica se é FUNCIONÁRIO
            string queryFunc = $@"
            SELECT id, comercio_id 
            FROM funcionarios 
            WHERE usuarios_id = {idUser}";

            DataTable func = Banco.Pesquisar(queryFunc);
            bool ehFuncionario = func.Rows.Count > 0;

            if (isDono)
            {
                //  dono escolhe empresa depois
                main.AbrirFormNoPanel(new frmEmpresa(idUser, main));

            }
            else if (ehFuncionario)
            {
                int idEmpresa = Convert.ToInt32(func.Rows[0]["comercio_id"]);

                //  Busca dados da empresa
                string queryEmpresa = $@"
                SELECT nome_fantasia, dono_id
                FROM comercios
                WHERE id = {idEmpresa}";

                DataTable emp = Banco.Pesquisar(queryEmpresa);

                string nomeEmpresa = emp.Rows[0]["nome_fantasia"].ToString();
                int idDono = Convert.ToInt32(emp.Rows[0]["dono_id"]);

                //  entra direto na main

                main.AbrirFormNoPanel(new MainEmpresa(idEmpresa, idDono, idUser, nomeEmpresa, main));


            }
            else
            {
                main.AbrirFormNoPanel(new frmEmpresa(idUser, main));

            }
        }

        private async void panel2_Click(object sender, EventArgs e)
        {
            string email = await googleAuth.LoginAsync();
            //  Busca usuário
            string queryUser = $@"
            SELECT id
            FROM usuarios 
            WHERE email = '{email.ToLower()}'";

            DataTable user = Banco.Pesquisar(queryUser);

            if (user.Rows.Count == 0)
            {
                MessageBox.Show("Usuário não encontrado!");
                return;
            }


            int idUser = Convert.ToInt32(user.Rows[0]["id"]);

            //  Verifica se é DONO
            string queryDono = $@"
            SELECT id 
            FROM comercios 
            WHERE dono_id = {idUser}";

            bool isDono = Banco.Pesquisar(queryDono).Rows.Count > 0;

            //  Verifica se é FUNCIONÁRIO
            string queryFunc = $@"
            SELECT id, comercio_id 
            FROM funcionarios 
            WHERE usuarios_id = {idUser}";

            DataTable func = Banco.Pesquisar(queryFunc);
            bool ehFuncionario = func.Rows.Count > 0;

            if (isDono)
            {
                //  dono escolhe empresa depois
                main.AbrirFormNoPanel(new frmEmpresa(idUser, main));

            }
            else if (ehFuncionario)
            {
                int idEmpresa = Convert.ToInt32(func.Rows[0]["comercio_id"]);

                //  Busca dados da empresa
                string queryEmpresa = $@"
                SELECT nome_fantasia, dono_id
                FROM comercios
                WHERE id = {idEmpresa}";

                DataTable emp = Banco.Pesquisar(queryEmpresa);

                string nomeEmpresa = emp.Rows[0]["nome_fantasia"].ToString();
                int idDono = Convert.ToInt32(emp.Rows[0]["dono_id"]);

                //  entra direto na main

                main.AbrirFormNoPanel(new MainEmpresa(idEmpresa, idDono, idUser, nomeEmpresa, main));


            }
            else
            {
                main.AbrirFormNoPanel(new frmEmpresa(idUser, main));

            }
        }
    }
}
