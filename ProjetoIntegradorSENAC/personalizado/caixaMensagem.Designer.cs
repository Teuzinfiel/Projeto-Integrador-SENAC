namespace ProjetoIntegradorSENAC.personalizado
{
    partial class caixaMensagem
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
            lbMensagem = new Label();
            btnOk = new Button();
            panel1 = new Panel();
            lbTitulo = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.FlatStyle = FlatStyle.Popup;
            btnMinimizar.Font = new Font("Segoe UI", 15F);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(290, 0);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(62, 44);
            btnMinimizar.TabIndex = 36;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(351, 0);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(62, 44);
            btnSair.TabIndex = 35;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 40);
            panel2.Controls.Add(lbTitulo);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 44);
            panel2.TabIndex = 37;
            // 
            // lbMensagem
            // 
            lbMensagem.AutoSize = true;
            lbMensagem.Font = new Font("Franklin Gothic Medium", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMensagem.ForeColor = Color.FromArgb(180, 180, 190);
            lbMensagem.Location = new Point(26, 38);
            lbMensagem.Name = "lbMensagem";
            lbMensagem.Size = new Size(58, 23);
            lbMensagem.TabIndex = 38;
            lbMensagem.Text = "label1";
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(50, 50, 60);
            btnOk.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnOk.FlatAppearance.BorderSize = 2;
            btnOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 60);
            btnOk.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 60);
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Franklin Gothic Medium", 15F);
            btnOk.ForeColor = SystemColors.Highlight;
            btnOk.Location = new Point(278, 90);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 44);
            btnOk.TabIndex = 39;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(lbMensagem);
            panel1.Controls.Add(btnOk);
            panel1.Location = new Point(12, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 146);
            panel1.TabIndex = 40;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Franklin Gothic Medium", 10.8F);
            lbTitulo.ForeColor = Color.FromArgb(180, 180, 190);
            lbTitulo.Location = new Point(12, 11);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(58, 23);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "label1";
            // 
            // caixaMensagem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(413, 219);
            Controls.Add(panel1);
            Controls.Add(btnMinimizar);
            Controls.Add(btnSair);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "caixaMensagem";
            Text = "caixaMensagem";
            Load += caixaMensagem_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMinimizar;
        private Button btnSair;
        private Panel panel2;
        private Label lbMensagem;
        private Button btnOk;
        private Panel panel1;
        private Label lbTitulo;
    }
}