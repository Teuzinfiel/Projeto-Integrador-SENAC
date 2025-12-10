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
            label5 = new Label();
            PrMarca = new TextBox();
            label2 = new Label();
            PrNome = new TextBox();
            label1 = new Label();
            label3 = new Label();
            PrDescricao = new TextBox();
            label4 = new Label();
            label6 = new Label();
            CmbCategoria = new ComboBox();
            CmbUnidade = new ComboBox();
            LbPreco = new Label();
            PrPreco = new TextBox();
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
            btnLimpar.Location = new Point(473, 580);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(348, 37);
            btnLimpar.TabIndex = 38;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = SystemColors.Highlight;
            btnCadastro.Cursor = Cursors.Hand;
            btnCadastro.FlatStyle = FlatStyle.Popup;
            btnCadastro.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastro.ForeColor = Color.White;
            btnCadastro.Location = new Point(473, 519);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(348, 37);
            btnCadastro.TabIndex = 36;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 12F);
            label5.ForeColor = Color.FromArgb(180, 180, 190);
            label5.Location = new Point(285, 249);
            label5.Name = "label5";
            label5.Size = new Size(131, 21);
            label5.TabIndex = 40;
            label5.Text = "Marca do produto";
            // 
            // PrMarca
            // 
            PrMarca.BackColor = Color.FromArgb(224, 224, 224);
            PrMarca.Font = new Font("Microsoft Sans Serif", 16F);
            PrMarca.Location = new Point(285, 273);
            PrMarca.Name = "PrMarca";
            PrMarca.PlaceholderText = "Digite a marca do produto";
            PrMarca.Size = new Size(348, 32);
            PrMarca.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F);
            label2.ForeColor = Color.FromArgb(180, 180, 190);
            label2.Location = new Point(285, 173);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 32;
            label2.Text = "Nome do produto";
            // 
            // PrNome
            // 
            PrNome.BackColor = Color.FromArgb(224, 224, 224);
            PrNome.Font = new Font("Microsoft Sans Serif", 16F);
            PrNome.Location = new Point(285, 197);
            PrNome.Name = "PrNome";
            PrNome.PlaceholderText = "Digite o nome do produto";
            PrNome.Size = new Size(348, 32);
            PrNome.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 23F);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(533, 98);
            label1.Name = "label1";
            label1.Size = new Size(288, 37);
            label1.TabIndex = 30;
            label1.Text = "Cadastre de produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 12F);
            label3.ForeColor = Color.FromArgb(180, 180, 190);
            label3.Location = new Point(694, 173);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 50;
            label3.Text = "Descrição";
            // 
            // PrDescricao
            // 
            PrDescricao.BackColor = Color.FromArgb(224, 224, 224);
            PrDescricao.Font = new Font("Microsoft Sans Serif", 16F);
            PrDescricao.Location = new Point(694, 197);
            PrDescricao.Multiline = true;
            PrDescricao.Name = "PrDescricao";
            PrDescricao.PlaceholderText = "Digite a descrição do produto";
            PrDescricao.Size = new Size(348, 108);
            PrDescricao.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 12F);
            label4.ForeColor = Color.FromArgb(180, 180, 190);
            label4.Location = new Point(285, 327);
            label4.Name = "label4";
            label4.Size = new Size(146, 21);
            label4.TabIndex = 51;
            label4.Text = "Unidade de medida";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 12F);
            label6.ForeColor = Color.FromArgb(180, 180, 190);
            label6.Location = new Point(694, 327);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 53;
            label6.Text = "Categoria";
            // 
            // CmbCategoria
            // 
            CmbCategoria.BackColor = Color.FromArgb(224, 224, 224);
            CmbCategoria.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbCategoria.FormattingEnabled = true;
            CmbCategoria.Location = new Point(694, 351);
            CmbCategoria.Name = "CmbCategoria";
            CmbCategoria.Size = new Size(348, 33);
            CmbCategoria.TabIndex = 54;
            // 
            // CmbUnidade
            // 
            CmbUnidade.AutoCompleteCustomSource.AddRange(new string[] { "Unidade", "Grama" });
            CmbUnidade.BackColor = Color.FromArgb(224, 224, 224);
            CmbUnidade.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbUnidade.FormattingEnabled = true;
            CmbUnidade.Items.AddRange(new object[] { "Unidade", "Grama" });
            CmbUnidade.Location = new Point(285, 351);
            CmbUnidade.Name = "CmbUnidade";
            CmbUnidade.Size = new Size(348, 33);
            CmbUnidade.TabIndex = 55;
            CmbUnidade.SelectedIndexChanged += CmbUnidade_SelectedIndexChanged;
            // 
            // LbPreco
            // 
            LbPreco.AutoSize = true;
            LbPreco.Font = new Font("Franklin Gothic Medium", 12F);
            LbPreco.ForeColor = Color.FromArgb(180, 180, 190);
            LbPreco.Location = new Point(285, 405);
            LbPreco.Name = "LbPreco";
            LbPreco.Size = new Size(135, 21);
            LbPreco.TabIndex = 57;
            LbPreco.Text = "Preço por unidade";
            // 
            // PrPreco
            // 
            PrPreco.BackColor = Color.FromArgb(224, 224, 224);
            PrPreco.Font = new Font("Microsoft Sans Serif", 16F);
            PrPreco.Location = new Point(285, 429);
            PrPreco.Name = "PrPreco";
            PrPreco.PlaceholderText = "digite o preço do produto";
            PrPreco.Size = new Size(348, 32);
            PrPreco.TabIndex = 56;
            // 
            // frmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(1323, 816);
            Controls.Add(LbPreco);
            Controls.Add(PrPreco);
            Controls.Add(CmbUnidade);
            Controls.Add(CmbCategoria);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(PrDescricao);
            Controls.Add(btnLimpar);
            Controls.Add(btnCadastro);
            Controls.Add(label5);
            Controls.Add(PrMarca);
            Controls.Add(label2);
            Controls.Add(PrNome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProduto";
            Text = "cadastroProduto";
            Load += frmProduto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLimpar;
        private Button btnCadastro;
        private Label label5;
        private TextBox PrMarca;
        private Label label2;
        private TextBox PrNome;
        private Label label1;
        private Label label3;
        private TextBox PrDescricao;
        private Label label4;
        private Label label6;
        private ComboBox CmbCategoria;
        private ComboBox CmbUnidade;
        private Label LbPreco;
        private TextBox PrPreco;
    }
}