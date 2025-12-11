using MySqlX.XDevAPI.Common;
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

namespace ProjetoIntegradorSENAC.Produto
{
    public partial class frmProduto : Form
    {

        public int idUsuario;
        public int idComercio;

        private bool erroNome = true;
        private bool erroDescricao = true;
        private bool erroMarca = true;
        private bool erroPreco = true;
        private bool erroCategoria = true;


        public frmProduto(int idUsuario, int idComercio)
        {
            InitializeComponent();

            this.idUsuario = idUsuario;
            this.idComercio = idComercio;

        }

        public int CodigoProduto()
        {

            Random random = new Random();
            int codigo = random.Next(100000000, 999999999);


            return codigo;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string unidade;

            if (CmbUnidade.SelectedItem.ToString() == "Grama")
                unidade = "gramas";
            else
                unidade = "unidade";


                if (CmbCategoria.SelectedIndex == -1)
            {
                erroCategoria = true;
                astCategoria.Visible = true;
                lbCategoria.ForeColor = Color.DarkRed;
            }

            if (erroNome || erroDescricao || erroMarca || erroPreco || erroCategoria)
            {

                MessageBox.Show("Preencha corretamente todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                string insert = "Insert into produtos (comercio_id, nome, descricao, marca, codigo_barra, unidade_medida, categoria, preco) " +
                        $"values ({idComercio},'{PrNome.Text}', '{PrDescricao.Text}', '{PrMarca.Text}', '{CodigoProduto()}', '{unidade}'," +
                        $" '{CmbCategoria.SelectedItem}', '{PrPreco.Text.Replace(",", ".")}')";

                Banco.Inserir(insert);
                MessageBox.Show("Produto cadastrado com sucesso!");

                Funcoes.Limpar(this);
                CmbUnidade.SelectedItem = "Unidade";

            }

        }


        private void frmProduto_Load(object sender, EventArgs e)
        {
            CmbUnidade.SelectedItem = "Unidade";
        }

        private void CmbUnidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbUnidade.SelectedItem != null)
            {

                if (CmbUnidade.SelectedItem.ToString() == "Grama")
                {
                    lbPreco.Text = "Preço por Kg";
                }
                else
                {
                    lbPreco.Text = "Preço por unidade";
                }
            }
        }

        private void PrNome_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.CampoVazio(PrNome))
            {
                erroNome = true;
                astNome.Visible = true;
                lbNome.ForeColor = Color.DarkRed;
            }
            else
            {
                erroNome = false;
                astNome.Visible = false;
                lbNome.ForeColor = Color.White;
            }
        }

        private void PrMarca_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.CampoVazio(PrMarca))
            {
                erroMarca = true;
                astMarca.Visible = true;
                lbMarca.ForeColor = Color.DarkRed;
            }
            else
            {
                erroMarca = false;
                astMarca.Visible = false;
                lbMarca.ForeColor = Color.White;
            }
        }

        private void PrDescricao_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.CampoVazio(PrDescricao))
            {
                erroDescricao = true;
                astDesc.Visible = true;
                lbDescricao.ForeColor = Color.DarkRed;
            }
            else
            {
                erroDescricao = false;
                astDesc.Visible = false;
                lbDescricao.ForeColor = Color.White;
            }
        }

        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbCategoria.SelectedIndex != -1)
            {
                erroCategoria = false;
                astCategoria.Visible = false;
                lbCategoria.ForeColor = Color.White;
            }
        }

        private void PrPreco_TextChanged(object sender, EventArgs e)
        {
            if (Funcoes.CampoVazio(PrPreco))
            {
                erroPreco = true;
                astPreco.Visible = true;
                lbPreco.ForeColor = Color.DarkRed;
            }
            else
            {
                erroPreco = false;
                astPreco.Visible = false;
                lbPreco.ForeColor = Color.White;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Funcoes.Limpar(this);
            CmbUnidade.SelectedItem = "Unidade";
        }
    }
}
