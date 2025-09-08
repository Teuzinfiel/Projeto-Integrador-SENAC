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
    }
}
