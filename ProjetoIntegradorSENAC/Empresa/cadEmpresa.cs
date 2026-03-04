    using MySql.Data.MySqlClient;
    using Mysqlx.Crud;
    using ProjetoIntegradorSENAC.Classes;
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using MySql.Data.MySqlClient;
    using ProjetoIntegradorSENAC.Main;

    namespace ProjetoIntegradorSENAC.Empresa
    {
    public partial class cadEmpresa : Form
    {
        public int idUsuario;
        mainFrm main;
        EmpresaCnpj empresa;
        CepService cepService;
        public cadEmpresa(int idUsuario, mainFrm mainFrm)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            main = mainFrm;
            empresa = new EmpresaCnpj();
            cepService = new CepService();
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
            frmEmpresa frm = new frmEmpresa(this.idUsuario, null);
            frm.Show();
            this.Hide();
        }

        bool erroRazao = true;
        bool erroFantasia = true;
        bool erroCnpj = true;
        bool erroCpf = true;
        bool erroTelefone = true;
        bool erroEmail = true;
        bool erroCep = true;

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

        private async void mkCNPJ_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.isCnpj(mkCNPJ.Text))
            {
                erroCnpj = false;
                label15.Visible = false;
                label4.ForeColor = Color.White;
                try
                {
                    var dados = await empresa.ConsultarCnpj(mkCNPJ.Text);


                    if (dados == null)
                    {
                        return;
                    }

                    txtEmail.Text = dados.Email;
                    txtNomeFantasia.Text = dados.NomeFantasia;
                    txtRazaoSocial.Text = dados.RazaoSocial;
                    mkTelefone.Text = dados.Telefone;
                    mkCep.Text = dados.Cep;


                    var cep = await cepService.BuscarCepAsync(mkCep.Text);
                    txtBairro.Text = cep.Bairro;
                    txtMunicipio.Text = cep.Localidade;



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
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
            bool erroDocumento = radioButton1.Checked ? erroCpf : erroCnpj;

            if (erroRazao || erroFantasia || erroDocumento || erroTelefone || erroEmail || erroCep)
            {
                MessageBox.Show("Preencha corretamente todos os campos!",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            string telefone = mkTelefone.Text;
            string nome = txtRazaoSocial.Text;
            string nomeFantasia = txtNomeFantasia.Text;
            string email = txtEmail.Text;
            string tipoDoc = radioButton1.Checked ? "cpf" : "cnpj";
            string doc = radioButton1.Checked ? mkCPF.Text : mkCNPJ.Text;
            string cep = mkCep.Text;
            string bairro = string.IsNullOrWhiteSpace(txtBairro.Text)
     ? "Não definido"
     : txtBairro.Text.Trim();
            string municipio = string.IsNullOrWhiteSpace(txtMunicipio.Text)
    ? "Não definido"
    : txtMunicipio.Text.Trim();

            using (var conn = Banco.AbrirConexao())
            {

                string verificaSql = $@"
        SELECT COUNT(*) 
        FROM comercios 
        WHERE documentacao = '{doc}'
    ";

                int existe;

                using (var cmdVerifica = new MySqlCommand(verificaSql, conn))
                    existe = Convert.ToInt32(cmdVerifica.ExecuteScalar());

                if (existe > 0)
                {
                    MessageBox.Show("Já existe uma empresa cadastrada com esse CPF/CNPJ!",
                                    "Documento duplicado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                //  cria empresa
                string insertEmpresa = $@"
                    INSERT INTO comercios 
                    (dono_id, nome, nome_fantasia, email, tipo_documentacao, documentacao, telefone, cep, bairro, municipio)
                    VALUES  ({idUsuario}, '{nome}', '{nomeFantasia}', '{email}', '{tipoDoc}', '{doc}', '{telefone}', '{cep}', '{bairro}', '{municipio}')
                    ";

                using (var cmd1 = new MySqlCommand(insertEmpresa, conn))
                    cmd1.ExecuteNonQuery();

                //  pega id da empresa
                int idEmpresa;

                using (var cmd2 = new MySqlCommand("SELECT LAST_INSERT_ID()", conn))
                    idEmpresa = Convert.ToInt32(cmd2.ExecuteScalar());

                //  cadastra dono como funcionario
                string insertFuncionario = $@"
                    INSERT INTO funcionarios (usuarios_id, comercio_id, cargo)
                    VALUES ({idUsuario}, {idEmpresa}, 'dono')
                    ";

                using (var cmd3 = new MySqlCommand(insertFuncionario, conn))
                    cmd3.ExecuteNonQuery();
            }

            MessageBox.Show("Empresa cadastrada com sucesso!");
            Funcoes.Limpar(this);
            main.AbrirFormNoPanel(new frmEmpresa(this.idUsuario, main));
           
        }

        private async void mkCNPJ_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private async void maskedTextBox1_Leave(object sender, EventArgs e)
        {

        }

        private async void mkCNPJ_Leave(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            main.AbrirFormNoPanel(new frmEmpresa(idUsuario, main));
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
                catch (Exception ex) {
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
