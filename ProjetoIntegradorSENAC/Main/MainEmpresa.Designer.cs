namespace ProjetoIntegradorSENAC
{
    partial class MainEmpresa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainEmpresa));
            panelLeft = new Panel();
            btnLogOut = new Button();
            panel4 = new Panel();
            btnMovimentacao = new Button();
            imageList1 = new ImageList(components);
            btnProdutos = new Button();
            btnFuncionario = new Button();
            btnLog = new Button();
            btnDashboard = new Button();
            btnCaixa = new Button();
            btnEstoque = new Button();
            label4 = new Label();
            txtNomeEmpresa = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panelTop2 = new Panel();
            txtNomeUser = new TextBox();
            labelCategorias = new Label();
            panelContainer = new Panel();
            bindingSource1 = new BindingSource(components);
            panelLeft.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTop2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(30, 30, 40);
            panelLeft.Controls.Add(btnLogOut);
            panelLeft.Controls.Add(panel4);
            panelLeft.Controls.Add(label4);
            panelLeft.Controls.Add(txtNomeEmpresa);
            panelLeft.Controls.Add(pictureBox1);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(291, 680);
            panelLeft.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogOut.BackColor = SystemColors.Highlight;
            btnLogOut.FlatStyle = FlatStyle.Popup;
            btnLogOut.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.FromArgb(224, 224, 224);
            btnLogOut.Location = new Point(12, 637);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(107, 35);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "Sair";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnMovimentacao);
            panel4.Controls.Add(btnProdutos);
            panel4.Controls.Add(btnFuncionario);
            panel4.Controls.Add(btnLog);
            panel4.Controls.Add(btnDashboard);
            panel4.Controls.Add(btnCaixa);
            panel4.Controls.Add(btnEstoque);
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(0, 173);
            panel4.Name = "panel4";
            panel4.Size = new Size(291, 450);
            panel4.TabIndex = 1;
            // 
            // btnMovimentacao
            // 
            btnMovimentacao.BackColor = Color.Transparent;
            btnMovimentacao.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 60);
            btnMovimentacao.FlatAppearance.BorderSize = 0;
            btnMovimentacao.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 60);
            btnMovimentacao.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 60);
            btnMovimentacao.FlatStyle = FlatStyle.Flat;
            btnMovimentacao.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMovimentacao.ForeColor = Color.FromArgb(224, 224, 224);
            btnMovimentacao.ImageAlign = ContentAlignment.MiddleLeft;
            btnMovimentacao.ImageIndex = 8;
            btnMovimentacao.ImageList = imageList1;
            btnMovimentacao.Location = new Point(12, 335);
            btnMovimentacao.Name = "btnMovimentacao";
            btnMovimentacao.Size = new Size(267, 52);
            btnMovimentacao.TabIndex = 9;
            btnMovimentacao.Text = "Movimentações";
            btnMovimentacao.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMovimentacao.UseVisualStyleBackColor = false;
            btnMovimentacao.Click += button2_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.Tag = "  ";
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, " log.png");
            imageList1.Images.SetKeyName(1, "ChatGPT Image 3 de out. de 2025, 20_09_11.png");
            imageList1.Images.SetKeyName(2, "ChatGPT Image 3 de out. de 2025, 20_12_11.png");
            imageList1.Images.SetKeyName(3, "ChatGPT Image 3 de out. de 2025, 20_14_35.png");
            imageList1.Images.SetKeyName(4, "ChatGPT Image 3 de out. de 2025, 20_18_28.png");
            imageList1.Images.SetKeyName(5, "ChatGPT Image 3 de out. de 2025, 20_20_42.png");
            imageList1.Images.SetKeyName(6, "ChatGPT Image 3 de out. de 2025, 20_22_52.png");
            imageList1.Images.SetKeyName(7, "ChatGPT Image 3 de out. de 2025, 20_27_40.png");
            imageList1.Images.SetKeyName(8, "ChatGPT Image 1 de mar. de 2026, 23_11_41.png");
            imageList1.Images.SetKeyName(9, "cadeado (1).png");
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.Transparent;
            btnProdutos.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 60);
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 60);
            btnProdutos.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 60);
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProdutos.ForeColor = Color.FromArgb(224, 224, 224);
            btnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutos.ImageIndex = 7;
            btnProdutos.ImageList = imageList1;
            btnProdutos.Location = new Point(12, 134);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(267, 56);
            btnProdutos.TabIndex = 2;
            btnProdutos.Text = "Produtos";
            btnProdutos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnFuncionario
            // 
            btnFuncionario.BackColor = Color.Transparent;
            btnFuncionario.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 60);
            btnFuncionario.FlatAppearance.BorderSize = 0;
            btnFuncionario.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 60);
            btnFuncionario.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 60);
            btnFuncionario.FlatStyle = FlatStyle.Flat;
            btnFuncionario.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFuncionario.ForeColor = Color.FromArgb(224, 224, 224);
            btnFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuncionario.ImageIndex = 4;
            btnFuncionario.ImageList = imageList1;
            btnFuncionario.Location = new Point(12, 262);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Size = new Size(267, 67);
            btnFuncionario.TabIndex = 3;
            btnFuncionario.Text = "Funcionário";
            btnFuncionario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFuncionario.UseVisualStyleBackColor = false;
            btnFuncionario.Click += btnFuncionario_Click;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.Transparent;
            btnLog.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 60);
            btnLog.FlatAppearance.BorderSize = 0;
            btnLog.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 60);
            btnLog.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 60);
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLog.ForeColor = Color.FromArgb(224, 224, 224);
            btnLog.ImageAlign = ContentAlignment.MiddleLeft;
            btnLog.ImageIndex = 0;
            btnLog.ImageList = imageList1;
            btnLog.Location = new Point(12, 393);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(267, 44);
            btnLog.TabIndex = 7;
            btnLog.Text = "Logs";
            btnLog.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 60);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 60);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 60);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(224, 224, 224);
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.ImageIndex = 1;
            btnDashboard.ImageList = imageList1;
            btnDashboard.Location = new Point(12, 73);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(267, 55);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnCaixa
            // 
            btnCaixa.BackColor = Color.Transparent;
            btnCaixa.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 60);
            btnCaixa.FlatAppearance.BorderSize = 0;
            btnCaixa.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 60);
            btnCaixa.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 60);
            btnCaixa.FlatStyle = FlatStyle.Flat;
            btnCaixa.Font = new Font("Franklin Gothic Medium", 15F);
            btnCaixa.ForeColor = Color.FromArgb(224, 224, 224);
            btnCaixa.ImageAlign = ContentAlignment.MiddleLeft;
            btnCaixa.ImageIndex = 2;
            btnCaixa.ImageList = imageList1;
            btnCaixa.Location = new Point(12, 13);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Size = new Size(267, 54);
            btnCaixa.TabIndex = 5;
            btnCaixa.Text = "Caixa";
            btnCaixa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCaixa.UseVisualStyleBackColor = false;
            btnCaixa.Click += btnCaixa_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.BackColor = Color.Transparent;
            btnEstoque.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 60);
            btnEstoque.FlatAppearance.BorderSize = 0;
            btnEstoque.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 60);
            btnEstoque.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 60);
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEstoque.ForeColor = Color.FromArgb(224, 224, 224);
            btnEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstoque.ImageIndex = 6;
            btnEstoque.ImageList = imageList1;
            btnEstoque.Location = new Point(12, 196);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(267, 60);
            btnEstoque.TabIndex = 4;
            btnEstoque.Text = "Estoque";
            btnEstoque.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEstoque.UseVisualStyleBackColor = false;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.System;
            label4.Font = new Font("Franklin Gothic Medium", 15F);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(191, 642);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 4;
            label4.Text = "Ajuda";
            // 
            // txtNomeEmpresa
            // 
            txtNomeEmpresa.BackColor = Color.FromArgb(30, 30, 40);
            txtNomeEmpresa.BorderStyle = BorderStyle.None;
            txtNomeEmpresa.Font = new Font("Franklin Gothic Demi", 15F);
            txtNomeEmpresa.ForeColor = Color.FromArgb(224, 224, 224);
            txtNomeEmpresa.Location = new Point(3, 138);
            txtNomeEmpresa.Name = "txtNomeEmpresa";
            txtNomeEmpresa.ReadOnly = true;
            txtNomeEmpresa.Size = new Size(280, 23);
            txtNomeEmpresa.TabIndex = 8;
            txtNomeEmpresa.Text = "Nome Empresa";
            txtNomeEmpresa.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(84, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Franklin Gothic Medium", 13F);
            button1.ForeColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(882, 0);
            button1.Name = "button1";
            button1.Size = new Size(107, 58);
            button1.TabIndex = 8;
            button1.Text = "IA ERPEX";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelTop2
            // 
            panelTop2.BackColor = Color.FromArgb(30, 30, 40);
            panelTop2.Controls.Add(button1);
            panelTop2.Controls.Add(txtNomeUser);
            panelTop2.Controls.Add(labelCategorias);
            panelTop2.Dock = DockStyle.Top;
            panelTop2.Location = new Point(291, 0);
            panelTop2.Name = "panelTop2";
            panelTop2.Size = new Size(989, 58);
            panelTop2.TabIndex = 1;
            // 
            // txtNomeUser
            // 
            txtNomeUser.BackColor = Color.FromArgb(30, 30, 40);
            txtNomeUser.BorderStyle = BorderStyle.None;
            txtNomeUser.Font = new Font("Franklin Gothic Demi", 18F);
            txtNomeUser.ForeColor = Color.FromArgb(224, 224, 224);
            txtNomeUser.Location = new Point(0, 13);
            txtNomeUser.Name = "txtNomeUser";
            txtNomeUser.ReadOnly = true;
            txtNomeUser.Size = new Size(331, 28);
            txtNomeUser.TabIndex = 9;
            txtNomeUser.Text = "Nome User";
            txtNomeUser.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCategorias
            // 
            labelCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCategorias.FlatStyle = FlatStyle.System;
            labelCategorias.Font = new Font("Franklin Gothic Medium", 15F);
            labelCategorias.ForeColor = Color.FromArgb(180, 180, 190);
            labelCategorias.Location = new Point(460, 17);
            labelCategorias.Name = "labelCategorias";
            labelCategorias.Size = new Size(104, 24);
            labelCategorias.TabIndex = 0;
            labelCategorias.Text = "Categorias";
            labelCategorias.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(45, 45, 60);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.ForeColor = Color.White;
            panelContainer.Location = new Point(291, 58);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(989, 622);
            panelContainer.TabIndex = 2;
            // 
            // MainEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 680);
            Controls.Add(panelContainer);
            Controls.Add(panelTop2);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MainEmpresa_Load;
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTop2.ResumeLayout(false);
            panelTop2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panel4;
        private Panel panelTop2;
        private Label labelCategorias;
        private Button btnProdutos;
        private Button btnFuncionario;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Button btnCaixa;
        private Button btnEstoque;
        private Label label4;
        private Button btnLogOut;
        private Button btnLog;
        private Panel panelContainer;
        private Button button1;
        private ImageList imageList1;
        private Button btnMovimentacao;
        private BindingSource bindingSource1;
        private TextBox txtNomeEmpresa;
        private TextBox txtNomeUser;
    }
}
