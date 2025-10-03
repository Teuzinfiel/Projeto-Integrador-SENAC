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
            CriarConta = new Label();
            label4 = new Label();
            button1 = new Button();
            chkMostrarSenha = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            txtSenha = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            btnLogin = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel2 = new Panel();
            btnMinimizar = new Button();
            btnSair = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(CriarConta);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(chkMostrarSenha);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(26, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 470);
            panel1.TabIndex = 1;
            // 
            // CriarConta
            // 
            CriarConta.AutoSize = true;
            CriarConta.Cursor = Cursors.Hand;
            CriarConta.Font = new Font("Franklin Gothic Medium", 12F);
            CriarConta.ForeColor = SystemColors.Highlight;
            CriarConta.Location = new Point(163, 400);
            CriarConta.Name = "CriarConta";
            CriarConta.Size = new Size(90, 21);
            CriarConta.TabIndex = 18;
            CriarConta.Text = "Criar Conta!";
            CriarConta.Click += CriarConta_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 12F);
            label4.ForeColor = Color.FromArgb(180, 180, 190);
            label4.Location = new Point(132, 376);
            label4.Name = "label4";
            label4.Size = new Size(154, 21);
            label4.TabIndex = 17;
            label4.Text = "Não tem uma conta?";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 60);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 60);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(43, 319);
            button1.Name = "button1";
            button1.Size = new Size(348, 37);
            button1.TabIndex = 16;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            label2.Size = new Size(62, 21);
            label2.TabIndex = 11;
            label2.Text = "Usuario";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(224, 224, 224);
            txtSenha.Font = new Font("Franklin Gothic Book", 16F);
            txtSenha.Location = new Point(42, 180);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite sua senha";
            txtSenha.Size = new Size(348, 32);
            txtSenha.TabIndex = 10;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Font = new Font("Franklin Gothic Book", 16F);
            textBox1.Location = new Point(42, 114);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite o nome de usuario";
            textBox1.Size = new Size(348, 32);
            textBox1.TabIndex = 9;
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
            btnLogin.Location = new Point(42, 267);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(348, 37);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 40);
            panel2.Controls.Add(btnMinimizar);
            panel2.Controls.Add(btnSair);
            panel2.Location = new Point(-3, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(869, 32);
            panel2.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.FlatStyle = FlatStyle.Popup;
            btnMinimizar.Font = new Font("Segoe UI", 15F);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(763, -1);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(54, 33);
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
            btnSair.Location = new Point(813, -1);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(54, 33);
            btnSair.TabIndex = 1;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Franklin Gothic Demi Cond", 40F);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(628, 340);
            label5.Name = "label5";
            label5.Size = new Size(169, 68);
            label5.TabIndex = 6;
            label5.Text = "gestao";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Demi Cond", 40F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(528, 204);
            label6.Name = "label6";
            label6.Size = new Size(304, 204);
            label6.TabIndex = 5;
            label6.Text = "Vamos juntos\r\nsimplificar\r\nsua ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium Cond", 16F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(528, 176);
            label7.Name = "label7";
            label7.Size = new Size(269, 28);
            label7.TabIndex = 4;
            label7.Text = "Conecte-se à sua produtividade";
            // 
            // loginUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(867, 548);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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
        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel2;
        private Button btnSair;
        private Button btnMinimizar;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckBox chkMostrarSenha;
        private Button button1;
        private Label CriarConta;
        private Label label4;
    }
}