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
            lbTelefone = new Label();
            UsCpf = new MaskedTextBox();
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
            dtgFuncionarios = new DataGridView();
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
            panel1.Controls.Add(lbTelefone);
            panel1.Controls.Add(UsCpf);
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
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 462);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // picSenha
            // 
            picSenha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picSenha.Image = Properties.Resources.pontoInterrogacao;
            picSenha.Location = new Point(386, 138);
            picSenha.Margin = new Padding(3, 2, 3, 2);
            picSenha.Name = "picSenha";
            picSenha.Size = new Size(35, 28);
            picSenha.SizeMode = PictureBoxSizeMode.StretchImage;
            picSenha.TabIndex = 37;
            picSenha.TabStop = false;
            picSenha.MouseLeave += picSenha_MouseLeave;
            picSenha.MouseHover += picSenha_MouseHover;
            // 
            // chkMostrarSenha
            // 
            chkMostrarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkMostrarSenha.AutoSize = true;
            chkMostrarSenha.Cursor = Cursors.Hand;
            chkMostrarSenha.FlatAppearance.BorderColor = Color.White;
            chkMostrarSenha.FlatAppearance.CheckedBackColor = SystemColors.Highlight;
            chkMostrarSenha.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 40);
            chkMostrarSenha.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 40);
            chkMostrarSenha.Font = new Font("Microsoft Sans Serif", 12F);
            chkMostrarSenha.ForeColor = Color.FromArgb(180, 180, 190);
            chkMostrarSenha.Location = new Point(248, 225);
            chkMostrarSenha.Margin = new Padding(3, 2, 3, 2);
            chkMostrarSenha.Name = "chkMostrarSenha";
            chkMostrarSenha.Size = new Size(133, 24);
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
            lbCpf.Location = new Point(42, 289);
            lbCpf.Name = "lbCpf";
            lbCpf.Size = new Size(40, 20);
            lbCpf.TabIndex = 27;
            lbCpf.Text = "CPF";
            // 
            // btnCadastro
            // 
            btnCadastro.Anchor = AnchorStyles.Bottom;
            btnCadastro.BackColor = SystemColors.Highlight;
            btnCadastro.Cursor = Cursors.Hand;
            btnCadastro.FlatStyle = FlatStyle.Popup;
            btnCadastro.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastro.ForeColor = Color.White;
            btnCadastro.Location = new Point(42, 422);
            btnCadastro.Margin = new Padding(3, 2, 3, 2);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(336, 31);
            btnCadastro.TabIndex = 17;
            btnCadastro.Text = "Criar conta";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // UsTelefone
            // 
            UsTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UsTelefone.BackColor = Color.FromArgb(224, 224, 224);
            UsTelefone.Font = new Font("Microsoft Sans Serif", 14F);
            UsTelefone.ForeColor = SystemColors.WindowText;
            UsTelefone.Location = new Point(42, 253);
            UsTelefone.Margin = new Padding(3, 2, 3, 2);
            UsTelefone.Mask = "(00)00000-9999";
            UsTelefone.Name = "UsTelefone";
            UsTelefone.Size = new Size(336, 29);
            UsTelefone.TabIndex = 26;
            UsTelefone.TextChanged += UsTelefone_TextChanged;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.BackColor = Color.FromArgb(30, 30, 40);
            lbTelefone.Font = new Font("Microsoft Sans Serif", 12F);
            lbTelefone.ForeColor = Color.FromArgb(180, 180, 190);
            lbTelefone.Location = new Point(42, 231);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(71, 20);
            lbTelefone.TabIndex = 24;
            lbTelefone.Text = "Telefone";
            // 
            // UsCpf
            // 
            UsCpf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UsCpf.BackColor = Color.FromArgb(224, 224, 224);
            UsCpf.Font = new Font("Microsoft Sans Serif", 14F);
            UsCpf.ForeColor = SystemColors.WindowText;
            UsCpf.Location = new Point(42, 317);
            UsCpf.Margin = new Padding(3, 2, 3, 2);
            UsCpf.Mask = " 000,000,000-00";
            UsCpf.Name = "UsCpf";
            UsCpf.Size = new Size(336, 29);
            UsCpf.TabIndex = 23;
            UsCpf.TextChanged += UsCpf_TextChanged;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Microsoft Sans Serif", 12F);
            lbEmail.ForeColor = Color.FromArgb(180, 180, 190);
            lbEmail.Location = new Point(42, 348);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(48, 20);
            lbEmail.TabIndex = 19;
            lbEmail.Text = "Email";
            // 
            // UsEmail
            // 
            UsEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UsEmail.BackColor = Color.FromArgb(224, 224, 224);
            UsEmail.Font = new Font("Microsoft Sans Serif", 14F);
            UsEmail.Location = new Point(42, 370);
            UsEmail.Margin = new Padding(3, 2, 3, 2);
            UsEmail.Name = "UsEmail";
            UsEmail.PlaceholderText = "Digite o seu email";
            UsEmail.Size = new Size(336, 29);
            UsEmail.TabIndex = 18;
            UsEmail.TextChanged += UsEmail_TextChanged;
            // 
            // lbConfirmar
            // 
            lbConfirmar.AutoSize = true;
            lbConfirmar.Font = new Font("Microsoft Sans Serif", 12F);
            lbConfirmar.ForeColor = Color.FromArgb(180, 180, 190);
            lbConfirmar.Location = new Point(45, 170);
            lbConfirmar.Name = "lbConfirmar";
            lbConfirmar.Size = new Size(126, 20);
            lbConfirmar.TabIndex = 17;
            lbConfirmar.Text = "Confirmar senha";
            // 
            // ConfirmarSenha
            // 
            ConfirmarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ConfirmarSenha.BackColor = Color.FromArgb(224, 224, 224);
            ConfirmarSenha.Font = new Font("Microsoft Sans Serif", 14F);
            ConfirmarSenha.Location = new Point(42, 192);
            ConfirmarSenha.Margin = new Padding(3, 2, 3, 2);
            ConfirmarSenha.Name = "ConfirmarSenha";
            ConfirmarSenha.PlaceholderText = "Confirme sua senha";
            ConfirmarSenha.Size = new Size(336, 29);
            ConfirmarSenha.TabIndex = 16;
            ConfirmarSenha.UseSystemPasswordChar = true;
            ConfirmarSenha.TextChanged += ConfirmarSenha_TextChanged;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Microsoft Sans Serif", 12F);
            lbSenha.ForeColor = Color.FromArgb(180, 180, 190);
            lbSenha.Location = new Point(45, 117);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(90, 20);
            lbSenha.TabIndex = 15;
            lbSenha.Text = "Criar senha";
            // 
            // UsSenha
            // 
            UsSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UsSenha.BackColor = Color.FromArgb(224, 224, 224);
            UsSenha.Font = new Font("Microsoft Sans Serif", 14F);
            UsSenha.Location = new Point(45, 137);
            UsSenha.Margin = new Padding(3, 2, 3, 2);
            UsSenha.Name = "UsSenha";
            UsSenha.PlaceholderText = "Digite sua senha";
            UsSenha.Size = new Size(336, 29);
            UsSenha.TabIndex = 14;
            UsSenha.UseSystemPasswordChar = true;
            UsSenha.TextChanged += UsSenha_TextChanged;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Microsoft Sans Serif", 12F);
            lbNome.ForeColor = Color.FromArgb(180, 180, 190);
            lbNome.Location = new Point(42, 57);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(129, 20);
            lbNome.TabIndex = 13;
            lbNome.Text = "Nome de usuário";
            // 
            // UsNome
            // 
            UsNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UsNome.BackColor = Color.FromArgb(224, 224, 224);
            UsNome.Font = new Font("Microsoft Sans Serif", 14F);
            UsNome.Location = new Point(45, 83);
            UsNome.Margin = new Padding(3, 2, 3, 2);
            UsNome.Name = "UsNome";
            UsNome.PlaceholderText = "Digite o nome de usuario";
            UsNome.Size = new Size(336, 29);
            UsNome.TabIndex = 12;
            UsNome.TextChanged += UsNome_TextChanged;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Franklin Gothic Medium", 23F);
            label1.ForeColor = Color.FromArgb(180, 180, 190);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(426, 45);
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
            panel2.Location = new Point(435, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 462);
            panel2.TabIndex = 2;
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
            dtgFuncionarios.Location = new Point(15, 71);
            dtgFuncionarios.Margin = new Padding(3, 2, 3, 2);
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
            dtgFuncionarios.Size = new Size(404, 132);
            dtgFuncionarios.TabIndex = 6;
            dtgFuncionarios.CellClick += dtgFuncionarios_CellClick;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Franklin Gothic Medium", 9F);
            label16.ForeColor = Color.FromArgb(180, 180, 190);
            label16.Location = new Point(15, 57);
            label16.Name = "label16";
            label16.Size = new Size(151, 16);
            label16.TabIndex = 76;
            label16.Text = "Clique em algum funcionario!\r\n";
            // 
            // label14
            // 
            label14.Dock = DockStyle.Top;
            label14.Font = new Font("Franklin Gothic Medium", 23F);
            label14.ForeColor = Color.FromArgb(180, 180, 190);
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(427, 45);
            label14.TabIndex = 59;
            label14.Text = "Selecione um fucionario!";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.Maroon;
            btnExcluir.Location = new Point(3, 424);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(180, 31);
            btnExcluir.TabIndex = 58;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnEditar.BackColor = SystemColors.Highlight;
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.FlatStyle = FlatStyle.Popup;
            BtnEditar.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEditar.ForeColor = Color.White;
            BtnEditar.Location = new Point(247, 424);
            BtnEditar.Margin = new Padding(3, 2, 3, 2);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(171, 31);
            BtnEditar.TabIndex = 57;
            BtnEditar.Text = "Atualizar Conta";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // lbCpfEd
            // 
            lbCpfEd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbCpfEd.AutoSize = true;
            lbCpfEd.BackColor = Color.FromArgb(30, 30, 40);
            lbCpfEd.Font = new Font("Microsoft Sans Serif", 12F);
            lbCpfEd.ForeColor = Color.FromArgb(180, 180, 190);
            lbCpfEd.Location = new Point(15, 313);
            lbCpfEd.Name = "lbCpfEd";
            lbCpfEd.Size = new Size(40, 20);
            lbCpfEd.TabIndex = 53;
            lbCpfEd.Text = "CPF";
            // 
            // EdCpf
            // 
            EdCpf.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EdCpf.BackColor = Color.FromArgb(224, 224, 224);
            EdCpf.Font = new Font("Microsoft Sans Serif", 14F);
            EdCpf.ForeColor = SystemColors.WindowText;
            EdCpf.Location = new Point(15, 335);
            EdCpf.Margin = new Padding(3, 2, 3, 2);
            EdCpf.Mask = " 000,000,000-00";
            EdCpf.Name = "EdCpf";
            EdCpf.Size = new Size(355, 29);
            EdCpf.TabIndex = 49;
            EdCpf.TextChanged += EdCpf_TextChanged;
            // 
            // EdTelefone
            // 
            EdTelefone.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EdTelefone.BackColor = Color.FromArgb(224, 224, 224);
            EdTelefone.Font = new Font("Microsoft Sans Serif", 14F);
            EdTelefone.ForeColor = SystemColors.WindowText;
            EdTelefone.Location = new Point(15, 388);
            EdTelefone.Margin = new Padding(3, 2, 3, 2);
            EdTelefone.Mask = "(00)00000-9999";
            EdTelefone.Name = "EdTelefone";
            EdTelefone.Size = new Size(355, 29);
            EdTelefone.TabIndex = 52;
            EdTelefone.TextChanged += EdTelefone_TextChanged;
            // 
            // lbEmailEd
            // 
            lbEmailEd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbEmailEd.AutoSize = true;
            lbEmailEd.Font = new Font("Microsoft Sans Serif", 12F);
            lbEmailEd.ForeColor = Color.FromArgb(180, 180, 190);
            lbEmailEd.Location = new Point(15, 262);
            lbEmailEd.Name = "lbEmailEd";
            lbEmailEd.Size = new Size(48, 20);
            lbEmailEd.TabIndex = 47;
            lbEmailEd.Text = "Email";
            // 
            // EdEmail
            // 
            EdEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EdEmail.BackColor = Color.FromArgb(224, 224, 224);
            EdEmail.Font = new Font("Microsoft Sans Serif", 14F);
            EdEmail.Location = new Point(15, 282);
            EdEmail.Margin = new Padding(3, 2, 3, 2);
            EdEmail.Name = "EdEmail";
            EdEmail.PlaceholderText = "Digite o seu email";
            EdEmail.Size = new Size(355, 29);
            EdEmail.TabIndex = 46;
            EdEmail.TextChanged += EdEmail_TextChanged;
            // 
            // lbTelefoneEd
            // 
            lbTelefoneEd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbTelefoneEd.AutoSize = true;
            lbTelefoneEd.BackColor = Color.FromArgb(30, 30, 40);
            lbTelefoneEd.Font = new Font("Microsoft Sans Serif", 12F);
            lbTelefoneEd.ForeColor = Color.FromArgb(180, 180, 190);
            lbTelefoneEd.Location = new Point(15, 366);
            lbTelefoneEd.Name = "lbTelefoneEd";
            lbTelefoneEd.Size = new Size(71, 20);
            lbTelefoneEd.TabIndex = 50;
            lbTelefoneEd.Text = "Telefone";
            // 
            // lbNomeEd
            // 
            lbNomeEd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbNomeEd.AutoSize = true;
            lbNomeEd.Font = new Font("Microsoft Sans Serif", 12F);
            lbNomeEd.ForeColor = Color.FromArgb(180, 180, 190);
            lbNomeEd.Location = new Point(15, 209);
            lbNomeEd.Name = "lbNomeEd";
            lbNomeEd.Size = new Size(129, 20);
            lbNomeEd.TabIndex = 37;
            lbNomeEd.Text = "Nome de usuário";
            // 
            // EdNome
            // 
            EdNome.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EdNome.BackColor = Color.FromArgb(224, 224, 224);
            EdNome.Font = new Font("Microsoft Sans Serif", 14F);
            EdNome.Location = new Point(15, 231);
            EdNome.Margin = new Padding(3, 2, 3, 2);
            EdNome.Name = "EdNome";
            EdNome.PlaceholderText = "Digite o nome de usuario";
            EdNome.Size = new Size(355, 29);
            EdNome.TabIndex = 36;
            EdNome.TextChanged += EdNome_TextChanged;
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
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(865, 466);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // frmFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(865, 466);
            Controls.Add(tableLayoutPanel1);
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
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox chkMostrarSenha;
        private Label lbCpf;
        private Button btnCadastro;
        private MaskedTextBox UsTelefone;
        private Label lbTelefone;
        private MaskedTextBox UsCpf;
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