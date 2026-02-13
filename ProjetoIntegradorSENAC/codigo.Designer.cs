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
            btnVerificarCodigo = new Button();
            btnVoltar = new Button();
            txtCodigo = new TextBox();
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
            btnMinimizar.Location = new Point(344, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(54, 33);
            btnMinimizar.TabIndex = 5;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(397, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(54, 33);
            btnSair.TabIndex = 4;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 40);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(344, 33);
            panel2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(btnVerificarCodigo);
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 479);
            panel1.TabIndex = 34;
            panel1.TabStop = true;
            // 
            // btnVerificarCodigo
            // 
            btnVerificarCodigo.BackColor = SystemColors.Highlight;
            btnVerificarCodigo.Cursor = Cursors.Hand;
            btnVerificarCodigo.FlatStyle = FlatStyle.Popup;
            btnVerificarCodigo.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerificarCodigo.ForeColor = Color.White;
            btnVerificarCodigo.Location = new Point(38, 231);
            btnVerificarCodigo.Name = "btnVerificarCodigo";
            btnVerificarCodigo.Size = new Size(190, 37);
            btnVerificarCodigo.TabIndex = 31;
            btnVerificarCodigo.Text = "Verificar código";
            btnVerificarCodigo.UseVisualStyleBackColor = false;
            btnVerificarCodigo.Click += btnVerificarCodigo_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnVoltar.FlatAppearance.BorderSize = 2;
            btnVoltar.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 60);
            btnVoltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 60);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = SystemColors.Highlight;
            btnVoltar.Location = new Point(38, 416);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(190, 37);
            btnVoltar.TabIndex = 30;
            btnVoltar.Text = "Voltar para o login";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(224, 224, 224);
            txtCodigo.Font = new Font("Microsoft Sans Serif", 16F);
            txtCodigo.HideSelection = false;
            txtCodigo.Location = new Point(38, 174);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "Digite o código";
            txtCodigo.Size = new Size(348, 32);
            txtCodigo.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 12F);
            label3.ForeColor = Color.FromArgb(180, 180, 190);
            label3.Location = new Point(73, 73);
            label3.Name = "label3";
            label3.Size = new Size(275, 63);
            label3.TabIndex = 1;
            label3.Text = "Enviamos um código de 6 dígitos para \r\nseuemail@email.com\r\nDigite o código abaixo para continuar.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 23F);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(73, 14);
            label4.Name = "label4";
            label4.Size = new Size(282, 37);
            label4.TabIndex = 0;
            label4.Text = "Verifique seu e-mail";
            // 
            // codigo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(451, 540);
            Controls.Add(panel1);
            Controls.Add(btnMinimizar);
            Controls.Add(btnSair);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button btnVoltar;
        private TextBox txtCodigo;
        private Label label3;
        private Label label4;
    }
}