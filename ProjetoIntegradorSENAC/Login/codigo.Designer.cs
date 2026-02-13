namespace ProjetoIntegradorSENAC
{
    partial class codigo
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
            btnMinimizar = new Button();
            btnSair = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            btnVoltarParaLogin = new Button();
            txtCodigo = new MaskedTextBox();
            btnVerificarCodigo = new Button();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
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
            btnMinimizar.TabIndex = 5;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
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
            btnSair.TabIndex = 4;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 40);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(393, 44);
            panel2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(btnVoltarParaLogin);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(btnVerificarCodigo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(13, 68);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 639);
            panel1.TabIndex = 34;
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
            btnVoltarParaLogin.TabIndex = 33;
            btnVoltarParaLogin.Text = "Voltar para o login";
            btnVoltarParaLogin.UseVisualStyleBackColor = true;
            btnVoltarParaLogin.Click += btnVoltarParaLogin_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(224, 224, 224);
            txtCodigo.Font = new Font("Microsoft Sans Serif", 16F);
            txtCodigo.Location = new Point(43, 242);
            txtCodigo.Mask = "000000";
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(397, 38);
            txtCodigo.TabIndex = 0;
            // 
            // btnVerificarCodigo
            // 
            btnVerificarCodigo.BackColor = SystemColors.Highlight;
            btnVerificarCodigo.Cursor = Cursors.Hand;
            btnVerificarCodigo.FlatStyle = FlatStyle.Popup;
            btnVerificarCodigo.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerificarCodigo.ForeColor = Color.White;
            btnVerificarCodigo.Location = new Point(43, 318);
            btnVerificarCodigo.Margin = new Padding(3, 4, 3, 4);
            btnVerificarCodigo.Name = "btnVerificarCodigo";
            btnVerificarCodigo.Size = new Size(397, 49);
            btnVerificarCodigo.TabIndex = 1;
            btnVerificarCodigo.Text = "Verificar código";
            btnVerificarCodigo.UseVisualStyleBackColor = false;
            btnVerificarCodigo.Click += btnVerificarCodigo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 12F);
            label3.ForeColor = Color.FromArgb(180, 180, 190);
            label3.Location = new Point(76, 97);
            label3.Name = "label3";
            label3.Size = new Size(346, 75);
            label3.TabIndex = 1;
            label3.Text = "Enviamos um código de 6 dígitos para \r\nseuemail@email.com\r\nDigite o código abaixo para continuar.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 23F);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(73, 19);
            label4.Name = "label4";
            label4.Size = new Size(351, 45);
            label4.TabIndex = 0;
            label4.Text = "Verifique seu e-mail";
            // 
            // codigo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(516, 720);
            Controls.Add(panel1);
            Controls.Add(btnMinimizar);
            Controls.Add(btnSair);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "codigo";
            Text = "codigo";
            Load += codigo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMinimizar;
        private Button btnSair;
        private Panel panel2;
        private Panel panel1;
        private Button btnVerificarCodigo;
        private Label label3;
        private Label label4;
        private MaskedTextBox txtCodigo;
        private Button btnVoltarParaLogin;
    }
}