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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
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
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            PrDescricao = new TextBox();
            label14 = new Label();
            panel4 = new Panel();
            btnCadCategoria = new Button();
            btnExcluirCat = new Button();
            txtCategoria = new TextBox();
            dtgCategoria = new DataGridView();
            label15 = new Label();
            label18 = new Label();
            panel6 = new Panel();
            removePic = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            PrCodigoBarra = new TextBox();
            label23 = new Label();
            txtPrecoCusto = new TextBox();
            label3 = new Label();
            lbBarrasAtt = new Label();
            cmbCatAtt = new ComboBox();
            lbCatAtt = new Label();
            lbDescAtt = new Label();
            panel2 = new Panel();
            label16 = new Label();
            label1 = new Label();
            dtgProdutos = new DataGridView();
            panel3 = new Panel();
            txtCodBarra = new TextBox();
            btnAttProd = new Button();
            label5 = new Label();
            txtPrecoProd = new TextBox();
            textBox1 = new TextBox();
            lbPrecoAtt = new Label();
            cmbMedida = new ComboBox();
            lbMedidaAtt = new Label();
            btnExcluirProd = new Button();
            txtMarcaProd = new TextBox();
            lbMarcaAtt = new Label();
            lbNomeAtt = new Label();
            txtNomeProd = new TextBox();
            btnDesativarProd = new Button();
            btnAtivarProd = new Button();
            mainLayout = new TableLayoutPanel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCategoria).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).BeginInit();
            panel3.SuspendLayout();
            mainLayout.SuspendLayout();
            SuspendLayout();
            // 
            // btnCadastro
            // 
            btnCadastro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCadastro.BackColor = SystemColors.Highlight;
            btnCadastro.Cursor = Cursors.Hand;
            btnCadastro.FlatStyle = FlatStyle.Popup;
            btnCadastro.Font = new Font("Franklin Gothic Medium", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastro.ForeColor = Color.White;
            btnCadastro.Location = new Point(127, 749);
            btnCadastro.Margin = new Padding(3, 4, 3, 4);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(269, 45);
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
            lbMarca.Location = new Point(3, -4);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new Size(166, 25);
            lbMarca.TabIndex = 40;
            lbMarca.Text = "Marca do produto";
            // 
            // PrMarca
            // 
            PrMarca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PrMarca.BackColor = Color.FromArgb(224, 224, 224);
            PrMarca.Font = new Font("Microsoft Sans Serif", 12F);
            PrMarca.Location = new Point(3, 28);
            PrMarca.Margin = new Padding(3, 4, 3, 4);
            PrMarca.Name = "PrMarca";
            PrMarca.PlaceholderText = "Digite a marca do produto";
            PrMarca.Size = new Size(239, 30);
            PrMarca.TabIndex = 39;
            PrMarca.TextChanged += PrMarca_TextChanged;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Franklin Gothic Medium", 12F);
            lbNome.ForeColor = Color.FromArgb(180, 180, 190);
            lbNome.Location = new Point(19, 427);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(163, 25);
            lbNome.TabIndex = 32;
            lbNome.Text = "Nome do produto";
            // 
            // PrNome
            // 
            PrNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PrNome.BackColor = Color.FromArgb(224, 224, 224);
            PrNome.Font = new Font("Microsoft Sans Serif", 12F);
            PrNome.Location = new Point(19, 459);
            PrNome.Margin = new Padding(3, 4, 3, 4);
            PrNome.Name = "PrNome";
            PrNome.PlaceholderText = "Digite o nome do produto";
            PrNome.Size = new Size(239, 30);
            PrNome.TabIndex = 31;
            PrNome.TextChanged += PrNome_TextChanged;
            // 
            // lbDescricao
            // 
            lbDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbDescricao.AutoSize = true;
            lbDescricao.Font = new Font("Franklin Gothic Medium", 12F);
            lbDescricao.ForeColor = Color.FromArgb(180, 180, 190);
            lbDescricao.Location = new Point(275, 427);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(96, 25);
            lbDescricao.TabIndex = 50;
            lbDescricao.Text = "Descrição";
            // 
            // PrDescricaoAtt
            // 
            PrDescricaoAtt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PrDescricaoAtt.BackColor = Color.FromArgb(224, 224, 224);
            PrDescricaoAtt.Font = new Font("Microsoft Sans Serif", 12F);
            PrDescricaoAtt.Location = new Point(275, 33);
            PrDescricaoAtt.Margin = new Padding(3, 4, 3, 4);
            PrDescricaoAtt.Multiline = true;
            PrDescricaoAtt.Name = "PrDescricaoAtt";
            PrDescricaoAtt.PlaceholderText = "Digite a descrição do produto";
            PrDescricaoAtt.Size = new Size(281, 37);
            PrDescricaoAtt.TabIndex = 49;
            PrDescricaoAtt.TextChanged += PrDescricao_TextChanged;
            // 
            // lbUnidade
            // 
            lbUnidade.AutoSize = true;
            lbUnidade.Font = new Font("Franklin Gothic Medium", 12F);
            lbUnidade.ForeColor = Color.FromArgb(180, 180, 190);
            lbUnidade.Location = new Point(3, 75);
            lbUnidade.Name = "lbUnidade";
            lbUnidade.Size = new Size(179, 25);
            lbUnidade.TabIndex = 51;
            lbUnidade.Text = "Unidade de medida";
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Font = new Font("Franklin Gothic Medium", 12F);
            lbCategoria.ForeColor = Color.FromArgb(180, 180, 190);
            lbCategoria.Location = new Point(3, 153);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(95, 25);
            lbCategoria.TabIndex = 53;
            lbCategoria.Text = "Categoria";
            // 
            // CmbCategoria
            // 
            CmbCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CmbCategoria.BackColor = Color.FromArgb(224, 224, 224);
            CmbCategoria.Font = new Font("Microsoft Sans Serif", 12F);
            CmbCategoria.FormattingEnabled = true;
            CmbCategoria.Location = new Point(3, 183);
            CmbCategoria.Margin = new Padding(3, 4, 3, 4);
            CmbCategoria.Name = "CmbCategoria";
            CmbCategoria.Size = new Size(239, 33);
            CmbCategoria.TabIndex = 54;
            CmbCategoria.SelectedIndexChanged += CmbCategoria_SelectedIndexChanged;
            // 
            // CmbUnidade
            // 
            CmbUnidade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CmbUnidade.AutoCompleteCustomSource.AddRange(new string[] { "Unidade", "Grama" });
            CmbUnidade.BackColor = Color.FromArgb(224, 224, 224);
            CmbUnidade.Font = new Font("Microsoft Sans Serif", 12F);
            CmbUnidade.FormattingEnabled = true;
            CmbUnidade.Items.AddRange(new object[] { "Unidade", "Caixa", "Pacote", "Kg", "Gramas", "Litros", "Ml", "Dúzia", "Fardo", "Kit" });
            CmbUnidade.Location = new Point(0, 107);
            CmbUnidade.Margin = new Padding(3, 4, 3, 4);
            CmbUnidade.Name = "CmbUnidade";
            CmbUnidade.Size = new Size(239, 33);
            CmbUnidade.TabIndex = 55;
            CmbUnidade.SelectedIndexChanged += CmbUnidade_SelectedIndexChanged;
            // 
            // lbPreco
            // 
            lbPreco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbPreco.AutoSize = true;
            lbPreco.Font = new Font("Franklin Gothic Medium", 12F);
            lbPreco.ForeColor = Color.FromArgb(180, 180, 190);
            lbPreco.Location = new Point(258, 71);
            lbPreco.Name = "lbPreco";
            lbPreco.Size = new Size(162, 25);
            lbPreco.TabIndex = 57;
            lbPreco.Text = "Preço do Produto";
            // 
            // PrPreco
            // 
            PrPreco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PrPreco.BackColor = Color.FromArgb(224, 224, 224);
            PrPreco.Font = new Font("Microsoft Sans Serif", 12F);
            PrPreco.Location = new Point(258, 107);
            PrPreco.Margin = new Padding(3, 4, 3, 4);
            PrPreco.Name = "PrPreco";
            PrPreco.PlaceholderText = "digite o preço do produto";
            PrPreco.Size = new Size(231, 30);
            PrPreco.TabIndex = 56;
            PrPreco.TextChanged += PrPreco_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 45);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(PrDescricao);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(btnCadastro);
            panel1.Controls.Add(lbDescricao);
            panel1.Controls.Add(lbNome);
            panel1.Controls.Add(PrNome);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(0, 0, 5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 809);
            panel1.TabIndex = 63;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Franklin Gothic Medium", 14F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(418, 750);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(89, 43);
            button1.TabIndex = 90;
            button1.Text = "→";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Franklin Gothic Medium", 14F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(19, 750);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(89, 43);
            button2.TabIndex = 89;
            button2.Text = "←";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // PrDescricao
            // 
            PrDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PrDescricao.BackColor = Color.FromArgb(224, 224, 224);
            PrDescricao.Font = new Font("Microsoft Sans Serif", 12F);
            PrDescricao.Location = new Point(277, 459);
            PrDescricao.Margin = new Padding(3, 4, 3, 4);
            PrDescricao.Multiline = true;
            PrDescricao.Name = "PrDescricao";
            PrDescricao.PlaceholderText = "Descrição do produto";
            PrDescricao.Size = new Size(228, 33);
            PrDescricao.TabIndex = 64;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.Font = new Font("Franklin Gothic Medium", 16F);
            label14.ForeColor = Color.FromArgb(180, 180, 190);
            label14.Location = new Point(94, 380);
            label14.Name = "label14";
            label14.Size = new Size(331, 34);
            label14.TabIndex = 63;
            label14.Text = "Cadastre aqui um Produto!";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnCadCategoria);
            panel4.Controls.Add(btnExcluirCat);
            panel4.Controls.Add(txtCategoria);
            panel4.Controls.Add(dtgCategoria);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label18);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(531, 376);
            panel4.TabIndex = 87;
            // 
            // btnCadCategoria
            // 
            btnCadCategoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCadCategoria.BackColor = SystemColors.Highlight;
            btnCadCategoria.Cursor = Cursors.Hand;
            btnCadCategoria.FlatStyle = FlatStyle.Popup;
            btnCadCategoria.Font = new Font("Franklin Gothic Medium", 13F);
            btnCadCategoria.ForeColor = Color.White;
            btnCadCategoria.Location = new Point(264, 308);
            btnCadCategoria.Margin = new Padding(3, 4, 3, 4);
            btnCadCategoria.Name = "btnCadCategoria";
            btnCadCategoria.Size = new Size(242, 41);
            btnCadCategoria.TabIndex = 77;
            btnCadCategoria.Text = "Cadastrar categoria";
            btnCadCategoria.UseVisualStyleBackColor = false;
            btnCadCategoria.Click += btnCadCategoria_Click;
            // 
            // btnExcluirCat
            // 
            btnExcluirCat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExcluirCat.BackColor = Color.Transparent;
            btnExcluirCat.FlatStyle = FlatStyle.Popup;
            btnExcluirCat.Font = new Font("Franklin Gothic Medium", 13F);
            btnExcluirCat.ForeColor = Color.Maroon;
            btnExcluirCat.Location = new Point(16, 308);
            btnExcluirCat.Margin = new Padding(3, 4, 3, 4);
            btnExcluirCat.Name = "btnExcluirCat";
            btnExcluirCat.Size = new Size(225, 41);
            btnExcluirCat.TabIndex = 76;
            btnExcluirCat.Text = "Excluir Categoria";
            btnExcluirCat.UseVisualStyleBackColor = false;
            btnExcluirCat.Click += btnExcluirCat_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCategoria.BackColor = Color.FromArgb(224, 224, 224);
            txtCategoria.Font = new Font("Microsoft Sans Serif", 12.25F);
            txtCategoria.Location = new Point(17, 263);
            txtCategoria.Margin = new Padding(3, 4, 3, 4);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.PlaceholderText = "Digite o nome do produto";
            txtCategoria.Size = new Size(489, 31);
            txtCategoria.TabIndex = 73;
            // 
            // dtgCategoria
            // 
            dtgCategoria.AllowUserToAddRows = false;
            dtgCategoria.AllowUserToDeleteRows = false;
            dtgCategoria.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 35, 45);
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dtgCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Medium", 13.8F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgCategoria.DefaultCellStyle = dataGridViewCellStyle3;
            dtgCategoria.EnableHeadersVisualStyles = false;
            dtgCategoria.GridColor = Color.FromArgb(60, 60, 80);
            dtgCategoria.Location = new Point(19, 52);
            dtgCategoria.Margin = new Padding(3, 4, 3, 4);
            dtgCategoria.MultiSelect = false;
            dtgCategoria.Name = "dtgCategoria";
            dtgCategoria.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle4.Font = new Font("Franklin Gothic Medium", 13.8F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgCategoria.RowHeadersVisible = false;
            dtgCategoria.RowHeadersWidth = 70;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle5.Font = new Font("Franklin Gothic Medium", 13.8F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dtgCategoria.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dtgCategoria.RowTemplate.Height = 35;
            dtgCategoria.ScrollBars = ScrollBars.Vertical;
            dtgCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCategoria.Size = new Size(490, 175);
            dtgCategoria.TabIndex = 72;
            dtgCategoria.CellClick += dtgCategoria_CellClick;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.Font = new Font("Franklin Gothic Medium", 15F);
            label15.ForeColor = Color.FromArgb(180, 180, 190);
            label15.Location = new Point(82, 15);
            label15.Name = "label15";
            label15.Size = new Size(391, 32);
            label15.TabIndex = 71;
            label15.Text = "Cadastre aqui uma nova Categoria!";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Franklin Gothic Medium", 12F);
            label18.ForeColor = Color.FromArgb(180, 180, 190);
            label18.Location = new Point(17, 231);
            label18.Name = "label18";
            label18.Size = new Size(184, 25);
            label18.TabIndex = 74;
            label18.Text = "Nome da Categoria!";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.Controls.Add(removePic);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(pictureBox1);
            panel6.Location = new Point(16, 497);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(490, 229);
            panel6.TabIndex = 87;
            panel6.Visible = false;
            // 
            // removePic
            // 
            removePic.AutoSize = true;
            removePic.Cursor = Cursors.Hand;
            removePic.Font = new Font("Franklin Gothic Medium", 12F);
            removePic.ForeColor = Color.DarkRed;
            removePic.Location = new Point(157, 91);
            removePic.Name = "removePic";
            removePic.Size = new Size(132, 25);
            removePic.TabIndex = 79;
            removePic.Text = "Remover Foto";
            removePic.Click += removePic_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 15F);
            label2.ForeColor = Color.FromArgb(180, 180, 190);
            label2.Location = new Point(157, 45);
            label2.Name = "label2";
            label2.Size = new Size(338, 32);
            label2.TabIndex = 78;
            label2.Text = "Adicione a foto do seu Produto";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(45, 45, 60);
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(18, 40);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(PrCodigoBarra);
            panel5.Controls.Add(label23);
            panel5.Controls.Add(txtPrecoCusto);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(lbUnidade);
            panel5.Controls.Add(CmbCategoria);
            panel5.Controls.Add(lbCategoria);
            panel5.Controls.Add(CmbUnidade);
            panel5.Controls.Add(lbPreco);
            panel5.Controls.Add(PrPreco);
            panel5.Controls.Add(PrMarca);
            panel5.Controls.Add(lbMarca);
            panel5.Location = new Point(16, 501);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(493, 224);
            panel5.TabIndex = 88;
            // 
            // PrCodigoBarra
            // 
            PrCodigoBarra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PrCodigoBarra.BackColor = Color.FromArgb(224, 224, 224);
            PrCodigoBarra.Font = new Font("Microsoft Sans Serif", 12F);
            PrCodigoBarra.Location = new Point(258, 183);
            PrCodigoBarra.Margin = new Padding(3, 4, 3, 4);
            PrCodigoBarra.Name = "PrCodigoBarra";
            PrCodigoBarra.PlaceholderText = "Digite o codigo do produto";
            PrCodigoBarra.Size = new Size(231, 30);
            PrCodigoBarra.TabIndex = 79;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label23.AutoSize = true;
            label23.Font = new Font("Franklin Gothic Medium", 12F);
            label23.ForeColor = Color.FromArgb(180, 180, 190);
            label23.Location = new Point(258, 153);
            label23.Name = "label23";
            label23.Size = new Size(160, 25);
            label23.TabIndex = 84;
            label23.Text = "Codigo de Barras";
            // 
            // txtPrecoCusto
            // 
            txtPrecoCusto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPrecoCusto.BackColor = Color.FromArgb(224, 224, 224);
            txtPrecoCusto.Font = new Font("Microsoft Sans Serif", 12F);
            txtPrecoCusto.Location = new Point(258, 28);
            txtPrecoCusto.Margin = new Padding(3, 4, 3, 4);
            txtPrecoCusto.Name = "txtPrecoCusto";
            txtPrecoCusto.PlaceholderText = "Digite o preço de custo";
            txtPrecoCusto.Size = new Size(231, 30);
            txtPrecoCusto.TabIndex = 85;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 12F);
            label3.ForeColor = Color.FromArgb(180, 180, 190);
            label3.Location = new Point(258, -4);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 86;
            label3.Text = "Preço De Custo";
            // 
            // lbBarrasAtt
            // 
            lbBarrasAtt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbBarrasAtt.AutoSize = true;
            lbBarrasAtt.Font = new Font("Franklin Gothic Medium", 12F);
            lbBarrasAtt.ForeColor = Color.FromArgb(180, 180, 190);
            lbBarrasAtt.Location = new Point(275, 159);
            lbBarrasAtt.Name = "lbBarrasAtt";
            lbBarrasAtt.Size = new Size(160, 25);
            lbBarrasAtt.TabIndex = 80;
            lbBarrasAtt.Text = "Codigo de Barras";
            // 
            // cmbCatAtt
            // 
            cmbCatAtt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbCatAtt.BackColor = Color.FromArgb(224, 224, 224);
            cmbCatAtt.Font = new Font("Microsoft Sans Serif", 12F);
            cmbCatAtt.FormattingEnabled = true;
            cmbCatAtt.Location = new Point(275, 272);
            cmbCatAtt.Margin = new Padding(3, 4, 3, 4);
            cmbCatAtt.Name = "cmbCatAtt";
            cmbCatAtt.Size = new Size(281, 33);
            cmbCatAtt.TabIndex = 67;
            // 
            // lbCatAtt
            // 
            lbCatAtt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbCatAtt.AutoSize = true;
            lbCatAtt.Font = new Font("Franklin Gothic Medium", 12F);
            lbCatAtt.ForeColor = Color.FromArgb(180, 180, 190);
            lbCatAtt.Location = new Point(275, 243);
            lbCatAtt.Name = "lbCatAtt";
            lbCatAtt.Size = new Size(95, 25);
            lbCatAtt.TabIndex = 66;
            lbCatAtt.Text = "Categoria";
            // 
            // lbDescAtt
            // 
            lbDescAtt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbDescAtt.AutoSize = true;
            lbDescAtt.Font = new Font("Franklin Gothic Medium", 12F);
            lbDescAtt.ForeColor = Color.FromArgb(180, 180, 190);
            lbDescAtt.Location = new Point(275, 4);
            lbDescAtt.Name = "lbDescAtt";
            lbDescAtt.Size = new Size(96, 25);
            lbDescAtt.TabIndex = 65;
            lbDescAtt.Text = "Descrição";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 45);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dtgProdutos);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(551, 10);
            panel2.Margin = new Padding(5, 0, 0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(569, 809);
            panel2.TabIndex = 64;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Franklin Gothic Medium", 10F);
            label16.ForeColor = Color.FromArgb(180, 180, 190);
            label16.Location = new Point(24, 80);
            label16.Name = "label16";
            label16.Size = new Size(191, 21);
            label16.TabIndex = 75;
            label16.Text = "Clique em algum produto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 12F);
            label1.ForeColor = Color.FromArgb(180, 180, 190);
            label1.Location = new Point(45, 28);
            label1.Name = "label1";
            label1.Size = new Size(521, 25);
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
            dtgProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Franklin Gothic Medium", 12F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dtgProdutos.DefaultCellStyle = dataGridViewCellStyle8;
            dtgProdutos.EnableHeadersVisualStyles = false;
            dtgProdutos.GridColor = Color.FromArgb(60, 60, 80);
            dtgProdutos.Location = new Point(18, 127);
            dtgProdutos.Margin = new Padding(3, 4, 3, 4);
            dtgProdutos.MultiSelect = false;
            dtgProdutos.Name = "dtgProdutos";
            dtgProdutos.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle9.Font = new Font("Franklin Gothic Medium", 12F);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dtgProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dtgProdutos.RowHeadersVisible = false;
            dtgProdutos.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle10.Font = new Font("Franklin Gothic Medium", 12F);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dtgProdutos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dtgProdutos.RowTemplate.Height = 26;
            dtgProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProdutos.Size = new Size(538, 254);
            dtgProdutos.TabIndex = 7;
            dtgProdutos.CellClick += dtgProdutos_CellClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtCodBarra);
            panel3.Controls.Add(btnAttProd);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(cmbCatAtt);
            panel3.Controls.Add(lbBarrasAtt);
            panel3.Controls.Add(lbCatAtt);
            panel3.Controls.Add(txtPrecoProd);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(lbPrecoAtt);
            panel3.Controls.Add(cmbMedida);
            panel3.Controls.Add(lbMedidaAtt);
            panel3.Controls.Add(btnExcluirProd);
            panel3.Controls.Add(txtMarcaProd);
            panel3.Controls.Add(lbMarcaAtt);
            panel3.Controls.Add(lbNomeAtt);
            panel3.Controls.Add(txtNomeProd);
            panel3.Controls.Add(PrDescricaoAtt);
            panel3.Controls.Add(lbDescAtt);
            panel3.Controls.Add(btnDesativarProd);
            panel3.Controls.Add(btnAtivarProd);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 389);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(569, 420);
            panel3.TabIndex = 92;
            // 
            // txtCodBarra
            // 
            txtCodBarra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCodBarra.BackColor = Color.FromArgb(224, 224, 224);
            txtCodBarra.Font = new Font("Microsoft Sans Serif", 12F);
            txtCodBarra.Location = new Point(275, 193);
            txtCodBarra.Margin = new Padding(3, 4, 3, 4);
            txtCodBarra.Name = "txtCodBarra";
            txtCodBarra.PlaceholderText = "Digite o codigo do produto";
            txtCodBarra.Size = new Size(281, 30);
            txtCodBarra.TabIndex = 83;
            // 
            // btnAttProd
            // 
            btnAttProd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAttProd.BackColor = SystemColors.Highlight;
            btnAttProd.Cursor = Cursors.Hand;
            btnAttProd.FlatStyle = FlatStyle.Popup;
            btnAttProd.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAttProd.ForeColor = Color.White;
            btnAttProd.Location = new Point(275, 351);
            btnAttProd.Margin = new Padding(3, 4, 3, 4);
            btnAttProd.Name = "btnAttProd";
            btnAttProd.Size = new Size(278, 37);
            btnAttProd.TabIndex = 73;
            btnAttProd.Text = "Atualizar Produto";
            btnAttProd.UseVisualStyleBackColor = false;
            btnAttProd.Click += btnAttProd_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 12F);
            label5.ForeColor = Color.FromArgb(180, 180, 190);
            label5.Location = new Point(275, 84);
            label5.Name = "label5";
            label5.Size = new Size(143, 25);
            label5.TabIndex = 90;
            label5.Text = "Preço De Custo";
            // 
            // txtPrecoProd
            // 
            txtPrecoProd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrecoProd.BackColor = Color.FromArgb(224, 224, 224);
            txtPrecoProd.Font = new Font("Microsoft Sans Serif", 12F);
            txtPrecoProd.Location = new Point(6, 274);
            txtPrecoProd.Margin = new Padding(3, 4, 3, 4);
            txtPrecoProd.Name = "txtPrecoProd";
            txtPrecoProd.PlaceholderText = "digite o preço do produto";
            txtPrecoProd.Size = new Size(256, 30);
            txtPrecoProd.TabIndex = 68;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Font = new Font("Microsoft Sans Serif", 12F);
            textBox1.Location = new Point(275, 120);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite o preço de custo";
            textBox1.Size = new Size(277, 30);
            textBox1.TabIndex = 89;
            // 
            // lbPrecoAtt
            // 
            lbPrecoAtt.AutoSize = true;
            lbPrecoAtt.Font = new Font("Franklin Gothic Medium", 12F);
            lbPrecoAtt.ForeColor = Color.FromArgb(180, 180, 190);
            lbPrecoAtt.Location = new Point(3, 243);
            lbPrecoAtt.Name = "lbPrecoAtt";
            lbPrecoAtt.Size = new Size(170, 25);
            lbPrecoAtt.TabIndex = 69;
            lbPrecoAtt.Text = "Preço por unidade";
            // 
            // cmbMedida
            // 
            cmbMedida.AutoCompleteCustomSource.AddRange(new string[] { "Unidade", "Grama" });
            cmbMedida.BackColor = Color.FromArgb(224, 224, 224);
            cmbMedida.Font = new Font("Microsoft Sans Serif", 12F);
            cmbMedida.FormattingEnabled = true;
            cmbMedida.Items.AddRange(new object[] { "Unidade", "Caixa", "Pacote", "Kg", "Gramas", "Litros", "Ml", "Dúzia", "Fardo", "Kit" });
            cmbMedida.Location = new Point(6, 190);
            cmbMedida.Margin = new Padding(3, 4, 3, 4);
            cmbMedida.Name = "cmbMedida";
            cmbMedida.Size = new Size(254, 33);
            cmbMedida.TabIndex = 67;
            // 
            // lbMedidaAtt
            // 
            lbMedidaAtt.AutoSize = true;
            lbMedidaAtt.Font = new Font("Franklin Gothic Medium", 12F);
            lbMedidaAtt.ForeColor = Color.FromArgb(180, 180, 190);
            lbMedidaAtt.Location = new Point(3, 157);
            lbMedidaAtt.Name = "lbMedidaAtt";
            lbMedidaAtt.Size = new Size(179, 25);
            lbMedidaAtt.TabIndex = 66;
            lbMedidaAtt.Text = "Unidade de medida";
            // 
            // btnExcluirProd
            // 
            btnExcluirProd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExcluirProd.BackColor = Color.Transparent;
            btnExcluirProd.FlatStyle = FlatStyle.Popup;
            btnExcluirProd.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluirProd.ForeColor = Color.Maroon;
            btnExcluirProd.Location = new Point(5, 351);
            btnExcluirProd.Margin = new Padding(3, 4, 3, 4);
            btnExcluirProd.Name = "btnExcluirProd";
            btnExcluirProd.Size = new Size(122, 37);
            btnExcluirProd.TabIndex = 74;
            btnExcluirProd.Text = "Excluir Produto";
            btnExcluirProd.UseVisualStyleBackColor = false;
            btnExcluirProd.Click += btnExcluirProd_Click;
            // 
            // txtMarcaProd
            // 
            txtMarcaProd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMarcaProd.BackColor = Color.FromArgb(224, 224, 224);
            txtMarcaProd.Font = new Font("Microsoft Sans Serif", 12F);
            txtMarcaProd.Location = new Point(6, 117);
            txtMarcaProd.Margin = new Padding(3, 4, 3, 4);
            txtMarcaProd.Name = "txtMarcaProd";
            txtMarcaProd.PlaceholderText = "Digite a marca do produto";
            txtMarcaProd.Size = new Size(256, 30);
            txtMarcaProd.TabIndex = 64;
            // 
            // lbMarcaAtt
            // 
            lbMarcaAtt.AutoSize = true;
            lbMarcaAtt.Font = new Font("Franklin Gothic Medium", 12F);
            lbMarcaAtt.ForeColor = Color.FromArgb(180, 180, 190);
            lbMarcaAtt.Location = new Point(6, 80);
            lbMarcaAtt.Name = "lbMarcaAtt";
            lbMarcaAtt.Size = new Size(166, 25);
            lbMarcaAtt.TabIndex = 65;
            lbMarcaAtt.Text = "Marca do produto";
            // 
            // lbNomeAtt
            // 
            lbNomeAtt.AutoSize = true;
            lbNomeAtt.Font = new Font("Franklin Gothic Medium", 12F);
            lbNomeAtt.ForeColor = Color.FromArgb(180, 180, 190);
            lbNomeAtt.Location = new Point(3, 5);
            lbNomeAtt.Name = "lbNomeAtt";
            lbNomeAtt.Size = new Size(163, 25);
            lbNomeAtt.TabIndex = 63;
            lbNomeAtt.Text = "Nome do produto";
            // 
            // txtNomeProd
            // 
            txtNomeProd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeProd.BackColor = Color.FromArgb(224, 224, 224);
            txtNomeProd.Font = new Font("Microsoft Sans Serif", 12F);
            txtNomeProd.Location = new Point(6, 34);
            txtNomeProd.Margin = new Padding(3, 4, 3, 4);
            txtNomeProd.Name = "txtNomeProd";
            txtNomeProd.PlaceholderText = "Digite o nome do produto";
            txtNomeProd.Size = new Size(256, 30);
            txtNomeProd.TabIndex = 62;
            // 
            // btnDesativarProd
            // 
            btnDesativarProd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDesativarProd.BackColor = Color.Transparent;
            btnDesativarProd.FlatStyle = FlatStyle.Popup;
            btnDesativarProd.Font = new Font("Franklin Gothic Medium", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDesativarProd.ForeColor = Color.Maroon;
            btnDesativarProd.Location = new Point(129, 351);
            btnDesativarProd.Margin = new Padding(3, 4, 3, 4);
            btnDesativarProd.Name = "btnDesativarProd";
            btnDesativarProd.Size = new Size(126, 37);
            btnDesativarProd.TabIndex = 86;
            btnDesativarProd.Text = "Desativar Produto";
            btnDesativarProd.UseVisualStyleBackColor = false;
            btnDesativarProd.Click += btnDesativarProd_Click;
            // 
            // btnAtivarProd
            // 
            btnAtivarProd.BackColor = Color.Transparent;
            btnAtivarProd.FlatStyle = FlatStyle.Popup;
            btnAtivarProd.Font = new Font("Franklin Gothic Medium", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtivarProd.ForeColor = Color.DarkSeaGreen;
            btnAtivarProd.Location = new Point(129, 352);
            btnAtivarProd.Margin = new Padding(3, 4, 3, 4);
            btnAtivarProd.Name = "btnAtivarProd";
            btnAtivarProd.Size = new Size(126, 36);
            btnAtivarProd.TabIndex = 87;
            btnAtivarProd.Text = "Ativar Produto";
            btnAtivarProd.UseVisualStyleBackColor = false;
            btnAtivarProd.Visible = false;
            btnAtivarProd.Click += btnAtivarProd_Click;
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.FromArgb(45, 45, 60);
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.2972145F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.7027855F));
            mainLayout.Controls.Add(panel2, 1, 0);
            mainLayout.Controls.Add(panel1, 0, 0);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Margin = new Padding(3, 4, 3, 4);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(10);
            mainLayout.RowCount = 1;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(1130, 829);
            mainLayout.TabIndex = 92;
            // 
            // frmProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(1130, 829);
            Controls.Add(mainLayout);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmProduto";
            Text = "cadastroProduto";
            Load += frmProduto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCategoria).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            mainLayout.ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;
        private DataGridView dtgProdutos;
        private Label label14;
        private Label lbPrecoAtt;
        private TextBox txtPrecoProd;
        private ComboBox cmbMedida;
        private Label lbMedidaAtt;
        private Label lbMarcaAtt;
        private TextBox txtMarcaProd;
        private Label lbNomeAtt;
        private TextBox txtNomeProd;
        private Label label1;
        private ComboBox cmbCatAtt;
        private Label lbCatAtt;
        private Label lbDescAtt;
        private TextBox PrDescricao;
        private Button btnAttProd;
        private Button btnExcluirProd;
        private Label label15;
        private Button btnCadCategoria;
        private Button btnExcluirCat;
        private Label label18;
        private TextBox txtCategoria;
        private DataGridView dtgCategoria;
        private Label label16;
        private Label lbBarrasAtt;
        private TextBox PrCodigoBarra;
        private Button btnDesativarProd;
        private Label label23;
        private TextBox txtCodBarra;
        private Button btnAtivarProd;
        private Label label3;
        private TextBox txtPrecoCusto;
        private Label label5;
        private TextBox textBox1;
        private TableLayoutPanel mainLayout;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button button2;
        private Button button1;
        private Panel panel6;
        private Label label2;
        private PictureBox pictureBox1;
        private Label removePic;
    }
}