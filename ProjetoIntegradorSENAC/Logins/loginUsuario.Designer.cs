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
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(26, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 423);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(48, 174);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 12;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 108);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 11;
            label2.Text = "Usuario";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 16F);
            txtSenha.Location = new Point(48, 198);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite sua senha";
            txtSenha.Size = new Size(242, 36);
            txtSenha.TabIndex = 10;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(48, 132);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite o nome de usuario";
            textBox1.Size = new Size(242, 36);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 16F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(68, 19);
            label1.Name = "label1";
            label1.Size = new Size(208, 28);
            label1.TabIndex = 8;
            label1.Text = "Entre com sua conta";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Highlight;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(48, 284);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(242, 37);
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
            panel2.Size = new Size(398, 32);
            panel2.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.FlatStyle = FlatStyle.Popup;
            btnMinimizar.Font = new Font("Segoe UI", 15F);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(291, 0);
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
            btnSair.Location = new Point(341, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(54, 33);
            btnSair.TabIndex = 1;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(262, 213);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 14;
            label4.Text = "<>";
            label4.Click += label4_Click;
            // 
            // loginUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(392, 496);
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
        private Label label4;
    }
}