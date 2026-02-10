namespace ProjetoIntegradorSENAC.Usuarios
{
    partial class frmFuncionarios
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
            panel1 = new Panel();
            astConfirmar = new Label();
            astSenha = new Label();
            astTelefone = new Label();
            astCpf = new Label();
            astEmail = new Label();
            astNome = new Label();
            chkMostrarSenha = new CheckBox();
            lbCpf = new Label();
            btnCadastro = new Button();
            UsTelefone = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            lbTelefone = new Label();
            UsCpf = new MaskedTextBox();
            mkCPF = new MaskedTextBox();
            lbEmail = new Label();
            UsEmail = new TextBox();
            lbConfirmar = new Label();
            ConfirmarSenha = new TextBox();
            lbSenha = new Label();
            UsSenha = new TextBox();
            lbNome = new Label();
            UsNome = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label16 = new Label();
            label14 = new Label();
            btnExcluir = new Button();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            label12 = new Label();
            maskedTextBox4 = new MaskedTextBox();
            maskedTextBox5 = new MaskedTextBox();
            label13 = new Label();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            dtgEmpresas = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgEmpresas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 40);
            panel1.Controls.Add(astConfirmar);
            panel1.Controls.Add(astSenha);
            panel1.Controls.Add(astTelefone);
            panel1.Controls.Add(astCpf);
            panel1.Controls.Add(astEmail);
            panel1.Controls.Add(astNome);
            panel1.Controls.Add(chkMostrarSenha);
            panel1.Controls.Add(lbCpf);
            panel1.Controls.Add(btnCadastro);
            panel1.Controls.Add(UsTelefone);
            panel1.Controls.Add(maskedTextBox2);
            panel1.Controls.Add(lbTelefone);
            panel1.Controls.Add(UsCpf);
            panel1.Controls.Add(mkCPF);
            panel1.Controls.Add(lbEmail);
            panel1.Controls.Add(UsEmail);
            panel1.Controls.Add(lbConfirmar);
            panel1.Controls.Add(ConfirmarSenha);
            panel1.Controls.Add(lbSenha);
            panel1.Controls.Add(UsSenha);
            panel1.Controls.Add(lbNome);
            panel1.Controls.Add(UsNome);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 681);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // astConfirmar
            // 
            astConfirmar.AutoSize = true;
            astConfirmar.Font = new Font("Franklin Gothic Medium Cond", 12F);
            astConfirmar.ForeColor = Color.FromArgb(192, 0, 0);
            astConfirmar.Location = new Point(153, 242);
            astConfirmar.Name = "astConfirmar";
            astConfirmar.Size = new Size(18, 21);
            astConfirmar.TabIndex = 35;
            astConfirmar.Text = "*";
            astConfirmar.Visible = false;
            // 
            // astSenha
            // 
            astSenha.AutoSize = true;
            astSenha.Font = new Font("Franklin Gothic Medium Cond", 12F);
            astSenha.ForeColor = Color.FromArgb(192, 0, 0);
            astSenha.Location = new Point(126, 170);
            astSenha.Name = "astSenha";
            astSenha.Size = new Size(18, 21);
            astSenha.TabIndex = 34;
            astSenha.Text = "*";
            astSenha.Visible = false;
            // 
            // astTelefone
            // 
            astTelefone.AutoSize = true;
            astTelefone.Font = new Font("Franklin Gothic Medium Cond", 12F);
            astTelefone.ForeColor = Color.FromArgb(192, 0, 0);
            astTelefone.Location = new Point(99, 361);
            astTelefone.Name = "astTelefone";
            astTelefone.Size = new Size(18, 21);
            astTelefone.TabIndex = 33;
            astTelefone.Text = "*";
            astTelefone.Visible = false;
            // 
            // astCpf
            // 
            astCpf.AutoSize = true;
            astCpf.Font = new Font("Franklin Gothic Medium Cond", 12F);
            astCpf.ForeColor = Color.FromArgb(192, 0, 0);
            astCpf.Location = new Point(90, 433);
            astCpf.Name = "astCpf";
            astCpf.Size = new Size(18, 21);
            astCpf.TabIndex = 33;
            astCpf.Text = "*";
            astCpf.Visible = false;
            // 
            // astEmail
            // 
            astEmail.AutoSize = true;
            astEmail.Font = new Font("Franklin Gothic Medium Cond", 12F);
            astEmail.ForeColor = Color.FromArgb(192, 0, 0);
            astEmail.Location = new Point(90, 507);
            astEmail.Name = "astEmail";
            astEmail.Size = new Size(18, 21);
            astEmail.TabIndex = 32;
            astEmail.Text = "*";
            astEmail.Visible = false;
            // 
            // astNome
            // 
            astNome.AutoSize = true;
            astNome.Font = new Font("Franklin Gothic Medium Cond", 12F);
            astNome.ForeColor = Color.FromArgb(192, 0, 0);
            astNome.Location = new Point(166, 95);
            astNome.Name = "astNome";
            astNome.Size = new Size(18, 21);
            astNome.TabIndex = 31;
            astNome.Text = "*";
            astNome.Visible = false;
            // 
            // chkMostrarSenha
            // 
            chkMostrarSenha.AutoSize = true;
            chkMostrarSenha.Cursor = Cursors.Hand;
            chkMostrarSenha.FlatAppearance.BorderColor = Color.White;
            chkMostrarSenha.FlatAppearance.CheckedBackColor = SystemColors.Highlight;
            chkMostrarSenha.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 40);
            chkMostrarSenha.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 40);
            chkMostrarSenha.Font = new Font("Franklin Gothic Medium Cond", 12F);
            chkMostrarSenha.ForeColor = Color.FromArgb(180, 180, 190);
            chkMostrarSenha.Location = new Point(44, 298);
            chkMostrarSenha.Name = "chkMostrarSenha";
            chkMostrarSenha.Size = new Size(111, 25);
            chkMostrarSenha.TabIndex = 28;
            chkMostrarSenha.Text = "Mostrar Senha";
            chkMostrarSenha.UseVisualStyleBackColor = true;
            chkMostrarSenha.CheckedChanged += chkMostrarSenha_CheckedChanged;
            // 
            // lbCpf
            // 
            lbCpf.AutoSize = true;
            lbCpf.BackColor = Color.FromArgb(40, 40, 50);
            lbCpf.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbCpf.ForeColor = Color.FromArgb(180, 180, 190);
            lbCpf.Location = new Point(44, 432);
            lbCpf.Name = "lbCpf";
            lbCpf.Size = new Size(33, 21);
            lbCpf.TabIndex = 27;
            lbCpf.Text = "CPF";
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = SystemColors.Highlight;
            btnCadastro.Cursor = Cursors.Hand;
            btnCadastro.FlatStyle = FlatStyle.Popup;
            btnCadastro.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastro.ForeColor = Color.White;
            btnCadastro.Location = new Point(44, 594);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(491, 41);
            btnCadastro.TabIndex = 17;
            btnCadastro.Text = "Criar conta";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // UsTelefone
            // 
            UsTelefone.BackColor = Color.FromArgb(224, 224, 224);
            UsTelefone.Font = new Font("Microsoft Sans Serif", 16F);
            UsTelefone.ForeColor = SystemColors.WindowText;
            UsTelefone.Location = new Point(44, 387);
            UsTelefone.Mask = "(00)00000-9999";
            UsTelefone.Name = "UsTelefone";
            UsTelefone.Size = new Size(491, 32);
            UsTelefone.TabIndex = 26;
            UsTelefone.TextChanged += UsTelefone_TextChanged;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BackColor = Color.White;
            maskedTextBox2.Font = new Font("Microsoft Sans Serif", 16F);
            maskedTextBox2.ForeColor = Color.FromArgb(40, 40, 50);
            maskedTextBox2.Location = new Point(44, 387);
            maskedTextBox2.Mask = "  000.000.000-00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(491, 32);
            maskedTextBox2.TabIndex = 25;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.BackColor = Color.FromArgb(40, 40, 50);
            lbTelefone.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbTelefone.ForeColor = Color.FromArgb(180, 180, 190);
            lbTelefone.Location = new Point(44, 361);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(59, 21);
            lbTelefone.TabIndex = 24;
            lbTelefone.Text = "Telefone";
            // 
            // UsCpf
            // 
            UsCpf.BackColor = Color.FromArgb(224, 224, 224);
            UsCpf.Font = new Font("Microsoft Sans Serif", 16F);
            UsCpf.ForeColor = SystemColors.WindowText;
            UsCpf.Location = new Point(44, 458);
            UsCpf.Mask = " 000.000.000-00";
            UsCpf.Name = "UsCpf";
            UsCpf.Size = new Size(491, 32);
            UsCpf.TabIndex = 23;
            UsCpf.TextChanged += UsCpf_TextChanged;
            // 
            // mkCPF
            // 
            mkCPF.BackColor = Color.White;
            mkCPF.Font = new Font("Microsoft Sans Serif", 16F);
            mkCPF.ForeColor = Color.FromArgb(40, 40, 50);
            mkCPF.Location = new Point(44, 458);
            mkCPF.Mask = "  000.000.000-00";
            mkCPF.Name = "mkCPF";
            mkCPF.Size = new Size(491, 32);
            mkCPF.TabIndex = 22;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbEmail.ForeColor = Color.FromArgb(180, 180, 190);
            lbEmail.Location = new Point(44, 507);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(43, 21);
            lbEmail.TabIndex = 19;
            lbEmail.Text = "Email";
            // 
            // UsEmail
            // 
            UsEmail.BackColor = Color.FromArgb(224, 224, 224);
            UsEmail.Font = new Font("Microsoft Sans Serif", 16F);
            UsEmail.Location = new Point(44, 533);
            UsEmail.Name = "UsEmail";
            UsEmail.PlaceholderText = "Digite o seu email";
            UsEmail.Size = new Size(491, 32);
            UsEmail.TabIndex = 18;
            UsEmail.TextChanged += UsEmail_TextChanged;
            // 
            // lbConfirmar
            // 
            lbConfirmar.AutoSize = true;
            lbConfirmar.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbConfirmar.ForeColor = Color.FromArgb(180, 180, 190);
            lbConfirmar.Location = new Point(44, 240);
            lbConfirmar.Name = "lbConfirmar";
            lbConfirmar.Size = new Size(103, 21);
            lbConfirmar.TabIndex = 17;
            lbConfirmar.Text = "Confirmar senha";
            // 
            // ConfirmarSenha
            // 
            ConfirmarSenha.BackColor = Color.FromArgb(224, 224, 224);
            ConfirmarSenha.Font = new Font("Microsoft Sans Serif", 16F);
            ConfirmarSenha.Location = new Point(44, 266);
            ConfirmarSenha.Name = "ConfirmarSenha";
            ConfirmarSenha.PlaceholderText = "Confirme sua senha";
            ConfirmarSenha.Size = new Size(491, 32);
            ConfirmarSenha.TabIndex = 16;
            ConfirmarSenha.UseSystemPasswordChar = true;
            ConfirmarSenha.TextChanged += ConfirmarSenha_TextChanged;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbSenha.ForeColor = Color.FromArgb(180, 180, 190);
            lbSenha.Location = new Point(44, 170);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(74, 21);
            lbSenha.TabIndex = 15;
            lbSenha.Text = "Criar senha";
            // 
            // UsSenha
            // 
            UsSenha.BackColor = Color.FromArgb(224, 224, 224);
            UsSenha.Font = new Font("Microsoft Sans Serif", 16F);
            UsSenha.Location = new Point(44, 196);
            UsSenha.Name = "UsSenha";
            UsSenha.PlaceholderText = "Digite sua senha";
            UsSenha.Size = new Size(491, 32);
            UsSenha.TabIndex = 14;
            UsSenha.UseSystemPasswordChar = true;
            UsSenha.TextChanged += UsSenha_TextChanged;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbNome.ForeColor = Color.FromArgb(180, 180, 190);
            lbNome.Location = new Point(44, 95);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(107, 21);
            lbNome.TabIndex = 13;
            lbNome.Text = "Nome de usuário";
            // 
            // UsNome
            // 
            UsNome.BackColor = Color.FromArgb(224, 224, 224);
            UsNome.Font = new Font("Microsoft Sans Serif", 16F);
            UsNome.Location = new Point(44, 121);
            UsNome.Name = "UsNome";
            UsNome.PlaceholderText = "Digite o nome de usuario";
            UsNome.Size = new Size(491, 32);
            UsNome.TabIndex = 12;
            UsNome.TextChanged += UsNome_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 23F);
            label1.ForeColor = Color.FromArgb(180, 180, 190);
            label1.Location = new Point(112, 15);
            label1.Name = "label1";
            label1.Size = new Size(358, 37);
            label1.TabIndex = 9;
            label1.Text = "Cadastre seu funcionario!";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 40);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(btnExcluir);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(maskedTextBox1);
            panel2.Controls.Add(maskedTextBox3);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(maskedTextBox4);
            panel2.Controls.Add(maskedTextBox5);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(dtgEmpresas);
            panel2.Location = new Point(612, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(702, 681);
            panel2.TabIndex = 2;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Franklin Gothic Medium", 9F);
            label16.ForeColor = Color.FromArgb(180, 180, 190);
            label16.Location = new Point(17, 82);
            label16.Name = "label16";
            label16.Size = new Size(151, 16);
            label16.TabIndex = 76;
            label16.Text = "Clique em algum funcionario!\r\n";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Franklin Gothic Medium", 23F);
            label14.ForeColor = Color.FromArgb(180, 180, 190);
            label14.Location = new Point(185, 15);
            label14.Name = "label14";
            label14.Size = new Size(348, 37);
            label14.TabIndex = 59;
            label14.Text = "Selecione um fucionario!";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.Maroon;
            btnExcluir.Location = new Point(17, 601);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(309, 41);
            btnExcluir.TabIndex = 58;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(378, 601);
            button1.Name = "button1";
            button1.Size = new Size(309, 41);
            button1.TabIndex = 57;
            button1.Text = "Atualizar Conta";
            button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Medium Cond", 12F);
            label8.ForeColor = Color.FromArgb(192, 0, 0);
            label8.Location = new Point(424, 392);
            label8.Name = "label8";
            label8.Size = new Size(18, 21);
            label8.TabIndex = 55;
            label8.Text = "*";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Franklin Gothic Medium Cond", 12F);
            label9.ForeColor = Color.FromArgb(192, 0, 0);
            label9.Location = new Point(415, 452);
            label9.Name = "label9";
            label9.Size = new Size(18, 21);
            label9.TabIndex = 56;
            label9.Text = "*";
            label9.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Franklin Gothic Medium Cond", 12F);
            label10.ForeColor = Color.FromArgb(192, 0, 0);
            label10.Location = new Point(415, 512);
            label10.Name = "label10";
            label10.Size = new Size(18, 21);
            label10.TabIndex = 54;
            label10.Text = "*";
            label10.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(40, 40, 50);
            label11.Font = new Font("Franklin Gothic Medium Cond", 12F);
            label11.ForeColor = Color.FromArgb(180, 180, 190);
            label11.Location = new Point(369, 451);
            label11.Name = "label11";
            label11.Size = new Size(33, 21);
            label11.TabIndex = 53;
            label11.Text = "CPF";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.FromArgb(224, 224, 224);
            maskedTextBox1.Font = new Font("Microsoft Sans Serif", 16F);
            maskedTextBox1.ForeColor = SystemColors.WindowText;
            maskedTextBox1.Location = new Point(369, 418);
            maskedTextBox1.Mask = "(00)00000-9999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.ReadOnly = true;
            maskedTextBox1.Size = new Size(318, 32);
            maskedTextBox1.TabIndex = 52;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.BackColor = Color.White;
            maskedTextBox3.Font = new Font("Microsoft Sans Serif", 16F);
            maskedTextBox3.ForeColor = Color.FromArgb(40, 40, 50);
            maskedTextBox3.Location = new Point(369, 418);
            maskedTextBox3.Mask = "  000.000.000-00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(318, 32);
            maskedTextBox3.TabIndex = 51;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(40, 40, 50);
            label12.Font = new Font("Franklin Gothic Medium Cond", 12F);
            label12.ForeColor = Color.FromArgb(180, 180, 190);
            label12.Location = new Point(369, 392);
            label12.Name = "label12";
            label12.Size = new Size(59, 21);
            label12.TabIndex = 50;
            label12.Text = "Telefone";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.BackColor = Color.FromArgb(224, 224, 224);
            maskedTextBox4.Font = new Font("Microsoft Sans Serif", 16F);
            maskedTextBox4.ForeColor = SystemColors.WindowText;
            maskedTextBox4.Location = new Point(369, 477);
            maskedTextBox4.Mask = " 000.000.000-00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.ReadOnly = true;
            maskedTextBox4.Size = new Size(318, 32);
            maskedTextBox4.TabIndex = 49;
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.BackColor = Color.White;
            maskedTextBox5.Font = new Font("Microsoft Sans Serif", 16F);
            maskedTextBox5.ForeColor = Color.FromArgb(40, 40, 50);
            maskedTextBox5.Location = new Point(369, 477);
            maskedTextBox5.Mask = "  000.000.000-00";
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(318, 32);
            maskedTextBox5.TabIndex = 48;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Franklin Gothic Medium Cond", 12F);
            label13.ForeColor = Color.FromArgb(180, 180, 190);
            label13.Location = new Point(369, 512);
            label13.Name = "label13";
            label13.Size = new Size(43, 21);
            label13.TabIndex = 47;
            label13.Text = "Email";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(224, 224, 224);
            textBox4.Font = new Font("Microsoft Sans Serif", 16F);
            textBox4.Location = new Point(369, 538);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Digite o seu email";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(318, 32);
            textBox4.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 12F);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(99, 512);
            label2.Name = "label2";
            label2.Size = new Size(18, 21);
            label2.TabIndex = 45;
            label2.Text = "*";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 12F);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(123, 453);
            label3.Name = "label3";
            label3.Size = new Size(18, 21);
            label3.TabIndex = 44;
            label3.Text = "*";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium Cond", 12F);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(139, 394);
            label4.Name = "label4";
            label4.Size = new Size(18, 21);
            label4.TabIndex = 43;
            label4.Text = "*";
            label4.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.FlatAppearance.BorderColor = Color.White;
            checkBox1.FlatAppearance.CheckedBackColor = SystemColors.Highlight;
            checkBox1.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 40);
            checkBox1.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 40);
            checkBox1.Font = new Font("Franklin Gothic Medium Cond", 12F);
            checkBox1.ForeColor = Color.FromArgb(180, 180, 190);
            checkBox1.Location = new Point(17, 570);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(111, 25);
            checkBox1.TabIndex = 42;
            checkBox1.Text = "Mostrar Senha";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium Cond", 12F);
            label5.ForeColor = Color.FromArgb(180, 180, 190);
            label5.Location = new Point(17, 512);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 41;
            label5.Text = "Senha atual";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Font = new Font("Microsoft Sans Serif", 16F);
            textBox1.Location = new Point(17, 538);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Confirme sua senha atual";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(326, 32);
            textBox1.TabIndex = 40;
            textBox1.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium Cond", 12F);
            label6.ForeColor = Color.FromArgb(180, 180, 190);
            label6.Location = new Point(17, 453);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 39;
            label6.Text = "Redefinir senha";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(224, 224, 224);
            textBox2.Font = new Font("Microsoft Sans Serif", 16F);
            textBox2.Location = new Point(17, 479);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Digite sua nova senha";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(326, 32);
            textBox2.TabIndex = 38;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium Cond", 12F);
            label7.ForeColor = Color.FromArgb(180, 180, 190);
            label7.Location = new Point(17, 394);
            label7.Name = "label7";
            label7.Size = new Size(107, 21);
            label7.TabIndex = 37;
            label7.Text = "Nome de usuário";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(224, 224, 224);
            textBox3.Font = new Font("Microsoft Sans Serif", 16F);
            textBox3.Location = new Point(17, 420);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Digite o nome de usuario";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(326, 32);
            textBox3.TabIndex = 36;
            // 
            // dtgEmpresas
            // 
            dtgEmpresas.AllowUserToAddRows = false;
            dtgEmpresas.AllowUserToDeleteRows = false;
            dtgEmpresas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 35, 45);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dtgEmpresas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgEmpresas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgEmpresas.BackgroundColor = Color.FromArgb(30, 35, 45);
            dtgEmpresas.BorderStyle = BorderStyle.None;
            dtgEmpresas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 70);
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgEmpresas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgEmpresas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEmpresas.EnableHeadersVisualStyles = false;
            dtgEmpresas.GridColor = Color.FromArgb(60, 60, 80);
            dtgEmpresas.Location = new Point(17, 101);
            dtgEmpresas.MultiSelect = false;
            dtgEmpresas.Name = "dtgEmpresas";
            dtgEmpresas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgEmpresas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle4.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dtgEmpresas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgEmpresas.RowTemplate.Height = 40;
            dtgEmpresas.Size = new Size(670, 265);
            dtgEmpresas.TabIndex = 6;
            // 
            // frmFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(1326, 705);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFuncionarios";
            Text = "cadastroUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgEmpresas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label astConfirmar;
        private Label astSenha;
        private Label astTelefone;
        private Label astCpf;
        private Label astEmail;
        private Label astNome;
        private CheckBox chkMostrarSenha;
        private Label lbCpf;
        private Button btnCadastro;
        private MaskedTextBox UsTelefone;
        private MaskedTextBox maskedTextBox2;
        private Label lbTelefone;
        private MaskedTextBox UsCpf;
        private MaskedTextBox mkCPF;
        private Label lbEmail;
        private TextBox UsEmail;
        private Label lbConfirmar;
        private TextBox ConfirmarSenha;
        private Label lbSenha;
        private TextBox UsSenha;
        private Label lbNome;
        private TextBox UsNome;
        private Label label1;
        private Panel panel2;
        private Button button1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox3;
        private Label label12;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox5;
        private Label label13;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox3;
        private DataGridView dtgEmpresas;
        private Label label14;
        private Button btnExcluir;
        private Label label16;
    }
}