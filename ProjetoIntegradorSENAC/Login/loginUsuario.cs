using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegradorSENAC.Caixa;
using ProjetoIntegradorSENAC.Classes;
using ProjetoIntegradorSENAC.Empresa;
using ProjetoIntegradorSENAC.Usuario;

namespace ProjetoIntegradorSENAC.Logins
{
    public partial class loginUsuario : Form
    {
        public loginUsuario()
        {
            InitializeComponent();
        }
        /*
         Davi, O que precisamos ->
        
            - Validações de cada campo, usar as funcoes, acho melhor vc esperar o usuario preencher tudo e depois vc mostra oq ta de errado

            - muda o metodo de login sem afetar os id, joga o codigo no chat pra vc entender melhor,
            esse codigo todo que fiz foi so pra comparar se o id do usuario era de funcionario ou de dono, pra
            direcionar ele pra frmEmpresa ou pra MainPrincipal, 

            (MUDAR O METODO DE LOGIN EU FALO, MELHORAR SEGURANÇA -> TENTA FAZER SENHAS HASH, PROTEGER CONTRA SQL INJECTION, E ETC, VE O MELHOR METODO 
            DE LOGIN QUE VOCE CONSEGUIR FAZER, USE ALGUNS SITES DE REFERENCIA)

            - NO CADASTRO DE CONTA TBM, APLICAR TUDO ISSO Q FALEI, VALIDAÇÕES MELHORES METODOS PARA CADASTRO ETC,

            - QUESTAO DO DESIGN PODE DEIXAR QUE EU RESOLVO QUANDO VOCE TIVER FINALIZADO

            ! PRECISEI ALTERAR O BANCO DE DADOS PARA FUNCIONAR A VERIFICACAO DE CARGO.

            - ENFIM, FAZENDO ISSO, APLICA AS MESMAS COISA NO CADASTRO DE FUNCIONARIOS, LA EU FIZ QUE CADA CADASTRO FEITO POR LA, O USUARIO SEJA RELACIONADO 
            COMO FUNCIONARIO, POREM EU N FIZ NENHUM TIPO DE VALIDAÇÃO E ETC ENTAO FAZ LA TBM, SEM DAR CONFLITO COM O CADASTRO QUE TA LA, QUANDO VC 
            TERMINAR EU VOU MELHORAR O DESIGN LA ENT TA DE BOA, 



        */
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //  Busca usuário
            string queryUser = $@"
            SELECT id, nome, senha 
            FROM usuarios 
            WHERE nome = '{txtNome.Text}'";

            DataTable user = Banco.Pesquisar(queryUser);

            if (user.Rows.Count == 0)
            {
                MessageBox.Show("Usuário não encontrado!");
                return;
            }

            string passwordBD = user.Rows[0]["senha"].ToString();
            int idUser = Convert.ToInt32(user.Rows[0]["id"]);

            //  Confere senha
            if (txtSenha.Text != passwordBD)
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
                frmEmpresa frm = new frmEmpresa(idUser);
                frm.Show();
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
                MainPrincipal main =
                    new MainPrincipal(idEmpresa, idDono, idUser, nomeEmpresa);

                main.Show();
            }
            else
            {
                frmEmpresa frm = new frmEmpresa(idUser);
                frm.Show();
            }

        }


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
                txtSenha.UseSystemPasswordChar = false; // Mostra a senha
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;  // Esconde a senha
            }
        }

        private void CriarConta_Click(object sender, EventArgs e)
        {
            cadUsuario cadastrar = new cadUsuario();
            cadastrar.Show();
            this.Hide();

        }

    

    }
}
