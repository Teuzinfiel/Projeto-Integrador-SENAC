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
            UsEmail = new TextBox();
            label2 = new Label();
            UsNome = new TextBox();
            label1 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
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
            // UsEmail
            // 
            UsEmail.BackColor = Color.FromArgb(224, 224, 224);
            UsEmail.Font = new Font("Microsoft Sans Serif", 16F);
            UsEmail.Location = new Point(285, 273);
            UsEmail.Name = "UsEmail";
            UsEmail.PlaceholderText = "Digite a marca do produto";
            UsEmail.Size = new Size(348, 32);
            UsEmail.TabIndex = 39;
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
            // UsNome
            // 
            UsNome.BackColor = Color.FromArgb(224, 224, 224);
            UsNome.Font = new Font("Microsoft Sans Serif", 16F);
            UsNome.Location = new Point(285, 197);
            UsNome.Name = "UsNome";
            UsNome.PlaceholderText = "Digite o nome do produto";
            UsNome.Size = new Size(348, 32);
            UsNome.TabIndex = 31;
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
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Font = new Font("Microsoft Sans Serif", 16F);
            textBox1.Location = new Point(694, 197);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite a descrição do produto";
            textBox1.Size = new Size(348, 108);
            textBox1.TabIndex = 49;
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
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(224, 224, 224);
            comboBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(694, 351);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(348, 33);
            comboBox1.TabIndex = 54;
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteCustomSource.AddRange(new string[] { "Unidade", "Grama" });
            comboBox2.BackColor = Color.FromArgb(224, 224, 224);
            comboBox2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(285, 351);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(348, 33);
            comboBox2.TabIndex = 55;
            // 
            // frmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(1323, 816);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(btnLimpar);
            Controls.Add(btnCadastro);
            Controls.Add(label5);
            Controls.Add(UsEmail);
            Controls.Add(label2);
            Controls.Add(UsNome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProduto";
            Text = "cadastroProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLimpar;
        private Button btnCadastro;
        private Label label5;
        private TextBox UsEmail;
        private Label label2;
        private TextBox UsNome;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}