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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPrincipal));
            panel1 = new Panel();
            label4 = new Label();
            button6 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            btnProdutos = new Button();
            btnFuncionario = new Button();
            btnLog = new Button();
            btnDashboard = new Button();
            btnCaixa = new Button();
            btnEstoque = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panelContainer = new Panel();
            panel5 = new Panel();
            button10 = new Button();
            btnSair = new Button();
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
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button6);
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
            label4.ForeColor = Color.White;
            label4.Location = new Point(186, 737);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 4;
            label4.Text = "Ajuda";
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(34, 732);
            button6.Name = "button6";
            button6.Size = new Size(107, 35);
            button6.TabIndex = 7;
            button6.Text = "Sair";
            button6.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Franklin Gothic Book", 15F);
            label3.ForeColor = Color.White;
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
            panel4.Controls.Add(btnProdutos);
            panel4.Controls.Add(btnFuncionario);
            panel4.Controls.Add(btnLog);
            panel4.Controls.Add(btnDashboard);
            panel4.Controls.Add(btnCaixa);
            panel4.Controls.Add(btnEstoque);
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(3, 272);
            panel4.Name = "panel4";
            panel4.Size = new Size(294, 411);
            panel4.TabIndex = 1;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.Transparent;
            btnProdutos.FlatStyle = FlatStyle.Popup;
            btnProdutos.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProdutos.ForeColor = Color.White;
            btnProdutos.Location = new Point(31, 165);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(233, 47);
            btnProdutos.TabIndex = 2;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnFuncionario
            // 
            btnFuncionario.BackColor = Color.Transparent;
            btnFuncionario.FlatStyle = FlatStyle.Popup;
            btnFuncionario.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFuncionario.ForeColor = Color.White;
            btnFuncionario.Location = new Point(31, 271);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Size = new Size(233, 47);
            btnFuncionario.TabIndex = 3;
            btnFuncionario.Text = "Funcionario";
            btnFuncionario.UseVisualStyleBackColor = false;
            btnFuncionario.Click += btnFuncionario_Click;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.Transparent;
            btnLog.FlatStyle = FlatStyle.Popup;
            btnLog.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLog.ForeColor = Color.White;
            btnLog.Location = new Point(31, 324);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(233, 47);
            btnLog.TabIndex = 7;
            btnLog.Text = "Alteracoes";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(31, 112);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(233, 47);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnCaixa
            // 
            btnCaixa.BackColor = Color.Transparent;
            btnCaixa.FlatStyle = FlatStyle.Popup;
            btnCaixa.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCaixa.ForeColor = Color.White;
            btnCaixa.Location = new Point(31, 59);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Size = new Size(233, 47);
            btnCaixa.TabIndex = 5;
            btnCaixa.Text = "Caixa";
            btnCaixa.UseVisualStyleBackColor = false;
            btnCaixa.Click += btnCaixa_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.BackColor = Color.Transparent;
            btnEstoque.FlatStyle = FlatStyle.Popup;
            btnEstoque.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEstoque.ForeColor = Color.White;
            btnEstoque.Location = new Point(31, 218);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(233, 47);
            btnEstoque.TabIndex = 4;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = false;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 51);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
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
            label2.ForeColor = Color.White;
            label2.Location = new Point(1071, 17);
            label2.Name = "label2";
            label2.Size = new Size(181, 25);
            label2.TabIndex = 1;
            label2.Text = "Bem Vindo, Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Franklin Gothic Medium", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(316, 17);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "Categorias";
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.DimGray;
            panelContainer.ForeColor = Color.White;
            panelContainer.Location = new Point(287, 87);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1342, 725);
            panelContainer.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(41, 41, 41);
            panel5.Controls.Add(button10);
            panel5.Controls.Add(btnSair);
            panel5.Location = new Point(0, -3);
            panel5.Name = "panel5";
            panel5.Size = new Size(1632, 36);
            panel5.TabIndex = 2;
            // 
            // button10
            // 
            button10.BackColor = Color.Transparent;
            button10.FlatStyle = FlatStyle.Popup;
            button10.Font = new Font("Segoe UI", 15F);
            button10.ForeColor = Color.White;
            button10.Location = new Point(1524, 3);
            button10.Name = "button10";
            button10.Size = new Size(54, 33);
            button10.TabIndex = 2;
            button10.Text = "-";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
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
        private Panel panelContainer;
        private Label label2;
        private Label label1;
        private Button btnProdutos;
        private Button btnFuncionario;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Button btnCaixa;
        private Button btnEstoque;
        private Label label4;
        private PictureBox pictureBox2;
        private Button button6;
        private Button btnLog;
        private Panel panel5;
        private Button button10;
        private Button btnSair;
    }
}
