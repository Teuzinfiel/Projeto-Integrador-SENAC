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
            panel2 = new Panel();
            lbTitulo = new Label();
            lbMensagem = new Label();
            btnOk = new Button();
            panel1 = new Panel();
            btnSair = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 40);
            panel2.Controls.Add(lbTitulo);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(301, 33);
            panel2.TabIndex = 37;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Franklin Gothic Medium", 10.8F);
            lbTitulo.ForeColor = Color.FromArgb(180, 180, 190);
            lbTitulo.Location = new Point(10, 8);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(50, 20);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "label1";
            // 
            // lbMensagem
            // 
            lbMensagem.AutoSize = true;
            lbMensagem.Font = new Font("Franklin Gothic Medium", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMensagem.ForeColor = Color.FromArgb(180, 180, 190);
            lbMensagem.Location = new Point(23, 28);
            lbMensagem.Name = "lbMensagem";
            lbMensagem.Size = new Size(50, 20);
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
            btnOk.Location = new Point(243, 68);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(82, 33);
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
            panel1.Location = new Point(10, 46);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 110);
            panel1.TabIndex = 40;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(307, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(54, 33);
            btnSair.TabIndex = 35;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // caixaMensagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(361, 164);
            Controls.Add(panel1);
            Controls.Add(btnSair);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private Panel panel2;
        private Label lbMensagem;
        private Button btnOk;
        private Panel panel1;
        private Label lbTitulo;
        private Button btnSair;
    }
}