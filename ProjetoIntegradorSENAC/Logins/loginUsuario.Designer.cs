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
            label1 = new Label();
            btnLogin = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(25, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 432);
            panel1.TabIndex = 1;
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(48, 132);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite o nome de usuario";
            textBox1.Size = new Size(242, 32);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(48, 198);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Digite sua senha";
            textBox2.Size = new Size(242, 32);
            textBox2.TabIndex = 10;
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // loginUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 40);
            ClientSize = new Size(392, 474);
            Controls.Add(panel1);
            Name = "loginUsuario";
            Text = "loginUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnLogin;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
    }
}