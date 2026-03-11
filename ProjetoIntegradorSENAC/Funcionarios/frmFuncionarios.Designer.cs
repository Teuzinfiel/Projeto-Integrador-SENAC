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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            panel1.BackColor = Color.FromArgb(30, 30, 45);
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
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0, 0, 5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(479, 601);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // picSenha
            // 
            picSenha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picSenha.Image = Properties.Resources.pontoInterrogacao;
            picSenha.Location = new Point(433, 184);
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
            chkMostrarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkMostrarSenha.AutoSize = true;
            chkMostrarSenha.Cursor = Cursors.Hand;
            chkMostrarSenha.FlatAppearance.BorderColor = Color.White;
            chkMostrarSenha.FlatAppearance.CheckedBackColor = SystemColors.Highlight;
            chkMostrarSenha.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 40);
            chkMostrarSenha.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 40);
            chkMostrarSenha.Font = new Font("Microsoft Sans Serif", 12F);
            chkMostrarSenha.ForeColor = Color.FromArgb(180, 180, 190);
            chkMostrarSenha.Location = new Point(264, 300);
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
            lbCpf.Location = new Point(48, 385);
            lbCpf.Name = "lbCpf";
            lbCpf.Size = new Size(52, 25);
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
            btnCadastro.Location = new Point(44, 548);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(390, 41);
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
            UsTelefone.Location = new Point(51, 336);
            UsTelefone.Mask = "(00)00000-9999";
            UsTelefone.Name = "UsTelefone";
            UsTelefone.Size = new Size(375, 34);
            UsTelefone.TabIndex = 26;
            UsTelefone.TextChanged += UsTelefone_TextChanged;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.BackColor = Color.FromArgb(30, 30, 40);
            lbTelefone.Font = new Font("Microsoft Sans Serif", 12F);
            lbTelefone.ForeColor = Color.FromArgb(180, 180, 190);
            lbTelefone.Location = new Point(48, 308);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(89, 25);
            lbTelefone.TabIndex = 24;
            lbTelefone.Text = "Telefone";
            // 
            // UsCpf
            // 
            UsCpf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UsCpf.BackColor = Color.FromArgb(224, 224, 224);
            UsCpf.Font = new Font("Microsoft Sans Serif", 14F);
            UsCpf.ForeColor = SystemColors.WindowText;
            UsCpf.Location = new Point(51, 413);
            UsCpf.Mask = " 000,000,000-00";
            UsCpf.Name = "UsCpf";
            UsCpf.Size = new Size(375, 34);
            UsCpf.TabIndex = 23;
            UsCpf.TextChanged += UsCpf_TextChanged;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Microsoft Sans Serif", 12F);
            lbEmail.ForeColor = Color.FromArgb(180, 180, 190);
            lbEmail.Location = new Point(48, 464);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(60, 25);
            lbEmail.TabIndex = 19;
            lbEmail.Text = "Email";
            // 
            // UsEmail
            // 
            UsEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UsEmail.BackColor = Color.FromArgb(224, 224, 224);
            UsEmail.Font = new Font("Microsoft Sans Serif", 14F);
            UsEmail.Location = new Point(51, 492);
            UsEmail.Name = "UsEmail";
            UsEmail.PlaceholderText = "Digite o seu email";
            UsEmail.Size = new Size(375, 34);
            UsEmail.TabIndex = 18;
            UsEmail.TextChanged += UsEmail_TextChanged;
            // 
            // lbConfirmar
            // 
            lbConfirmar.AutoSize = true;
            lbConfirmar.Font = new Font("Microsoft Sans Serif", 12F);
            lbConfirmar.ForeColor = Color.FromArgb(180, 180, 190);
            lbConfirmar.Location = new Point(51, 227);
            lbConfirmar.Name = "lbConfirmar";
            lbConfirmar.Size = new Size(156, 25);
            lbConfirmar.TabIndex = 17;
            lbConfirmar.Text = "Confirmar senha";
            // 
            // ConfirmarSenha
            // 
            ConfirmarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ConfirmarSenha.BackColor = Color.FromArgb(224, 224, 224);
            ConfirmarSenha.Font = new Font("Microsoft Sans Serif", 14F);
            ConfirmarSenha.Location = new Point(51, 255);
            ConfirmarSenha.Name = "ConfirmarSenha";
            ConfirmarSenha.PlaceholderText = "Confirme sua senha";
            ConfirmarSenha.Size = new Size(375, 34);
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
            UsSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UsSenha.BackColor = Color.FromArgb(224, 224, 224);
            UsSenha.Font = new Font("Microsoft Sans Serif", 14F);
            UsSenha.Location = new Point(51, 184);
            UsSenha.Name = "UsSenha";
            UsSenha.PlaceholderText = "Digite sua senha";
            UsSenha.Size = new Size(375, 34);
            UsSenha.TabIndex = 14;
            UsSenha.UseSystemPasswordChar = true;
            UsSenha.TextChanged += UsSenha_TextChanged;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Microsoft Sans Serif", 12F);
            lbNome.ForeColor = Color.FromArgb(180, 180, 190);
            lbNome.Location = new Point(48, 76);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(160, 25);
            lbNome.TabIndex = 13;
            lbNome.Text = "Nome de usuário";
            // 
            // UsNome
            // 
            UsNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UsNome.BackColor = Color.FromArgb(224, 224, 224);
            UsNome.Font = new Font("Microsoft Sans Serif", 14F);
            UsNome.Location = new Point(51, 111);
            UsNome.Name = "UsNome";
            UsNome.PlaceholderText = "Digite o nome de usuario";
            UsNome.Size = new Size(375, 34);
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
            label1.Size = new Size(479, 60);
            label1.TabIndex = 9;
            label1.Text = "Cadastre seu funcionario!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 45);
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
            panel2.Location = new Point(489, 0);
            panel2.Margin = new Padding(5, 0, 0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(480, 601);
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Medium", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgFuncionarios.DefaultCellStyle = dataGridViewCellStyle3;
            dtgFuncionarios.EnableHeadersVisualStyles = false;
            dtgFuncionarios.GridColor = Color.FromArgb(60, 60, 80);
            dtgFuncionarios.Location = new Point(17, 95);
            dtgFuncionarios.MultiSelect = false;
            dtgFuncionarios.Name = "dtgFuncionarios";
            dtgFuncionarios.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle4.Font = new Font("Franklin Gothic Medium", 12F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgFuncionarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgFuncionarios.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle5.Font = new Font("Franklin Gothic Medium", 12F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dtgFuncionarios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dtgFuncionarios.RowTemplate.Height = 40;
            dtgFuncionarios.Size = new Size(454, 161);
            dtgFuncionarios.TabIndex = 6;
            dtgFuncionarios.CellClick += dtgFuncionarios_CellClick;
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
            label14.Dock = DockStyle.Top;
            label14.Font = new Font("Franklin Gothic Medium", 23F);
            label14.ForeColor = Color.FromArgb(180, 180, 190);
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(480, 60);
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
            btnExcluir.Location = new Point(17, 550);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(206, 41);
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
            BtnEditar.Location = new Point(274, 550);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(195, 41);
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
            lbCpfEd.Location = new Point(17, 402);
            lbCpfEd.Name = "lbCpfEd";
            lbCpfEd.Size = new Size(52, 25);
            lbCpfEd.TabIndex = 53;
            lbCpfEd.Text = "CPF";
            // 
            // EdCpf
            // 
            EdCpf.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EdCpf.BackColor = Color.FromArgb(224, 224, 224);
            EdCpf.Font = new Font("Microsoft Sans Serif", 14F);
            EdCpf.ForeColor = SystemColors.WindowText;
            EdCpf.Location = new Point(17, 432);
            EdCpf.Mask = " 000,000,000-00";
            EdCpf.Name = "EdCpf";
            EdCpf.Size = new Size(437, 34);
            EdCpf.TabIndex = 49;
            EdCpf.TextChanged += EdCpf_TextChanged;
            // 
            // EdTelefone
            // 
            EdTelefone.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EdTelefone.BackColor = Color.FromArgb(224, 224, 224);
            EdTelefone.Font = new Font("Microsoft Sans Serif", 14F);
            EdTelefone.ForeColor = SystemColors.WindowText;
            EdTelefone.Location = new Point(17, 502);
            EdTelefone.Mask = "(00)00000-9999";
            EdTelefone.Name = "EdTelefone";
            EdTelefone.Size = new Size(437, 34);
            EdTelefone.TabIndex = 52;
            EdTelefone.TextChanged += EdTelefone_TextChanged;
            // 
            // lbEmailEd
            // 
            lbEmailEd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbEmailEd.AutoSize = true;
            lbEmailEd.Font = new Font("Microsoft Sans Serif", 12F);
            lbEmailEd.ForeColor = Color.FromArgb(180, 180, 190);
            lbEmailEd.Location = new Point(17, 334);
            lbEmailEd.Name = "lbEmailEd";
            lbEmailEd.Size = new Size(60, 25);
            lbEmailEd.TabIndex = 47;
            lbEmailEd.Text = "Email";
            // 
            // EdEmail
            // 
            EdEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EdEmail.BackColor = Color.FromArgb(224, 224, 224);
            EdEmail.Font = new Font("Microsoft Sans Serif", 14F);
            EdEmail.Location = new Point(17, 361);
            EdEmail.Name = "EdEmail";
            EdEmail.PlaceholderText = "Digite o seu email";
            EdEmail.Size = new Size(437, 34);
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
            lbTelefoneEd.Location = new Point(17, 473);
            lbTelefoneEd.Name = "lbTelefoneEd";
            lbTelefoneEd.Size = new Size(89, 25);
            lbTelefoneEd.TabIndex = 50;
            lbTelefoneEd.Text = "Telefone";
            // 
            // lbNomeEd
            // 
            lbNomeEd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbNomeEd.AutoSize = true;
            lbNomeEd.Font = new Font("Microsoft Sans Serif", 12F);
            lbNomeEd.ForeColor = Color.FromArgb(180, 180, 190);
            lbNomeEd.Location = new Point(17, 264);
            lbNomeEd.Name = "lbNomeEd";
            lbNomeEd.Size = new Size(160, 25);
            lbNomeEd.TabIndex = 37;
            lbNomeEd.Text = "Nome de usuário";
            // 
            // EdNome
            // 
            EdNome.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EdNome.BackColor = Color.FromArgb(224, 224, 224);
            EdNome.Font = new Font("Microsoft Sans Serif", 14F);
            EdNome.Location = new Point(17, 293);
            EdNome.Name = "EdNome";
            EdNome.PlaceholderText = "Digite o nome de usuario";
            EdNome.Size = new Size(437, 34);
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
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(969, 601);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // frmFuncionarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(989, 621);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmFuncionarios";
            Padding = new Padding(10);
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