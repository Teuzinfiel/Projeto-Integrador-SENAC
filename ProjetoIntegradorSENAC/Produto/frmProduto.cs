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

        public frmProduto(int idUsuario)
        {
            InitializeComponent();

            this.idUsuario = idUsuario;

        }

        public int CodigoProduto()
        {

            Random random = new Random();
            int codigo = random.Next(100000000, 999999999);


            return codigo;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

            string insert = "Insert into produtos (funcionario_id, nome, descricao, marca, codigo_barra, unidade_medida, categoria, preco) " +
                $"values ({idUsuario},'{PrNome.Text}', '{PrDescricao.Text}', '{PrMarca.Text}', '{CodigoProduto()}', '{CmbUnidade.SelectedItem}'," +
                $" '{CmbCategoria.SelectedItem}', '{PrPreco.Text.Replace(",", ".")}')";

            Banco.Inserir(insert);


        }

       
        private void frmProduto_Load(object sender, EventArgs e)
        {
            CmbUnidade.SelectedItem = "Unidade";
        }

        private void CmbUnidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbUnidade.SelectedItem.ToString() == "Grama")
            {
                LbPreco.Text = "Preço por Kg";
            }
            else
            {
                LbPreco.Text = "Preço por unidade";
            }
        }
    }
}
