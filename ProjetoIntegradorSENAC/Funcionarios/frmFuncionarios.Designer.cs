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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
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
            panel1.Location = new Point(179, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 577);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // astConfirmar
            // 
            astConfirmar.AutoSize = true;
            astConfirmar.Font = new Font("Franklin Gothic Medium Cond", 12F);
            astConfirmar.ForeColor = Color.FromArgb(192, 0, 0);
            astConfirmar.Location = new Point(272, 275);
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
            astSenha.Location = new Point(236, 219);
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
            astTelefone.Location = new Point(583, 160);
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
            astCpf.Location = new Point(574, 220);
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
            astEmail.Location = new Point(574, 280);
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
            astNome.Location = new Point(276, 160);
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
            chkMostrarSenha.Location = new Point(154, 336);
            chkMostrarSenha.Name = "chkMostrarSenha";
            chkMostrarSenha.Size = new Size(111, 25);
            chkMostrarSenha.TabIndex = 28;
            chkMostrarSenha.Text = "Mostrar Senha";
            chkMostrarSenha.UseVisualStyleBackColor = true;
            chkMostrarSenha.CheckedChanged += this.chkMostrarSenha_CheckedChanged;
            // 
            // lbCpf
            // 
            lbCpf.AutoSize = true;
            lbCpf.BackColor = Color.FromArgb(40, 40, 50);
            lbCpf.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbCpf.ForeColor = Color.FromArgb(180, 180, 190);
            lbCpf.Location = new Point(528, 219);
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
            btnCadastro.Location = new Point(528, 354);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(348, 41);
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
            UsTelefone.Location = new Point(528, 184);
            UsTelefone.Mask = "(00)00000-9999";
            UsTelefone.Name = "UsTelefone";
            UsTelefone.Size = new Size(348, 32);
            UsTelefone.TabIndex = 26;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BackColor = Color.White;
            maskedTextBox2.Font = new Font("Microsoft Sans Serif", 16F);
            maskedTextBox2.ForeColor = Color.FromArgb(40, 40, 50);
            maskedTextBox2.Location = new Point(528, 184);
            maskedTextBox2.Mask = "  000.000.000-00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(348, 32);
            maskedTextBox2.TabIndex = 25;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.BackColor = Color.FromArgb(40, 40, 50);
            lbTelefone.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbTelefone.ForeColor = Color.FromArgb(180, 180, 190);
            lbTelefone.Location = new Point(528, 160);
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
            UsCpf.Location = new Point(528, 243);
            UsCpf.Mask = " 000.000.000-00";
            UsCpf.Name = "UsCpf";
            UsCpf.Size = new Size(348, 32);
            UsCpf.TabIndex = 23;
            // 
            // mkCPF
            // 
            mkCPF.BackColor = Color.White;
            mkCPF.Font = new Font("Microsoft Sans Serif", 16F);
            mkCPF.ForeColor = Color.FromArgb(40, 40, 50);
            mkCPF.Location = new Point(528, 243);
            mkCPF.Mask = "  000.000.000-00";
            mkCPF.Name = "mkCPF";
            mkCPF.Size = new Size(348, 32);
            mkCPF.TabIndex = 22;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbEmail.ForeColor = Color.FromArgb(180, 180, 190);
            lbEmail.Location = new Point(528, 280);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(43, 21);
            lbEmail.TabIndex = 19;
            lbEmail.Text = "Email";
            // 
            // UsEmail
            // 
            UsEmail.BackColor = Color.FromArgb(224, 224, 224);
            UsEmail.Font = new Font("Microsoft Sans Serif", 16F);
            UsEmail.Location = new Point(528, 304);
            UsEmail.Name = "UsEmail";
            UsEmail.PlaceholderText = "Digite o seu email";
            UsEmail.Size = new Size(348, 32);
            UsEmail.TabIndex = 18;
            // 
            // lbConfirmar
            // 
            lbConfirmar.AutoSize = true;
            lbConfirmar.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbConfirmar.ForeColor = Color.FromArgb(180, 180, 190);
            lbConfirmar.Location = new Point(154, 278);
            lbConfirmar.Name = "lbConfirmar";
            lbConfirmar.Size = new Size(103, 21);
            lbConfirmar.TabIndex = 17;
            lbConfirmar.Text = "Confirmar senha";
            // 
            // ConfirmarSenha
            // 
            ConfirmarSenha.BackColor = Color.FromArgb(224, 224, 224);
            ConfirmarSenha.Font = new Font("Microsoft Sans Serif", 16F);
            ConfirmarSenha.Location = new Point(154, 302);
            ConfirmarSenha.Name = "ConfirmarSenha";
            ConfirmarSenha.PlaceholderText = "Confirme sua senha";
            ConfirmarSenha.Size = new Size(348, 32);
            ConfirmarSenha.TabIndex = 16;
            ConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbSenha.ForeColor = Color.FromArgb(180, 180, 190);
            lbSenha.Location = new Point(154, 219);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(74, 21);
            lbSenha.TabIndex = 15;
            lbSenha.Text = "Criar senha";
            // 
            // UsSenha
            // 
            UsSenha.BackColor = Color.FromArgb(224, 224, 224);
            UsSenha.Font = new Font("Microsoft Sans Serif", 16F);
            UsSenha.Location = new Point(154, 243);
            UsSenha.Name = "UsSenha";
            UsSenha.PlaceholderText = "Digite sua senha";
            UsSenha.Size = new Size(348, 32);
            UsSenha.TabIndex = 14;
            UsSenha.UseSystemPasswordChar = true;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Franklin Gothic Medium Cond", 12F);
            lbNome.ForeColor = Color.FromArgb(180, 180, 190);
            lbNome.Location = new Point(154, 160);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(107, 21);
            lbNome.TabIndex = 13;
            lbNome.Text = "Nome de usuário";
            // 
            // UsNome
            // 
            UsNome.BackColor = Color.FromArgb(224, 224, 224);
            UsNome.Font = new Font("Microsoft Sans Serif", 16F);
            UsNome.Location = new Point(154, 184);
            UsNome.Name = "UsNome";
            UsNome.PlaceholderText = "Digite o nome de usuario";
            UsNome.Size = new Size(348, 32);
            UsNome.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 23F);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(387, 51);
            label1.Name = "label1";
            label1.Size = new Size(274, 37);
            label1.TabIndex = 9;
            label1.Text = "Cadastre sua conta";
            // 
            // frmFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(1326, 686);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFuncionarios";
            Text = "cadastroUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}