namespace ProjetoIntegradorSENAC.Empresa
{
    partial class cadEmpresa
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
            panel1 = new Panel();
            panel2 = new Panel();
            label19 = new Label();
            label18 = new Label();
            label12 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            mkTelefone = new MaskedTextBox();
            label15 = new Label();
            label17 = new Label();
            label14 = new Label();
            btnSalvar = new Button();
            label16 = new Label();
            txtRazaoSocial = new TextBox();
            label8 = new Label();
            label13 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            label6 = new Label();
            txtNomeFantasia = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            mkCNPJ = new MaskedTextBox();
            mkCPF = new MaskedTextBox();
            button1 = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(mkTelefone);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(txtRazaoSocial);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtNomeFantasia);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(mkCNPJ);
            panel1.Controls.Add(mkCPF);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(549, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(719, 644);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(maskedTextBox1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(49, 251);
            panel2.Name = "panel2";
            panel2.Size = new Size(622, 326);
            panel2.TabIndex = 19;
            panel2.Visible = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Franklin Gothic Medium", 15F);
            label19.ForeColor = Color.White;
            label19.Location = new Point(0, 153);
            label19.Name = "label19";
            label19.Size = new Size(65, 25);
            label19.TabIndex = 39;
            label19.Text = "Bairro";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Franklin Gothic Medium", 15F);
            label18.ForeColor = Color.White;
            label18.Location = new Point(0, 75);
            label18.Name = "label18";
            label18.Size = new Size(96, 25);
            label18.TabIndex = 38;
            label18.Text = "Munícipio";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Franklin Gothic Medium", 15F);
            label12.ForeColor = Color.White;
            label12.Location = new Point(3, -1);
            label12.Name = "label12";
            label12.Size = new Size(47, 25);
            label12.TabIndex = 37;
            label12.Text = "CEP";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.White;
            maskedTextBox1.Font = new Font("Franklin Gothic Book", 20.25F);
            maskedTextBox1.ForeColor = Color.FromArgb(40, 40, 50);
            maskedTextBox1.Location = new Point(0, 27);
            maskedTextBox1.Mask = "00000-000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(619, 38);
            maskedTextBox1.TabIndex = 36;
            maskedTextBox1.Leave += maskedTextBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Franklin Gothic Book", 20.25F);
            textBox2.ForeColor = Color.FromArgb(40, 40, 50);
            textBox2.Location = new Point(0, 181);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "  Digite aqui o Bairro do seu Comércio";
            textBox2.Size = new Size(622, 38);
            textBox2.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Franklin Gothic Book", 20.25F);
            textBox1.ForeColor = Color.FromArgb(40, 40, 50);
            textBox1.Location = new Point(0, 103);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "  Digite aqui o Municipio do seu Comércio";
            textBox1.Size = new Size(622, 38);
            textBox1.TabIndex = 26;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = SystemColors.Highlight;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Franklin Gothic Medium", 14F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 294);
            button2.Name = "button2";
            button2.Size = new Size(96, 32);
            button2.TabIndex = 25;
            button2.Text = "←";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // mkTelefone
            // 
            mkTelefone.BackColor = Color.White;
            mkTelefone.Font = new Font("Franklin Gothic Book", 20.25F);
            mkTelefone.ForeColor = Color.FromArgb(40, 40, 50);
            mkTelefone.Location = new Point(49, 422);
            mkTelefone.Mask = "(00) 00000-0000";
            mkTelefone.Name = "mkTelefone";
            mkTelefone.Size = new Size(622, 38);
            mkTelefone.TabIndex = 35;
            mkTelefone.TextChanged += mkTelefone_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(192, 0, 0);
            label15.Location = new Point(101, 155);
            label15.Name = "label15";
            label15.Size = new Size(16, 24);
            label15.TabIndex = 32;
            label15.Text = "*";
            label15.Visible = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(192, 0, 0);
            label17.Location = new Point(214, 469);
            label17.Name = "label17";
            label17.Size = new Size(16, 24);
            label17.TabIndex = 34;
            label17.Text = "*";
            label17.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(192, 0, 0);
            label14.Location = new Point(186, 327);
            label14.Name = "label14";
            label14.Size = new Size(16, 24);
            label14.TabIndex = 31;
            label14.Text = "*";
            label14.Visible = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.FlatStyle = FlatStyle.Popup;
            btnSalvar.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(227, 583);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(234, 35);
            btnSalvar.TabIndex = 29;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(192, 0, 0);
            label16.Location = new Point(227, 394);
            label16.Name = "label16";
            label16.Size = new Size(16, 24);
            label16.TabIndex = 33;
            label16.Text = "*";
            label16.Visible = false;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.BackColor = Color.White;
            txtRazaoSocial.Font = new Font("Franklin Gothic Book", 20.25F);
            txtRazaoSocial.ForeColor = Color.FromArgb(40, 40, 50);
            txtRazaoSocial.Location = new Point(49, 279);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.PlaceholderText = "  Digite aqui a Razao Social";
            txtRazaoSocial.Size = new Size(622, 38);
            txtRazaoSocial.TabIndex = 0;
            txtRazaoSocial.TextChanged += txtRazaoSocial_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Medium", 25F);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(357, 16);
            label8.Name = "label8";
            label8.Size = new Size(156, 39);
            label8.TabIndex = 27;
            label8.Text = "Comércio";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(192, 0, 0);
            label13.Location = new Point(167, 251);
            label13.Name = "label13";
            label13.Size = new Size(16, 24);
            label13.TabIndex = 30;
            label13.Text = "*";
            label13.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Franklin Gothic Book", 20.25F);
            txtEmail.ForeColor = Color.FromArgb(40, 40, 50);
            txtEmail.Location = new Point(49, 497);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "  seuemail@gmail.com";
            txtEmail.Size = new Size(622, 38);
            txtEmail.TabIndex = 24;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium", 25F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(156, 16);
            label7.Name = "label7";
            label7.Size = new Size(439, 39);
            label7.TabIndex = 26;
            label7.Text = "Cadastre seu                  aqui!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 15F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(49, 394);
            label5.Name = "label5";
            label5.Size = new Size(184, 25);
            label5.TabIndex = 23;
            label5.Text = "Numero de Telefone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(49, 251);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 12;
            label2.Text = "Razao Social";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 15F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(49, 469);
            label6.Name = "label6";
            label6.Size = new Size(169, 25);
            label6.TabIndex = 25;
            label6.Text = "Email da Empresa";
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.BackColor = Color.White;
            txtNomeFantasia.Font = new Font("Franklin Gothic Book", 20.25F);
            txtNomeFantasia.ForeColor = Color.FromArgb(40, 40, 50);
            txtNomeFantasia.Location = new Point(49, 351);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.PlaceholderText = "  Digite aqui o nome Fantasia";
            txtNomeFantasia.Size = new Size(622, 38);
            txtNomeFantasia.TabIndex = 13;
            txtNomeFantasia.TextChanged += txtNomeFantasia_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 323);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 14;
            label1.Text = "Nome Fantasia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 15F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(49, 154);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 21;
            label4.Text = "CNPJ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(49, 87);
            label3.Name = "label3";
            label3.Size = new Size(194, 25);
            label3.TabIndex = 20;
            label3.Text = "Escolha CNPJ ou CPF";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 30, 40);
            panel3.Controls.Add(radioButton2);
            panel3.Controls.Add(radioButton1);
            panel3.Location = new Point(49, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(259, 31);
            panel3.TabIndex = 19;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.FlatStyle = FlatStyle.Popup;
            radioButton2.Font = new Font("Franklin Gothic Medium", 15F);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(26, 0);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(73, 29);
            radioButton2.TabIndex = 18;
            radioButton2.TabStop = true;
            radioButton2.Text = "CNPJ";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.FlatAppearance.CheckedBackColor = Color.Lime;
            radioButton1.FlatStyle = FlatStyle.Popup;
            radioButton1.Font = new Font("Franklin Gothic Medium", 15F);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(158, 0);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 29);
            radioButton1.TabIndex = 17;
            radioButton1.Text = "CPF";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // mkCNPJ
            // 
            mkCNPJ.BackColor = Color.White;
            mkCNPJ.Font = new Font("Franklin Gothic Book", 20.25F);
            mkCNPJ.ForeColor = Color.FromArgb(40, 40, 50);
            mkCNPJ.Location = new Point(49, 184);
            mkCNPJ.Mask = "  00,000,000/0000-00";
            mkCNPJ.Name = "mkCNPJ";
            mkCNPJ.Size = new Size(324, 38);
            mkCNPJ.TabIndex = 16;
            mkCNPJ.TextChanged += mkCNPJ_TextChanged;
            mkCNPJ.Leave += mkCNPJ_Leave;
            mkCNPJ.Validating += mkCNPJ_Validating;
            // 
            // mkCPF
            // 
            mkCPF.BackColor = Color.White;
            mkCPF.Font = new Font("Franklin Gothic Book", 20.25F);
            mkCPF.ForeColor = Color.FromArgb(40, 40, 50);
            mkCPF.Location = new Point(49, 184);
            mkCPF.Mask = "  000.000.000-00";
            mkCPF.Name = "mkCPF";
            mkCPF.Size = new Size(324, 38);
            mkCPF.TabIndex = 15;
            mkCPF.TextChanged += mkCPF_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = SystemColors.Highlight;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Franklin Gothic Medium", 14F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(576, 543);
            button1.Name = "button1";
            button1.Size = new Size(96, 32);
            button1.TabIndex = 25;
            button1.Text = "→";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Franklin Gothic Demi Cond", 40F);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(349, 256);
            label9.Name = "label9";
            label9.Size = new Size(175, 68);
            label9.TabIndex = 18;
            label9.Text = "Gestão";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Franklin Gothic Demi Cond", 40F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(20, 254);
            label10.Name = "label10";
            label10.Size = new Size(346, 136);
            label10.TabIndex = 17;
            label10.Text = "Transforme sua\r\nEm resultados.";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Franklin Gothic Medium Cond", 20F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(31, 220);
            label11.Name = "label11";
            label11.Size = new Size(252, 34);
            label11.TabIndex = 16;
            label11.Text = "Gerencie com facilidade";
            // 
            // cadEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(1280, 680);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "cadEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cadEmpresa";
            Load += cadEmpresa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TextBox txtRazaoSocial;
        private MaskedTextBox mkCNPJ;
        private MaskedTextBox mkCPF;
        private Label label1;
        private TextBox txtNomeFantasia;
        private Panel panel3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtEmail;
        private Label label8;
        private Label label7;
        private Button btnSalvar;
        private Label label13;
        private Label label2;
        private Label label15;
        private Label label14;
        private Label label17;
        private Label label16;
        private MaskedTextBox mkTelefone;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel panel2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private MaskedTextBox maskedTextBox1;
        private Label label19;
        private Label label18;
        private Label label12;
        private Button button1;
    }
}