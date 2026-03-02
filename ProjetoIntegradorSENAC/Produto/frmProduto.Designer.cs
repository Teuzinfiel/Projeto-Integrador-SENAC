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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            btnCadastro = new Button();
            lbMarca = new Label();
            PrMarca = new TextBox();
            lbNome = new Label();
            PrNome = new TextBox();
            lbDescricao = new Label();
            PrDescricaoAtt = new TextBox();
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
            astDescAtt = new Label();
            panel1 = new Panel();
            label23 = new Label();
            astCod = new Label();
            PrCodigoBarra = new TextBox();
            label19 = new Label();
            btnCadCategoria = new Button();
            btnExcluirCat = new Button();
            label17 = new Label();
            label18 = new Label();
            txtCategoria = new TextBox();
            dtgCategoria = new DataGridView();
            label15 = new Label();
            astUnidade = new Label();
            astDescricao = new Label();
            PrDescricao = new TextBox();
            label14 = new Label();
            lbBarrasAtt = new Label();
            astCatAtt = new Label();
            cmbCatAtt = new ComboBox();
            lbCatAtt = new Label();
            lbDescAtt = new Label();
            panel2 = new Panel();
            astMedidaAtt = new Label();
            btnAtivarProd = new Button();
            astBarrasAtt = new Label();
            btnDesativarProd = new Button();
            txtCodBarra = new TextBox();
            label16 = new Label();
            btnExcluirProd = new Button();
            btnAttProd = new Button();
            astPrecoAtt = new Label();
            astmarcaAtt = new Label();
            astNomeAtt = new Label();
            lbPrecoAtt = new Label();
            txtPrecoProd = new TextBox();
            cmbMedida = new ComboBox();
            lbMedidaAtt = new Label();
            lbMarcaAtt = new Label();
            txtMarcaProd = new TextBox();
            lbNomeAtt = new Label();
            txtNomeProd = new TextBox();
            label1 = new Label();
            dtgProdutos = new DataGridView();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCategoria).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).BeginInit();
            SuspendLayout();
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = SystemColors.Highlight;
            btnCadastro.Cursor = Cursors.Hand;
            btnCadastro.FlatStyle = FlatStyle.Popup;
            btnCadastro.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastro.ForeColor = Color.White;
            btnCadastro.Location = new Point(17, 641);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(556, 37);
            btnCadastro.TabIndex = 36;
            btnCadastro.Text = "Cadastrar Produto";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // lbMarca
            // 
            lbMarca.AutoSize = true;
            lbMarca.Font = new Font("Franklin Gothic Medium", 12F);
            lbMarca.ForeColor = Color.FromArgb(180, 180, 190);
            lbMarca.Location = new Point(18, 449);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new Size(131, 21);
            lbMarca.TabIndex = 40;
            lbMarca.Text = "Marca do produto";
            // 
            // PrMarca
            // 
            PrMarca.BackColor = Color.FromArgb(224, 224, 224);
            PrMarca.Font = new Font("Microsoft Sans Serif", 16F);
            PrMarca.Location = new Point(18, 473);
            PrMarca.Name = "PrMarca";
            PrMarca.PlaceholderText = "Digite a marca do produto";
            PrMarca.Size = new Size(294, 32);
            PrMarca.TabIndex = 39;
            PrMarca.TextChanged += PrMarca_TextChanged;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Franklin Gothic Medium", 12F);
            lbNome.ForeColor = Color.FromArgb(180, 180, 190);
            lbNome.Location = new Point(17, 386);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(128, 21);
            lbNome.TabIndex = 32;
            lbNome.Text = "Nome do produto";
            // 
            // PrNome
            // 
            PrNome.BackColor = Color.FromArgb(224, 224, 224);
            PrNome.Font = new Font("Microsoft Sans Serif", 16F);
            PrNome.Location = new Point(17, 410);
            PrNome.Name = "PrNome";
            PrNome.PlaceholderText = "Digite o nome do produto";
            PrNome.Size = new Size(294, 32);
            PrNome.TabIndex = 31;
            PrNome.TextChanged += PrNome_TextChanged;
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.Font = new Font("Franklin Gothic Medium", 12F);
            lbDescricao.ForeColor = Color.FromArgb(180, 180, 190);
            lbDescricao.Location = new Point(322, 380);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(75, 21);
            lbDescricao.TabIndex = 50;
            lbDescricao.Text = "Descrição";
            // 
            // PrDescricaoAtt
            // 
            PrDescricaoAtt.BackColor = Color.FromArgb(224, 224, 224);
            PrDescricaoAtt.Font = new Font("Microsoft Sans Serif", 16F);
            PrDescricaoAtt.Location = new Point(345, 395);
            PrDescricaoAtt.Multiline = true;
            PrDescricaoAtt.Name = "PrDescricaoAtt";
            PrDescricaoAtt.PlaceholderText = "Digite a descrição do produto";
            PrDescricaoAtt.Size = new Size(345, 95);
            PrDescricaoAtt.TabIndex = 49;
            PrDescricaoAtt.TextChanged += PrDescricao_TextChanged;
            // 
            // lbUnidade
            // 
            lbUnidade.AutoSize = true;
            lbUnidade.Font = new Font("Franklin Gothic Medium", 12F);
            lbUnidade.ForeColor = Color.FromArgb(180, 180, 190);
            lbUnidade.Location = new Point(17, 511);
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
            lbCategoria.Location = new Point(322, 575);
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
            CmbCategoria.Location = new Point(322, 600);
            CmbCategoria.Name = "CmbCategoria";
            CmbCategoria.Size = new Size(251, 33);
            CmbCategoria.TabIndex = 54;
            CmbCategoria.SelectedIndexChanged += CmbCategoria_SelectedIndexChanged;
            // 
            // CmbUnidade
            // 
            CmbUnidade.AutoCompleteCustomSource.AddRange(new string[] { "Unidade", "Grama" });
            CmbUnidade.BackColor = Color.FromArgb(224, 224, 224);
            CmbUnidade.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbUnidade.FormattingEnabled = true;
            CmbUnidade.Items.AddRange(new object[] { "Unidade", "Caixa", "Pacote", "Kg", "Gramas", "Litros", "Ml", "Dúzia", "Fardo", "Kit" });
            CmbUnidade.Location = new Point(17, 535);
            CmbUnidade.Name = "CmbUnidade";
            CmbUnidade.Size = new Size(294, 33);
            CmbUnidade.TabIndex = 55;
            CmbUnidade.SelectedIndexChanged += CmbUnidade_SelectedIndexChanged;
            // 
            // lbPreco
            // 
            lbPreco.AutoSize = true;
            lbPreco.Font = new Font("Franklin Gothic Medium", 12F);
            lbPreco.ForeColor = Color.FromArgb(180, 180, 190);
            lbPreco.Location = new Point(17, 576);
            lbPreco.Name = "lbPreco";
            lbPreco.Size = new Size(135, 21);
            lbPreco.TabIndex = 57;
            lbPreco.Text = "Preço por unidade";
            // 
            // PrPreco
            // 
            PrPreco.BackColor = Color.FromArgb(224, 224, 224);
            PrPreco.Font = new Font("Microsoft Sans Serif", 16F);
            PrPreco.Location = new Point(17, 600);
            PrPreco.Name = "PrPreco";
            PrPreco.PlaceholderText = "digite o preço do produto";
            PrPreco.Size = new Size(294, 32);
            PrPreco.TabIndex = 56;
            PrPreco.TextChanged += PrPreco_TextChanged;
            // 
            // astNome
            // 
            astNome.AutoSize = true;
            astNome.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astNome.ForeColor = Color.FromArgb(192, 0, 0);
            astNome.Location = new Point(147, 383);
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
            astCategoria.Location = new Point(391, 573);
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
            astMarca.Location = new Point(148, 446);
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
            astPreco.Location = new Point(147, 576);
            astPreco.Name = "astPreco";
            astPreco.Size = new Size(16, 24);
            astPreco.TabIndex = 61;
            astPreco.Text = "*";
            astPreco.Visible = false;
            // 
            // astDescAtt
            // 
            astDescAtt.AutoSize = true;
            astDescAtt.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astDescAtt.ForeColor = Color.FromArgb(192, 0, 0);
            astDescAtt.Location = new Point(426, 368);
            astDescAtt.Name = "astDescAtt";
            astDescAtt.Size = new Size(16, 24);
            astDescAtt.TabIndex = 62;
            astDescAtt.Text = "*";
            astDescAtt.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 45);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(astCod);
            panel1.Controls.Add(dtgCategoria);
            panel1.Controls.Add(PrCodigoBarra);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(astUnidade);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(btnCadCategoria);
            panel1.Controls.Add(astCategoria);
            panel1.Controls.Add(txtCategoria);
            panel1.Controls.Add(astDescricao);
            panel1.Controls.Add(btnExcluirCat);
            panel1.Controls.Add(PrDescricao);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(astPreco);
            panel1.Controls.Add(astMarca);
            panel1.Controls.Add(astNome);
            panel1.Controls.Add(lbPreco);
            panel1.Controls.Add(PrPreco);
            panel1.Controls.Add(CmbCategoria);
            panel1.Controls.Add(CmbUnidade);
            panel1.Controls.Add(lbUnidade);
            panel1.Controls.Add(lbCategoria);
            panel1.Controls.Add(btnCadastro);
            panel1.Controls.Add(lbDescricao);
            panel1.Controls.Add(lbMarca);
            panel1.Controls.Add(PrMarca);
            panel1.Controls.Add(lbNome);
            panel1.Controls.Add(PrNome);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 701);
            panel1.TabIndex = 63;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Franklin Gothic Medium", 12F);
            label23.ForeColor = Color.FromArgb(180, 180, 190);
            label23.Location = new Point(322, 508);
            label23.Name = "label23";
            label23.Size = new Size(126, 21);
            label23.TabIndex = 84;
            label23.Text = "Codigo de Barras";
            // 
            // astCod
            // 
            astCod.AutoSize = true;
            astCod.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astCod.ForeColor = Color.FromArgb(192, 0, 0);
            astCod.Location = new Point(454, 505);
            astCod.Name = "astCod";
            astCod.Size = new Size(16, 24);
            astCod.TabIndex = 81;
            astCod.Text = "*";
            astCod.Visible = false;
            // 
            // PrCodigoBarra
            // 
            PrCodigoBarra.BackColor = Color.FromArgb(224, 224, 224);
            PrCodigoBarra.Font = new Font("Microsoft Sans Serif", 16F);
            PrCodigoBarra.Location = new Point(322, 535);
            PrCodigoBarra.Name = "PrCodigoBarra";
            PrCodigoBarra.PlaceholderText = "Digite o codigo do produto";
            PrCodigoBarra.Size = new Size(251, 32);
            PrCodigoBarra.TabIndex = 79;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Franklin Gothic Medium", 10F);
            label19.ForeColor = Color.FromArgb(180, 180, 190);
            label19.Location = new Point(18, 50);
            label19.Name = "label19";
            label19.Size = new Size(264, 36);
            label19.TabIndex = 78;
            label19.Text = "Clique em alguma categoria para exclui-la!\r\n\r\n";
            // 
            // btnCadCategoria
            // 
            btnCadCategoria.BackColor = SystemColors.Highlight;
            btnCadCategoria.Cursor = Cursors.Hand;
            btnCadCategoria.FlatStyle = FlatStyle.Popup;
            btnCadCategoria.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadCategoria.ForeColor = Color.White;
            btnCadCategoria.Location = new Point(306, 259);
            btnCadCategoria.Name = "btnCadCategoria";
            btnCadCategoria.Size = new Size(267, 35);
            btnCadCategoria.TabIndex = 77;
            btnCadCategoria.Text = "Cadastrar categoria";
            btnCadCategoria.UseVisualStyleBackColor = false;
            btnCadCategoria.Click += btnCadCategoria_Click;
            // 
            // btnExcluirCat
            // 
            btnExcluirCat.BackColor = Color.Transparent;
            btnExcluirCat.FlatStyle = FlatStyle.Popup;
            btnExcluirCat.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluirCat.ForeColor = Color.Maroon;
            btnExcluirCat.Location = new Point(17, 259);
            btnExcluirCat.Name = "btnExcluirCat";
            btnExcluirCat.Size = new Size(262, 35);
            btnExcluirCat.TabIndex = 76;
            btnExcluirCat.Text = "Excluir Categoria";
            btnExcluirCat.UseVisualStyleBackColor = false;
            btnExcluirCat.Click += btnExcluirCat_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(192, 0, 0);
            label17.Location = new Point(159, 194);
            label17.Name = "label17";
            label17.Size = new Size(16, 24);
            label17.TabIndex = 75;
            label17.Text = "*";
            label17.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Franklin Gothic Medium", 12F);
            label18.ForeColor = Color.FromArgb(180, 180, 190);
            label18.Location = new Point(17, 197);
            label18.Name = "label18";
            label18.Size = new Size(145, 21);
            label18.TabIndex = 74;
            label18.Text = "Nome da Categoria!";
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = Color.FromArgb(224, 224, 224);
            txtCategoria.Font = new Font("Microsoft Sans Serif", 16F);
            txtCategoria.Location = new Point(17, 221);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.PlaceholderText = "Digite o nome do produto";
            txtCategoria.Size = new Size(556, 32);
            txtCategoria.TabIndex = 73;
            // 
            // dtgCategoria
            // 
            dtgCategoria.AllowUserToAddRows = false;
            dtgCategoria.AllowUserToDeleteRows = false;
            dtgCategoria.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 35, 45);
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Medium Cond", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dtgCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgCategoria.BackgroundColor = Color.FromArgb(30, 35, 45);
            dtgCategoria.BorderStyle = BorderStyle.None;
            dtgCategoria.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 70);
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Medium", 11F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgCategoria.DefaultCellStyle = dataGridViewCellStyle3;
            dtgCategoria.EnableHeadersVisualStyles = false;
            dtgCategoria.GridColor = Color.FromArgb(60, 60, 80);
            dtgCategoria.Location = new Point(17, 69);
            dtgCategoria.MultiSelect = false;
            dtgCategoria.Name = "dtgCategoria";
            dtgCategoria.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle4.Font = new Font("Franklin Gothic Medium", 11F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgCategoria.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle5.Font = new Font("Franklin Gothic Medium", 11F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dtgCategoria.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dtgCategoria.RowTemplate.Height = 26;
            dtgCategoria.ScrollBars = ScrollBars.Vertical;
            dtgCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCategoria.Size = new Size(556, 125);
            dtgCategoria.TabIndex = 72;
            dtgCategoria.CellClick += dtgCategoria_CellClick;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Franklin Gothic Medium", 20F);
            label15.ForeColor = Color.FromArgb(180, 180, 190);
            label15.Location = new Point(89, 8);
            label15.Name = "label15";
            label15.Size = new Size(430, 34);
            label15.TabIndex = 71;
            label15.Text = "Cadastre aqui uma nova Categoria!";
            // 
            // astUnidade
            // 
            astUnidade.AutoSize = true;
            astUnidade.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astUnidade.ForeColor = Color.FromArgb(192, 0, 0);
            astUnidade.Location = new Point(169, 508);
            astUnidade.Name = "astUnidade";
            astUnidade.Size = new Size(16, 24);
            astUnidade.TabIndex = 70;
            astUnidade.Text = "*";
            astUnidade.Visible = false;
            // 
            // astDescricao
            // 
            astDescricao.AutoSize = true;
            astDescricao.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astDescricao.ForeColor = Color.FromArgb(192, 0, 0);
            astDescricao.Location = new Point(393, 377);
            astDescricao.Name = "astDescricao";
            astDescricao.Size = new Size(16, 24);
            astDescricao.TabIndex = 69;
            astDescricao.Text = "*";
            astDescricao.Visible = false;
            // 
            // PrDescricao
            // 
            PrDescricao.BackColor = Color.FromArgb(224, 224, 224);
            PrDescricao.Font = new Font("Microsoft Sans Serif", 16F);
            PrDescricao.Location = new Point(322, 404);
            PrDescricao.Multiline = true;
            PrDescricao.Name = "PrDescricao";
            PrDescricao.PlaceholderText = "Descrição do produto";
            PrDescricao.Size = new Size(251, 101);
            PrDescricao.TabIndex = 64;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Franklin Gothic Medium", 16F);
            label14.ForeColor = Color.FromArgb(180, 180, 190);
            label14.Location = new Point(159, 349);
            label14.Name = "label14";
            label14.Size = new Size(268, 28);
            label14.TabIndex = 63;
            label14.Text = "Cadastre aqui um Produto!";
            // 
            // lbBarrasAtt
            // 
            lbBarrasAtt.AutoSize = true;
            lbBarrasAtt.Font = new Font("Franklin Gothic Medium", 12F);
            lbBarrasAtt.ForeColor = Color.FromArgb(180, 180, 190);
            lbBarrasAtt.Location = new Point(345, 502);
            lbBarrasAtt.Name = "lbBarrasAtt";
            lbBarrasAtt.Size = new Size(126, 21);
            lbBarrasAtt.TabIndex = 80;
            lbBarrasAtt.Text = "Codigo de Barras";
            // 
            // astCatAtt
            // 
            astCatAtt.AutoSize = true;
            astCatAtt.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astCatAtt.ForeColor = Color.FromArgb(192, 0, 0);
            astCatAtt.Location = new Point(416, 561);
            astCatAtt.Name = "astCatAtt";
            astCatAtt.Size = new Size(16, 24);
            astCatAtt.TabIndex = 68;
            astCatAtt.Text = "*";
            astCatAtt.Visible = false;
            // 
            // cmbCatAtt
            // 
            cmbCatAtt.BackColor = Color.FromArgb(224, 224, 224);
            cmbCatAtt.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCatAtt.FormattingEnabled = true;
            cmbCatAtt.Location = new Point(345, 590);
            cmbCatAtt.Name = "cmbCatAtt";
            cmbCatAtt.Size = new Size(345, 33);
            cmbCatAtt.TabIndex = 67;
            // 
            // lbCatAtt
            // 
            lbCatAtt.AutoSize = true;
            lbCatAtt.Font = new Font("Franklin Gothic Medium", 12F);
            lbCatAtt.ForeColor = Color.FromArgb(180, 180, 190);
            lbCatAtt.Location = new Point(345, 564);
            lbCatAtt.Name = "lbCatAtt";
            lbCatAtt.Size = new Size(75, 21);
            lbCatAtt.TabIndex = 66;
            lbCatAtt.Text = "Categoria";
            // 
            // lbDescAtt
            // 
            lbDescAtt.AutoSize = true;
            lbDescAtt.Font = new Font("Franklin Gothic Medium", 12F);
            lbDescAtt.ForeColor = Color.FromArgb(180, 180, 190);
            lbDescAtt.Location = new Point(345, 371);
            lbDescAtt.Name = "lbDescAtt";
            lbDescAtt.Size = new Size(75, 21);
            lbDescAtt.TabIndex = 65;
            lbDescAtt.Text = "Descrição";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 45);
            panel2.Controls.Add(astMedidaAtt);
            panel2.Controls.Add(btnAtivarProd);
            panel2.Controls.Add(astBarrasAtt);
            panel2.Controls.Add(btnDesativarProd);
            panel2.Controls.Add(txtCodBarra);
            panel2.Controls.Add(lbBarrasAtt);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(btnExcluirProd);
            panel2.Controls.Add(btnAttProd);
            panel2.Controls.Add(astPrecoAtt);
            panel2.Controls.Add(astDescAtt);
            panel2.Controls.Add(astmarcaAtt);
            panel2.Controls.Add(astNomeAtt);
            panel2.Controls.Add(lbPrecoAtt);
            panel2.Controls.Add(astCatAtt);
            panel2.Controls.Add(lbCatAtt);
            panel2.Controls.Add(cmbCatAtt);
            panel2.Controls.Add(txtPrecoProd);
            panel2.Controls.Add(cmbMedida);
            panel2.Controls.Add(lbMedidaAtt);
            panel2.Controls.Add(lbDescAtt);
            panel2.Controls.Add(lbMarcaAtt);
            panel2.Controls.Add(txtMarcaProd);
            panel2.Controls.Add(lbNomeAtt);
            panel2.Controls.Add(txtNomeProd);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dtgProdutos);
            panel2.Controls.Add(PrDescricaoAtt);
            panel2.Location = new Point(625, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(705, 701);
            panel2.TabIndex = 64;
            // 
            // astMedidaAtt
            // 
            astMedidaAtt.AutoSize = true;
            astMedidaAtt.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astMedidaAtt.ForeColor = Color.FromArgb(192, 0, 0);
            astMedidaAtt.Location = new Point(163, 499);
            astMedidaAtt.Name = "astMedidaAtt";
            astMedidaAtt.Size = new Size(16, 24);
            astMedidaAtt.TabIndex = 88;
            astMedidaAtt.Text = "*";
            astMedidaAtt.Visible = false;
            // 
            // btnAtivarProd
            // 
            btnAtivarProd.BackColor = Color.Transparent;
            btnAtivarProd.FlatStyle = FlatStyle.Popup;
            btnAtivarProd.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtivarProd.ForeColor = Color.DarkSeaGreen;
            btnAtivarProd.Location = new Point(172, 639);
            btnAtivarProd.Name = "btnAtivarProd";
            btnAtivarProd.Size = new Size(155, 37);
            btnAtivarProd.TabIndex = 87;
            btnAtivarProd.Text = "Ativar Produto";
            btnAtivarProd.UseVisualStyleBackColor = false;
            btnAtivarProd.Click += btnAtivarProd_Click;
            // 
            // astBarrasAtt
            // 
            astBarrasAtt.AutoSize = true;
            astBarrasAtt.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astBarrasAtt.ForeColor = Color.FromArgb(192, 0, 0);
            astBarrasAtt.Location = new Point(477, 493);
            astBarrasAtt.Name = "astBarrasAtt";
            astBarrasAtt.Size = new Size(16, 24);
            astBarrasAtt.TabIndex = 85;
            astBarrasAtt.Text = "*";
            astBarrasAtt.Visible = false;
            // 
            // btnDesativarProd
            // 
            btnDesativarProd.BackColor = Color.Transparent;
            btnDesativarProd.FlatStyle = FlatStyle.Popup;
            btnDesativarProd.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDesativarProd.ForeColor = Color.Maroon;
            btnDesativarProd.Location = new Point(173, 639);
            btnDesativarProd.Name = "btnDesativarProd";
            btnDesativarProd.Size = new Size(154, 38);
            btnDesativarProd.TabIndex = 86;
            btnDesativarProd.Text = "Desativar Produto";
            btnDesativarProd.UseVisualStyleBackColor = false;
            btnDesativarProd.Click += btnDesativarProd_Click;
            // 
            // txtCodBarra
            // 
            txtCodBarra.BackColor = Color.FromArgb(224, 224, 224);
            txtCodBarra.Font = new Font("Microsoft Sans Serif", 16F);
            txtCodBarra.Location = new Point(345, 526);
            txtCodBarra.Name = "txtCodBarra";
            txtCodBarra.PlaceholderText = "Digite o codigo do produto";
            txtCodBarra.Size = new Size(345, 32);
            txtCodBarra.TabIndex = 83;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Franklin Gothic Medium", 9F);
            label16.ForeColor = Color.FromArgb(180, 180, 190);
            label16.Location = new Point(21, 60);
            label16.Name = "label16";
            label16.Size = new Size(130, 16);
            label16.TabIndex = 75;
            label16.Text = "Clique em algum produto";
            // 
            // btnExcluirProd
            // 
            btnExcluirProd.BackColor = Color.Transparent;
            btnExcluirProd.FlatStyle = FlatStyle.Popup;
            btnExcluirProd.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluirProd.ForeColor = Color.Maroon;
            btnExcluirProd.Location = new Point(20, 640);
            btnExcluirProd.Name = "btnExcluirProd";
            btnExcluirProd.Size = new Size(146, 38);
            btnExcluirProd.TabIndex = 74;
            btnExcluirProd.Text = "Excluir Produto";
            btnExcluirProd.UseVisualStyleBackColor = false;
            btnExcluirProd.Click += btnExcluirProd_Click;
            // 
            // btnAttProd
            // 
            btnAttProd.BackColor = SystemColors.Highlight;
            btnAttProd.Cursor = Cursors.Hand;
            btnAttProd.FlatStyle = FlatStyle.Popup;
            btnAttProd.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAttProd.ForeColor = Color.White;
            btnAttProd.Location = new Point(345, 640);
            btnAttProd.Name = "btnAttProd";
            btnAttProd.Size = new Size(345, 37);
            btnAttProd.TabIndex = 73;
            btnAttProd.Text = "Atualizar Produto";
            btnAttProd.UseVisualStyleBackColor = false;
            btnAttProd.Click += btnAttProd_Click;
            // 
            // astPrecoAtt
            // 
            astPrecoAtt.AutoSize = true;
            astPrecoAtt.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astPrecoAtt.ForeColor = Color.FromArgb(192, 0, 0);
            astPrecoAtt.Location = new Point(150, 567);
            astPrecoAtt.Name = "astPrecoAtt";
            astPrecoAtt.Size = new Size(16, 24);
            astPrecoAtt.TabIndex = 72;
            astPrecoAtt.Text = "*";
            astPrecoAtt.Visible = false;
            // 
            // astmarcaAtt
            // 
            astmarcaAtt.AutoSize = true;
            astmarcaAtt.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astmarcaAtt.ForeColor = Color.FromArgb(192, 0, 0);
            astmarcaAtt.Location = new Point(150, 431);
            astmarcaAtt.Name = "astmarcaAtt";
            astmarcaAtt.Size = new Size(16, 24);
            astmarcaAtt.TabIndex = 71;
            astmarcaAtt.Text = "*";
            astmarcaAtt.Visible = false;
            // 
            // astNomeAtt
            // 
            astNomeAtt.AutoSize = true;
            astNomeAtt.FlatStyle = FlatStyle.System;
            astNomeAtt.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astNomeAtt.ForeColor = Color.FromArgb(192, 0, 0);
            astNomeAtt.Location = new Point(150, 368);
            astNomeAtt.Name = "astNomeAtt";
            astNomeAtt.Size = new Size(16, 24);
            astNomeAtt.TabIndex = 70;
            astNomeAtt.Text = "*";
            astNomeAtt.Visible = false;
            // 
            // lbPrecoAtt
            // 
            lbPrecoAtt.AutoSize = true;
            lbPrecoAtt.Font = new Font("Franklin Gothic Medium", 12F);
            lbPrecoAtt.ForeColor = Color.FromArgb(180, 180, 190);
            lbPrecoAtt.Location = new Point(20, 567);
            lbPrecoAtt.Name = "lbPrecoAtt";
            lbPrecoAtt.Size = new Size(135, 21);
            lbPrecoAtt.TabIndex = 69;
            lbPrecoAtt.Text = "Preço por unidade";
            // 
            // txtPrecoProd
            // 
            txtPrecoProd.BackColor = Color.FromArgb(224, 224, 224);
            txtPrecoProd.Font = new Font("Microsoft Sans Serif", 16F);
            txtPrecoProd.Location = new Point(20, 591);
            txtPrecoProd.Name = "txtPrecoProd";
            txtPrecoProd.PlaceholderText = "digite o preço do produto";
            txtPrecoProd.Size = new Size(307, 32);
            txtPrecoProd.TabIndex = 68;
            // 
            // cmbMedida
            // 
            cmbMedida.AutoCompleteCustomSource.AddRange(new string[] { "Unidade", "Grama" });
            cmbMedida.BackColor = Color.FromArgb(224, 224, 224);
            cmbMedida.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMedida.FormattingEnabled = true;
            cmbMedida.Items.AddRange(new object[] { "Unidade", "Caixa", "Pacote", "Kg", "Gramas", "Litros", "Ml", "Dúzia", "Fardo", "Kit" });
            cmbMedida.Location = new Point(20, 526);
            cmbMedida.Name = "cmbMedida";
            cmbMedida.Size = new Size(307, 33);
            cmbMedida.TabIndex = 67;
            // 
            // lbMedidaAtt
            // 
            lbMedidaAtt.AutoSize = true;
            lbMedidaAtt.Font = new Font("Franklin Gothic Medium", 12F);
            lbMedidaAtt.ForeColor = Color.FromArgb(180, 180, 190);
            lbMedidaAtt.Location = new Point(20, 502);
            lbMedidaAtt.Name = "lbMedidaAtt";
            lbMedidaAtt.Size = new Size(146, 21);
            lbMedidaAtt.TabIndex = 66;
            lbMedidaAtt.Text = "Unidade de medida";
            // 
            // lbMarcaAtt
            // 
            lbMarcaAtt.AutoSize = true;
            lbMarcaAtt.Font = new Font("Franklin Gothic Medium", 12F);
            lbMarcaAtt.ForeColor = Color.FromArgb(180, 180, 190);
            lbMarcaAtt.Location = new Point(20, 434);
            lbMarcaAtt.Name = "lbMarcaAtt";
            lbMarcaAtt.Size = new Size(131, 21);
            lbMarcaAtt.TabIndex = 65;
            lbMarcaAtt.Text = "Marca do produto";
            // 
            // txtMarcaProd
            // 
            txtMarcaProd.BackColor = Color.FromArgb(224, 224, 224);
            txtMarcaProd.Font = new Font("Microsoft Sans Serif", 16F);
            txtMarcaProd.Location = new Point(20, 458);
            txtMarcaProd.Name = "txtMarcaProd";
            txtMarcaProd.PlaceholderText = "Digite a marca do produto";
            txtMarcaProd.Size = new Size(307, 32);
            txtMarcaProd.TabIndex = 64;
            // 
            // lbNomeAtt
            // 
            lbNomeAtt.AutoSize = true;
            lbNomeAtt.Font = new Font("Franklin Gothic Medium", 12F);
            lbNomeAtt.ForeColor = Color.FromArgb(180, 180, 190);
            lbNomeAtt.Location = new Point(20, 371);
            lbNomeAtt.Name = "lbNomeAtt";
            lbNomeAtt.Size = new Size(128, 21);
            lbNomeAtt.TabIndex = 63;
            lbNomeAtt.Text = "Nome do produto";
            // 
            // txtNomeProd
            // 
            txtNomeProd.BackColor = Color.FromArgb(224, 224, 224);
            txtNomeProd.Font = new Font("Microsoft Sans Serif", 16F);
            txtNomeProd.Location = new Point(20, 395);
            txtNomeProd.Name = "txtNomeProd";
            txtNomeProd.PlaceholderText = "Digite o nome do produto";
            txtNomeProd.Size = new Size(307, 32);
            txtNomeProd.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 17F);
            label1.ForeColor = Color.FromArgb(180, 180, 190);
            label1.Location = new Point(52, 13);
            label1.Name = "label1";
            label1.Size = new Size(592, 29);
            label1.TabIndex = 60;
            label1.Text = "Clique em algum produto para Atualizar e excluir Produtos!\r\n";
            // 
            // dtgProdutos
            // 
            dtgProdutos.AllowUserToAddRows = false;
            dtgProdutos.AllowUserToDeleteRows = false;
            dtgProdutos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(35, 35, 45);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dtgProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dtgProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProdutos.BackgroundColor = Color.FromArgb(30, 35, 45);
            dtgProdutos.BorderStyle = BorderStyle.None;
            dtgProdutos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(50, 50, 70);
            dataGridViewCellStyle7.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtgProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dtgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProdutos.EnableHeadersVisualStyles = false;
            dtgProdutos.GridColor = Color.FromArgb(60, 60, 80);
            dtgProdutos.Location = new Point(20, 79);
            dtgProdutos.MultiSelect = false;
            dtgProdutos.Name = "dtgProdutos";
            dtgProdutos.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle8.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dtgProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dtgProdutos.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle9.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dtgProdutos.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dtgProdutos.RowTemplate.Height = 26;
            dtgProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProdutos.Size = new Size(670, 265);
            dtgProdutos.TabIndex = 7;
            dtgProdutos.CellClick += dtgProdutos_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 45, 60);
            panel3.Location = new Point(-6, 322);
            panel3.Name = "panel3";
            panel3.Size = new Size(591, 24);
            panel3.TabIndex = 85;
            // 
            // frmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(1342, 735);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProduto";
            Text = "cadastroProduto";
            Load += frmProduto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCategoria).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCadastro;
        private Label lbMarca;
        private TextBox PrMarca;
        private Label lbNome;
        private TextBox PrNome;
        private Label lbDescricao;
        private TextBox PrDescricaoAtt;
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
        private Label astDescAtt;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dtgProdutos;
        private Label label14;
        private Label astPrecoAtt;
        private Label astmarcaAtt;
        private Label astNomeAtt;
        private Label lbPrecoAtt;
        private TextBox txtPrecoProd;
        private ComboBox cmbMedida;
        private Label lbMedidaAtt;
        private Label lbMarcaAtt;
        private TextBox txtMarcaProd;
        private Label lbNomeAtt;
        private TextBox txtNomeProd;
        private Label label1;
        private Label astDescricao;
        private Label astCatAtt;
        private ComboBox cmbCatAtt;
        private Label lbCatAtt;
        private Label lbDescAtt;
        private TextBox PrDescricao;
        private Button btnAttProd;
        private Button btnExcluirProd;
        private Label label15;
        private Label astUnidade;
        private Button btnCadCategoria;
        private Button btnExcluirCat;
        private Label label17;
        private Label label18;
        private TextBox txtCategoria;
        private DataGridView dtgCategoria;
        private Label label16;
        private Label label19;
        private Label astCod;
        private Label lbBarrasAtt;
        private TextBox PrCodigoBarra;
        private Button btnDesativarProd;
        private Label astBarrasAtt;
        private Label label23;
        private TextBox txtCodBarra;
        private Button btnAtivarProd;
        private Label astMedidaAtt;
        private Panel panel3;
    }
}