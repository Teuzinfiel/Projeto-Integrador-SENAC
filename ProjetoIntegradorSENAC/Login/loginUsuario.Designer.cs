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
            label10 = new Label();
            label9 = new Label();
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
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
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
            panel1.Location = new Point(318, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 470);
            panel1.TabIndex = 1;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Franklin Gothic Medium", 12F);
            label10.ForeColor = Color.FromArgb(180, 180, 190);
            label10.Location = new Point(0, 308);
            label10.Name = "label10";
            label10.Size = new Size(170, 21);
            label10.TabIndex = 22;
            label10.Text = "____________________";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Franklin Gothic Medium", 12F);
            label9.ForeColor = Color.FromArgb(180, 180, 190);
            label9.Location = new Point(259, 308);
            label9.Name = "label9";
            label9.Size = new Size(170, 21);
            label9.TabIndex = 21;
            label9.Text = "____________________";
            // 
            // recuperarConta
            // 
            recuperarConta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            recuperarConta.AutoSize = true;
            recuperarConta.Cursor = Cursors.Hand;
            recuperarConta.Font = new Font("Franklin Gothic Medium", 12F);
            recuperarConta.ForeColor = SystemColors.Highlight;
            recuperarConta.Location = new Point(260, 372);
            recuperarConta.Name = "recuperarConta";
            recuperarConta.Size = new Size(132, 21);
            recuperarConta.TabIndex = 20;
            recuperarConta.Text = "Recuperar Senha!";
            recuperarConta.Click += recuperarConta_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Medium", 12F);
            label8.ForeColor = Color.FromArgb(180, 180, 190);
            label8.Location = new Point(256, 348);
            label8.Name = "label8";
            label8.Size = new Size(143, 21);
            label8.TabIndex = 19;
            label8.Text = "Esqueceu a senha?";
            // 
            // CriarConta
            // 
            CriarConta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CriarConta.AutoSize = true;
            CriarConta.Cursor = Cursors.Hand;
            CriarConta.Font = new Font("Franklin Gothic Medium", 12F);
            CriarConta.ForeColor = SystemColors.Highlight;
            CriarConta.Location = new Point(73, 372);
            CriarConta.Name = "CriarConta";
            CriarConta.Size = new Size(90, 21);
            CriarConta.TabIndex = 18;
            CriarConta.Text = "Criar Conta!";
            CriarConta.Click += CriarConta_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 12F);
            label4.ForeColor = Color.FromArgb(180, 180, 190);
            label4.Location = new Point(42, 348);
            label4.Name = "label4";
            label4.Size = new Size(154, 21);
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
            chkMostrarSenha.Location = new Point(244, 218);
            chkMostrarSenha.Name = "chkMostrarSenha";
            chkMostrarSenha.Size = new Size(146, 29);
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
            label3.Location = new Point(42, 156);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 12;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F);
            label2.ForeColor = Color.FromArgb(180, 180, 190);
            label2.Location = new Point(42, 90);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 11;
            label2.Text = "Email";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(224, 224, 224);
            txtSenha.Font = new Font("Microsoft Sans Serif", 16F);
            txtSenha.Location = new Point(42, 180);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite sua senha";
            txtSenha.Size = new Size(348, 32);
            txtSenha.TabIndex = 10;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(224, 224, 224);
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F);
            txtEmail.Location = new Point(42, 114);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite o email de usuario";
            txtEmail.Size = new Size(348, 32);
            txtEmail.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 23F);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(33, 38);
            label1.Name = "label1";
            label1.Size = new Size(209, 37);
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
            btnLogin.Location = new Point(42, 253);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(348, 37);
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
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Franklin Gothic Medium", 39.75F);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(916, 359);
            label5.Margin = new Padding(2, 0, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(181, 66);
            label5.TabIndex = 6;
            label5.Text = "gestão";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium Cond", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(812, 209);
            label7.Margin = new Padding(2, 0, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(279, 29);
            label7.TabIndex = 4;
            label7.Text = "Conecte-se à sua produtividade";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Franklin Gothic Medium", 39.75F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(809, 233);
            label6.Margin = new Padding(2, 0, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(337, 198);
            label6.TabIndex = 5;
            label6.Text = "Vamos juntos\r\nsimplificar\r\nsua ";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            label6.UseMnemonic = false;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Franklin Gothic Medium", 12F);
            label11.ForeColor = Color.FromArgb(180, 180, 190);
            label11.Location = new Point(195, 314);
            label11.Name = "label11";
            label11.Size = new Size(30, 21);
            label11.TabIndex = 23;
            label11.Text = "OU";
            // 
            // loginUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(1280, 680);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loginUsuario";
            Load += loginUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label5;
        private Label label7;
        private CheckBox chkMostrarSenha;
        private Label CriarConta;
        private Label label4;
        private Label label6;
        private Label recuperarConta;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label11;
    }
}