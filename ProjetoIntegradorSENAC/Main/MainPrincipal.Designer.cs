﻿namespace ProjetoIntegradorSENAC
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
            button1 = new Button();
            btnProdutos = new Button();
            imageList1 = new ImageList(components);
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
            panel1.Location = new Point(-3, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 780);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.System;
            label4.Font = new Font("Franklin Gothic Medium", 15F);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(186, 737);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 4;
            label4.Text = "Ajuda";
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = SystemColors.Highlight;
            btnLogOut.FlatStyle = FlatStyle.Popup;
            btnLogOut.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(34, 732);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(107, 35);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "Sair";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Franklin Gothic Book", 15F);
            label3.ForeColor = Color.FromArgb(180, 180, 190);
            label3.Location = new Point(83, 207);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 3;
            label3.Text = "Nome Empresa";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(65, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Controls.Add(btnProdutos);
            panel4.Controls.Add(btnFuncionario);
            panel4.Controls.Add(btnLog);
            panel4.Controls.Add(btnDashboard);
            panel4.Controls.Add(btnCaixa);
            panel4.Controls.Add(btnEstoque);
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(3, 251);
            panel4.Name = "panel4";
            panel4.Size = new Size(294, 444);
            panel4.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 55);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 55);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(22, 17);
            button1.Name = "button1";
            button1.Size = new Size(246, 47);
            button1.TabIndex = 8;
            button1.Text = "Configuracoes";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.Transparent;
            btnProdutos.FlatAppearance.BorderColor = Color.FromArgb(65, 65, 80);
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 75);
            btnProdutos.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 75);
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProdutos.ForeColor = Color.FromArgb(224, 224, 224);
            btnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutos.ImageIndex = 2;
            btnProdutos.ImageList = imageList1;
            btnProdutos.Location = new Point(32, 209);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(260, 58);
            btnProdutos.TabIndex = 2;
            btnProdutos.Text = "     Produtos";
            btnProdutos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.Tag = "  ";
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "procurar.png");
            imageList1.Images.SetKeyName(1, "aluna.png");
            imageList1.Images.SetKeyName(2, "remover-do-carrinho.png");
            imageList1.Images.SetKeyName(3, "estatisticas.png");
            imageList1.Images.SetKeyName(4, "adicionar-ao-carrinho.png");
            imageList1.Images.SetKeyName(5, "armazem.png");
            imageList1.Images.SetKeyName(6, " log.png");
            // 
            // btnFuncionario
            // 
            btnFuncionario.BackColor = Color.Transparent;
            btnFuncionario.FlatAppearance.BorderColor = Color.FromArgb(65, 65, 80);
            btnFuncionario.FlatAppearance.BorderSize = 0;
            btnFuncionario.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 75);
            btnFuncionario.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 75);
            btnFuncionario.FlatStyle = FlatStyle.Flat;
            btnFuncionario.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFuncionario.ForeColor = Color.FromArgb(224, 224, 224);
            btnFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuncionario.ImageIndex = 1;
            btnFuncionario.ImageList = imageList1;
            btnFuncionario.Location = new Point(32, 315);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Size = new Size(260, 56);
            btnFuncionario.TabIndex = 3;
            btnFuncionario.Text = "    Funcionario";
            btnFuncionario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFuncionario.UseVisualStyleBackColor = false;
            btnFuncionario.Click += btnFuncionario_Click;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.Transparent;
            btnLog.FlatAppearance.BorderColor = Color.FromArgb(65, 65, 80);
            btnLog.FlatAppearance.BorderSize = 0;
            btnLog.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 75);
            btnLog.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 75);
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLog.ForeColor = Color.FromArgb(224, 224, 224);
            btnLog.ImageAlign = ContentAlignment.MiddleLeft;
            btnLog.ImageIndex = 6;
            btnLog.ImageList = imageList1;
            btnLog.Location = new Point(32, 368);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(260, 54);
            btnLog.TabIndex = 7;
            btnLog.Text = "    Alteracoes";
            btnLog.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatAppearance.BorderColor = Color.FromArgb(65, 65, 80);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 75);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 75);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(224, 224, 224);
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.ImageIndex = 3;
            btnDashboard.ImageList = imageList1;
            btnDashboard.Location = new Point(31, 156);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(260, 55);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "     Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnCaixa
            // 
            btnCaixa.BackColor = Color.Transparent;
            btnCaixa.FlatAppearance.BorderSize = 0;
            btnCaixa.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 75);
            btnCaixa.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 75);
            btnCaixa.FlatStyle = FlatStyle.Flat;
            btnCaixa.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCaixa.ForeColor = Color.FromArgb(224, 224, 224);
            btnCaixa.ImageAlign = ContentAlignment.MiddleLeft;
            btnCaixa.ImageIndex = 2;
            btnCaixa.ImageList = imageList1;
            btnCaixa.Location = new Point(31, 103);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Size = new Size(260, 54);
            btnCaixa.TabIndex = 5;
            btnCaixa.Text = "      Caixa";
            btnCaixa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCaixa.UseVisualStyleBackColor = false;
            btnCaixa.Click += btnCaixa_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.BackColor = Color.Transparent;
            btnEstoque.FlatAppearance.BorderColor = Color.FromArgb(65, 65, 80);
            btnEstoque.FlatAppearance.BorderSize = 0;
            btnEstoque.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 75);
            btnEstoque.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 75);
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEstoque.ForeColor = Color.FromArgb(224, 224, 224);
            btnEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstoque.ImageIndex = 5;
            btnEstoque.ImageList = imageList1;
            btnEstoque.Location = new Point(32, 262);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(260, 54);
            btnEstoque.TabIndex = 4;
            btnEstoque.Text = "    Estoque";
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
            panel2.Location = new Point(287, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(1345, 58);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1258, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 15F);
            label2.ForeColor = Color.FromArgb(180, 180, 190);
            label2.Location = new Point(1071, 17);
            label2.Name = "label2";
            label2.Size = new Size(181, 25);
            label2.TabIndex = 1;
            label2.Text = "Bem Vindo, Usuario";
            // 
            // labelCategorias
            // 
            labelCategorias.AutoSize = true;
            labelCategorias.FlatStyle = FlatStyle.System;
            labelCategorias.Font = new Font("Franklin Gothic Medium", 15F);
            labelCategorias.ForeColor = Color.FromArgb(180, 180, 190);
            labelCategorias.Location = new Point(316, 17);
            labelCategorias.Name = "labelCategorias";
            labelCategorias.Size = new Size(104, 25);
            labelCategorias.TabIndex = 0;
            labelCategorias.Text = "Categorias";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(27, 27, 37);
            panel5.Controls.Add(btnMinimizar);
            panel5.Controls.Add(btnSair);
            panel5.Location = new Point(0, -3);
            panel5.Name = "panel5";
            panel5.Size = new Size(1632, 36);
            panel5.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.FlatStyle = FlatStyle.Popup;
            btnMinimizar.Font = new Font("Segoe UI", 15F);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(1524, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(54, 33);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(1575, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(54, 33);
            btnSair.TabIndex = 0;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(60, 60, 75);
            panelContainer.ForeColor = Color.White;
            panelContainer.Location = new Point(287, 87);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1342, 725);
            panelContainer.TabIndex = 2;
            // 
            // MainPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1624, 811);
            Controls.Add(panel5);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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
    }
}
