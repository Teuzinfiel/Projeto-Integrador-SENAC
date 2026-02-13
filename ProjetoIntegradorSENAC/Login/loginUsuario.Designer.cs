namespace ProjetoIntegradorSENAC.Logins
{
    partial class loginUsuario
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            recuperarConta = new Label();
            label8 = new Label();
            CriarConta = new Label();
            label4 = new Label();
            chkMostrarSenha = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            btnLogin = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel2 = new Panel();
            btnMinimizar = new Button();
            btnSair = new Button();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(recuperarConta);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(CriarConta);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(chkMostrarSenha);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(30, 69);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 627);
            panel1.TabIndex = 1;
            // 
            // recuperarConta
            // 
            recuperarConta.AutoSize = true;
            recuperarConta.Cursor = Cursors.Hand;
            recuperarConta.Font = new Font("Franklin Gothic Medium", 12F);
            recuperarConta.ForeColor = SystemColors.Highlight;
            recuperarConta.Location = new Point(297, 496);
            recuperarConta.Name = "recuperarConta";
            recuperarConta.Size = new Size(166, 25);
            recuperarConta.TabIndex = 20;
            recuperarConta.Text = "Recuperar Senha!";
            recuperarConta.Click += recuperarConta_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Medium", 12F);
            label8.ForeColor = Color.FromArgb(180, 180, 190);
            label8.Location = new Point(293, 464);
            label8.Name = "label8";
            label8.Size = new Size(177, 25);
            label8.TabIndex = 19;
            label8.Text = "Esqueceu a senha?";
            // 
            // CriarConta
            // 
            CriarConta.AutoSize = true;
            CriarConta.Cursor = Cursors.Hand;
            CriarConta.Font = new Font("Franklin Gothic Medium", 12F);
            CriarConta.ForeColor = SystemColors.Highlight;
            CriarConta.Location = new Point(83, 496);
            CriarConta.Name = "CriarConta";
            CriarConta.Size = new Size(116, 25);
            CriarConta.TabIndex = 18;
            CriarConta.Text = "Criar Conta!";
            CriarConta.Click += CriarConta_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 12F);
            label4.ForeColor = Color.FromArgb(180, 180, 190);
            label4.Location = new Point(48, 464);
            label4.Name = "label4";
            label4.Size = new Size(192, 25);
            label4.TabIndex = 17;
            label4.Text = "Não tem uma conta?";
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
            chkMostrarSenha.Location = new Point(279, 291);
            chkMostrarSenha.Margin = new Padding(3, 4, 3, 4);
            chkMostrarSenha.Name = "chkMostrarSenha";
            chkMostrarSenha.Size = new Size(176, 34);
            chkMostrarSenha.TabIndex = 15;
            chkMostrarSenha.Text = "Mostrar Senha";
            chkMostrarSenha.UseVisualStyleBackColor = true;
            chkMostrarSenha.CheckedChanged += chkMostrarSenha_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 12F);
            label3.ForeColor = Color.FromArgb(180, 180, 190);
            label3.Location = new Point(48, 208);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 12;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F);
            label2.ForeColor = Color.FromArgb(180, 180, 190);
            label2.Location = new Point(48, 120);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 11;
            label2.Text = "Email";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(224, 224, 224);
            txtSenha.Font = new Font("Microsoft Sans Serif", 16F);
            txtSenha.Location = new Point(48, 240);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite sua senha";
            txtSenha.Size = new Size(397, 38);
            txtSenha.TabIndex = 10;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(224, 224, 224);
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F);
            txtEmail.Location = new Point(48, 152);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite o email de usuario";
            txtEmail.Size = new Size(397, 38);
            txtEmail.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 23F);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(38, 51);
            label1.Name = "label1";
            label1.Size = new Size(261, 45);
            label1.TabIndex = 8;
            label1.Text = "Faça seu login";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Highlight;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(48, 337);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(398, 49);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 40);
            panel2.Controls.Add(btnMinimizar);
            panel2.Controls.Add(btnSair);
            panel2.Location = new Point(-3, 1);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1018, 43);
            panel2.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.FlatStyle = FlatStyle.Popup;
            btnMinimizar.Font = new Font("Segoe UI", 15F);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(896, 0);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(62, 44);
            btnMinimizar.TabIndex = 3;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(953, 0);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(62, 44);
            btnSair.TabIndex = 1;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 40F);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(720, 441);
            label5.Margin = new Padding(2, 0, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(233, 76);
            label5.TabIndex = 6;
            label5.Text = "gestao";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 17F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(616, 221);
            label7.Margin = new Padding(2, 0, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(426, 33);
            label7.TabIndex = 4;
            label7.Text = "Conecte-se à sua produtividade";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 40F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(616, 260);
            label6.Margin = new Padding(2, 0, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(437, 228);
            label6.TabIndex = 5;
            label6.Text = "Vamos juntos\r\nsimplificar\r\nsua ";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            label6.UseMnemonic = false;
            // 
            // loginUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(1013, 731);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "loginUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loginUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnLogin;
        private Label label3;
        private Label label2;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel2;
        private Button btnSair;
        private Button btnMinimizar;
        private Label label5;
        private Label label7;
        private CheckBox chkMostrarSenha;
        private Label CriarConta;
        private Label label4;
        private Label label6;
        private Label recuperarConta;
        private Label label8;
    }
}