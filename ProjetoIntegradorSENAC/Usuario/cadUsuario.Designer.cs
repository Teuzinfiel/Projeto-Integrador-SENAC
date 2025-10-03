namespace ProjetoIntegradorSENAC.Usuario
{
    partial class cadUsuario
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(155, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 313);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 23F);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(61, 35);
            label1.Name = "label1";
            label1.Size = new Size(274, 37);
            label1.TabIndex = 9;
            label1.Text = "Cadastre sua conta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F);
            label2.ForeColor = Color.FromArgb(180, 180, 190);
            label2.Location = new Point(28, 128);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 13;
            label2.Text = "Nome de usuário";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Font = new Font("Franklin Gothic Book", 16F);
            textBox1.Location = new Point(28, 152);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite o nome de usuario";
            textBox1.Size = new Size(348, 32);
            textBox1.TabIndex = 12;
            // 
            // cadUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(800, 525);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "cadUsuario";
            Text = "cadUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
    }
}