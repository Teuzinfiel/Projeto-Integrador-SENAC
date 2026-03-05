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
            picSenha = new PictureBox();
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
            lbCpfEd = new Label();
            EdCpf = new MaskedTextBox();
            EdTelefone = new MaskedTextBox();
            lbEmailEd = new Label();
            EdEmail = new TextBox();
            lbTelefoneEd = new Label();
            lbNomeEd = new Label();
            EdNome = new TextBox();
            dtgFuncionarios = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSenha).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgFuncionarios).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 40);
            panel1.Controls.Add(picSenha);
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
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 616);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // picSenha
            // 
            picSenha.Image = Properties.Resources.pontoInterrogacao;
            picSenha.Location = new Point(441, 184);
            picSenha.Margin = new Padding(3, 2, 3, 2);
            picSenha.Name = "picSenha";
            picSenha.Size = new Size(40, 37);
            picSenha.SizeMode = PictureBoxSizeMode.StretchImage;
            picSenha.TabIndex = 37;
            picSenha.TabStop = false;
            picSenha.MouseLeave += picSenha_MouseLeave;
            picSenha.MouseHover += picSenha_MouseHover;
            // 
            // chkMostrarSenha
            // 
            chkMostrarSenha.AutoSize = true;
            chkMostrarSenha.Cursor = Cursors.Hand;
            chkMostrarSenha.FlatAppearance.BorderColor = Color.White;
            chkMostrarSenha.FlatAppearance.CheckedBackColor = SystemColors.Highlight;
            chkMostrarSenha.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 40);
            chkMostrarSenha.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 40);
            chkMostrarSenha.Font = new Font("Microsoft Sans Serif", 12F);
            chkMostrarSenha.ForeColor = Color.FromArgb(180, 180, 190);
            chkMostrarSenha.Location = new Point(324, 277);
            chkMostrarSenha.Name = "chkMostrarSenha";
            chkMostrarSenha.Size = new Size(163, 29);
            chkMostrarSenha.TabIndex = 28;
            chkMostrarSenha.Text = "Mostrar Senha";
            chkMostrarSenha.UseVisualStyleBackColor = true;
            chkMostrarSenha.CheckedChanged += chkMostrarSenha_CheckedChanged;
            // 
            // lbCpf
            // 
            lbCpf.AutoSize = true;
            lbCpf.BackColor = Color.FromArgb(30, 30, 40);
            lbCpf.Font = new Font("Microsoft Sans Serif", 12F);
            lbCpf.ForeColor = Color.FromArgb(180, 180, 190);
            lbCpf.Location = new Point(51, 364);
            lbCpf.Name = "lbCpf";
            lbCpf.Size = new Size(52, 25);
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
            btnCadastro.Location = new Point(51, 519);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(384, 41);
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
            UsTelefone.Location = new Point(51, 328);
            UsTelefone.Mask = "(00)00000-9999";
            UsTelefone.Name = "UsTelefone";
            UsTelefone.Size = new Size(384, 32);
            UsTelefone.TabIndex = 26;
            UsTelefone.TextChanged += UsTelefone_TextChanged;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BackColor = Color.White;
            maskedTextBox2.Font = new Font("Microsoft Sans Serif", 16F);
            maskedTextBox2.ForeColor = Color.FromArgb(40, 40, 50);
            maskedTextBox2.Location = new Point(51, 328);
            maskedTextBox2.Mask = "  000.000.000-00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(384, 32);
            maskedTextBox2.TabIndex = 25;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.BackColor = Color.FromArgb(30, 30, 40);
            lbTelefone.Font = new Font("Microsoft Sans Serif", 12F);
            lbTelefone.ForeColor = Color.FromArgb(180, 180, 190);
            lbTelefone.Location = new Point(51, 302);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(89, 25);
            lbTelefone.TabIndex = 24;
            lbTelefone.Text = "Telefone";
            // 
            // UsCpf
            // 
            UsCpf.BackColor = Color.FromArgb(224, 224, 224);
            UsCpf.Font = new Font("Microsoft Sans Serif", 16F);
            UsCpf.ForeColor = SystemColors.WindowText;
            UsCpf.Location = new Point(51, 390);
            UsCpf.Mask = " 000,000,000-00";
            UsCpf.Name = "UsCpf";
            UsCpf.Size = new Size(384, 32);
            UsCpf.TabIndex = 23;
            UsCpf.TextChanged += UsCpf_TextChanged;
            // 
            // mkCPF
            // 
            mkCPF.BackColor = Color.White;
            mkCPF.Font = new Font("Microsoft Sans Serif", 16F);
            mkCPF.ForeColor = Color.FromArgb(40, 40, 50);
            mkCPF.Location = new Point(51, 390);
            mkCPF.Mask = "  000.000.000-00";
            mkCPF.Name = "mkCPF";
            mkCPF.Size = new Size(384, 32);
            mkCPF.TabIndex = 22;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Microsoft Sans Serif", 12F);
            lbEmail.ForeColor = Color.FromArgb(180, 180, 190);
            lbEmail.Location = new Point(51, 425);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(60, 25);
            lbEmail.TabIndex = 19;
            lbEmail.Text = "Email";
            // 
            // UsEmail
            // 
            UsEmail.BackColor = Color.FromArgb(224, 224, 224);
            UsEmail.Font = new Font("Microsoft Sans Serif", 16F);
            UsEmail.Location = new Point(51, 451);
            UsEmail.Name = "UsEmail";
            UsEmail.PlaceholderText = "Digite o seu email";
            UsEmail.Size = new Size(384, 32);
            UsEmail.TabIndex = 18;
            UsEmail.TextChanged += UsEmail_TextChanged;
            // 
            // lbConfirmar
            // 
            lbConfirmar.AutoSize = true;
            lbConfirmar.Font = new Font("Microsoft Sans Serif", 12F);
            lbConfirmar.ForeColor = Color.FromArgb(180, 180, 190);
            lbConfirmar.Location = new Point(51, 215);
            lbConfirmar.Name = "lbConfirmar";
            lbConfirmar.Size = new Size(156, 25);
            lbConfirmar.TabIndex = 17;
            lbConfirmar.Text = "Confirmar senha";
            // 
            // ConfirmarSenha
            // 
            ConfirmarSenha.BackColor = Color.FromArgb(224, 224, 224);
            ConfirmarSenha.Font = new Font("Microsoft Sans Serif", 16F);
            ConfirmarSenha.Location = new Point(51, 239);
            ConfirmarSenha.Name = "ConfirmarSenha";
            ConfirmarSenha.PlaceholderText = "Confirme sua senha";
            ConfirmarSenha.Size = new Size(384, 32);
            ConfirmarSenha.TabIndex = 16;
            ConfirmarSenha.UseSystemPasswordChar = true;
            ConfirmarSenha.TextChanged += ConfirmarSenha_TextChanged;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Microsoft Sans Serif", 12F);
            lbSenha.ForeColor = Color.FromArgb(180, 180, 190);
            lbSenha.Location = new Point(51, 156);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(113, 25);
            lbSenha.TabIndex = 15;
            lbSenha.Text = "Criar senha";
            // 
            // UsSenha
            // 
            UsSenha.BackColor = Color.FromArgb(224, 224, 224);
            UsSenha.Font = new Font("Microsoft Sans Serif", 16F);
            UsSenha.Location = new Point(51, 180);
            UsSenha.Name = "UsSenha";
            UsSenha.PlaceholderText = "Digite sua senha";
            UsSenha.Size = new Size(384, 32);
            UsSenha.TabIndex = 14;
            UsSenha.UseSystemPasswordChar = true;
            UsSenha.TextChanged += UsSenha_TextChanged;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Microsoft Sans Serif", 12F);
            lbNome.ForeColor = Color.FromArgb(180, 180, 190);
            lbNome.Location = new Point(51, 97);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(160, 25);
            lbNome.TabIndex = 13;
            lbNome.Text = "Nome de usuário";
            // 
            // UsNome
            // 
            UsNome.BackColor = Color.FromArgb(224, 224, 224);
            UsNome.Font = new Font("Microsoft Sans Serif", 16F);
            UsNome.Location = new Point(51, 121);
            UsNome.Name = "UsNome";
            UsNome.PlaceholderText = "Digite o nome de usuario";
            UsNome.Size = new Size(384, 32);
            UsNome.TabIndex = 12;
            UsNome.TextChanged += UsNome_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Franklin Gothic Medium", 23F);
            label1.ForeColor = Color.FromArgb(180, 180, 190);
            label1.Location = new Point(61, 32);
            label1.Name = "label1";
            label1.Size = new Size(513, 60);
            label1.TabIndex = 9;
            label1.Text = "Cadastre seu funcionario!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 40);
            panel2.Controls.Add(dtgFuncionarios);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(btnExcluir);
            panel2.Controls.Add(BtnEditar);
            panel2.Controls.Add(lbCpfEd);
            panel2.Controls.Add(EdCpf);
            panel2.Controls.Add(EdTelefone);
            panel2.Controls.Add(lbEmailEd);
            panel2.Controls.Add(EdEmail);
            panel2.Controls.Add(lbTelefoneEd);
            panel2.Controls.Add(lbNomeEd);
            panel2.Controls.Add(EdNome);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(497, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(489, 616);
            panel2.TabIndex = 2;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Franklin Gothic Medium", 9F);
            label16.ForeColor = Color.FromArgb(180, 180, 190);
            label16.Location = new Point(17, 76);
            label16.Name = "label16";
            label16.Size = new Size(199, 20);
            label16.TabIndex = 76;
            label16.Text = "Clique em algum funcionario!\r\n";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.Font = new Font("Franklin Gothic Medium", 23F);
            label14.ForeColor = Color.FromArgb(180, 180, 190);
            label14.Location = new Point(80, 32);
            label14.Name = "label14";
            label14.Size = new Size(498, 60);
            label14.TabIndex = 59;
            label14.Text = "Selecione um fucionario!";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.Maroon;
            btnExcluir.Location = new Point(17, 566);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(206, 41);
            btnExcluir.TabIndex = 58;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = SystemColors.Highlight;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.FlatStyle = FlatStyle.Popup;
            BtnEditar.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEditar.ForeColor = Color.White;
            BtnEditar.Location = new Point(259, 566);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(221, 41);
            BtnEditar.TabIndex = 57;
            BtnEditar.Text = "Atualizar Conta";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // lbCpfEd
            // 
            lbCpfEd.AutoSize = true;
            lbCpfEd.BackColor = Color.FromArgb(30, 30, 40);
            lbCpfEd.Font = new Font("Microsoft Sans Serif", 12F);
            lbCpfEd.ForeColor = Color.FromArgb(180, 180, 190);
            lbCpfEd.Location = new Point(17, 411);
            lbCpfEd.Name = "lbCpfEd";
            lbCpfEd.Size = new Size(52, 25);
            lbCpfEd.TabIndex = 53;
            lbCpfEd.Text = "CPF";
            // 
            // EdCpf
            // 
            EdCpf.BackColor = Color.FromArgb(224, 224, 224);
            EdCpf.Font = new Font("Microsoft Sans Serif", 16F);
            EdCpf.ForeColor = SystemColors.WindowText;
            EdCpf.Location = new Point(17, 435);
            EdCpf.Mask = " 000.000.000-00";
            EdCpf.Name = "EdCpf";
            EdCpf.Size = new Size(405, 32);
            EdCpf.TabIndex = 49;
            EdCpf.TextChanged += EdCpf_TextChanged;
            // 
            // EdTelefone
            // 
            EdTelefone.BackColor = Color.FromArgb(224, 224, 224);
            EdTelefone.Font = new Font("Microsoft Sans Serif", 16F);
            EdTelefone.ForeColor = SystemColors.WindowText;
            EdTelefone.Location = new Point(17, 494);
            EdTelefone.Mask = "(00)00000-9999";
            EdTelefone.Name = "EdTelefone";
            EdTelefone.Size = new Size(405, 32);
            EdTelefone.TabIndex = 52;
            EdTelefone.TextChanged += EdTelefone_TextChanged;
            // 
            // lbEmailEd
            // 
            lbEmailEd.AutoSize = true;
            lbEmailEd.Font = new Font("Microsoft Sans Serif", 12F);
            lbEmailEd.ForeColor = Color.FromArgb(180, 180, 190);
            lbEmailEd.Location = new Point(17, 350);
            lbEmailEd.Name = "lbEmailEd";
            lbEmailEd.Size = new Size(60, 25);
            lbEmailEd.TabIndex = 47;
            lbEmailEd.Text = "Email";
            // 
            // EdEmail
            // 
            EdEmail.BackColor = Color.FromArgb(224, 224, 224);
            EdEmail.Font = new Font("Microsoft Sans Serif", 16F);
            EdEmail.Location = new Point(17, 376);
            EdEmail.Name = "EdEmail";
            EdEmail.PlaceholderText = "Digite o seu email";
            EdEmail.Size = new Size(405, 32);
            EdEmail.TabIndex = 46;
            EdEmail.TextChanged += EdEmail_TextChanged;
            // 
            // lbTelefoneEd
            // 
            lbTelefoneEd.AutoSize = true;
            lbTelefoneEd.BackColor = Color.FromArgb(30, 30, 40);
            lbTelefoneEd.Font = new Font("Microsoft Sans Serif", 12F);
            lbTelefoneEd.ForeColor = Color.FromArgb(180, 180, 190);
            lbTelefoneEd.Location = new Point(17, 470);
            lbTelefoneEd.Name = "lbTelefoneEd";
            lbTelefoneEd.Size = new Size(89, 25);
            lbTelefoneEd.TabIndex = 50;
            lbTelefoneEd.Text = "Telefone";
            // 
            // lbNomeEd
            // 
            lbNomeEd.AutoSize = true;
            lbNomeEd.Font = new Font("Microsoft Sans Serif", 12F);
            lbNomeEd.ForeColor = Color.FromArgb(180, 180, 190);
            lbNomeEd.Location = new Point(17, 286);
            lbNomeEd.Name = "lbNomeEd";
            lbNomeEd.Size = new Size(160, 25);
            lbNomeEd.TabIndex = 37;
            lbNomeEd.Text = "Nome de usuário";
            // 
            // EdNome
            // 
            EdNome.BackColor = Color.FromArgb(224, 224, 224);
            EdNome.Font = new Font("Microsoft Sans Serif", 16F);
            EdNome.Location = new Point(17, 315);
            EdNome.Name = "EdNome";
            EdNome.PlaceholderText = "Digite o nome de usuario";
            EdNome.Size = new Size(405, 32);
            EdNome.TabIndex = 36;
            EdNome.TextChanged += EdNome_TextChanged;
            // 
            // dtgFuncionarios
            // 
            dtgFuncionarios.AllowUserToAddRows = false;
            dtgFuncionarios.AllowUserToDeleteRows = false;
            dtgFuncionarios.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 35, 45);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dtgFuncionarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgFuncionarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgFuncionarios.BackgroundColor = Color.FromArgb(30, 35, 45);
            dtgFuncionarios.BorderStyle = BorderStyle.None;
            dtgFuncionarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 70);
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgFuncionarios.EnableHeadersVisualStyles = false;
            dtgFuncionarios.GridColor = Color.FromArgb(60, 60, 80);
            dtgFuncionarios.Location = new Point(17, 95);
            dtgFuncionarios.MultiSelect = false;
            dtgFuncionarios.Name = "dtgFuncionarios";
            dtgFuncionarios.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgFuncionarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgFuncionarios.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle4.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dtgFuncionarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgFuncionarios.RowTemplate.Height = 40;
            dtgFuncionarios.Size = new Size(463, 176);
            dtgFuncionarios.TabIndex = 6;
            dtgFuncionarios.CellClick += dtgFuncionarios_CellClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(989, 622);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // frmFuncionarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(989, 622);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(panel1);
            Controls.Add(panel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmFuncionarios";
            Text = "cadastroUsuario";
            Load += frmFuncionarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSenha).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgFuncionarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
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
        private Label lbCpfEd;
        private MaskedTextBox EdTelefone;
        private Label lbTelefoneEd;
        private MaskedTextBox EdCpf;
        private Label lbEmailEd;
        private TextBox EdEmail;
        private Label lbNomeEd;
        private TextBox EdNome;
        private DataGridView dtgFuncionarios;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label14;
        private Button btnExcluir;
        private Label label16;
        private PictureBox picSenha;
    }
}