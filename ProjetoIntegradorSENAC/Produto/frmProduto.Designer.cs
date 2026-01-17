namespace ProjetoIntegradorSENAC.Produto
{
    partial class frmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLimpar = new Button();
            btnCadastro = new Button();
            lbMarca = new Label();
            PrMarca = new TextBox();
            lbNome = new Label();
            PrNome = new TextBox();
            lbDescricao = new Label();
            PrDescricao = new TextBox();
            lbUnidade = new Label();
            lbCategoria = new Label();
            CmbCategoria = new ComboBox();
            CmbUnidade = new ComboBox();
            lbPreco = new Label();
            PrPreco = new TextBox();
            astNome = new Label();
            astCategoria = new Label();
            astMarca = new Label();
            astPreco = new Label();
            astDesc = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Transparent;
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnLimpar.FlatAppearance.BorderSize = 2;
            btnLimpar.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 60);
            btnLimpar.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 60);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = SystemColors.Highlight;
            btnLimpar.Location = new Point(164, 408);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(348, 37);
            btnLimpar.TabIndex = 38;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = SystemColors.Highlight;
            btnCadastro.Cursor = Cursors.Hand;
            btnCadastro.FlatStyle = FlatStyle.Popup;
            btnCadastro.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastro.ForeColor = Color.White;
            btnCadastro.Location = new Point(573, 408);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(348, 37);
            btnCadastro.TabIndex = 36;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // lbMarca
            // 
            lbMarca.AutoSize = true;
            lbMarca.Font = new Font("Franklin Gothic Medium", 12F);
            lbMarca.ForeColor = Color.FromArgb(180, 180, 190);
            lbMarca.Location = new Point(164, 170);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new Size(131, 21);
            lbMarca.TabIndex = 40;
            lbMarca.Text = "Marca do produto";
            // 
            // PrMarca
            // 
            PrMarca.BackColor = Color.FromArgb(224, 224, 224);
            PrMarca.Font = new Font("Microsoft Sans Serif", 16F);
            PrMarca.Location = new Point(164, 194);
            PrMarca.Name = "PrMarca";
            PrMarca.PlaceholderText = "Digite a marca do produto";
            PrMarca.Size = new Size(348, 32);
            PrMarca.TabIndex = 39;
            PrMarca.TextChanged += PrMarca_TextChanged;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Franklin Gothic Medium", 12F);
            lbNome.ForeColor = Color.FromArgb(180, 180, 190);
            lbNome.Location = new Point(164, 94);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(128, 21);
            lbNome.TabIndex = 32;
            lbNome.Text = "Nome do produto";
            // 
            // PrNome
            // 
            PrNome.BackColor = Color.FromArgb(224, 224, 224);
            PrNome.Font = new Font("Microsoft Sans Serif", 16F);
            PrNome.Location = new Point(164, 118);
            PrNome.Name = "PrNome";
            PrNome.PlaceholderText = "Digite o nome do produto";
            PrNome.Size = new Size(348, 32);
            PrNome.TabIndex = 31;
            PrNome.TextChanged += PrNome_TextChanged;
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.Font = new Font("Franklin Gothic Medium", 12F);
            lbDescricao.ForeColor = Color.FromArgb(180, 180, 190);
            lbDescricao.Location = new Point(573, 94);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(75, 21);
            lbDescricao.TabIndex = 50;
            lbDescricao.Text = "Descrição";
            // 
            // PrDescricao
            // 
            PrDescricao.BackColor = Color.FromArgb(224, 224, 224);
            PrDescricao.Font = new Font("Microsoft Sans Serif", 16F);
            PrDescricao.Location = new Point(573, 118);
            PrDescricao.Multiline = true;
            PrDescricao.Name = "PrDescricao";
            PrDescricao.PlaceholderText = "Digite a descrição do produto";
            PrDescricao.Size = new Size(348, 187);
            PrDescricao.TabIndex = 49;
            PrDescricao.TextChanged += PrDescricao_TextChanged;
            // 
            // lbUnidade
            // 
            lbUnidade.AutoSize = true;
            lbUnidade.Font = new Font("Franklin Gothic Medium", 12F);
            lbUnidade.ForeColor = Color.FromArgb(180, 180, 190);
            lbUnidade.Location = new Point(164, 248);
            lbUnidade.Name = "lbUnidade";
            lbUnidade.Size = new Size(146, 21);
            lbUnidade.TabIndex = 51;
            lbUnidade.Text = "Unidade de medida";
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Font = new Font("Franklin Gothic Medium", 12F);
            lbCategoria.ForeColor = Color.FromArgb(180, 180, 190);
            lbCategoria.Location = new Point(573, 325);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(75, 21);
            lbCategoria.TabIndex = 53;
            lbCategoria.Text = "Categoria";
            // 
            // CmbCategoria
            // 
            CmbCategoria.BackColor = Color.FromArgb(224, 224, 224);
            CmbCategoria.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbCategoria.FormattingEnabled = true;
            CmbCategoria.Items.AddRange(new object[] { "Alimentos", "Eletrodomésticos", "Móveis" });
            CmbCategoria.Location = new Point(573, 349);
            CmbCategoria.Name = "CmbCategoria";
            CmbCategoria.Size = new Size(348, 33);
            CmbCategoria.TabIndex = 54;
            CmbCategoria.SelectedIndexChanged += CmbCategoria_SelectedIndexChanged;
            // 
            // CmbUnidade
            // 
            CmbUnidade.AutoCompleteCustomSource.AddRange(new string[] { "Unidade", "Grama" });
            CmbUnidade.BackColor = Color.FromArgb(224, 224, 224);
            CmbUnidade.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbUnidade.FormattingEnabled = true;
            CmbUnidade.Items.AddRange(new object[] { "Unidade", "Grama" });
            CmbUnidade.Location = new Point(164, 272);
            CmbUnidade.Name = "CmbUnidade";
            CmbUnidade.Size = new Size(348, 33);
            CmbUnidade.TabIndex = 55;
            CmbUnidade.SelectedIndexChanged += CmbUnidade_SelectedIndexChanged;
            // 
            // lbPreco
            // 
            lbPreco.AutoSize = true;
            lbPreco.Font = new Font("Franklin Gothic Medium", 12F);
            lbPreco.ForeColor = Color.FromArgb(180, 180, 190);
            lbPreco.Location = new Point(164, 325);
            lbPreco.Name = "lbPreco";
            lbPreco.Size = new Size(135, 21);
            lbPreco.TabIndex = 57;
            lbPreco.Text = "Preço por unidade";
            // 
            // PrPreco
            // 
            PrPreco.BackColor = Color.FromArgb(224, 224, 224);
            PrPreco.Font = new Font("Microsoft Sans Serif", 16F);
            PrPreco.Location = new Point(164, 349);
            PrPreco.Name = "PrPreco";
            PrPreco.PlaceholderText = "digite o preço do produto";
            PrPreco.Size = new Size(348, 32);
            PrPreco.TabIndex = 56;
            PrPreco.TextChanged += PrPreco_TextChanged;
            // 
            // astNome
            // 
            astNome.AutoSize = true;
            astNome.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astNome.ForeColor = Color.FromArgb(192, 0, 0);
            astNome.Location = new Point(294, 91);
            astNome.Name = "astNome";
            astNome.Size = new Size(16, 24);
            astNome.TabIndex = 58;
            astNome.Text = "*";
            astNome.Visible = false;
            // 
            // astCategoria
            // 
            astCategoria.AutoSize = true;
            astCategoria.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astCategoria.ForeColor = Color.FromArgb(192, 0, 0);
            astCategoria.Location = new Point(645, 325);
            astCategoria.Name = "astCategoria";
            astCategoria.Size = new Size(16, 24);
            astCategoria.TabIndex = 59;
            astCategoria.Text = "*";
            astCategoria.Visible = false;
            // 
            // astMarca
            // 
            astMarca.AutoSize = true;
            astMarca.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astMarca.ForeColor = Color.FromArgb(192, 0, 0);
            astMarca.Location = new Point(294, 167);
            astMarca.Name = "astMarca";
            astMarca.Size = new Size(16, 24);
            astMarca.TabIndex = 60;
            astMarca.Text = "*";
            astMarca.Visible = false;
            // 
            // astPreco
            // 
            astPreco.AutoSize = true;
            astPreco.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astPreco.ForeColor = Color.FromArgb(192, 0, 0);
            astPreco.Location = new Point(294, 325);
            astPreco.Name = "astPreco";
            astPreco.Size = new Size(16, 24);
            astPreco.TabIndex = 61;
            astPreco.Text = "*";
            astPreco.Visible = false;
            // 
            // astDesc
            // 
            astDesc.AutoSize = true;
            astDesc.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astDesc.ForeColor = Color.FromArgb(192, 0, 0);
            astDesc.Location = new Point(645, 91);
            astDesc.Name = "astDesc";
            astDesc.Size = new Size(16, 24);
            astDesc.TabIndex = 62;
            astDesc.Text = "*";
            astDesc.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 45);
            panel1.Controls.Add(astDesc);
            panel1.Controls.Add(astPreco);
            panel1.Controls.Add(astMarca);
            panel1.Controls.Add(astCategoria);
            panel1.Controls.Add(astNome);
            panel1.Controls.Add(lbPreco);
            panel1.Controls.Add(PrPreco);
            panel1.Controls.Add(CmbUnidade);
            panel1.Controls.Add(CmbCategoria);
            panel1.Controls.Add(lbCategoria);
            panel1.Controls.Add(lbUnidade);
            panel1.Controls.Add(lbDescricao);
            panel1.Controls.Add(PrDescricao);
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(btnCadastro);
            panel1.Controls.Add(lbMarca);
            panel1.Controls.Add(PrMarca);
            panel1.Controls.Add(lbNome);
            panel1.Controls.Add(PrNome);
            panel1.Location = new Point(132, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 570);
            panel1.TabIndex = 63;
            // 
            // frmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(1342, 725);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProduto";
            Text = "cadastroProduto";
            Load += frmProduto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnLimpar;
        private Button btnCadastro;
        private Label lbMarca;
        private TextBox PrMarca;
        private Label lbNome;
        private TextBox PrNome;
        private Label lbDescricao;
        private TextBox PrDescricao;
        private Label lbUnidade;
        private Label lbCategoria;
        private ComboBox CmbCategoria;
        private ComboBox CmbUnidade;
        private Label lbPreco;
        private TextBox PrPreco;
        private Label astNome;
        private Label astCategoria;
        private Label astMarca;
        private Label astPreco;
        private Label astDesc;
        private Panel panel1;
    }
}