using ProjetoIntegradorSENAC.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Empresa
{
    public partial class cadEmpresa : Form
    {
        public int idUsuario;

        public cadEmpresa()
        {
            InitializeComponent();
        }

        private void cadEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "CNPJ:";
            erroCpf = false;
            mkCPF.Visible = false;
            mkCNPJ.Visible = true;
            mkCPF.Clear();
            mkCNPJ.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "CPF:";
            erroCnpj = false;
            mkCNPJ.Visible = false;
            mkCPF.Visible = true;
            mkCPF.Clear();
            mkCNPJ.Clear();
        }

  
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmEmpresa frm = new frmEmpresa();
            frm.idUsuario = this.idUsuario; // <-- PASSA O ID DE VOLTA
            frm.Show();
            this.Hide();
        }

        bool erroRazao = true;
        bool erroFantasia = true;
        bool erroCnpj = true;
        bool erroCpf = true;
        bool erroTelefone = true;
        bool erroEmail = true;

        private void txtRazaoSocial_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.CampoVazio(txtRazaoSocial))
            {
                erroRazao = true;
                label13.Visible = true;
                label2.ForeColor = Color.DarkRed;
            }
            else
            {
                erroRazao = false;
                label13.Visible = false;
                label2.ForeColor = Color.White;
            }
        }

        private void txtNomeFantasia_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.CampoVazio(txtNomeFantasia))
            {
                erroFantasia = true;
                label14.Visible = true;
                label1.ForeColor = Color.DarkRed;
            }
            else
            {
                erroFantasia = false;
                label14.Visible = false;
                label1.ForeColor = Color.White;
            }
        }

        private void mkCNPJ_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isCnpj(mkCNPJ.Text))
            {
                erroCnpj = false;
                label15.Visible = false;
                label4.ForeColor = Color.White;
            }
            else
            {
                erroCnpj = true;
                label15.Visible = true;
                label4.ForeColor = Color.DarkRed;
            }
        }

        private void mkCPF_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isCpf(mkCPF.Text))
            {
                erroCpf = false;
                label15.Visible = false;
                label4.ForeColor = Color.White;
            }
            else
            {
                erroCpf = true;
                label15.Visible = true;
                label4.ForeColor = Color.DarkRed;
            }
        }

        private void mkTelefone_TextChanged(object sender, EventArgs e)
        {
             if (Funcoes.isTelefone(mkTelefone.Text))
             {
                 erroTelefone = false;
                 label16.Visible = false;
                 label5.ForeColor = Color.White;
             }
             else
             {
                 erroTelefone = true;
                 label16.Visible = true;
                 label5.ForeColor = Color.DarkRed;
             }
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isEmail(txtEmail.Text))
            {
                erroEmail = false;
                label17.Visible = false;
                label6.ForeColor = Color.White;
            }
            else
            {
                erroEmail = true;
                label17.Visible = true;
                label6.ForeColor = Color.DarkRed;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (erroRazao || erroFantasia || erroCnpj || erroCpf || erroTelefone || erroEmail)
            {
                MessageBox.Show("Preencha corretamente todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string telefone = mkTelefone.Text;
            string nome = txtRazaoSocial.Text;
            string nomeFantasia = txtNomeFantasia.Text;
            string email = txtEmail.Text;
            string tipoDoc = radioButton1.Checked ? "cpf" : "cnpj";
            string doc = radioButton1.Checked ? mkCPF.Text : mkCNPJ.Text;

            string insert = $@"
        INSERT INTO comercios 
        (dono_id, nome, nome_fantasia, email, tipo_documentacao, documentacao, telefone)
        VALUES  ({idUsuario}, '{nome}', '{nomeFantasia}', '{email}', '{tipoDoc}', '{doc}', '{telefone}')
    ";

            Banco.Inserir(insert);
            MessageBox.Show("Empresa cadastrada com sucesso!");
            Funcoes.Limpar(this);
        }

     
    }
}
