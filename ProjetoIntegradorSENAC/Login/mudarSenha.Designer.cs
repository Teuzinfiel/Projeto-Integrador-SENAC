namespace ProjetoIntegradorSENAC
{
    partial class mudarSenha
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
            btnVoltarParaLogin = new Button();
            chkMostrarSenha = new CheckBox();
            lbConfirmarSenha = new Label();
            lbNovaSenha = new Label();
            txtConfirmarSenha = new TextBox();
            btnEnviar = new Button();
            txtNovaSenha = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnMinimizar = new Button();
            btnSair = new Button();
            panelTop = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(btnVoltarParaLogin);
            panel1.Controls.Add(chkMostrarSenha);
            panel1.Controls.Add(lbConfirmarSenha);
            panel1.Controls.Add(lbNovaSenha);
            panel1.Controls.Add(txtConfirmarSenha);
            panel1.Controls.Add(btnEnviar);
            panel1.Controls.Add(txtNovaSenha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 68);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 639);
            panel1.TabIndex = 1;
            panel1.TabStop = true;
            // 
            // btnVoltarParaLogin
            // 
            btnVoltarParaLogin.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnVoltarParaLogin.FlatAppearance.BorderSize = 2;
            btnVoltarParaLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 60);
            btnVoltarParaLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 60);
            btnVoltarParaLogin.FlatStyle = FlatStyle.Flat;
            btnVoltarParaLogin.Font = new Font("Franklin Gothic Medium", 15F);
            btnVoltarParaLogin.ForeColor = SystemColors.Highlight;
            btnVoltarParaLogin.Location = new Point(43, 544);
            btnVoltarParaLogin.Name = "btnVoltarParaLogin";
            btnVoltarParaLogin.Size = new Size(223, 49);
            btnVoltarParaLogin.TabIndex = 35;
            btnVoltarParaLogin.Text = "Voltar para o login";
            btnVoltarParaLogin.UseVisualStyleBackColor = true;
            btnVoltarParaLogin.Click += btnVoltarParaLogin_Click;
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
            chkMostrarSenha.Location = new Point(264, 335);
            chkMostrarSenha.Margin = new Padding(3, 4, 3, 4);
            chkMostrarSenha.Name = "chkMostrarSenha";
            chkMostrarSenha.Size = new Size(176, 34);
            chkMostrarSenha.TabIndex = 35;
            chkMostrarSenha.Text = "Mostrar Senha";
            chkMostrarSenha.UseVisualStyleBackColor = true;
            chkMostrarSenha.CheckedChanged += chkMostrarSenha_CheckedChanged;
            // 
            // lbConfirmarSenha
            // 
            lbConfirmarSenha.AutoSize = true;
            lbConfirmarSenha.Font = new Font("Franklin Gothic Medium", 12F);
            lbConfirmarSenha.ForeColor = Color.FromArgb(180, 180, 190);
            lbConfirmarSenha.Location = new Point(43, 262);
            lbConfirmarSenha.Name = "lbConfirmarSenha";
            lbConfirmarSenha.Size = new Size(161, 25);
            lbConfirmarSenha.TabIndex = 34;
            lbConfirmarSenha.Text = "Confirmar senha:";
            // 
            // lbNovaSenha
            // 
            lbNovaSenha.AutoSize = true;
            lbNovaSenha.Font = new Font("Franklin Gothic Medium", 12F);
            lbNovaSenha.ForeColor = Color.FromArgb(180, 180, 190);
            lbNovaSenha.Location = new Point(43, 160);
            lbNovaSenha.Name = "lbNovaSenha";
            lbNovaSenha.Size = new Size(118, 25);
            lbNovaSenha.TabIndex = 33;
            lbNovaSenha.Text = "Nova senha:";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.BackColor = Color.FromArgb(224, 224, 224);
            txtConfirmarSenha.Font = new Font("Microsoft Sans Serif", 16F);
            txtConfirmarSenha.Location = new Point(43, 290);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PlaceholderText = "Confirmar senha";
            txtConfirmarSenha.Size = new Size(397, 38);
            txtConfirmarSenha.TabIndex = 2;
            txtConfirmarSenha.UseSystemPasswordChar = true;
            txtConfirmarSenha.TextChanged += txtConfirmarSenha_TextChanged;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = SystemColors.Highlight;
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.FlatStyle = FlatStyle.Popup;
            btnEnviar.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviar.ForeColor = Color.White;
            btnEnviar.Location = new Point(43, 396);
            btnEnviar.Margin = new Padding(3, 4, 3, 4);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(397, 49);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "Salvar nova senha";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.BackColor = Color.FromArgb(224, 224, 224);
            txtNovaSenha.Font = new Font("Microsoft Sans Serif", 16F);
            txtNovaSenha.HideSelection = false;
            txtNovaSenha.Location = new Point(43, 189);
            txtNovaSenha.Margin = new Padding(3, 4, 3, 4);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.PlaceholderText = "Nova senha";
            txtNovaSenha.Size = new Size(397, 38);
            txtNovaSenha.TabIndex = 1;
            txtNovaSenha.UseSystemPasswordChar = true;
            txtNovaSenha.TextChanged += txtNovaSenha_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(180, 180, 190);
            label2.Location = new Point(125, 105);
            label2.Name = "label2";
            label2.Size = new Size(230, 29);
            label2.TabIndex = 1;
            label2.Text = "  Crie uma nova senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 23F);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(74, 19);
            label1.Name = "label1";
            label1.Size = new Size(342, 45);
            label1.TabIndex = 0;
            label1.Text = "🔐 Redefinir Senha";
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.FlatStyle = FlatStyle.Popup;
            btnMinimizar.Font = new Font("Segoe UI", 15F);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(393, 0);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(62, 44);
            btnMinimizar.TabIndex = 33;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(454, 0);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(62, 44);
            btnSair.TabIndex = 32;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(30, 30, 40);
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(393, 44);
            panelTop.TabIndex = 34;
            // 
            // mudarSenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(516, 720);
            Controls.Add(btnMinimizar);
            Controls.Add(btnSair);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mudarSenha";
            Text = "mudarSenha";
            Load += mudarSenha_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEnviar;
        private TextBox txtNovaSenha;
        private Label label2;
        private Label label1;
        private Button btnMinimizar;
        private Button btnSair;
        private Panel panelTop;
        private TextBox txtConfirmarSenha;
        private Label lbNovaSenha;
        private Label lbConfirmarSenha;
        private CheckBox chkMostrarSenha;
        private Button btnVoltarParaLogin;
    }
}