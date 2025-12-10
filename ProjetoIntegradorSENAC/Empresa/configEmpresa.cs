using ProjetoIntegradorSENAC.Classes;
using ProjetoIntegradorSENAC.Empresa;
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

namespace ProjetoIntegradorSENAC.Configurações
{
    public partial class configEmpresa : Form
    {
        public int idUsuario;
        public int idEmpresa;
        public int idDono;
        public configEmpresa(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }
        private void CarregarEmpresas()
        {
            string query = $@"
        SELECT 
            comercios.id AS id_comercio,
            usuarios.id AS id_dono,
            usuarios.nome AS dono,
            comercios.nome AS comercio,
            comercios.nome_fantasia AS fantasia,
            comercios.telefone AS telefone
        FROM comercios
        JOIN usuarios ON usuarios.id = comercios.dono_id
        WHERE comercios.dono_id = {idUsuario}";

            DataTable dt = Banco.Pesquisar(query);
            dtgEmpresas.DataSource = dt;

            dtgEmpresas.Columns["id_comercio"].Visible = false;
            dtgEmpresas.Columns["id_dono"].Visible = false;

            dtgEmpresas.Columns["dono"].HeaderText = "Gerente";
            dtgEmpresas.Columns["comercio"].HeaderText = "Comércio";
            dtgEmpresas.Columns["fantasia"].HeaderText = "Nome Fantasia";
            dtgEmpresas.Columns["telefone"].HeaderText = "Telefone";

            dtgEmpresas.ClearSelection();
        }
        private void configEmpresa_Load(object sender, EventArgs e)
        {
            CarregarEmpresas();
        }
        private void dtgEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            idEmpresa = Convert.ToInt32(
                dtgEmpresas.Rows[e.RowIndex].Cells["id_comercio"].Value
            );

            idDono = Convert.ToInt32(
                dtgEmpresas.Rows[e.RowIndex].Cells["id_dono"].Value
            );

            string query = $@"
        SELECT nome, nome_fantasia, email, tipo_documentacao, documentacao, telefone
        FROM comercios
        WHERE id = {idEmpresa}";

            DataTable dt = Banco.Pesquisar(query);

            if (dt.Rows.Count > 0)
            {
                txtRazaoSocial.Text = dt.Rows[0]["nome"].ToString();
                txtNomeFantasia.Text = dt.Rows[0]["nome_fantasia"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                mkTelefone.Text = dt.Rows[0]["telefone"].ToString();

                string tipoDoc = dt.Rows[0]["tipo_documentacao"].ToString();
                string doc = dt.Rows[0]["documentacao"].ToString();

                if (tipoDoc == "cpf")
                {
                    radioButton1.Checked = true;
                    mkCPF.Text = doc;
                }
                else
                {
                    radioButton2.Checked = true;
                    mkCNPJ.Text = doc;
                }
            }
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
                label10.ForeColor = Color.DarkRed;
            }
            else
            {
                erroRazao = false;
                label13.Visible = false;
                label10.ForeColor = Color.White;
            }
        }

        private void txtNomeFantasia_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.CampoVazio(txtNomeFantasia))
            {
                erroFantasia = true;
                label14.Visible = true;
                label9.ForeColor = Color.DarkRed;
            }
            else
            {
                erroFantasia = false;
                label14.Visible = false;
                label9.ForeColor = Color.White;
            }
        }

        private void mkCNPJ_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isCnpj(mkCNPJ.Text))
            {
                erroCnpj = false;
                label15.Visible = false;
                label2.ForeColor = Color.White;
            }
            else
            {
                erroCnpj = true;
                label15.Visible = true;
                label2.ForeColor = Color.DarkRed;
            }
        }
        private void mkCPF_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isCpf(mkCPF.Text))
            {
                erroCpf = false;
                label15.Visible = false;
                label2.ForeColor = Color.White;
            }
            else
            {
                erroCpf = true;
                label15.Visible = true;
                label2.ForeColor = Color.DarkRed;
            }
        }
        private void mkTelefone_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isTelefone(mkTelefone.Text))
            {
                erroTelefone = false;
                label16.Visible = false;
                label1.ForeColor = Color.White;
            }
            else
            {
                erroTelefone = true;
                label16.Visible = true;
                label1.ForeColor = Color.DarkRed;
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "CNPJ:";
            erroCpf = false;
            mkCPF.Visible = false;
            mkCNPJ.Visible = true;
            mkCPF.Clear();
            mkCNPJ.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "CPF:";
            erroCnpj = false;
            mkCNPJ.Visible = false;
            mkCPF.Visible = true;
            mkCPF.Clear();
            mkCNPJ.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (erroRazao || erroFantasia || erroCnpj || erroCpf || erroTelefone || erroEmail)
            {
                MessageBox.Show("Preencha corretamente todos os campos!", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string telefone = mkTelefone.Text;
            string nome = txtRazaoSocial.Text;
            string nomeFantasia = txtNomeFantasia.Text;
            string email = txtEmail.Text;
            string tipoDoc = radioButton1.Checked ? "cpf" : "cnpj";
            string doc = radioButton1.Checked ? mkCPF.Text : mkCNPJ.Text;

            string update = $@"
        UPDATE comercios SET
            nome = '{nome}',
            nome_fantasia = '{nomeFantasia}',
            email = '{email}',
            tipo_documentacao = '{tipoDoc}',
            documentacao = '{doc}',
            telefone = '{telefone}'
        WHERE id = {idEmpresa}";

            Banco.Inserir(update);
            MessageBox.Show("Empresa atualizada com sucesso!");
            CarregarEmpresas();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmEmpresa frm = new frmEmpresa(this.idUsuario);
            frm.Show();
            this.Hide();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
                this.Close();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
