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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            picSenha = new PictureBox();
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
            BtnEditar = new Button();
            astTellEd = new Label();
            astCpfEd = new Label();
            astEmailEd = new Label();
            lbCpfEd = new Label();
            EdTelefone = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            lbTellEd = new Label();
            EdCpf = new MaskedTextBox();
            maskedTextBox5 = new MaskedTextBox();
            lbEmailEd = new Label();
            EdEmail = new TextBox();
            astSenhaEd = new Label();
            astRedefinir = new Label();
            astNomeEd = new Label();
            checkBox1 = new CheckBox();
            lbSenhaEd = new Label();
            EdSenha = new TextBox();
            lbERedefinir = new Label();
            EdRedefinir = new TextBox();
            lbNomeEd = new Label();
            EdNome = new TextBox();
            dtgFuncionarios = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSenha).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 40);
            panel1.Controls.Add(picSenha);
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
            // picSenha
            // 
            picSenha.Image = Properties.Resources.pontoInterrogacao;
            picSenha.Location = new Point(541, 196);
            picSenha.Margin = new Padding(3, 2, 3, 2);
            picSenha.Name = "picSenha";
            picSenha.Size = new Size(35, 28);
            picSenha.SizeMode = PictureBoxSizeMode.StretchImage;
            picSenha.TabIndex = 37;
            picSenha.TabStop = false;
            picSenha.MouseLeave += picSenha_MouseLeave;
            picSenha.MouseHover += picSenha_MouseHover;
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
            panel2.Controls.Add(BtnEditar);
            panel2.Controls.Add(astTellEd);
            panel2.Controls.Add(astCpfEd);
            panel2.Controls.Add(astEmailEd);
            panel2.Controls.Add(lbCpfEd);
            panel2.Controls.Add(EdTelefone);
            panel2.Controls.Add(maskedTextBox3);
            panel2.Controls.Add(lbTellEd);
            panel2.Controls.Add(EdCpf);
            panel2.Controls.Add(maskedTextBox5);
            panel2.Controls.Add(lbEmailEd);
            panel2.Controls.Add(EdEmail);
            panel2.Controls.Add(astSenhaEd);
            panel2.Controls.Add(astRedefinir);
            panel2.Controls.Add(astNomeEd);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(lbSenhaEd);
            panel2.Controls.Add(EdSenha);
            panel2.Controls.Add(lbERedefinir);
            panel2.Controls.Add(EdRedefinir);
            panel2.Controls.Add(lbNomeEd);
            panel2.Controls.Add(EdNome);
            panel2.Controls.Add(dtgFuncionarios);
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
            // BtnEditar
            // 
            BtnEditar.BackColor = SystemColors.Highlight;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.FlatStyle = FlatStyle.Popup;
            BtnEditar.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEditar.ForeColor = Color.White;
            BtnEditar.Location = new Point(378, 601);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(309, 41);
            BtnEditar.TabIndex = 57;
            BtnEditar.Text = "Atualizar Conta";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // astTellEd
            // 
            astTellEd.AutoSize = true;
            astTellEd.Font = new Font("Franklin Gothic Medium Cond", 12F);
            astTellEd.ForeColor = Color.FromArgb(192, 0, 0);
            astTellEd.Location = new Point(424, 392);
            astTellEd.Name = "astTellEd";
            astTellEd.Size = new Size(18, 21);
            astTellEd.TabIndex = 55;
            astTellEd.Text = "*";
            astTellEd.Visible = false;
            // 
            // astCpfEd
            // 
            astCpfEd.AutoSize = true;
            astCpfEd.Font = new Font("Franklin Gothic Medium Cond", 12F);
            astCpfEd.ForeColor = Color.FromArgb(192, 0, 0);
            astCpfEd.Location = new Point(415, 452);
            astCpfEd.Name = "astCpfEd";
            astCpfEd.Size = new Size(18, 21);
            astCpfEd.TabIndex = 56;
            astCpfEd.Text = "*";
            astCpfEd.Visible = false;
            // 
            // astEmailEd
            // 
            astEmailEd.AutoSize = true;
            astEmailEd.Font = new Font("Franklin Gothic Medium Cond", 12F);
            astEmailEd.ForeColor = Color.FromArgb(192, 0, 0);
            astEmailEd.Location = new Point(415, 512);
            astEmailEd.Name = "astEmailEd";
            astEmailEd.Size = new Size(18, 21);
            astEmailEd.TabIndex = 54;
            astEmailEd.Text = "*";
            astEmailEd.Visible = false;
            // 
            // lbCpfEd
            // 
            lbCpfEd.AutoSize = true;
            lbCpfEd.BackColor = Color.FromArgb(40, 40, 50);
            lbCpfEd.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbCpfEd.ForeColor = Color.FromArgb(180, 180, 190);
            lbCpfEd.Location = new Point(369, 451);
            lbCpfEd.Name = "lbCpfEd";
            lbCpfEd.Size = new Size(33, 21);
            lbCpfEd.TabIndex = 53;
            lbCpfEd.Text = "CPF";
            // 
            // EdTelefone
            // 
            EdTelefone.BackColor = Color.FromArgb(224, 224, 224);
            EdTelefone.Font = new Font("Microsoft Sans Serif", 16F);
            EdTelefone.ForeColor = SystemColors.WindowText;
            EdTelefone.Location = new Point(369, 418);
            EdTelefone.Mask = "(00)00000-9999";
            EdTelefone.Name = "EdTelefone";
            EdTelefone.ReadOnly = true;
            EdTelefone.Size = new Size(318, 32);
            EdTelefone.TabIndex = 52;
            EdTelefone.TextChanged += EdTelefone_TextChanged;
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
            // lbTellEd
            // 
            lbTellEd.AutoSize = true;
            lbTellEd.BackColor = Color.FromArgb(40, 40, 50);
            lbTellEd.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbTellEd.ForeColor = Color.FromArgb(180, 180, 190);
            lbTellEd.Location = new Point(369, 392);
            lbTellEd.Name = "lbTellEd";
            lbTellEd.Size = new Size(59, 21);
            lbTellEd.TabIndex = 50;
            lbTellEd.Text = "Telefone";
            // 
            // EdCpf
            // 
            EdCpf.BackColor = Color.FromArgb(224, 224, 224);
            EdCpf.Font = new Font("Microsoft Sans Serif", 16F);
            EdCpf.ForeColor = SystemColors.WindowText;
            EdCpf.Location = new Point(369, 477);
            EdCpf.Mask = " 000.000.000-00";
            EdCpf.Name = "EdCpf";
            EdCpf.ReadOnly = true;
            EdCpf.Size = new Size(318, 32);
            EdCpf.TabIndex = 49;
            EdCpf.TextChanged += EdCpf_TextChanged;
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
            // lbEmailEd
            // 
            lbEmailEd.AutoSize = true;
            lbEmailEd.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbEmailEd.ForeColor = Color.FromArgb(180, 180, 190);
            lbEmailEd.Location = new Point(369, 512);
            lbEmailEd.Name = "lbEmailEd";
            lbEmailEd.Size = new Size(43, 21);
            lbEmailEd.TabIndex = 47;
            lbEmailEd.Text = "Email";
            // 
            // EdEmail
            // 
            EdEmail.BackColor = Color.FromArgb(224, 224, 224);
            EdEmail.Font = new Font("Microsoft Sans Serif", 16F);
            EdEmail.Location = new Point(369, 538);
            EdEmail.Name = "EdEmail";
            EdEmail.PlaceholderText = "Digite o seu email";
            EdEmail.ReadOnly = true;
            EdEmail.Size = new Size(318, 32);
            EdEmail.TabIndex = 46;
            EdEmail.TextChanged += EdEmail_TextChanged;
            // 
            // astSenhaEd
            // 
            astSenhaEd.AutoSize = true;
            astSenhaEd.Font = new Font("Franklin Gothic Medium Cond", 12F);
            astSenhaEd.ForeColor = Color.FromArgb(192, 0, 0);
            astSenhaEd.Location = new Point(99, 512);
            astSenhaEd.Name = "astSenhaEd";
            astSenhaEd.Size = new Size(18, 21);
            astSenhaEd.TabIndex = 45;
            astSenhaEd.Text = "*";
            astSenhaEd.Visible = false;
            // 
            // astRedefinir
            // 
            astRedefinir.AutoSize = true;
            astRedefinir.Font = new Font("Franklin Gothic Medium Cond", 12F);
            astRedefinir.ForeColor = Color.FromArgb(192, 0, 0);
            astRedefinir.Location = new Point(123, 453);
            astRedefinir.Name = "astRedefinir";
            astRedefinir.Size = new Size(18, 21);
            astRedefinir.TabIndex = 44;
            astRedefinir.Text = "*";
            astRedefinir.Visible = false;
            // 
            // astNomeEd
            // 
            astNomeEd.AutoSize = true;
            astNomeEd.Font = new Font("Franklin Gothic Medium Cond", 12F);
            astNomeEd.ForeColor = Color.FromArgb(192, 0, 0);
            astNomeEd.Location = new Point(139, 394);
            astNomeEd.Name = "astNomeEd";
            astNomeEd.Size = new Size(18, 21);
            astNomeEd.TabIndex = 43;
            astNomeEd.Text = "*";
            astNomeEd.Visible = false;
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
            // lbSenhaEd
            // 
            lbSenhaEd.AutoSize = true;
            lbSenhaEd.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbSenhaEd.ForeColor = Color.FromArgb(180, 180, 190);
            lbSenhaEd.Location = new Point(17, 512);
            lbSenhaEd.Name = "lbSenhaEd";
            lbSenhaEd.Size = new Size(78, 21);
            lbSenhaEd.TabIndex = 41;
            lbSenhaEd.Text = "Senha atual";
            // 
            // EdSenha
            // 
            EdSenha.BackColor = Color.FromArgb(224, 224, 224);
            EdSenha.Font = new Font("Microsoft Sans Serif", 16F);
            EdSenha.Location = new Point(17, 538);
            EdSenha.Name = "EdSenha";
            EdSenha.PlaceholderText = "Confirme sua senha atual";
            EdSenha.ReadOnly = true;
            EdSenha.Size = new Size(326, 32);
            EdSenha.TabIndex = 40;
            EdSenha.UseSystemPasswordChar = true;
            EdSenha.TextChanged += EdSenha_TextChanged;
            // 
            // lbERedefinir
            // 
            lbERedefinir.AutoSize = true;
            lbERedefinir.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbERedefinir.ForeColor = Color.FromArgb(180, 180, 190);
            lbERedefinir.Location = new Point(17, 453);
            lbERedefinir.Name = "lbERedefinir";
            lbERedefinir.Size = new Size(100, 21);
            lbERedefinir.TabIndex = 39;
            lbERedefinir.Text = "Redefinir senha";
            // 
            // EdRedefinir
            // 
            EdRedefinir.BackColor = Color.FromArgb(224, 224, 224);
            EdRedefinir.Font = new Font("Microsoft Sans Serif", 16F);
            EdRedefinir.Location = new Point(17, 479);
            EdRedefinir.Name = "EdRedefinir";
            EdRedefinir.PlaceholderText = "Digite sua nova senha";
            EdRedefinir.ReadOnly = true;
            EdRedefinir.Size = new Size(326, 32);
            EdRedefinir.TabIndex = 38;
            EdRedefinir.UseSystemPasswordChar = true;
            EdRedefinir.TextChanged += EdRedefinir_TextChanged;
            // 
            // lbNomeEd
            // 
            lbNomeEd.AutoSize = true;
            lbNomeEd.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbNomeEd.ForeColor = Color.FromArgb(180, 180, 190);
            lbNomeEd.Location = new Point(17, 394);
            lbNomeEd.Name = "lbNomeEd";
            lbNomeEd.Size = new Size(107, 21);
            lbNomeEd.TabIndex = 37;
            lbNomeEd.Text = "Nome de usuário";
            // 
            // EdNome
            // 
            EdNome.BackColor = Color.FromArgb(224, 224, 224);
            EdNome.Font = new Font("Microsoft Sans Serif", 16F);
            EdNome.Location = new Point(17, 420);
            EdNome.Name = "EdNome";
            EdNome.PlaceholderText = "Digite o nome de usuario";
            EdNome.ReadOnly = true;
            EdNome.Size = new Size(326, 32);
            EdNome.TabIndex = 36;
            EdNome.TextChanged += EdNome_TextChanged;
            // 
            // dtgFuncionarios
            // 
            dtgFuncionarios.AllowUserToAddRows = false;
            dtgFuncionarios.AllowUserToDeleteRows = false;
            dtgFuncionarios.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(35, 35, 45);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dtgFuncionarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dtgFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgFuncionarios.BackgroundColor = Color.FromArgb(30, 35, 45);
            dtgFuncionarios.BorderStyle = BorderStyle.None;
            dtgFuncionarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(50, 50, 70);
            dataGridViewCellStyle6.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dtgFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dtgFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgFuncionarios.EnableHeadersVisualStyles = false;
            dtgFuncionarios.GridColor = Color.FromArgb(60, 60, 80);
            dtgFuncionarios.Location = new Point(17, 101);
            dtgFuncionarios.MultiSelect = false;
            dtgFuncionarios.Name = "dtgFuncionarios";
            dtgFuncionarios.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle7.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtgFuncionarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle8.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dtgFuncionarios.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dtgFuncionarios.RowTemplate.Height = 40;
            dtgFuncionarios.Size = new Size(670, 265);
            dtgFuncionarios.TabIndex = 6;
            dtgFuncionarios.CellClick += dtgFuncionarios_CellClick;
            dtgFuncionarios.CellContentClick += dtgFuncionarios_CellContentClick;
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
            Load += frmFuncionarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSenha).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgFuncionarios).EndInit();
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
        private Button BtnEditar;
        private Label astTellEd;
        private Label astCpfEd;
        private Label astEmailEd;
        private Label lbCpfEd;
        private MaskedTextBox EdTelefone;
        private MaskedTextBox maskedTextBox3;
        private Label lbTellEd;
        private MaskedTextBox EdCpf;
        private MaskedTextBox maskedTextBox5;
        private Label lbEmailEd;
        private TextBox EdEmail;
        private Label astSenhaEd;
        private Label astRedefinir;
        private Label astNomeEd;
        private CheckBox checkBox1;
        private Label lbSenhaEd;
        private TextBox EdSenha;
        private Label lbERedefinir;
        private TextBox EdRedefinir;
        private Label lbNomeEd;
        private TextBox EdNome;
        private DataGridView dtgFuncionarios;
        private Label label14;
        private Button btnExcluir;
        private Label label16;
        private PictureBox picSenha;
    }
}