using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegradorSENAC.Classes;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ProjetoIntegradorSENAC.Usuario
{
    public partial class cadUsuario : Form
    {
        public cadUsuario()
        {
            InitializeComponent();
        }

        private async void btnCadastro_Click(object sender, EventArgs e)
        {
            if (UsSenha.Text != ConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não correspondem");
                return;
            }

            if (UsNome.Text == "" || !UsTelefone.MaskFull || UsEmail.Text == "")
            {
                MessageBox.Show("Preencha todos os campos corretamente");
                return;
            }

            using (var http = new HttpClient())
            {
                var dados = new FormUrlEncodedContent(new[]
                {
            new KeyValuePair<string,string>("nome", UsNome.Text),
            new KeyValuePair<string,string>("email", UsEmail.Text),
            new KeyValuePair<string,string>("cpf", UsCpf.Text),
            new KeyValuePair<string,string>("telefone", UsTelefone.Text),
            new KeyValuePair<string,string>("senha", UsSenha.Text)
        });

                try
                {
                    // COLOQUE AQUI O LINK DO SEU PHP NO CLOUDFLARE
                    string url = "https://solutions-specialty-volunteer-nirvana.trycloudflare.com/testapisenac/index.php";

                    var response = await http.PostAsync(url, dados);
                    string resposta = await response.Content.ReadAsStringAsync();

                    dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(resposta);

                    if (json.status == true)
                    {
                        MessageBox.Show("Conta criada com sucesso!");
                        Funcoes.Limpar(this);
                    }
                    else
                    {
                        MessageBox.Show("Erro: " + json.mensagem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao conectar ao servidor:\n" + ex.Message);
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

        private void UsCpf_TextChanged(object sender, EventArgs e)
        {
            if (UsCpf.MaskFull)
            {

                if (!Funcoes.isCpf(UsCpf.Text))
                {
                    MessageBox.Show("tá errado isso ae");
                    UsCpf.Text = "";
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Funcoes.Limpar(this);
        }
    }
}
