namespace ProjetoIntegradorSENAC.personalizado
{
    partial class caixaInformacao
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
            lbMensagem = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(lbMensagem);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.FromArgb(180, 180, 190);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 109);
            panel1.TabIndex = 41;
            // 
            // lbMensagem
            // 
            lbMensagem.AutoSize = true;
            lbMensagem.Font = new Font("Franklin Gothic Medium", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMensagem.ForeColor = Color.FromArgb(224, 224, 224);
            lbMensagem.Location = new Point(11, 11);
            lbMensagem.Name = "lbMensagem";
            lbMensagem.Size = new Size(335, 92);
            lbMensagem.TabIndex = 38;
            lbMensagem.Text = "A senha deve ter no mínimo 8 caracteres,\r\ncom pelo menos 1 letra maiúscula,\r\n1 minúscula, 1 caractere númerico e 1 \r\ncaractere especial.";
            // 
            // caixaInformacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(408, 121);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(180, 180, 190);
            FormBorderStyle = FormBorderStyle.None;
            Name = "caixaInformacao";
            Padding = new Padding(6);
            Text = "caixaInformacao";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbMensagem;
    }
}