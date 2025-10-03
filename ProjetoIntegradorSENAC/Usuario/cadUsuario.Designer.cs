namespace ProjetoIntegradorSENAC.Usuario
{
    partial class cadUsuario
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
            chkMostrarSenha = new CheckBox();
            btnLimpar = new Button();
            label7 = new Label();
            btnCadastro = new Button();
            UsTelefone = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            label6 = new Label();
            UsCpf = new MaskedTextBox();
            mkCPF = new MaskedTextBox();
            label5 = new Label();
            UsEmail = new TextBox();
            label4 = new Label();
            ConfirmarSenha = new TextBox();
            label3 = new Label();
            UsSenha = new TextBox();
            label2 = new Label();
            UsNome = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(chkMostrarSenha);
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnCadastro);
            panel1.Controls.Add(UsTelefone);
            panel1.Controls.Add(maskedTextBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(UsCpf);
            panel1.Controls.Add(mkCPF);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(UsEmail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ConfirmarSenha);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(UsSenha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(UsNome);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(114, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(819, 577);
            panel1.TabIndex = 0;
            // 
            // chkMostrarSenha
            // 
            chkMostrarSenha.AutoSize = true;
            chkMostrarSenha.Cursor = Cursors.Hand;
            chkMostrarSenha.FlatAppearance.BorderColor = Color.White;
            chkMostrarSenha.FlatAppearance.CheckedBackColor = SystemColors.Highlight;
            chkMostrarSenha.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 40);
            chkMostrarSenha.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 40);
            chkMostrarSenha.Font = new Font("Segoe UI", 13F);
            chkMostrarSenha.ForeColor = Color.FromArgb(180, 180, 190);
            chkMostrarSenha.Location = new Point(639, 266);
            chkMostrarSenha.Name = "chkMostrarSenha";
            chkMostrarSenha.Size = new Size(146, 29);
            chkMostrarSenha.TabIndex = 28;
            chkMostrarSenha.Text = "Mostrar Senha";
            chkMostrarSenha.UseVisualStyleBackColor = true;
            chkMostrarSenha.CheckedChanged += chkMostrarSenha_CheckedChanged;
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
            btnLimpar.Location = new Point(28, 506);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(348, 37);
            btnLimpar.TabIndex = 18;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(40, 40, 50);
            label7.Font = new Font("Franklin Gothic Medium", 15F);
            label7.ForeColor = Color.FromArgb(180, 180, 190);
            label7.Location = new Point(28, 267);
            label7.Name = "label7";
            label7.Size = new Size(46, 25);
            label7.TabIndex = 27;
            label7.Text = "CPF";
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = SystemColors.Highlight;
            btnCadastro.Cursor = Cursors.Hand;
            btnCadastro.FlatStyle = FlatStyle.Popup;
            btnCadastro.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastro.ForeColor = Color.White;
            btnCadastro.Location = new Point(28, 445);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(348, 37);
            btnCadastro.TabIndex = 17;
            btnCadastro.Text = "Criar conta";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // UsTelefone
            // 
            UsTelefone.BackColor = Color.FromArgb(224, 224, 224);
            UsTelefone.Font = new Font("Franklin Gothic Book", 20.25F);
            UsTelefone.ForeColor = SystemColors.WindowText;
            UsTelefone.Location = new Point(28, 374);
            UsTelefone.Mask = "(00)00000-9999";
            UsTelefone.Name = "UsTelefone";
            UsTelefone.Size = new Size(348, 38);
            UsTelefone.TabIndex = 26;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BackColor = Color.White;
            maskedTextBox2.Font = new Font("Franklin Gothic Book", 20.25F);
            maskedTextBox2.ForeColor = Color.FromArgb(40, 40, 50);
            maskedTextBox2.Location = new Point(28, 374);
            maskedTextBox2.Mask = "  000.000.000-00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(348, 38);
            maskedTextBox2.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(40, 40, 50);
            label6.Font = new Font("Franklin Gothic Medium", 15F);
            label6.ForeColor = Color.FromArgb(180, 180, 190);
            label6.Location = new Point(28, 346);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 24;
            label6.Text = "Telefone";
            // 
            // UsCpf
            // 
            UsCpf.BackColor = Color.FromArgb(224, 224, 224);
            UsCpf.Font = new Font("Franklin Gothic Book", 20.25F);
            UsCpf.ForeColor = SystemColors.WindowText;
            UsCpf.Location = new Point(28, 295);
            UsCpf.Mask = "  000.000.000-00";
            UsCpf.Name = "UsCpf";
            UsCpf.Size = new Size(348, 38);
            UsCpf.TabIndex = 23;
            UsCpf.TextChanged += UsCpf_TextChanged;
            // 
            // mkCPF
            // 
            mkCPF.BackColor = Color.White;
            mkCPF.Font = new Font("Franklin Gothic Book", 20.25F);
            mkCPF.ForeColor = Color.FromArgb(40, 40, 50);
            mkCPF.Location = new Point(28, 295);
            mkCPF.Mask = "  000.000.000-00";
            mkCPF.Name = "mkCPF";
            mkCPF.Size = new Size(348, 38);
            mkCPF.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 12F);
            label5.ForeColor = Color.FromArgb(180, 180, 190);
            label5.Location = new Point(28, 204);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 19;
            label5.Text = "Email";
            // 
            // UsEmail
            // 
            UsEmail.BackColor = Color.FromArgb(224, 224, 224);
            UsEmail.Font = new Font("Franklin Gothic Book", 16F);
            UsEmail.Location = new Point(28, 228);
            UsEmail.Name = "UsEmail";
            UsEmail.PlaceholderText = "Digite o seu email";
            UsEmail.Size = new Size(348, 32);
            UsEmail.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 12F);
            label4.ForeColor = Color.FromArgb(180, 180, 190);
            label4.Location = new Point(437, 204);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 17;
            label4.Text = "Confirmar senha";
            // 
            // ConfirmarSenha
            // 
            ConfirmarSenha.BackColor = Color.FromArgb(224, 224, 224);
            ConfirmarSenha.Font = new Font("Franklin Gothic Book", 16F);
            ConfirmarSenha.Location = new Point(437, 228);
            ConfirmarSenha.Name = "ConfirmarSenha";
            ConfirmarSenha.PlaceholderText = "Confirme sua senha";
            ConfirmarSenha.Size = new Size(348, 32);
            ConfirmarSenha.TabIndex = 16;
            ConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 12F);
            label3.ForeColor = Color.FromArgb(180, 180, 190);
            label3.Location = new Point(437, 136);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 15;
            label3.Text = "Criar senha";
            // 
            // UsSenha
            // 
            UsSenha.BackColor = Color.FromArgb(224, 224, 224);
            UsSenha.Font = new Font("Franklin Gothic Book", 16F);
            UsSenha.Location = new Point(437, 160);
            UsSenha.Name = "UsSenha";
            UsSenha.PlaceholderText = "Digite sua senha";
            UsSenha.Size = new Size(348, 32);
            UsSenha.TabIndex = 14;
            UsSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F);
            label2.ForeColor = Color.FromArgb(180, 180, 190);
            label2.Location = new Point(28, 128);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 13;
            label2.Text = "Nome de usuário";
            // 
            // UsNome
            // 
            UsNome.BackColor = Color.FromArgb(224, 224, 224);
            UsNome.Font = new Font("Franklin Gothic Book", 16F);
            UsNome.Location = new Point(28, 152);
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
            label1.Location = new Point(276, 53);
            label1.Name = "label1";
            label1.Size = new Size(274, 37);
            label1.TabIndex = 9;
            label1.Text = "Cadastre sua conta";
            // 
            // cadUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(1107, 800);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "cadUsuario";
            Text = "cadUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox UsNome;
        private Label label3;
        private TextBox UsSenha;
        private Label label5;
        private TextBox UsEmail;
        private Label label4;
        private TextBox ConfirmarSenha;
        private Label label7;
        private MaskedTextBox UsTelefone;
        private MaskedTextBox maskedTextBox2;
        private Label label6;
        private MaskedTextBox UsCpf;
        private MaskedTextBox mkCPF;
        private Button btnLimpar;
        private Button btnCadastro;
        private CheckBox chkMostrarSenha;
    }
}