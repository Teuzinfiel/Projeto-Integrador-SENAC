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

namespace ProjetoIntegradorSENAC.Configurações
{
    public partial class configEmpresa : Form
    {
        public int idUsuario;
        public int idEmpresa;
        public int idDono;
        CepService cepService;
        mainFrm main;
        public configEmpresa(int idUsuario, mainFrm mainFrm)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            main = mainFrm;
            cepService = new CepService();
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

            carregando = true;

            idEmpresa = Convert.ToInt32(
                dtgEmpresas.Rows[e.RowIndex].Cells["id_comercio"].Value
            );

            string query = $@"
        SELECT nome, nome_fantasia, email, tipo_documentacao, documentacao, telefone, cep, municipio, bairro
        FROM comercios
        WHERE id = {idEmpresa}";

            DataTable dt = Banco.Pesquisar(query);

            if (dt.Rows.Count > 0)
            {
                txtRazaoSocial.Text = dt.Rows[0]["nome"].ToString();
                txtNomeFantasia.Text = dt.Rows[0]["nome_fantasia"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                mkTelefone.Text = dt.Rows[0]["telefone"].ToString();
                txtBairro.Text = dt.Rows[0]["bairro"].ToString();
                txtMunicipio.Text = dt.Rows[0]["municipio"].ToString();
                mkCep.Text = dt.Rows[0]["cep"].ToString();

                string tipoDoc = dt.Rows[0]["tipo_documentacao"].ToString();
                string doc = dt.Rows[0]["documentacao"].ToString();

                if (tipoDoc == "cpf")
                {


                    label18.Text = "CPF";
                    maskedTextBox2.Visible = true;   // CPF
                    maskedTextBox1.Visible = false;  // CNPJ

                    maskedTextBox1.Clear();
                    maskedTextBox2.Text = doc;
                }
                else
                {


                    label18.Text = "CNPJ";
                    maskedTextBox2.Visible = false;
                    maskedTextBox1.Visible = true;

                    maskedTextBox2.Clear();
                    maskedTextBox1.Text = doc;
                }
            }

            carregando = false;
        }

        bool erroRazao = false;
        bool erroFantasia = false;
        bool erroCnpj = false;
        bool erroCpf = false;
        bool erroTelefone = false;
        bool erroEmail = false;
        bool erroCep = false;


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

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isCnpj(maskedTextBox1.Text))
            {
                erroCnpj = false;
                label12.Visible = false;
                label18.ForeColor = Color.White;
            }
            else
            {
                erroCnpj = true;
                label12.Visible = true;
                label18.ForeColor = Color.DarkRed;
            }
        }
        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isCpf(maskedTextBox2.Text))
            {
                erroCpf = false;
                label12.Visible = false;
                label18.ForeColor = Color.White;
            }
            else
            {
                erroCpf = true;
                label12.Visible = true;
                label18.ForeColor = Color.DarkRed;
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
                label6.ForeColor = Color.White;
            }
            else
            {
                erroEmail = true;
                label6.ForeColor = Color.DarkRed;
            }
        }

        bool carregando = false;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (carregando) return;

            label18.Text = "CNPJ";
            maskedTextBox2.Visible = false;
            maskedTextBox1.Visible = true;

            maskedTextBox2.Clear();
            maskedTextBox1.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (carregando) return;

            label18.Text = "CPF";
            maskedTextBox2.Visible = true;
            maskedTextBox1.Visible = false;

            maskedTextBox2.Clear();
            maskedTextBox1.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!erroRazao || !erroFantasia || !erroCnpj || !erroCpf ||
    !erroTelefone || !erroEmail || !erroCep)
            {

                string telefone = mkTelefone.Text;
                string nome = txtRazaoSocial.Text;
                string nomeFantasia = txtNomeFantasia.Text;
                string email = txtEmail.Text;

                string update = $@"
        UPDATE comercios SET
            nome = '{nome}',
            nome_fantasia = '{nomeFantasia}',
            email = '{email}',
            telefone = '{telefone}'
        WHERE id = {idEmpresa}";

                Banco.Inserir(update);
                MessageBox.Show("Empresa atualizada com sucesso!");
                CarregarEmpresas();
            }
            else {
                MessageBox.Show("Preencha corretamente todos os campos!",
                                   "Erro",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
           main.AbrirFormNoPanel(new frmEmpresa(this.idUsuario, main));
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idEmpresa == 0)
            {
                MessageBox.Show("Selecione uma empresa para excluir.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult resultado = MessageBox.Show("Você tem certeza que deseja excluir este comércio?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                Banco.Excluir($"DELETE FROM comercios WHERE id = {idEmpresa}");
                MessageBox.Show("Empresa excluída com sucesso!");
                CarregarEmpresas();
            }
            else
            {

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private async void mkCep_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.CepValido(mkCep.Text))
            {
                erroCep = false;
                label12.ForeColor = Color.White;
                label12.Text = "CEP";

                try
                {
                    var cep = await cepService.BuscarCepAsync(mkCep.Text);

                    if (cep == null)
                    {
                        return;
                    }
                    txtBairro.Text = cep.Bairro;
                    txtMunicipio.Text = cep.Localidade;
                }
                catch (Exception ex)
                {
                    return;
                }
            }

            else
            {
                erroCep = true;
                label12.ForeColor = Color.DarkRed;
                label12.Text = "CEP invalido *";
            }
        }
    }
}
