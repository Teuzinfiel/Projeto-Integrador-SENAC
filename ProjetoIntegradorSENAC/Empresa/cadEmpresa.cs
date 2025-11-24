using ProjetoIntegradorSENAC.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Empresa
{
    public partial class cadEmpresa : Form
    {
        public cadEmpresa()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "CNPJ:";
            mkCPF.Visible = false;
            mkCNPJ.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "CPF:";
            mkCNPJ.Visible = false;
            mkCPF.Visible = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmEmpresa frmEmpresa = new frmEmpresa();
            frmEmpresa.Show();
            this.Hide();
        }
        bool errorFlag = false;
        private void txtRazaoSocial_TextChanged(object sender, EventArgs e)
        {
            string RazaoSocial = txtRazaoSocial.Text;
            if (Funcoes.CampoVazio(txtRazaoSocial))
            {
                errorFlag = true;
                label13.Visible = true;
                label2.ForeColor = Color.DarkRed;
            }
            else
            {
                errorFlag = false;
                label13.Visible = false;
                label2.ForeColor = Color.White;
            }
        }

        private void txtNomeFantasia_TextChanged(object sender, EventArgs e)
        {
            string NomeFantasia = txtNomeFantasia.Text;
            if (Funcoes.CampoVazio(txtNomeFantasia))
            {
                errorFlag = true;
                label14.Visible = true;
                label1.ForeColor = Color.DarkRed;
            }
            else 
            {
                errorFlag = false;
                label14.Visible = false;
                label1.ForeColor = Color.White;
            }
        }

        private void mkCNPJ_TextChanged(object sender, EventArgs e)
        {
            
            string cnpj = mkCNPJ.Text;
            if (Funcoes.isCnpj(cnpj))
            {
                errorFlag = false;
                label4.ForeColor = Color.White;
                label15.Visible = false;
            }
            else
            {
                errorFlag = true;
                label15.Visible = true;
                label4.ForeColor = Color.DarkRed;
            }
        }
        private void mkCPF_TextChanged(object sender, EventArgs e)
        {
            string cpf = mkCPF.Text;
        }

        private void mkTelefone_TextChanged(object sender, EventArgs e)
        {
            string Telefone = mkTelefone.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
        }

      
    }
}
