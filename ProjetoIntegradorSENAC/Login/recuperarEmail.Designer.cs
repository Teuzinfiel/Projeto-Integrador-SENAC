namespace ProjetoIntegradorSENAC
{
    partial class recuperarEmail
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
            btnEnviar = new Button();
            bntSair = new Button();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnMinimizar = new Button();
            btnSair = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(btnEnviar);
            panel1.Controls.Add(bntSair);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 479);
            panel1.TabIndex = 0;
            panel1.TabStop = true;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = SystemColors.Highlight;
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.FlatStyle = FlatStyle.Popup;
            btnEnviar.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviar.ForeColor = Color.White;
            btnEnviar.Location = new Point(38, 231);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(190, 37);
            btnEnviar.TabIndex = 31;
            btnEnviar.Text = "Enviar código";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnCadastro_Click;
            // 
            // bntSair
            // 
            bntSair.BackColor = Color.Transparent;
            bntSair.Cursor = Cursors.Hand;
            bntSair.FlatAppearance.BorderColor = SystemColors.Highlight;
            bntSair.FlatAppearance.BorderSize = 2;
            bntSair.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 60);
            bntSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 60);
            bntSair.FlatStyle = FlatStyle.Flat;
            bntSair.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntSair.ForeColor = SystemColors.Highlight;
            bntSair.Location = new Point(38, 416);
            bntSair.Name = "bntSair";
            bntSair.Size = new Size(190, 37);
            bntSair.TabIndex = 30;
            bntSair.Text = "Voltar para o login";
            bntSair.UseVisualStyleBackColor = false;
            bntSair.Click += bntSair_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(224, 224, 224);
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F);
            txtEmail.HideSelection = false;
            txtEmail.Location = new Point(38, 174);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite o seu e-mail";
            txtEmail.Size = new Size(348, 32);
            txtEmail.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F);
            label2.ForeColor = Color.FromArgb(180, 180, 190);
            label2.Location = new Point(50, 80);
            label2.Name = "label2";
            label2.Size = new Size(319, 42);
            label2.TabIndex = 1;
            label2.Text = "Digite seu e-mail e enviaremos um código de \r\n      verificação para redefinir sua senha.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 23F);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(55, 14);
            label1.Name = "label1";
            label1.Size = new Size(306, 37);
            label1.TabIndex = 0;
            label1.Text = "Esqueceu sua senha?";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 40);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(344, 33);
            panel2.TabIndex = 3;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.FlatStyle = FlatStyle.Popup;
            btnMinimizar.Font = new Font("Segoe UI", 15F);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(344, 0);
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
            btnSair.Location = new Point(397, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(54, 33);
            btnSair.TabIndex = 1;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // recuperarEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(451, 540);
            Controls.Add(btnMinimizar);
            Controls.Add(panel1);
            Controls.Add(btnSair);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "recuperarEmail";
            Text = "Form1";
            Load += recuperarEmail_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMinimizar;
        private Panel panel2;
        private Button btnSair;
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private Button bntSair;
        private Button btnEnviar;
    }
}