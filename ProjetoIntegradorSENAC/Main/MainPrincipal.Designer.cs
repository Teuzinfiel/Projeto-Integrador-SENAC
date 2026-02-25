namespace ProjetoIntegradorSENAC
{
    partial class MainPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPrincipal));
            panel1 = new Panel();
            label4 = new Label();
            btnLogOut = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            btnMovimentacao = new Button();
            imageList1 = new ImageList(components);
            button1 = new Button();
            btnProdutos = new Button();
            btnFuncionario = new Button();
            btnLog = new Button();
            btnDashboard = new Button();
            btnCaixa = new Button();
            btnEstoque = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            labelCategorias = new Label();
            panel5 = new Panel();
            btnMinimizar = new Button();
            btnSair = new Button();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 40);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(-3, 43);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 1040);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.System;
            label4.Font = new Font("Franklin Gothic Medium", 15F);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(214, 979);
            label4.Name = "label4";
            label4.Size = new Size(75, 32);
            label4.TabIndex = 4;
            label4.Text = "Ajuda";
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = SystemColors.Highlight;
            btnLogOut.FlatStyle = FlatStyle.Popup;
            btnLogOut.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.FromArgb(224, 224, 224);
            btnLogOut.Location = new Point(40, 972);
            btnLogOut.Margin = new Padding(3, 4, 3, 4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(122, 47);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "Sair";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Microsoft Sans Serif", 15F);
            label3.ForeColor = Color.FromArgb(180, 180, 190);
            label3.Location = new Point(74, 263);
            label3.Name = "label3";
            label3.Size = new Size(190, 29);
            label3.TabIndex = 3;
            label3.Text = "Nome Empresa";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(74, 73);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnMovimentacao);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(btnProdutos);
            panel4.Controls.Add(btnFuncionario);
            panel4.Controls.Add(btnLog);
            panel4.Controls.Add(btnDashboard);
            panel4.Controls.Add(btnCaixa);
            panel4.Controls.Add(btnEstoque);
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(3, 312);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(336, 651);
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
            btnMovimentacao.ImageIndex = 4;
            btnMovimentacao.ImageList = imageList1;
            btnMovimentacao.Location = new Point(32, 461);
            btnMovimentacao.Margin = new Padding(3, 4, 3, 4);
            btnMovimentacao.Name = "btnMovimentacao";
            btnMovimentacao.Size = new Size(297, 75);
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
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(31, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(281, 63);
            button1.TabIndex = 8;
            button1.Text = "Configuracoes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            btnProdutos.Location = new Point(32, 225);
            btnProdutos.Margin = new Padding(3, 4, 3, 4);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(297, 77);
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
            btnFuncionario.Location = new Point(32, 379);
            btnFuncionario.Margin = new Padding(3, 4, 3, 4);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Size = new Size(297, 75);
            btnFuncionario.TabIndex = 3;
            btnFuncionario.Text = "Funcionario";
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
            btnLog.Location = new Point(32, 544);
            btnLog.Margin = new Padding(3, 4, 3, 4);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(297, 72);
            btnLog.TabIndex = 7;
            btnLog.Text = "Alteracoes";
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
            btnDashboard.Location = new Point(31, 155);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(297, 73);
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
            btnCaixa.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCaixa.ForeColor = Color.FromArgb(224, 224, 224);
            btnCaixa.ImageAlign = ContentAlignment.MiddleLeft;
            btnCaixa.ImageIndex = 2;
            btnCaixa.ImageList = imageList1;
            btnCaixa.Location = new Point(31, 84);
            btnCaixa.Margin = new Padding(3, 4, 3, 4);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Size = new Size(297, 72);
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
            btnEstoque.Location = new Point(32, 311);
            btnEstoque.Margin = new Padding(3, 4, 3, 4);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(297, 72);
            btnEstoque.TabIndex = 4;
            btnEstoque.Text = "Estoque";
            btnEstoque.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEstoque.UseVisualStyleBackColor = false;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 40);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(labelCategorias);
            panel2.Location = new Point(328, 43);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1537, 77);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1438, 9);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 15F);
            label2.ForeColor = Color.FromArgb(180, 180, 190);
            label2.Location = new Point(1224, 23);
            label2.Name = "label2";
            label2.Size = new Size(222, 32);
            label2.TabIndex = 1;
            label2.Text = "Bem Vindo, Usuario";
            // 
            // labelCategorias
            // 
            labelCategorias.AutoSize = true;
            labelCategorias.FlatStyle = FlatStyle.System;
            labelCategorias.Font = new Font("Franklin Gothic Medium", 15F);
            labelCategorias.ForeColor = Color.FromArgb(180, 180, 190);
            labelCategorias.Location = new Point(361, 23);
            labelCategorias.Name = "labelCategorias";
            labelCategorias.Size = new Size(128, 32);
            labelCategorias.TabIndex = 0;
            labelCategorias.Text = "Categorias";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(27, 27, 37);
            panel5.Controls.Add(btnMinimizar);
            panel5.Controls.Add(btnSair);
            panel5.Location = new Point(0, -4);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1865, 48);
            panel5.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 60);
            btnMinimizar.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMinimizar.FlatStyle = FlatStyle.Popup;
            btnMinimizar.Font = new Font("Segoe UI", 15F);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(1742, 4);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(62, 44);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 60);
            btnSair.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnSair.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(1803, 4);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(62, 44);
            btnSair.TabIndex = 0;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(45, 45, 60);
            panelContainer.ForeColor = Color.White;
            panelContainer.Location = new Point(328, 116);
            panelContainer.Margin = new Padding(3, 4, 3, 4);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1537, 967);
            panelContainer.TabIndex = 2;
            // 
            // MainPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1865, 1081);
            Controls.Add(panel5);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel2;
        private Label label2;
        private Label labelCategorias;
        private Button btnProdutos;
        private Button btnFuncionario;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Button btnCaixa;
        private Button btnEstoque;
        private Label label4;
        private PictureBox pictureBox2;
        private Button btnLogOut;
        private Button btnLog;
        private Panel panel5;
        private Button btnMinimizar;
        private Button btnSair;
        private Panel panelContainer;
        private Button button1;
        private ImageList imageList1;
        private Button btnMovimentacao;
    }
}
